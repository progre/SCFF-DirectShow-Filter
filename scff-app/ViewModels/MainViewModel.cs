using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using ScffApp.Commons.ViewModels;

namespace ScffApp.ViewModels
{
    /// <summary>
    /// MainフォームのViewModel
    /// Mainフォームにプロパティとコマンドを提供し、Modelを組み合わせてサービスを構成する
    /// </summary>
    internal class MainViewModel : ViewModelBase
    {
        public string Title { get { return "SCFF DirectShow Filter Ver.0.0.1"; } }
    }
}
