﻿// Copyright 2012 Alalf <alalf.iQLc_at_gmail.com>
//
// This file is part of SCFF DSF.
//
// SCFF DSF is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// SCFF DSF is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with SCFF DSF.  If not, see <http://www.gnu.org/licenses/>.

/// @file scff-app/form1-scff.cs
/// @brief Form1(メインウィンドウ)のイベントハンドラ以外の定義

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.Win32;
using System.IO;

namespace scff_app {

/// @brief Form1(メインウィンドウ)から利用する実装クラス
public partial class AppImplementation {
  //-------------------------------------------------------------------
  // Wrappers
  //-------------------------------------------------------------------
  [StructLayout(LayoutKind.Sequential)]
  struct RECT { public int left, top, right, bottom; }
  [DllImport("user32.dll")]
  [return: MarshalAs(UnmanagedType.Bool)]
  static extern bool IsWindow(UIntPtr hWnd);
  [DllImport("user32.dll")]
  static extern bool GetClientRect(UIntPtr hWnd, out RECT lpRect);
  [DllImport("user32.dll", SetLastError = false)]
  static extern UIntPtr GetDesktopWindow();
  [DllImport("user32.dll")]
  static extern UIntPtr WindowFromPoint(int xPoint, int yPoint);
  //-------------------------------------------------------------------

  /// @brief コンストラクタ
  public AppImplementation() {
    // 初期化
    interprocess_ = null;

    // プロセス間通信に必要なオブジェクトの生成
    interprocess_ = new scff_interprocess.Interprocess();

    // リサイズ方法のリストを作成
    BuildResizeMethodList();
  }

  /// @brief 起動時のチェックを行うメソッド
  public bool CheckEnvironment() {
    // GUID
    const string kGUID = "D64DB8AA-9055-418F-AFE9-A080A4FAE47A";
    // Registry Key
    const string kRegistryKey = "CLSID\\{" + kGUID + "}";

    //------------------
    // 32bit版のチェック
    //------------------
    bool is_correctly_installed_x86 = false;
    bool is_dll_found_x86 = false;
    string dll_path_x86 = "";
    try {
      RegistryKey scff_dsf_key =
          RegistryKey.OpenBaseKey(
              RegistryHive.ClassesRoot,
              RegistryView.Registry32).OpenSubKey(kRegistryKey);
      if (scff_dsf_key != null) {
        is_correctly_installed_x86 = true;
      }

      RegistryKey scff_dsf_path_key = scff_dsf_key.OpenSubKey("InprocServer32");
      dll_path_x86 = scff_dsf_path_key.GetValue("").ToString();
      if (File.Exists(dll_path_x86)) {
        is_dll_found_x86 = true;
      }
    } catch {
      // 念のためエラーが出た場合も考慮
    }

    //------------------
    // 64bit版のチェック
    //------------------
    bool is_correctly_installed_amd64 = false;
    bool is_dll_found_amd64 = false;
    string dll_path_amd64 = "";
    try {
      RegistryKey scff_dsf_key =
          RegistryKey.OpenBaseKey(
              RegistryHive.ClassesRoot,
              RegistryView.Registry64).OpenSubKey(kRegistryKey);
      if (scff_dsf_key != null) {
        is_correctly_installed_amd64 = true;
      }

      RegistryKey scff_dsf_path_key = scff_dsf_key.OpenSubKey("InprocServer32");
      dll_path_amd64 = scff_dsf_path_key.GetValue("").ToString();
      if (File.Exists(dll_path_amd64)) {
        is_dll_found_amd64 = true;
      }
    } catch {
      // 念のためエラーが出た場合も考慮
    }

    //----------------------
    // エラーダイアログの表示
    // （若干不正確だがないよりましだろう）
    //----------------------
    if (!is_correctly_installed_x86 && !is_correctly_installed_amd64) {
      // 32bit版も64bit版もインストールされていない場合
      MessageBox.Show("scff-*.ax is not correctly installed.\nPlease re-install SCFF DirectShow Filter.",
                      "Not correctly installed",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Error);
      return false;
    }

    if (!is_dll_found_x86 && !is_dll_found_amd64) {
      // 32bit版のDLLも64bit版のDLLも指定された場所に存在していない場合
      string message = "scff-*.ax is not found:\n";
      message += "\n";
      message += "  32bit: " + dll_path_x86 + "\n";
      message += "  64bit: " + dll_path_amd64 + "\n"; 
      message += "\n";
      message += "Check your SCFF directory.";
      MessageBox.Show(message,
                      "DLL is not found",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Error);
      return false;
    }

    //------------------
    // カラーチェック
    //------------------
    if (Screen.PrimaryScreen.BitsPerPixel != 32) {
      MessageBox.Show("SCFF requires primary screen is configured 32bit color mode.",
                      "Not 32bit color mode",
                      MessageBoxButtons.OK, MessageBoxIcon.Error);
      return false;
    }

    // 起動OK
    return true;
  }

  /// @brief コンボボックス用のResizeMethodアイテムクラス
  public class ResizeMethodItem {
    public scff_interprocess.SWScaleFlags Value { get; set; }
    public string Text { get; set; }
    public override string ToString() {
      return Text;
    }
  }

  /// @brief ResizeMethodコンボボックス用にリストを生成する
  private void BuildResizeMethodList() {
    // リストを新しく作成する
    ResizeMethodList = new List<Tuple<string, scff_interprocess.SWScaleFlags>>();
    ResizeMethodList.Add(Tuple.Create("FastBilinear (fast bilinear)", scff_interprocess.SWScaleFlags.kFastBilinear));
    ResizeMethodList.Add(Tuple.Create("Bilinear (bilinear)", scff_interprocess.SWScaleFlags.kBilinear));
    ResizeMethodList.Add(Tuple.Create("Bicubic (bicubic)", scff_interprocess.SWScaleFlags.kBicubic));
    ResizeMethodList.Add(Tuple.Create("X (experimental)", scff_interprocess.SWScaleFlags.kX));
    ResizeMethodList.Add(Tuple.Create("Point (nearest neighbor)", scff_interprocess.SWScaleFlags.kPoint));
    ResizeMethodList.Add(Tuple.Create("Area (averaging area)", scff_interprocess.SWScaleFlags.kArea));
    ResizeMethodList.Add(Tuple.Create("Bicublin (luma bicubic, chroma bilinear)", scff_interprocess.SWScaleFlags.kBicublin));
    ResizeMethodList.Add(Tuple.Create("Gauss (gaussian)", scff_interprocess.SWScaleFlags.kGauss));
    ResizeMethodList.Add(Tuple.Create("Sinc (sinc)", scff_interprocess.SWScaleFlags.kSinc));
    ResizeMethodList.Add(Tuple.Create("Lanczos (lanczos)", scff_interprocess.SWScaleFlags.kLanczos));
    ResizeMethodList.Add(Tuple.Create("Spline (natural bicubic spline)", scff_interprocess.SWScaleFlags.kSpline));
  }

  /// @brief 共有メモリからディレクトリを取得し、CurrentDirectoryを更新
  public data.Directory GetCurrentDirectory() {
    // 共有メモリからデータを取得
    interprocess_.InitDirectory();
    scff_interprocess.Directory interprocess_directory;
    interprocess_.GetDirectory(out interprocess_directory);

    // リストを新しく作成する
    return data.DirectoryFactory.FromInterprocess(interprocess_directory);
  }

  //-------------------------------------------------------------------
  // ウィンドウ指定
  //-------------------------------------------------------------------

  /// @brief スクリーン座標からウィンドウハンドルを設定する
  public UIntPtr GetWindowFromPoint(int screen_x, int screen_y) {
    Trace.WriteLine("Cursor: " + screen_x + "," + screen_y);
    UIntPtr window = WindowFromPoint(screen_x, screen_y);
    if (window != UIntPtr.Zero) {
      // 見つかった場合
      return window;
    } else {
      return UIntPtr.Zero;
    }
  }

  /// @brief デスクトップを全画面で取り込む
  public UIntPtr GetWindowFromDesktop() {
    return GetDesktopWindow();
  }

  /// @brief ウィンドウのサイズを得る
  public void GetWindowSize(UIntPtr window,
      out int window_width, out int window_height) {
    if (window == UIntPtr.Zero || !IsWindow(window)) {
      window_width = 0;
      window_height = 0;
      return;
    }

    RECT window_rect;
    GetClientRect(window, out window_rect);
    window_width = window_rect.right;
    window_height = window_rect.bottom;
  }

  /// @brief クリッピング領域を適切な値に調整してから設定
  public void JustifyClippingRegion(UIntPtr window,
      int src_x, int src_y, int src_width, int src_height,
      out int clipping_x, out int clipping_y,
      out int clipping_width, out int clipping_height) {
    if (window == UIntPtr.Zero || !IsWindow(window)) {
      clipping_x = 0;
      clipping_y = 0;
      clipping_width = 0;
      clipping_height = 0;
      return;
    }

    RECT window_rect;
    GetClientRect(window, out window_rect);

    int dst_x = src_x;
    int dst_y = src_y;
    int dst_width = src_width;
    int dst_height = src_height;
    if (src_x < 0) {
      dst_width += src_x;
      dst_x = 0;
    }
    if (src_y < 0) {
      dst_height += src_y;
      dst_y = 0;
    }
    if (src_x > window_rect.right) {
      dst_x = window_rect.right - src_width;
    }
    if (src_y > window_rect.bottom) {
      dst_y = window_rect.bottom - src_height;
    }

    if (dst_x + dst_width > window_rect.right) {
      dst_width = window_rect.right - dst_x;
    }
    if (dst_y + dst_height > window_rect.bottom) {
      dst_height = window_rect.bottom - dst_y;
    }

    clipping_x = dst_x;
    clipping_y = dst_y;
    clipping_width = dst_width;
    clipping_height = dst_height;
  }

  public bool ValidateParameters(List<data.LayoutParameter> parameters, int bound_width, int bound_height, bool show_message) {
    foreach (data.LayoutParameter i in parameters) {
      if (!ValidateParameter(i, bound_width, bound_height, show_message)) {
        return false;
      }
    }
    return true;
  }

  /// @brief パラメータのValidate
  private bool ValidateParameter(data.LayoutParameter parameter, int bound_width, int bound_height, bool show_message) {
    // もっとも危険な状態になりやすいウィンドウからチェック
    if (parameter.Window == UIntPtr.Zero) { // NULL
      if (show_message) {
        MessageBox.Show("Specified window is invalid", "Invalid Window",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      return false;
    }
    if (!IsWindow(parameter.Window)) {
      if (show_message) {
        MessageBox.Show("Specified window is invalid", "Invalid Window",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      return false;
    }

    // 境界設定のチェック
    if (parameter.BoundRelativeTop < parameter.BoundRelativeBottom &&
        parameter.BoundRelativeLeft < parameter.BoundRelativeRight) {
      // ok
    } else {
      if (show_message) {
        MessageBox.Show("Specified bound-rect is invalid", "Invalid Bound-rect",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      return false;
    }

    // 縮小した結果があまりにも小さくならないように
    /// @todo(me) 思ったより判定が難しい。要調査。
    // int new_width = (int)(((parameter.BoundRelativeBottom - parameter.BoundRelativeTop) * bound_width) / 100);
    // int new_height = (int)(((parameter.BoundRelativeRight - parameter.BoundRelativeLeft) * bound_height) / 100);
    // if (new_width > 64 && new_height > 64) {
    //   // ok
    // } else {
    //   if (show_message) {
    //     MessageBox.Show("Specified bound-rect is too small", "Too small bound-rect",
    //         MessageBoxButtons.OK, MessageBoxIcon.Error);
    //   }
    //   return false;
    // }

    // クリッピングリージョンの判定
    RECT window_rect;
    GetClientRect(parameter.Window, out window_rect);
    if (parameter.ClippingX + parameter.ClippingWidth <= window_rect.right &&
        parameter.ClippingY + parameter.ClippingHeight <= window_rect.bottom &&
        parameter.ClippingWidth > 0 &&
        parameter.ClippingHeight > 0) {
      // nop 問題なし
    } else {
      if (show_message) {
        MessageBox.Show("Clipping region is invalid", "Invalid Clipping Region",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      return false;
    }

    return true;
  }

  //-------------------------------------------------------------------

  /// @brief 共有メモリにNullLayoutリクエストを設定
  public void SendNullLayoutRequest(UInt32 process_id) {
    // メッセージを書いて送る
    data.Message message = data.MessageFactory.Default();
    message.LayoutType = scff_interprocess.LayoutType.kNullLayout;

    // 共有メモリを開いて送る
    interprocess_.InitMessage(process_id);
    // Bound関連の値は無視されるのでダミーの100をいれておく
    interprocess_.SendMessage(data.MessageFactory.ToInterprocess(message, 100, 100));
  }

  /// @brief 共有メモリにLayoutリクエストを設定
  public void SendLayoutRequest(UInt32 process_id, List<data.LayoutParameter> parameters, int bound_width, int bound_height) {
    if (process_id == 0) {
      return;
    }

    if (parameters.Count == 0) {
      SendNullLayoutRequest(process_id);
    } else if (parameters.Count == 1) {
      SendNativeLayoutRequest(process_id, parameters[0]);
    } else {
      SendComplexLayoutRequest(process_id, parameters, bound_width, bound_height);
    }
  }

  /// @brief 共有メモリにNativeLayoutリクエストを設定
  private void SendNativeLayoutRequest(UInt32 process_id, data.LayoutParameter parameter) {
    // メッセージを書いて送る
    data.Message message = data.MessageFactory.Default();
    message.LayoutType = scff_interprocess.LayoutType.kNativeLayout;
    message.LayoutElementCount = 1;
    message.LayoutParameters.Add(parameter);

    // 共有メモリを開いて送る
    interprocess_.InitMessage(process_id);
    // Bound関連の値は無視されるのでダミーの100を入れておく
    interprocess_.SendMessage(data.MessageFactory.ToInterprocess(message, 100, 100));
  }

  /// @brief 共有メモリにComplexLayoutリクエストを設定
  private void SendComplexLayoutRequest(UInt32 process_id, List<data.LayoutParameter> parameters, int bound_width, int bound_height) {
    // メッセージを書いて送る
    data.Message message = data.MessageFactory.Default();
    message.LayoutType = scff_interprocess.LayoutType.kComplexLayout;
    message.LayoutElementCount = parameters.Count;

    foreach (data.LayoutParameter i in parameters) {
      message.LayoutParameters.Add(i);
    }

    // 共有メモリを開いて送る
    interprocess_.InitMessage(process_id);
    interprocess_.SendMessage(data.MessageFactory.ToInterprocess(message, bound_width, bound_height));
  }

  //-------------------------------------------------------------------

  /// @brief ResizeMethodコンボボックス用リスト
  public List<Tuple<string, scff_interprocess.SWScaleFlags>> ResizeMethodList { get; private set; }

  /// @brief プロセス間通信用オブジェクト
  private scff_interprocess.Interprocess interprocess_;
}
}   // namespace scff_app