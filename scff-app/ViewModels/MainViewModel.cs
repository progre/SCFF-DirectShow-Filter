using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using ScffApp.Commons.ViewModels;
using scff_interprocess;

namespace ScffApp.ViewModels
{
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
    }
}
