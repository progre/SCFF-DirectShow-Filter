
// Copyright 2012 Progre <djyayutto_at_gmail.com>
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

// TODO(progre): 移植未達部分が完了次第名称含め全体をリファクタリング

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Runtime.InteropServices;
using scff_interprocess;
using ScffApp.ViewModels;

namespace ScffApp.Views
{
    public partial class MainForm : Form
    {
        private MainViewModel viewModel;

        public MainForm()
        {
            viewModel = new MainViewModel();

            InitializeComponent();

            mainViewModelBindingSource.Add(viewModel);

            // コントロールの準備
            BuildResizeMethodCombobox();

            // ListViewを選択する
            layout_list.Items[viewModel.editing_layout_index_].Selected = true;
            layout_list.Select();

            // ディレクトリ取得
            UpdateDirectory();

            // デフォルトの設定を書き込む
            DoCaptureDesktopWindow();
            option_keep_aspect_ratio.Checked = true;
            option_enable_enlargement.Checked = true;
            option_resize_method_combo.SelectedIndex = 9;
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            viewModel.DWMAPIRestore();
        }

        /// 共有メモリからディレクトリを取得し、いろいろ処理
        private void UpdateDirectory()
        {
            ArrayList managed_directory = viewModel.GetManagedDirectory();
            process_combo.DataSource = managed_directory;

            if (managed_directory.Count > 0)
            {
                // SCFH DSF発見
                process_combo.DisplayMember = "Info";
                process_combo.ValueMember = "ProcessID";
                process_combo.Enabled = true;
                process_combo.SelectedIndex = 0;

                // メッセージを送るためのボタンを有効化
                splash.Enabled = true;
                apply.Enabled = true;
            }
            else
            {
                // SCFH DSFがロードされていない場合
                process_combo.Enabled = false;

                // メッセージを送るためのボタンを無効化
                splash.Enabled = false;
                apply.Enabled = false;
            }
        }

        private void SendNullLayoutRequest()
        {
            if (process_combo.SelectedValue != null)
            {
                viewModel.SendNullLayoutRequest((uint)((ManagedEntry)process_combo.SelectedItem).ProcessID);
            }
        }

        private void SendNativeLayoutRequest()
        {
            // 共有メモリを開いて送る
            if (process_combo.SelectedValue != null)
            {
                viewModel.SendNativeLayoutRequest((uint)((ManagedEntry)(process_combo.SelectedItem)).ProcessID);
            }
        }

        /// 共有メモリにComplexLayoutリクエストを設定
        private void SendComplexLayoutRequest()
        {
            // 共有メモリを開いて送る
            if (process_combo.SelectedValue != null)
            {
                viewModel.SendComplexLayoutRequest((uint)(process_combo.SelectedValue));
            }
        }

        //-------------------------------------------------------------------

        /// ResizeMethod ComboBoxにデータソースを設定する
        private void BuildResizeMethodCombobox()
        {
            // リストを新しく作成する
            ArrayList resize_methods = viewModel.GetResizeMethods();
            option_resize_method_combo.DataSource = resize_methods;
            option_resize_method_combo.DisplayMember = "MethodName";
            //option_resize_method_combo.ValueMember = "SWScaleFlags";
            option_resize_method_combo.Enabled = true;
            option_resize_method_combo.SelectedIndex = 0;
        }

        //-------------------------------------------------------------------

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        private static extern int GetClassName(IntPtr hWnd, StringBuilder lpClassName, int nMaxCount);
        /// ウィンドウを指定する
        private void SetWindow(IntPtr window_handle)
        {
            viewModel.layout1_parameter_.window = (ulong)window_handle;

            if (window_handle == null)
            {
                this.window_handle.Text = "(Splash)";
            }
            else if (window_handle == GetDesktopWindow())
            {
                this.window_handle.Text = "(Desktop)";
            }
            else
            {
                StringBuilder class_name = new StringBuilder(256);
                GetClassName(window_handle, class_name, 256);
                this.window_handle.Text = class_name.ToString();
            }

            ResetClippingRegion();
        }
        [DllImport("user32.dll", SetLastError = false)]
        static extern IntPtr GetDesktopWindow();        /// デスクトップを全画面で取り込む
        private void DoCaptureDesktopWindow()
        {
            SetWindow(GetDesktopWindow());
        }
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool IsWindow(IntPtr hWnd);
        [StructLayout(LayoutKind.Sequential)]
        struct RECT
        {
            public int left, top, right, bottom;
        }
        [DllImport("user32.dll")]
        static extern bool GetClientRect(IntPtr hWnd, out RECT lpRect);
        /// クリッピング領域をリセットする
        private void ResetClippingRegion()
        {
            IntPtr window_handle =
                (IntPtr)viewModel.GetCurrentLayoutParameter().window;

            if (window_handle == null || !IsWindow(window_handle))
            {
                return;
            }

            RECT window_rect;
            GetClientRect(window_handle, out window_rect);
            area_fit.Checked = true;

            // MinimumとMaximumはValueの更新前に更新しておかないと例外が発生する
            area_clipping_x.Minimum = window_rect.left;
            area_clipping_x.Maximum = window_rect.right;
            area_clipping_y.Minimum = window_rect.top;
            area_clipping_y.Maximum = window_rect.bottom;
            area_clipping_width.Maximum = window_rect.right;
            area_clipping_height.Maximum = window_rect.bottom;

            area_clipping_x.Value = window_rect.left;
            area_clipping_y.Value = window_rect.top;
            area_clipping_width.Value = window_rect.right;
            area_clipping_height.Value = window_rect.bottom;

            viewModel.layout1_parameter_.clipping_x = window_rect.left;
            viewModel.layout1_parameter_.clipping_y = window_rect.top;
            viewModel.layout1_parameter_.clipping_width = window_rect.right;
            viewModel.layout1_parameter_.clipping_height = window_rect.bottom;
        }

        //-------------------------------------------------------------------

        [DllImport("dwmapi.dll")]
        private static extern int DwmIsCompositionEnabled(out bool enabled);
        [DllImport("dwmapi.dll")]
        private static extern int DwmEnableComposition(uint uCompositionAction);
        const int DWM_EC_DISABLECOMPOSITION = 0;
        const int DWM_EC_ENABLECOMPOSITION = 1;

        /// Dwmapi.dllを利用してAeroをOffに
        private void DWMAPIOff()
        {
            viewModel.DWMAPIOff();
            aero_on_item.Checked = false;
        }
        /// 強制的にAeroのOn/Offを切り替える
        private void DWMAPIFlip()
        {
            if (!viewModel.DWMAPIFlip(aero_on_item.Checked))
            {
                // dwmapi.dllを利用できなければ何もしない
                return;
            }
            aero_on_item.Checked = !(aero_on_item.Checked);
        }
        //-------------------------------------------------------------------

        private void aero_on_item_Click(object sender, EventArgs e)
        {
            DWMAPIFlip();
        }

        private void window_draghere_MouseDown(object sender, MouseEventArgs e)
        {
            window_draghere.BackColor = Color.Orange;
        }

        private void process_refresh_Click(object sender, EventArgs e)
        {  // ディレクトリから更新
            UpdateDirectory();
        }
        [DllImport("user32.dll")]
        private static extern IntPtr WindowFromPoint(int xPoint, int yPoint);
        private void window_draghere_MouseUp(object sender, MouseEventArgs e)
        {
            window_draghere.BackColor = SystemColors.Control;

            Point location = window_draghere.PointToScreen(e.Location);

            IntPtr window_handle = WindowFromPoint(location.X, location.Y);
            if (window_handle != IntPtr.Zero)
            {
                // 見つかった場合
                SetWindow(window_handle);
            }
            else
            {
                // nop
            }
        }
        private void splash_Click(object sender, EventArgs e)
        {
            SendNullLayoutRequest();
        }
        private void apply_Click(object sender, EventArgs e)
        {
            if (viewModel.ValidateParameters())
            {
                SendNativeLayoutRequest();
            }
        }
        private void process_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void area_fit_CheckedChanged(object sender, EventArgs e)
        {
            if (area_fit.Checked)
            {
                area_clipping_x.Enabled = false;
                area_clipping_y.Enabled = false;
                area_clipping_width.Enabled = false;
                area_clipping_height.Enabled = false;

                ResetClippingRegion();
            }
            else
            {
                area_clipping_x.Enabled = true;
                area_clipping_y.Enabled = true;
                area_clipping_width.Enabled = true;
                area_clipping_height.Enabled = true;
            }
        }
        private void window_desktop_Click(object sender, EventArgs e)
        {
            DoCaptureDesktopWindow();
        }
        private void area_clipping_x_ValueChanged(object sender, EventArgs e)
        {
            viewModel.layout1_parameter_.clipping_x = (int)area_clipping_x.Value;
        }
        private void area_clipping_y_ValueChanged(object sender, EventArgs e)
        {
            viewModel.layout1_parameter_.clipping_y = (int)area_clipping_y.Value;
        }
        private void area_clipping_width_ValueChanged(object sender, EventArgs e)
        {
            viewModel.layout1_parameter_.clipping_width =
            (int)area_clipping_width.Value;
        }
        private void area_clipping_height_ValueChanged(object sender, EventArgs e)
        {
            viewModel.layout1_parameter_.clipping_height = (int)
            area_clipping_height.Value;
        }
        private void option_show_mouse_cursor_CheckedChanged(object sender, EventArgs e)
        {
            if (option_show_mouse_cursor.Checked)
            {
                viewModel.layout1_parameter_.show_cursor = 1;
            }
            else
            {
                viewModel.layout1_parameter_.show_cursor = 0;
            }
        }
        private void option_show_layered_window_CheckedChanged(object sender, EventArgs e)
        {
            if (option_show_layered_window.Checked)
            {
                viewModel.layout1_parameter_.show_layered_window = 1;
            }
            else
            {
                viewModel.layout1_parameter_.show_layered_window = 0;
            }
        }
        private void option_keep_aspect_ratio_CheckedChanged(object sender, EventArgs e)
        {
            if (option_keep_aspect_ratio.Checked)
            {
                viewModel.layout1_parameter_.keep_aspect_ratio = 1;
            }
            else
            {
                viewModel.layout1_parameter_.keep_aspect_ratio = 0;
            }
        }
        private void option_enable_enlargement_CheckedChanged(object sender, EventArgs e)
        {
            if (option_enable_enlargement.Checked)
            {
                viewModel.layout1_parameter_.stretch = 1;
            }
            else
            {
                viewModel.layout1_parameter_.stretch = 0;
            }
        }
        private void option_over_sampling_CheckedChanged(object sender, EventArgs e) { }
        private void option_thread_num_ValueChanged(object sender, EventArgs e) { }
        private void option_resize_method_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            viewModel.layout1_parameter_.sws_flags = (int)(
                (ResizeMethod)option_resize_method_combo.SelectedValue).SWScaleFlags;
        }
        private void target_area_select_Click(object sender, EventArgs e)
        {
            AreaSelectForm form = new AreaSelectForm();
            Point new_loc = new Point((int)area_clipping_x.Value,
                          (int)area_clipping_y.Value);
            form.Location = new_loc;
            Size new_size = new Size((int)area_clipping_width.Value,
                                           (int)area_clipping_height.Value);
            form.Size = new_size;
            form.ShowDialog();

            // デスクトップキャプチャに変更
            DoCaptureDesktopWindow();
            // FitをはずしてClippingをかく
            area_fit.Checked = false;
            area_clipping_x.Value = Math.Max(form.clipping_x, area_clipping_x.Minimum);
            area_clipping_y.Value = Math.Max(form.clipping_y, area_clipping_y.Minimum);
            area_clipping_width.Value = Math.Min(form.clipping_width, area_clipping_width.Maximum - area_clipping_x.Value);
            area_clipping_height.Value = Math.Min(form.clipping_height, area_clipping_height.Maximum - area_clipping_y.Value);
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            DWMAPIOff();
        }
        private void layout_layout_Click(object sender, EventArgs e)
        {
            if (viewModel.ValidateParameters())
            {
                SendComplexLayoutRequest();
            }
        }
        private void layout_add_Click(object sender, EventArgs e)
        {
        }
        private void layout_remove_Click(object sender, EventArgs e)
        {
        }
        private void layout_strip_ButtonClick(object sender, EventArgs e)
        {
            if (Width > 300)
            {
                Width = 300;
            }
            else
            {
                Width = 488;
            }
        }
        private void layout_list_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

    }
}
