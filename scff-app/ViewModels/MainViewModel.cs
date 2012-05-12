using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using ScffApp.Commons.ViewModels;
using scff_interprocess;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Collections;

namespace ScffApp.ViewModels
{
    // enum格納用
    // Tupleの動作が不安定との情報を聞いたのでしょうがなく作った
    internal class ResizeMethod
    {
        public
        ResizeMethod(String name, Interprocess.SWScaleFlags flags)
        {
            MethodName = name;
            SWScaleFlags = flags;
        }
        public String MethodName;
        public Interprocess.SWScaleFlags SWScaleFlags;
    }

    /// <summary>
    /// MainフォームのViewModel
    /// Mainフォームにプロパティとコマンドを提供し、Modelを組み合わせてサービスを構成する
    /// </summary>
    internal class MainViewModel : ViewModelBase
    {
        /// Dwmapi.dllが利用可能かどうか
        public bool can_use_dwmapi_dll_;
        /// Aeroが起動時にONになっていたかどうか
        public bool was_dwm_enabled_on_start_;
        /// プロセス間通信用オブジェクト
        public Interprocess interprocess_;
        /// 現在編集中のレイアウト番号
        public int editing_layout_index_;
        /// レイアウトパラメータ1
        public Interprocess.LayoutParameter layout1_parameter_ = new Interprocess.LayoutParameter();
        public Interprocess.LayoutParameter layout2_parameter_ = new Interprocess.LayoutParameter();
        public Interprocess.LayoutParameter layout3_parameter_ = new Interprocess.LayoutParameter();
        public Interprocess.LayoutParameter layout4_parameter_ = new Interprocess.LayoutParameter();
        public Interprocess.LayoutParameter layout5_parameter_ = new Interprocess.LayoutParameter();
        public Interprocess.LayoutParameter layout6_parameter_ = new Interprocess.LayoutParameter();
        public Interprocess.LayoutParameter layout7_parameter_ = new Interprocess.LayoutParameter();
        public Interprocess.LayoutParameter layout8_parameter_ = new Interprocess.LayoutParameter();

        public string Title { get { return "SCFF DirectShow Filter Ver.0.0.1"; } }

        public MainViewModel()
        {
            can_use_dwmapi_dll_ = false;
            was_dwm_enabled_on_start_ = false;
            interprocess_ = null;

            // DWMAPI.DLLが利用可能かどうか調べる
            var os = Environment.OSVersion;
            if (os.Platform == PlatformID.Win32NT && os.Version.Major >= 6)
            {
                can_use_dwmapi_dll_ = true;
            }

            // プロセス間通信に必要なオブジェクトの生成
            interprocess_ = new Interprocess();
            // レイアウトパラメータを格納するためのオブジェクトを生成
            layout1_parameter_ = new Interprocess.LayoutParameter();
            layout2_parameter_ = new Interprocess.LayoutParameter();
            layout3_parameter_ = new Interprocess.LayoutParameter();
            layout4_parameter_ = new Interprocess.LayoutParameter();
            layout5_parameter_ = new Interprocess.LayoutParameter();
            layout6_parameter_ = new Interprocess.LayoutParameter();
            layout7_parameter_ = new Interprocess.LayoutParameter();
            layout8_parameter_ = new Interprocess.LayoutParameter();

            // 編集中のレイアウトインデックス
            editing_layout_index_ = 0;
        }

        [StructLayout(LayoutKind.Sequential)]
        struct RECT
        {
            public int left, top, right, bottom;
        }
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool IsWindow(IntPtr hWnd);
        [DllImport("user32.dll")]
        static extern bool GetClientRect(IntPtr hWnd, out RECT lpRect);
        /// パラメータのValidate
        public bool ValidateParameters()
        {
            // もっとも危険な状態になりやすいウィンドウからチェック
            if (GetCurrentLayoutParameter().window == 0)
            { // NULL
                MessageBox.Show("Specified window is invalid", "Invalid Window",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            var window_handle = (IntPtr)(GetCurrentLayoutParameter().window);
            if (!IsWindow(window_handle))
            {
                MessageBox.Show("Specified window is invalid", "Invalid Window",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // クリッピングリージョンの判定
            RECT window_rect;
            GetClientRect(window_handle, out window_rect);
            if (GetCurrentLayoutParameter().clipping_x +
                GetCurrentLayoutParameter().clipping_width
                <= window_rect.right &&
                GetCurrentLayoutParameter().clipping_y +
                GetCurrentLayoutParameter().clipping_height
                <= window_rect.bottom &&
                GetCurrentLayoutParameter().clipping_width > 0 &&
                GetCurrentLayoutParameter().clipping_height > 0)
            {
                // nop 問題なし
            }
            else
            {
                MessageBox.Show("Clipping region is invalid", "Invalid Clipping Region",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        /// 共有メモリにNullLayoutリクエストを設定
        public void SendNullLayoutRequest(uint processId)
        {
            // メッセージを書いて送る
            Interprocess.Message message = new Interprocess.Message();
            message.timestamp = DateTime.Now.Ticks;
            message.layout_type = (int)Interprocess.LayoutType.kNullLayout;

            // 共有メモリを開いて送る
            interprocess_.InitMessage(processId);
            interprocess_.SendMessage(message);
        }

        /// 共有メモリにNativeLayoutリクエストを設定
        public void SendNativeLayoutRequest(uint processId)
        {
            // メッセージを書いて送る
            Interprocess.Message message = new Interprocess.Message();
            message.timestamp = DateTime.Now.Ticks;
            message.layout_type = (int)Interprocess.LayoutType.kNativeLayout;
            // 無視される
            message.layout_element_count = 1;
            message.layout_parameters = new Interprocess.LayoutParameter[Interprocess.kMaxComplexLayoutElements];
            message.layout_parameters[0].bound_x = 0;
            message.layout_parameters[0].bound_y = 0;
            message.layout_parameters[0].bound_width = 0;
            message.layout_parameters[0].bound_height = 0;
            // ここまで無視
            message.layout_parameters[0].window = GetCurrentLayoutParameter().window;
            message.layout_parameters[0].clipping_x = GetCurrentLayoutParameter().clipping_x;
            message.layout_parameters[0].clipping_y = GetCurrentLayoutParameter().clipping_y;
            message.layout_parameters[0].clipping_width = GetCurrentLayoutParameter().clipping_width;
            message.layout_parameters[0].clipping_height = GetCurrentLayoutParameter().clipping_height;
            message.layout_parameters[0].show_cursor = GetCurrentLayoutParameter().show_cursor;
            message.layout_parameters[0].show_layered_window = GetCurrentLayoutParameter().show_layered_window;
            message.layout_parameters[0].sws_flags = GetCurrentLayoutParameter().sws_flags;
            message.layout_parameters[0].stretch = GetCurrentLayoutParameter().stretch;
            message.layout_parameters[0].keep_aspect_ratio = GetCurrentLayoutParameter().keep_aspect_ratio;

            // 共有メモリを開いて送る
            interprocess_.InitMessage(processId);
            interprocess_.SendMessage(message);
        }

        [DllImport("user32.dll", SetLastError = false)]
        static extern IntPtr GetDesktopWindow();        /// デスクトップを全画面で取り込む
        /// 共有メモリにComplexLayoutリクエストを設定
        public void SendComplexLayoutRequest(uint processId)
        {
            // todo(Alalf) テスト中！あとで直す！

            // メッセージを書いて送る
            Interprocess.Message message = new Interprocess.Message();
            message.timestamp = DateTime.Now.Ticks;
            message.layout_type = (int)Interprocess.LayoutType.kComplexLayout;
            message.layout_element_count = 2;
            // 1個目の取り込み範囲
            message.layout_parameters[0].bound_x = 32;
            message.layout_parameters[0].bound_y = 32;
            message.layout_parameters[0].bound_width = 320;
            message.layout_parameters[0].bound_height = 240;
            message.layout_parameters[0].window = (ulong)(GetDesktopWindow());
            message.layout_parameters[0].clipping_x = 0;
            message.layout_parameters[0].clipping_y = 0;
            message.layout_parameters[0].clipping_width = 1000;
            message.layout_parameters[0].clipping_height = 500;
            message.layout_parameters[0].show_cursor = 0;
            message.layout_parameters[0].show_layered_window = 0;
            message.layout_parameters[0].sws_flags = (int)Interprocess.SWScaleFlags.kLanczos;
            message.layout_parameters[0].stretch = 1;
            message.layout_parameters[0].keep_aspect_ratio = 1;
            // 2個目の取り込み範囲
            message.layout_parameters[1].bound_x = 300;
            message.layout_parameters[1].bound_y = 0;
            message.layout_parameters[1].bound_width = 300;
            message.layout_parameters[1].bound_height = 100;
            message.layout_parameters[1].window = (ulong)(GetDesktopWindow());
            message.layout_parameters[1].clipping_x = 320;
            message.layout_parameters[1].clipping_y = 320;
            message.layout_parameters[1].clipping_width = 200;
            message.layout_parameters[1].clipping_height = 200;
            message.layout_parameters[1].show_cursor = 0;
            message.layout_parameters[1].show_layered_window = 0;
            message.layout_parameters[1].sws_flags = (int)Interprocess.SWScaleFlags.kLanczos;
            message.layout_parameters[1].stretch = 1;
            message.layout_parameters[1].keep_aspect_ratio = 1;

            // 共有メモリを開いて送る
            interprocess_.InitMessage(processId);
            interprocess_.SendMessage(message);
        }

        public ArrayList GetResizeMethods()
        {
            ArrayList resize_methods = new ArrayList();
            resize_methods.Add(new ResizeMethod("FastBilinear (fast bilinear)", Interprocess.SWScaleFlags.kFastBilinear));
            resize_methods.Add(new ResizeMethod("Bilinear (bilinear)", Interprocess.SWScaleFlags.kBilinear));
            resize_methods.Add(new ResizeMethod("Bicubic (bicubic)", Interprocess.SWScaleFlags.kBicubic));
            resize_methods.Add(new ResizeMethod("X (experimental)", Interprocess.SWScaleFlags.kX));
            resize_methods.Add(new ResizeMethod("Point (nearest neighbor)", Interprocess.SWScaleFlags.kPoint));
            resize_methods.Add(new ResizeMethod("Area (averaging area)", Interprocess.SWScaleFlags.kArea));
            resize_methods.Add(new ResizeMethod("Bicublin (luma bicubic, chroma bilinear)", Interprocess.SWScaleFlags.kBicublin));
            resize_methods.Add(new ResizeMethod("Gauss (gaussian)", Interprocess.SWScaleFlags.kGauss));
            resize_methods.Add(new ResizeMethod("Sinc (sinc)", Interprocess.SWScaleFlags.kSinc));
            resize_methods.Add(new ResizeMethod("Lanczos (natural)", Interprocess.SWScaleFlags.kLanczos));
            resize_methods.Add(new ResizeMethod("Spline (natural bicubic spline)", Interprocess.SWScaleFlags.kSpline));
            return resize_methods;
        }

        [DllImport("dwmapi.dll")]
        private static extern int DwmIsCompositionEnabled(out bool enabled);
        [DllImport("dwmapi.dll")]
        private static extern int DwmEnableComposition(uint uCompositionAction);
        const int DWM_EC_DISABLECOMPOSITION = 0;
        const int DWM_EC_ENABLECOMPOSITION = 1;
        /// Dwmapi.dllを利用してAeroをOffに
        public void DWMAPIOff()
        {
            if (!can_use_dwmapi_dll_)
            {
                // dwmapi.dllを利用できなければ何もしない
                was_dwm_enabled_on_start_ = false;
                return;
            }

            bool was_dwm_enabled_on_start;
            DwmIsCompositionEnabled(out was_dwm_enabled_on_start);
            if (was_dwm_enabled_on_start)
            {
                //DwmEnableComposition(DWM_EC_DISABLECOMPOSITION);
            }
            else
            {
            }
            was_dwm_enabled_on_start_ = was_dwm_enabled_on_start == true;
        }
        /// 強制的にAeroのOn/Offを切り替える
        public bool DWMAPIFlip(bool isChecked)
        {
            if (!can_use_dwmapi_dll_)
            {
                // dwmapi.dllを利用できなければ何もしない
                return false;
            }

            if (isChecked)
            {
                DwmEnableComposition(DWM_EC_DISABLECOMPOSITION);
            }
            else
            {
                DwmEnableComposition(DWM_EC_ENABLECOMPOSITION);
            }
            return true;
        }
        /// AeroをOffにしていたらOnに戻す
        public void DWMAPIRestore()
        {
            if (!can_use_dwmapi_dll_)
            {
                // dwmapi.dllを利用できなければ何もしない
                return;
            }

            if (was_dwm_enabled_on_start_)
            {
                DwmEnableComposition(DWM_EC_ENABLECOMPOSITION);
            }
        }

        public ArrayList GetManagedDirectory()
        {
            // 共有メモリからデータを取得
            interprocess_.InitDirectory();
            Interprocess.Directory directory;
            interprocess_.GetDirectory(out directory);

            // リストを新しく作成する
            ArrayList managed_directory = new ArrayList();

            // コンボボックスの内容を構築
            for (int i = 0; i < Interprocess.kMaxEntry; i++)
            {
                if (directory.entries[i].process_id == 0) continue;
                ManagedEntry entry = new ManagedEntry(directory.entries[i]);
                managed_directory.Add(entry);
            }
            return managed_directory;
        }

        public Interprocess.LayoutParameter GetCurrentLayoutParameter()
        {
            return GetLayoutParameterByIndex(editing_layout_index_);
        }

        private Interprocess.LayoutParameter GetLayoutParameterByIndex(int index)
        {
            switch (index)
            {
                case 0:
                    return layout1_parameter_;
                case 1:
                    return layout2_parameter_;
                case 2:
                    return layout3_parameter_;
                case 3:
                    return layout4_parameter_;
                case 4:
                    return layout5_parameter_;
                case 5:
                    return layout6_parameter_;
                case 6:
                    return layout7_parameter_;
                case 7:
                    return layout8_parameter_;
                default:
                    throw new ArgumentException();
            }
        }
    }
}
