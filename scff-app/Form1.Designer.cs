﻿namespace scff_app {
  partial class Form1 {
    /// <summary>
    /// 必要なデザイナー変数です。
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// 使用中のリソースをすべてクリーンアップします。
    /// </summary>
    /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows フォーム デザイナーで生成されたコード

    /// <summary>
    /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
    /// コード エディターで変更しないでください。
    /// </summary>
    private void InitializeComponent() {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.layout_layout = new System.Windows.Forms.Button();
      this.main_menu = new System.Windows.Forms.MenuStrip();
      this.tools_menu = new System.Windows.Forms.ToolStripMenuItem();
      this.cts_item = new System.Windows.Forms.ToolStripMenuItem();
      this.ctc_item = new System.Windows.Forms.ToolStripMenuItem();
      this.kToolsSeparator = new System.Windows.Forms.ToolStripSeparator();
      this.aero_on_item = new System.Windows.Forms.ToolStripMenuItem();
      this.language_menu = new System.Windows.Forms.ToolStripMenuItem();
      this.english_item = new System.Windows.Forms.ToolStripMenuItem();
      this.external_item = new System.Windows.Forms.ToolStripMenuItem();
      this.layout_bound_relative_bottom = new System.Windows.Forms.NumericUpDown();
      this.layoutParameterBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.window_desktop = new System.Windows.Forms.Button();
      this.layout_bound_relative_right = new System.Windows.Forms.NumericUpDown();
      this.kWindow = new System.Windows.Forms.GroupBox();
      this.kWindowTable = new System.Windows.Forms.TableLayoutPanel();
      this.window_draghere = new System.Windows.Forms.Button();
      this.window_handle = new System.Windows.Forms.TextBox();
      this.kCaption = new System.Windows.Forms.Label();
      this.area_fit = new System.Windows.Forms.CheckBox();
      this.target_area_select = new System.Windows.Forms.Button();
      this.kArea = new System.Windows.Forms.GroupBox();
      this.kAreaTable = new System.Windows.Forms.TableLayoutPanel();
      this.kX = new System.Windows.Forms.Label();
      this.area_clipping_height = new System.Windows.Forms.NumericUpDown();
      this.kY = new System.Windows.Forms.Label();
      this.kCross = new System.Windows.Forms.Label();
      this.area_clipping_width = new System.Windows.Forms.NumericUpDown();
      this.area_clipping_y = new System.Windows.Forms.NumericUpDown();
      this.kSize = new System.Windows.Forms.Label();
      this.area_clipping_x = new System.Windows.Forms.NumericUpDown();
      this.layout_bound_relative_top = new System.Windows.Forms.NumericUpDown();
      this.layout_bound_relative_left = new System.Windows.Forms.NumericUpDown();
      this.process_refresh = new System.Windows.Forms.Button();
      this.kLayoutBoundRelativeBottom = new System.Windows.Forms.Label();
      this.process_combo = new System.Windows.Forms.ComboBox();
      this.entryBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.kLayoutBoundRelativeRight = new System.Windows.Forms.Label();
      this.kLayoutBoundRelativeTop = new System.Windows.Forms.Label();
      this.kTarget = new System.Windows.Forms.GroupBox();
      this.auto_apply = new System.Windows.Forms.CheckBox();
      this.kLayoutBoundRelativeLeft = new System.Windows.Forms.Label();
      this.layout_remove = new System.Windows.Forms.Button();
      this.layout_add = new System.Windows.Forms.Button();
      this.option_show_mouse_cursor = new System.Windows.Forms.CheckBox();
      this.option_show_layered_window = new System.Windows.Forms.CheckBox();
      this.kDirectShowFilter = new System.Windows.Forms.Label();
      this.kSCFF = new System.Windows.Forms.Label();
      this.apply = new System.Windows.Forms.Button();
      this.splash = new System.Windows.Forms.Button();
      this.kOption = new System.Windows.Forms.GroupBox();
      this.kOptionTable = new System.Windows.Forms.TableLayoutPanel();
      this.option_thread_num = new System.Windows.Forms.NumericUpDown();
      this.kThreadNum = new System.Windows.Forms.Label();
      this.option_enable_enlargement = new System.Windows.Forms.CheckBox();
      this.option_over_sampling = new System.Windows.Forms.CheckBox();
      this.option_keep_aspect_ratio = new System.Windows.Forms.CheckBox();
      this.resize_method_accurate_rnd = new System.Windows.Forms.CheckBox();
      this.resize_method_combo = new System.Windows.Forms.ComboBox();
      this.layout_list = new System.Windows.Forms.ListBox();
      this.kVersion = new System.Windows.Forms.Label();
      this.layout_profile_combo = new System.Windows.Forms.ComboBox();
      this.layout_bound_table = new System.Windows.Forms.TableLayoutPanel();
      this.kLayoutButtonTable = new System.Windows.Forms.TableLayoutPanel();
      this.kHeaderTable = new System.Windows.Forms.TableLayoutPanel();
      this.kResizeMethod = new System.Windows.Forms.GroupBox();
      this.kResizeMethodFilter = new System.Windows.Forms.GroupBox();
      this.kResizeMethodFilterTable = new System.Windows.Forms.TableLayoutPanel();
      this.resize_method_is_filter_enabled = new System.Windows.Forms.CheckBox();
      this.kCHShift = new System.Windows.Forms.Label();
      this.resize_method_chshift = new System.Windows.Forms.NumericUpDown();
      this.kCVShift = new System.Windows.Forms.Label();
      this.resize_method_cvshift = new System.Windows.Forms.NumericUpDown();
      this.kLSharpen = new System.Windows.Forms.Label();
      this.resize_method_lsharpen = new System.Windows.Forms.NumericUpDown();
      this.kCSharpen = new System.Windows.Forms.Label();
      this.resize_method_csharpen = new System.Windows.Forms.NumericUpDown();
      this.kCGBlur = new System.Windows.Forms.Label();
      this.kLGBlur = new System.Windows.Forms.Label();
      this.resize_method_lgblur = new System.Windows.Forms.NumericUpDown();
      this.resize_method_cgblur = new System.Windows.Forms.NumericUpDown();
      this.kResizeMethodTable = new System.Windows.Forms.TableLayoutPanel();
      this.kMainButtonPanel = new System.Windows.Forms.Panel();
      this.kLayout = new System.Windows.Forms.GroupBox();
      this.kProcessPanel = new System.Windows.Forms.Panel();
      this.kProfilePanel = new System.Windows.Forms.Panel();
      this.main_menu.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.layout_bound_relative_bottom)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutParameterBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layout_bound_relative_right)).BeginInit();
      this.kWindow.SuspendLayout();
      this.kWindowTable.SuspendLayout();
      this.kArea.SuspendLayout();
      this.kAreaTable.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.area_clipping_height)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.area_clipping_width)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.area_clipping_y)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.area_clipping_x)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layout_bound_relative_top)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layout_bound_relative_left)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.entryBindingSource)).BeginInit();
      this.kTarget.SuspendLayout();
      this.kOption.SuspendLayout();
      this.kOptionTable.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.option_thread_num)).BeginInit();
      this.layout_bound_table.SuspendLayout();
      this.kLayoutButtonTable.SuspendLayout();
      this.kHeaderTable.SuspendLayout();
      this.kResizeMethod.SuspendLayout();
      this.kResizeMethodFilter.SuspendLayout();
      this.kResizeMethodFilterTable.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.resize_method_chshift)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.resize_method_cvshift)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.resize_method_lsharpen)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.resize_method_csharpen)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.resize_method_lgblur)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.resize_method_cgblur)).BeginInit();
      this.kResizeMethodTable.SuspendLayout();
      this.kMainButtonPanel.SuspendLayout();
      this.kLayout.SuspendLayout();
      this.kProcessPanel.SuspendLayout();
      this.kProfilePanel.SuspendLayout();
      this.SuspendLayout();
      // 
      // layout_layout
      // 
      this.layout_layout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.layout_layout.Enabled = false;
      this.layout_layout.Location = new System.Drawing.Point(111, 3);
      this.layout_layout.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.layout_layout.Name = "layout_layout";
      this.layout_layout.Size = new System.Drawing.Size(70, 26);
      this.layout_layout.TabIndex = 11;
      this.layout_layout.Text = "Layout";
      this.layout_layout.UseVisualStyleBackColor = true;
      this.layout_layout.Click += new System.EventHandler(this.layout_layout_Click);
      // 
      // main_menu
      // 
      this.main_menu.GripMargin = new System.Windows.Forms.Padding(2);
      this.main_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tools_menu,
            this.language_menu});
      this.main_menu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
      this.main_menu.Location = new System.Drawing.Point(0, 0);
      this.main_menu.Name = "main_menu";
      this.main_menu.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
      this.main_menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
      this.main_menu.Size = new System.Drawing.Size(515, 22);
      this.main_menu.TabIndex = 1;
      this.main_menu.Text = "main_menu";
      // 
      // tools_menu
      // 
      this.tools_menu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.tools_menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cts_item,
            this.ctc_item,
            this.kToolsSeparator,
            this.aero_on_item});
      this.tools_menu.Name = "tools_menu";
      this.tools_menu.Size = new System.Drawing.Size(45, 16);
      this.tools_menu.Text = "Tools";
      // 
      // cts_item
      // 
      this.cts_item.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.cts_item.Enabled = false;
      this.cts_item.Name = "cts_item";
      this.cts_item.Size = new System.Drawing.Size(251, 22);
      this.cts_item.Text = "Convert To Screen Coordinates";
      // 
      // ctc_item
      // 
      this.ctc_item.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.ctc_item.Enabled = false;
      this.ctc_item.Name = "ctc_item";
      this.ctc_item.Size = new System.Drawing.Size(251, 22);
      this.ctc_item.Text = "Convert to Client-area Coordinates";
      // 
      // kToolsSeparator
      // 
      this.kToolsSeparator.Name = "kToolsSeparator";
      this.kToolsSeparator.Size = new System.Drawing.Size(248, 6);
      // 
      // aero_on_item
      // 
      this.aero_on_item.Name = "aero_on_item";
      this.aero_on_item.Size = new System.Drawing.Size(251, 22);
      this.aero_on_item.Text = "Force Windows Aero Enabled";
      this.aero_on_item.Click += new System.EventHandler(this.aero_on_item_Click);
      // 
      // language_menu
      // 
      this.language_menu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.language_menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.english_item,
            this.external_item});
      this.language_menu.Enabled = false;
      this.language_menu.Name = "language_menu";
      this.language_menu.Size = new System.Drawing.Size(65, 16);
      this.language_menu.Text = "Language";
      // 
      // english_item
      // 
      this.english_item.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.english_item.Enabled = false;
      this.english_item.Name = "english_item";
      this.english_item.Size = new System.Drawing.Size(112, 22);
      this.english_item.Text = "English";
      // 
      // external_item
      // 
      this.external_item.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.external_item.Enabled = false;
      this.external_item.Name = "external_item";
      this.external_item.Size = new System.Drawing.Size(112, 22);
      this.external_item.Text = "External";
      // 
      // layout_bound_relative_bottom
      // 
      this.layout_bound_relative_bottom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.layout_bound_table.SetColumnSpan(this.layout_bound_relative_bottom, 2);
      this.layout_bound_relative_bottom.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.layoutParameterBindingSource, "BoundRelativeBottom", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.layout_bound_relative_bottom.DecimalPlaces = 1;
      this.layout_bound_relative_bottom.Enabled = false;
      this.layout_bound_relative_bottom.Location = new System.Drawing.Point(62, 51);
      this.layout_bound_relative_bottom.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.layout_bound_relative_bottom.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.layout_bound_relative_bottom.Name = "layout_bound_relative_bottom";
      this.layout_bound_relative_bottom.Size = new System.Drawing.Size(56, 18);
      this.layout_bound_relative_bottom.TabIndex = 7;
      this.layout_bound_relative_bottom.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
      // 
      // layoutParameterBindingSource
      // 
      this.layoutParameterBindingSource.DataSource = typeof(scff_app.data.LayoutParameter);
      // 
      // window_desktop
      // 
      this.window_desktop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.window_desktop.Location = new System.Drawing.Point(183, 27);
      this.window_desktop.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.window_desktop.Name = "window_desktop";
      this.window_desktop.Size = new System.Drawing.Size(66, 25);
      this.window_desktop.TabIndex = 3;
      this.window_desktop.Text = "Desktop";
      this.window_desktop.UseVisualStyleBackColor = true;
      this.window_desktop.Click += new System.EventHandler(this.window_desktop_Click);
      // 
      // layout_bound_relative_right
      // 
      this.layout_bound_relative_right.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.layout_bound_table.SetColumnSpan(this.layout_bound_relative_right, 2);
      this.layout_bound_relative_right.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.layoutParameterBindingSource, "BoundRelativeRight", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.layout_bound_relative_right.DecimalPlaces = 1;
      this.layout_bound_relative_right.Enabled = false;
      this.layout_bound_relative_right.Location = new System.Drawing.Point(92, 27);
      this.layout_bound_relative_right.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.layout_bound_relative_right.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.layout_bound_relative_right.Name = "layout_bound_relative_right";
      this.layout_bound_relative_right.Size = new System.Drawing.Size(56, 18);
      this.layout_bound_relative_right.TabIndex = 5;
      this.layout_bound_relative_right.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
      // 
      // kWindow
      // 
      this.kWindow.AutoSize = true;
      this.kWindow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.kWindow.Controls.Add(this.kWindowTable);
      this.kWindow.Dock = System.Windows.Forms.DockStyle.Top;
      this.kWindow.Location = new System.Drawing.Point(6, 14);
      this.kWindow.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.kWindow.Name = "kWindow";
      this.kWindow.Padding = new System.Windows.Forms.Padding(6, 3, 6, 8);
      this.kWindow.Size = new System.Drawing.Size(263, 77);
      this.kWindow.TabIndex = 0;
      this.kWindow.TabStop = false;
      this.kWindow.Text = "Window";
      // 
      // kWindowTable
      // 
      this.kWindowTable.AutoSize = true;
      this.kWindowTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.kWindowTable.ColumnCount = 3;
      this.kWindowTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
      this.kWindowTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.kWindowTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
      this.kWindowTable.Controls.Add(this.window_desktop, 2, 1);
      this.kWindowTable.Controls.Add(this.window_draghere, 0, 1);
      this.kWindowTable.Controls.Add(this.window_handle, 1, 0);
      this.kWindowTable.Controls.Add(this.kCaption, 0, 0);
      this.kWindowTable.Dock = System.Windows.Forms.DockStyle.Top;
      this.kWindowTable.Location = new System.Drawing.Point(6, 14);
      this.kWindowTable.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.kWindowTable.Name = "kWindowTable";
      this.kWindowTable.RowCount = 2;
      this.kWindowTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.kWindowTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.kWindowTable.Size = new System.Drawing.Size(251, 55);
      this.kWindowTable.TabIndex = 6;
      // 
      // window_draghere
      // 
      this.window_draghere.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.kWindowTable.SetColumnSpan(this.window_draghere, 2);
      this.window_draghere.Location = new System.Drawing.Point(2, 27);
      this.window_draghere.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.window_draghere.Name = "window_draghere";
      this.window_draghere.Size = new System.Drawing.Size(177, 25);
      this.window_draghere.TabIndex = 2;
      this.window_draghere.Text = "Drag here.";
      this.window_draghere.UseVisualStyleBackColor = true;
      this.window_draghere.MouseDown += new System.Windows.Forms.MouseEventHandler(this.window_draghere_MouseDown);
      this.window_draghere.MouseUp += new System.Windows.Forms.MouseEventHandler(this.window_draghere_MouseUp);
      // 
      // window_handle
      // 
      this.window_handle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.kWindowTable.SetColumnSpan(this.window_handle, 2);
      this.window_handle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.layoutParameterBindingSource, "WindowText", true));
      this.window_handle.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.layoutParameterBindingSource, "Window", true));
      this.window_handle.Location = new System.Drawing.Point(57, 3);
      this.window_handle.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.window_handle.Name = "window_handle";
      this.window_handle.ReadOnly = true;
      this.window_handle.Size = new System.Drawing.Size(192, 18);
      this.window_handle.TabIndex = 1;
      this.window_handle.TabStop = false;
      // 
      // kCaption
      // 
      this.kCaption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.kCaption.AutoSize = true;
      this.kCaption.Location = new System.Drawing.Point(2, 0);
      this.kCaption.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.kCaption.Name = "kCaption";
      this.kCaption.Size = new System.Drawing.Size(40, 24);
      this.kCaption.TabIndex = 0;
      this.kCaption.Text = "Caption";
      this.kCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // area_fit
      // 
      this.area_fit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.area_fit.AutoSize = true;
      this.area_fit.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.layoutParameterBindingSource, "Fit", true));
      this.area_fit.Location = new System.Drawing.Point(2, 3);
      this.area_fit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.area_fit.Name = "area_fit";
      this.kAreaTable.SetRowSpan(this.area_fit, 2);
      this.area_fit.Size = new System.Drawing.Size(36, 42);
      this.area_fit.TabIndex = 0;
      this.area_fit.Text = "Fit";
      this.area_fit.UseVisualStyleBackColor = true;
      this.area_fit.CheckedChanged += new System.EventHandler(this.area_fit_CheckedChanged);
      // 
      // target_area_select
      // 
      this.target_area_select.Dock = System.Windows.Forms.DockStyle.Top;
      this.target_area_select.Location = new System.Drawing.Point(6, 161);
      this.target_area_select.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.target_area_select.Name = "target_area_select";
      this.target_area_select.Size = new System.Drawing.Size(263, 25);
      this.target_area_select.TabIndex = 2;
      this.target_area_select.Text = "Area Selection";
      this.target_area_select.UseVisualStyleBackColor = true;
      this.target_area_select.Click += new System.EventHandler(this.target_area_select_Click);
      // 
      // kArea
      // 
      this.kArea.AutoSize = true;
      this.kArea.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.kArea.Controls.Add(this.kAreaTable);
      this.kArea.Dock = System.Windows.Forms.DockStyle.Top;
      this.kArea.Location = new System.Drawing.Point(6, 91);
      this.kArea.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.kArea.Name = "kArea";
      this.kArea.Padding = new System.Windows.Forms.Padding(6, 3, 6, 8);
      this.kArea.Size = new System.Drawing.Size(263, 70);
      this.kArea.TabIndex = 1;
      this.kArea.TabStop = false;
      this.kArea.Text = "Area";
      // 
      // kAreaTable
      // 
      this.kAreaTable.AutoSize = true;
      this.kAreaTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.kAreaTable.ColumnCount = 5;
      this.kAreaTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
      this.kAreaTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.kAreaTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
      this.kAreaTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.kAreaTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 66F));
      this.kAreaTable.Controls.Add(this.kX, 1, 0);
      this.kAreaTable.Controls.Add(this.area_fit, 0, 0);
      this.kAreaTable.Controls.Add(this.area_clipping_height, 4, 1);
      this.kAreaTable.Controls.Add(this.kY, 3, 0);
      this.kAreaTable.Controls.Add(this.kCross, 3, 1);
      this.kAreaTable.Controls.Add(this.area_clipping_width, 2, 1);
      this.kAreaTable.Controls.Add(this.area_clipping_y, 4, 0);
      this.kAreaTable.Controls.Add(this.kSize, 1, 1);
      this.kAreaTable.Controls.Add(this.area_clipping_x, 2, 0);
      this.kAreaTable.Dock = System.Windows.Forms.DockStyle.Top;
      this.kAreaTable.Location = new System.Drawing.Point(6, 14);
      this.kAreaTable.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.kAreaTable.Name = "kAreaTable";
      this.kAreaTable.RowCount = 2;
      this.kAreaTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.kAreaTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.kAreaTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.kAreaTable.Size = new System.Drawing.Size(251, 48);
      this.kAreaTable.TabIndex = 9;
      // 
      // kX
      // 
      this.kX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.kX.AutoSize = true;
      this.kX.Location = new System.Drawing.Point(62, 0);
      this.kX.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.kX.Name = "kX";
      this.kX.Size = new System.Drawing.Size(12, 24);
      this.kX.TabIndex = 1;
      this.kX.Text = "X";
      this.kX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // area_clipping_height
      // 
      this.area_clipping_height.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.area_clipping_height.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.layoutParameterBindingSource, "ClippingHeight", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.area_clipping_height.Location = new System.Drawing.Point(187, 27);
      this.area_clipping_height.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.area_clipping_height.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
      this.area_clipping_height.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.area_clipping_height.Name = "area_clipping_height";
      this.area_clipping_height.Size = new System.Drawing.Size(62, 18);
      this.area_clipping_height.TabIndex = 8;
      this.area_clipping_height.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
      // 
      // kY
      // 
      this.kY.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.kY.AutoSize = true;
      this.kY.Location = new System.Drawing.Point(157, 0);
      this.kY.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.kY.Name = "kY";
      this.kY.Size = new System.Drawing.Size(11, 24);
      this.kY.TabIndex = 3;
      this.kY.Text = "Y";
      this.kY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // kCross
      // 
      this.kCross.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.kCross.AutoSize = true;
      this.kCross.Location = new System.Drawing.Point(157, 24);
      this.kCross.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.kCross.Name = "kCross";
      this.kCross.Size = new System.Drawing.Size(10, 24);
      this.kCross.TabIndex = 7;
      this.kCross.Text = "x";
      this.kCross.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // area_clipping_width
      // 
      this.area_clipping_width.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.area_clipping_width.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.layoutParameterBindingSource, "ClippingWidth", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.area_clipping_width.Location = new System.Drawing.Point(92, 27);
      this.area_clipping_width.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.area_clipping_width.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
      this.area_clipping_width.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.area_clipping_width.Name = "area_clipping_width";
      this.area_clipping_width.Size = new System.Drawing.Size(61, 18);
      this.area_clipping_width.TabIndex = 6;
      this.area_clipping_width.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
      // 
      // area_clipping_y
      // 
      this.area_clipping_y.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.area_clipping_y.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.layoutParameterBindingSource, "ClippingY", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.area_clipping_y.Location = new System.Drawing.Point(187, 3);
      this.area_clipping_y.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.area_clipping_y.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
      this.area_clipping_y.Name = "area_clipping_y";
      this.area_clipping_y.Size = new System.Drawing.Size(62, 18);
      this.area_clipping_y.TabIndex = 4;
      this.area_clipping_y.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
      // 
      // kSize
      // 
      this.kSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.kSize.AutoSize = true;
      this.kSize.Location = new System.Drawing.Point(62, 24);
      this.kSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.kSize.Name = "kSize";
      this.kSize.Size = new System.Drawing.Size(25, 24);
      this.kSize.TabIndex = 5;
      this.kSize.Text = "Size";
      this.kSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // area_clipping_x
      // 
      this.area_clipping_x.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.area_clipping_x.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.layoutParameterBindingSource, "ClippingX", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.area_clipping_x.Location = new System.Drawing.Point(92, 3);
      this.area_clipping_x.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.area_clipping_x.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
      this.area_clipping_x.Name = "area_clipping_x";
      this.area_clipping_x.Size = new System.Drawing.Size(61, 18);
      this.area_clipping_x.TabIndex = 2;
      this.area_clipping_x.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
      // 
      // layout_bound_relative_top
      // 
      this.layout_bound_relative_top.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.layout_bound_table.SetColumnSpan(this.layout_bound_relative_top, 2);
      this.layout_bound_relative_top.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.layoutParameterBindingSource, "BoundRelativeTop", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.layout_bound_relative_top.DecimalPlaces = 1;
      this.layout_bound_relative_top.Enabled = false;
      this.layout_bound_relative_top.Location = new System.Drawing.Point(62, 3);
      this.layout_bound_relative_top.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.layout_bound_relative_top.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
      this.layout_bound_relative_top.Name = "layout_bound_relative_top";
      this.layout_bound_relative_top.Size = new System.Drawing.Size(56, 18);
      this.layout_bound_relative_top.TabIndex = 2;
      // 
      // layout_bound_relative_left
      // 
      this.layout_bound_relative_left.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.layout_bound_table.SetColumnSpan(this.layout_bound_relative_left, 2);
      this.layout_bound_relative_left.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.layoutParameterBindingSource, "BoundRelativeLeft", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.layout_bound_relative_left.DecimalPlaces = 1;
      this.layout_bound_relative_left.Enabled = false;
      this.layout_bound_relative_left.Location = new System.Drawing.Point(32, 27);
      this.layout_bound_relative_left.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.layout_bound_relative_left.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
      this.layout_bound_relative_left.Name = "layout_bound_relative_left";
      this.layout_bound_relative_left.Size = new System.Drawing.Size(56, 18);
      this.layout_bound_relative_left.TabIndex = 4;
      // 
      // process_refresh
      // 
      this.process_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.process_refresh.Font = new System.Drawing.Font("MS UI Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      this.process_refresh.Location = new System.Drawing.Point(208, 3);
      this.process_refresh.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.process_refresh.Name = "process_refresh";
      this.process_refresh.Size = new System.Drawing.Size(65, 25);
      this.process_refresh.TabIndex = 3;
      this.process_refresh.Text = "Refresh";
      this.process_refresh.UseVisualStyleBackColor = true;
      this.process_refresh.Click += new System.EventHandler(this.process_refresh_Click);
      // 
      // kLayoutBoundRelativeBottom
      // 
      this.kLayoutBoundRelativeBottom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.kLayoutBoundRelativeBottom.AutoSize = true;
      this.layout_bound_table.SetColumnSpan(this.kLayoutBoundRelativeBottom, 2);
      this.kLayoutBoundRelativeBottom.Location = new System.Drawing.Point(122, 48);
      this.kLayoutBoundRelativeBottom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.kLayoutBoundRelativeBottom.Name = "kLayoutBoundRelativeBottom";
      this.kLayoutBoundRelativeBottom.Size = new System.Drawing.Size(40, 24);
      this.kLayoutBoundRelativeBottom.TabIndex = 8;
      this.kLayoutBoundRelativeBottom.Text = "Bottom";
      this.kLayoutBoundRelativeBottom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // process_combo
      // 
      this.process_combo.DataSource = this.entryBindingSource;
      this.process_combo.DisplayMember = "EntryInfo";
      this.process_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.process_combo.Font = new System.Drawing.Font("MS UI Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      this.process_combo.FormattingEnabled = true;
      this.process_combo.Location = new System.Drawing.Point(2, 5);
      this.process_combo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.process_combo.Name = "process_combo";
      this.process_combo.Size = new System.Drawing.Size(197, 19);
      this.process_combo.TabIndex = 2;
      this.process_combo.ValueMember = "ProcessID";
      // 
      // entryBindingSource
      // 
      this.entryBindingSource.DataSource = typeof(scff_app.data.Entry);
      // 
      // kLayoutBoundRelativeRight
      // 
      this.kLayoutBoundRelativeRight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.kLayoutBoundRelativeRight.AutoSize = true;
      this.kLayoutBoundRelativeRight.Location = new System.Drawing.Point(152, 24);
      this.kLayoutBoundRelativeRight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.kLayoutBoundRelativeRight.Name = "kLayoutBoundRelativeRight";
      this.kLayoutBoundRelativeRight.Size = new System.Drawing.Size(29, 24);
      this.kLayoutBoundRelativeRight.TabIndex = 6;
      this.kLayoutBoundRelativeRight.Text = "Right";
      this.kLayoutBoundRelativeRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // kLayoutBoundRelativeTop
      // 
      this.kLayoutBoundRelativeTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.kLayoutBoundRelativeTop.AutoSize = true;
      this.kLayoutBoundRelativeTop.Location = new System.Drawing.Point(36, 0);
      this.kLayoutBoundRelativeTop.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.kLayoutBoundRelativeTop.Name = "kLayoutBoundRelativeTop";
      this.kLayoutBoundRelativeTop.Size = new System.Drawing.Size(22, 24);
      this.kLayoutBoundRelativeTop.TabIndex = 1;
      this.kLayoutBoundRelativeTop.Text = "Top";
      this.kLayoutBoundRelativeTop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // kTarget
      // 
      this.kTarget.AutoSize = true;
      this.kTarget.Controls.Add(this.target_area_select);
      this.kTarget.Controls.Add(this.kArea);
      this.kTarget.Controls.Add(this.kWindow);
      this.kTarget.Font = new System.Drawing.Font("MS UI Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      this.kTarget.Location = new System.Drawing.Point(5, 99);
      this.kTarget.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.kTarget.Name = "kTarget";
      this.kTarget.Padding = new System.Windows.Forms.Padding(6, 3, 6, 8);
      this.kTarget.Size = new System.Drawing.Size(275, 200);
      this.kTarget.TabIndex = 0;
      this.kTarget.TabStop = false;
      this.kTarget.Text = "Target";
      // 
      // auto_apply
      // 
      this.auto_apply.Location = new System.Drawing.Point(134, 4);
      this.auto_apply.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.auto_apply.Name = "auto_apply";
      this.auto_apply.Size = new System.Drawing.Size(48, 17);
      this.auto_apply.TabIndex = 3;
      this.auto_apply.Text = "Auto";
      this.auto_apply.UseVisualStyleBackColor = true;
      // 
      // kLayoutBoundRelativeLeft
      // 
      this.kLayoutBoundRelativeLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.kLayoutBoundRelativeLeft.AutoSize = true;
      this.kLayoutBoundRelativeLeft.Location = new System.Drawing.Point(4, 24);
      this.kLayoutBoundRelativeLeft.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.kLayoutBoundRelativeLeft.Name = "kLayoutBoundRelativeLeft";
      this.kLayoutBoundRelativeLeft.Size = new System.Drawing.Size(24, 24);
      this.kLayoutBoundRelativeLeft.TabIndex = 3;
      this.kLayoutBoundRelativeLeft.Text = "Left";
      this.kLayoutBoundRelativeLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // layout_remove
      // 
      this.layout_remove.Image = global::scff_app.Properties.Resources.Remove;
      this.layout_remove.Location = new System.Drawing.Point(32, 3);
      this.layout_remove.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.layout_remove.Name = "layout_remove";
      this.layout_remove.Size = new System.Drawing.Size(25, 25);
      this.layout_remove.TabIndex = 10;
      this.layout_remove.UseVisualStyleBackColor = true;
      this.layout_remove.Click += new System.EventHandler(this.layout_remove_Click);
      // 
      // layout_add
      // 
      this.layout_add.Image = global::scff_app.Properties.Resources.Add;
      this.layout_add.Location = new System.Drawing.Point(2, 3);
      this.layout_add.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.layout_add.Name = "layout_add";
      this.layout_add.Size = new System.Drawing.Size(25, 25);
      this.layout_add.TabIndex = 9;
      this.layout_add.UseVisualStyleBackColor = true;
      this.layout_add.Click += new System.EventHandler(this.layout_add_Click);
      // 
      // option_show_mouse_cursor
      // 
      this.option_show_mouse_cursor.AutoSize = true;
      this.option_show_mouse_cursor.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.layoutParameterBindingSource, "ShowCursor", true));
      this.option_show_mouse_cursor.Location = new System.Drawing.Point(2, 3);
      this.option_show_mouse_cursor.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.option_show_mouse_cursor.Name = "option_show_mouse_cursor";
      this.option_show_mouse_cursor.Size = new System.Drawing.Size(119, 15);
      this.option_show_mouse_cursor.TabIndex = 0;
      this.option_show_mouse_cursor.Text = "Show Mouse Cursor";
      this.option_show_mouse_cursor.UseVisualStyleBackColor = true;
      // 
      // option_show_layered_window
      // 
      this.option_show_layered_window.AutoSize = true;
      this.option_show_layered_window.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.layoutParameterBindingSource, "ShowLayeredWindow", true));
      this.option_show_layered_window.Location = new System.Drawing.Point(2, 24);
      this.option_show_layered_window.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.option_show_layered_window.Name = "option_show_layered_window";
      this.option_show_layered_window.Size = new System.Drawing.Size(127, 15);
      this.option_show_layered_window.TabIndex = 1;
      this.option_show_layered_window.Text = "Show Layered Window";
      this.option_show_layered_window.UseVisualStyleBackColor = true;
      // 
      // kDirectShowFilter
      // 
      this.kDirectShowFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.kDirectShowFilter.AutoSize = true;
      this.kDirectShowFilter.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.kDirectShowFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
      this.kDirectShowFilter.Location = new System.Drawing.Point(55, 0);
      this.kDirectShowFilter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.kDirectShowFilter.Name = "kDirectShowFilter";
      this.kDirectShowFilter.Size = new System.Drawing.Size(103, 35);
      this.kDirectShowFilter.TabIndex = 1;
      this.kDirectShowFilter.Text = "DirectShow Filter";
      this.kDirectShowFilter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // kSCFF
      // 
      this.kSCFF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.kSCFF.AutoSize = true;
      this.kSCFF.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.kSCFF.ForeColor = System.Drawing.Color.White;
      this.kSCFF.Location = new System.Drawing.Point(2, 0);
      this.kSCFF.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.kSCFF.Name = "kSCFF";
      this.kSCFF.Size = new System.Drawing.Size(49, 35);
      this.kSCFF.TabIndex = 0;
      this.kSCFF.Text = "  SCFF";
      this.kSCFF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // apply
      // 
      this.apply.Enabled = false;
      this.apply.Location = new System.Drawing.Point(187, 0);
      this.apply.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.apply.Name = "apply";
      this.apply.Size = new System.Drawing.Size(86, 25);
      this.apply.TabIndex = 4;
      this.apply.Text = "Apply";
      this.apply.UseVisualStyleBackColor = true;
      this.apply.Click += new System.EventHandler(this.apply_Click);
      // 
      // splash
      // 
      this.splash.Enabled = false;
      this.splash.FlatStyle = System.Windows.Forms.FlatStyle.System;
      this.splash.Location = new System.Drawing.Point(0, 0);
      this.splash.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.splash.Name = "splash";
      this.splash.Size = new System.Drawing.Size(68, 25);
      this.splash.TabIndex = 2;
      this.splash.Text = "Splash";
      this.splash.UseVisualStyleBackColor = true;
      this.splash.Click += new System.EventHandler(this.splash_Click);
      // 
      // kOption
      // 
      this.kOption.AutoSize = true;
      this.kOption.Controls.Add(this.kOptionTable);
      this.kOption.Font = new System.Drawing.Font("MS UI Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      this.kOption.Location = new System.Drawing.Point(5, 300);
      this.kOption.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.kOption.Name = "kOption";
      this.kOption.Padding = new System.Windows.Forms.Padding(6, 3, 6, 8);
      this.kOption.Size = new System.Drawing.Size(275, 109);
      this.kOption.TabIndex = 1;
      this.kOption.TabStop = false;
      this.kOption.Text = "Option";
      // 
      // kOptionTable
      // 
      this.kOptionTable.AutoSize = true;
      this.kOptionTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.kOptionTable.ColumnCount = 2;
      this.kOptionTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.kOptionTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.kOptionTable.Controls.Add(this.option_show_mouse_cursor, 0, 0);
      this.kOptionTable.Controls.Add(this.option_show_layered_window, 0, 1);
      this.kOptionTable.Controls.Add(this.option_thread_num, 1, 3);
      this.kOptionTable.Controls.Add(this.kThreadNum, 1, 2);
      this.kOptionTable.Controls.Add(this.option_enable_enlargement, 0, 3);
      this.kOptionTable.Controls.Add(this.option_over_sampling, 1, 0);
      this.kOptionTable.Controls.Add(this.option_keep_aspect_ratio, 0, 2);
      this.kOptionTable.Dock = System.Windows.Forms.DockStyle.Top;
      this.kOptionTable.Location = new System.Drawing.Point(6, 14);
      this.kOptionTable.Name = "kOptionTable";
      this.kOptionTable.RowCount = 4;
      this.kOptionTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
      this.kOptionTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
      this.kOptionTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
      this.kOptionTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.kOptionTable.Size = new System.Drawing.Size(263, 87);
      this.kOptionTable.TabIndex = 15;
      // 
      // option_thread_num
      // 
      this.option_thread_num.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.option_thread_num.Enabled = false;
      this.option_thread_num.Location = new System.Drawing.Point(133, 66);
      this.option_thread_num.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.option_thread_num.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
      this.option_thread_num.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.option_thread_num.Name = "option_thread_num";
      this.option_thread_num.Size = new System.Drawing.Size(129, 18);
      this.option_thread_num.TabIndex = 6;
      this.option_thread_num.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      // 
      // kThreadNum
      // 
      this.kThreadNum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.kThreadNum.AutoSize = true;
      this.kThreadNum.Enabled = false;
      this.kThreadNum.Location = new System.Drawing.Point(201, 42);
      this.kThreadNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.kThreadNum.Name = "kThreadNum";
      this.kThreadNum.Size = new System.Drawing.Size(61, 21);
      this.kThreadNum.TabIndex = 5;
      this.kThreadNum.Text = "Thread Num";
      this.kThreadNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // option_enable_enlargement
      // 
      this.option_enable_enlargement.AutoSize = true;
      this.option_enable_enlargement.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.layoutParameterBindingSource, "Stretch", true));
      this.option_enable_enlargement.Location = new System.Drawing.Point(2, 66);
      this.option_enable_enlargement.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.option_enable_enlargement.Name = "option_enable_enlargement";
      this.option_enable_enlargement.Size = new System.Drawing.Size(115, 15);
      this.option_enable_enlargement.TabIndex = 3;
      this.option_enable_enlargement.Text = "Enable Enlargement";
      this.option_enable_enlargement.UseVisualStyleBackColor = true;
      // 
      // option_over_sampling
      // 
      this.option_over_sampling.AutoSize = true;
      this.option_over_sampling.Enabled = false;
      this.option_over_sampling.Location = new System.Drawing.Point(133, 3);
      this.option_over_sampling.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.option_over_sampling.Name = "option_over_sampling";
      this.option_over_sampling.Size = new System.Drawing.Size(93, 15);
      this.option_over_sampling.TabIndex = 4;
      this.option_over_sampling.Text = "Over-Sampling";
      this.option_over_sampling.UseVisualStyleBackColor = true;
      // 
      // option_keep_aspect_ratio
      // 
      this.option_keep_aspect_ratio.AutoSize = true;
      this.option_keep_aspect_ratio.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.layoutParameterBindingSource, "KeepAspectRatio", true));
      this.option_keep_aspect_ratio.Location = new System.Drawing.Point(2, 45);
      this.option_keep_aspect_ratio.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.option_keep_aspect_ratio.Name = "option_keep_aspect_ratio";
      this.option_keep_aspect_ratio.Size = new System.Drawing.Size(111, 15);
      this.option_keep_aspect_ratio.TabIndex = 2;
      this.option_keep_aspect_ratio.Text = "Keep Aspect Ratio";
      this.option_keep_aspect_ratio.UseVisualStyleBackColor = true;
      // 
      // resize_method_accurate_rnd
      // 
      this.resize_method_accurate_rnd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.resize_method_accurate_rnd.AutoSize = true;
      this.resize_method_accurate_rnd.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.layoutParameterBindingSource, "SWScaleConfig.AccurateRnd", true));
      this.resize_method_accurate_rnd.Location = new System.Drawing.Point(133, 3);
      this.resize_method_accurate_rnd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.resize_method_accurate_rnd.Name = "resize_method_accurate_rnd";
      this.resize_method_accurate_rnd.Size = new System.Drawing.Size(114, 22);
      this.resize_method_accurate_rnd.TabIndex = 20;
      this.resize_method_accurate_rnd.Text = "Accurate Rounding";
      this.resize_method_accurate_rnd.UseVisualStyleBackColor = true;
      // 
      // resize_method_combo
      // 
      this.resize_method_combo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.resize_method_combo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.layoutParameterBindingSource, "SWScaleConfig.Flags", true));
      this.resize_method_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.resize_method_combo.FormattingEnabled = true;
      this.resize_method_combo.Location = new System.Drawing.Point(2, 3);
      this.resize_method_combo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.resize_method_combo.Name = "resize_method_combo";
      this.resize_method_combo.Size = new System.Drawing.Size(127, 19);
      this.resize_method_combo.TabIndex = 8;
      // 
      // layout_list
      // 
      this.layout_list.DataSource = this.layoutParameterBindingSource;
      this.layout_list.DisplayMember = "WindowText";
      this.layout_list.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layout_list.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      this.layout_list.FormattingEnabled = true;
      this.layout_list.ItemHeight = 16;
      this.layout_list.Location = new System.Drawing.Point(6, 14);
      this.layout_list.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.layout_list.Name = "layout_list";
      this.layout_list.Size = new System.Drawing.Size(183, 403);
      this.layout_list.TabIndex = 0;
      // 
      // kVersion
      // 
      this.kVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.kVersion.AutoSize = true;
      this.kVersion.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.kVersion.ForeColor = System.Drawing.Color.White;
      this.kVersion.Location = new System.Drawing.Point(449, 0);
      this.kVersion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.kVersion.Name = "kVersion";
      this.kVersion.Size = new System.Drawing.Size(64, 35);
      this.kVersion.TabIndex = 2;
      this.kVersion.Text = "Ver.0.1.0  ";
      this.kVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // layout_profile_combo
      // 
      this.layout_profile_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.layout_profile_combo.Enabled = false;
      this.layout_profile_combo.Font = new System.Drawing.Font("MS UI Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      this.layout_profile_combo.FormattingEnabled = true;
      this.layout_profile_combo.Location = new System.Drawing.Point(6, 5);
      this.layout_profile_combo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.layout_profile_combo.Name = "layout_profile_combo";
      this.layout_profile_combo.Size = new System.Drawing.Size(183, 19);
      this.layout_profile_combo.TabIndex = 5;
      this.layout_profile_combo.Visible = false;
      // 
      // layout_bound_table
      // 
      this.layout_bound_table.AutoSize = true;
      this.layout_bound_table.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.layout_bound_table.ColumnCount = 6;
      this.layout_bound_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
      this.layout_bound_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
      this.layout_bound_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
      this.layout_bound_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
      this.layout_bound_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
      this.layout_bound_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
      this.layout_bound_table.Controls.Add(this.layout_bound_relative_left, 1, 1);
      this.layout_bound_table.Controls.Add(this.kLayoutBoundRelativeLeft, 0, 1);
      this.layout_bound_table.Controls.Add(this.kLayoutBoundRelativeRight, 5, 1);
      this.layout_bound_table.Controls.Add(this.kLayoutBoundRelativeBottom, 4, 2);
      this.layout_bound_table.Controls.Add(this.layout_bound_relative_top, 2, 0);
      this.layout_bound_table.Controls.Add(this.layout_bound_relative_right, 3, 1);
      this.layout_bound_table.Controls.Add(this.layout_bound_relative_bottom, 2, 2);
      this.layout_bound_table.Controls.Add(this.kLayoutBoundRelativeTop, 1, 0);
      this.layout_bound_table.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.layout_bound_table.Location = new System.Drawing.Point(6, 313);
      this.layout_bound_table.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.layout_bound_table.Name = "layout_bound_table";
      this.layout_bound_table.RowCount = 3;
      this.layout_bound_table.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.layout_bound_table.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.layout_bound_table.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.layout_bound_table.Size = new System.Drawing.Size(183, 72);
      this.layout_bound_table.TabIndex = 16;
      // 
      // kLayoutButtonTable
      // 
      this.kLayoutButtonTable.ColumnCount = 3;
      this.kLayoutButtonTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.kLayoutButtonTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.kLayoutButtonTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.kLayoutButtonTable.Controls.Add(this.layout_add, 0, 0);
      this.kLayoutButtonTable.Controls.Add(this.layout_remove, 1, 0);
      this.kLayoutButtonTable.Controls.Add(this.layout_layout, 2, 0);
      this.kLayoutButtonTable.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.kLayoutButtonTable.Location = new System.Drawing.Point(6, 385);
      this.kLayoutButtonTable.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.kLayoutButtonTable.Name = "kLayoutButtonTable";
      this.kLayoutButtonTable.RowCount = 1;
      this.kLayoutButtonTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.kLayoutButtonTable.Size = new System.Drawing.Size(183, 32);
      this.kLayoutButtonTable.TabIndex = 15;
      // 
      // kHeaderTable
      // 
      this.kHeaderTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(0)))));
      this.kHeaderTable.ColumnCount = 3;
      this.kHeaderTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.kHeaderTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.kHeaderTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.kHeaderTable.Controls.Add(this.kVersion, 2, 0);
      this.kHeaderTable.Controls.Add(this.kSCFF, 0, 0);
      this.kHeaderTable.Controls.Add(this.kDirectShowFilter, 1, 0);
      this.kHeaderTable.Dock = System.Windows.Forms.DockStyle.Top;
      this.kHeaderTable.Location = new System.Drawing.Point(0, 22);
      this.kHeaderTable.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.kHeaderTable.Name = "kHeaderTable";
      this.kHeaderTable.RowCount = 1;
      this.kHeaderTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.kHeaderTable.Size = new System.Drawing.Size(515, 35);
      this.kHeaderTable.TabIndex = 22;
      // 
      // kResizeMethod
      // 
      this.kResizeMethod.AutoSize = true;
      this.kResizeMethod.Controls.Add(this.kResizeMethodFilter);
      this.kResizeMethod.Controls.Add(this.kResizeMethodTable);
      this.kResizeMethod.Font = new System.Drawing.Font("MS UI Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      this.kResizeMethod.Location = new System.Drawing.Point(5, 411);
      this.kResizeMethod.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.kResizeMethod.Name = "kResizeMethod";
      this.kResizeMethod.Padding = new System.Windows.Forms.Padding(6, 3, 6, 8);
      this.kResizeMethod.Size = new System.Drawing.Size(275, 163);
      this.kResizeMethod.TabIndex = 24;
      this.kResizeMethod.TabStop = false;
      this.kResizeMethod.Text = "Resize Method";
      // 
      // kResizeMethodFilter
      // 
      this.kResizeMethodFilter.AutoSize = true;
      this.kResizeMethodFilter.Controls.Add(this.kResizeMethodFilterTable);
      this.kResizeMethodFilter.Dock = System.Windows.Forms.DockStyle.Top;
      this.kResizeMethodFilter.Font = new System.Drawing.Font("MS UI Gothic", 8F);
      this.kResizeMethodFilter.Location = new System.Drawing.Point(6, 42);
      this.kResizeMethodFilter.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.kResizeMethodFilter.Name = "kResizeMethodFilter";
      this.kResizeMethodFilter.Size = new System.Drawing.Size(263, 110);
      this.kResizeMethodFilter.TabIndex = 30;
      this.kResizeMethodFilter.TabStop = false;
      this.kResizeMethodFilter.Text = "Filter";
      // 
      // kResizeMethodFilterTable
      // 
      this.kResizeMethodFilterTable.AutoScroll = true;
      this.kResizeMethodFilterTable.AutoSize = true;
      this.kResizeMethodFilterTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.kResizeMethodFilterTable.ColumnCount = 4;
      this.kResizeMethodFilterTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.kResizeMethodFilterTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.kResizeMethodFilterTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.kResizeMethodFilterTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.kResizeMethodFilterTable.Controls.Add(this.resize_method_is_filter_enabled, 0, 0);
      this.kResizeMethodFilterTable.Controls.Add(this.kCHShift, 0, 3);
      this.kResizeMethodFilterTable.Controls.Add(this.resize_method_chshift, 1, 3);
      this.kResizeMethodFilterTable.Controls.Add(this.kCVShift, 2, 3);
      this.kResizeMethodFilterTable.Controls.Add(this.resize_method_cvshift, 3, 3);
      this.kResizeMethodFilterTable.Controls.Add(this.kLSharpen, 0, 2);
      this.kResizeMethodFilterTable.Controls.Add(this.resize_method_lsharpen, 1, 2);
      this.kResizeMethodFilterTable.Controls.Add(this.kCSharpen, 2, 2);
      this.kResizeMethodFilterTable.Controls.Add(this.resize_method_csharpen, 3, 2);
      this.kResizeMethodFilterTable.Controls.Add(this.kCGBlur, 2, 1);
      this.kResizeMethodFilterTable.Controls.Add(this.kLGBlur, 0, 1);
      this.kResizeMethodFilterTable.Controls.Add(this.resize_method_lgblur, 1, 1);
      this.kResizeMethodFilterTable.Controls.Add(this.resize_method_cgblur, 3, 1);
      this.kResizeMethodFilterTable.Dock = System.Windows.Forms.DockStyle.Top;
      this.kResizeMethodFilterTable.Location = new System.Drawing.Point(3, 14);
      this.kResizeMethodFilterTable.Name = "kResizeMethodFilterTable";
      this.kResizeMethodFilterTable.RowCount = 4;
      this.kResizeMethodFilterTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.kResizeMethodFilterTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.kResizeMethodFilterTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.kResizeMethodFilterTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.kResizeMethodFilterTable.Size = new System.Drawing.Size(257, 93);
      this.kResizeMethodFilterTable.TabIndex = 25;
      // 
      // resize_method_is_filter_enabled
      // 
      this.resize_method_is_filter_enabled.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.resize_method_is_filter_enabled.AutoSize = true;
      this.resize_method_is_filter_enabled.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.layoutParameterBindingSource, "SWScaleConfig.IsFilterEnabled", true));
      this.resize_method_is_filter_enabled.Location = new System.Drawing.Point(3, 3);
      this.resize_method_is_filter_enabled.Name = "resize_method_is_filter_enabled";
      this.resize_method_is_filter_enabled.Size = new System.Drawing.Size(58, 15);
      this.resize_method_is_filter_enabled.TabIndex = 30;
      this.resize_method_is_filter_enabled.Text = "Enabled";
      this.resize_method_is_filter_enabled.UseVisualStyleBackColor = true;
      this.resize_method_is_filter_enabled.CheckedChanged += new System.EventHandler(this.resize_method_is_filter_enabled_CheckedChanged);
      // 
      // kCHShift
      // 
      this.kCHShift.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.kCHShift.AutoSize = true;
      this.kCHShift.Location = new System.Drawing.Point(17, 69);
      this.kCHShift.Name = "kCHShift";
      this.kCHShift.Size = new System.Drawing.Size(44, 24);
      this.kCHShift.TabIndex = 30;
      this.kCHShift.Text = "C HShift";
      this.kCHShift.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // resize_method_chshift
      // 
      this.resize_method_chshift.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.layoutParameterBindingSource, "SWScaleConfig.ChromaHShift", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.resize_method_chshift.DecimalPlaces = 2;
      this.resize_method_chshift.Enabled = false;
      this.resize_method_chshift.Increment = new decimal(new int[] {
            2,
            0,
            0,
            65536});
      this.resize_method_chshift.Location = new System.Drawing.Point(67, 72);
      this.resize_method_chshift.Maximum = new decimal(new int[] {
            14,
            0,
            0,
            65536});
      this.resize_method_chshift.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            65536});
      this.resize_method_chshift.Name = "resize_method_chshift";
      this.resize_method_chshift.Size = new System.Drawing.Size(58, 18);
      this.resize_method_chshift.TabIndex = 30;
      this.resize_method_chshift.Value = new decimal(new int[] {
            8,
            0,
            0,
            65536});
      // 
      // kCVShift
      // 
      this.kCVShift.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.kCVShift.AutoSize = true;
      this.kCVShift.Location = new System.Drawing.Point(145, 69);
      this.kCVShift.Name = "kCVShift";
      this.kCVShift.Size = new System.Drawing.Size(44, 24);
      this.kCVShift.TabIndex = 31;
      this.kCVShift.Text = "C VShift";
      this.kCVShift.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // resize_method_cvshift
      // 
      this.resize_method_cvshift.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.layoutParameterBindingSource, "SWScaleConfig.ChromaVShift", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.resize_method_cvshift.DecimalPlaces = 2;
      this.resize_method_cvshift.Enabled = false;
      this.resize_method_cvshift.Increment = new decimal(new int[] {
            2,
            0,
            0,
            65536});
      this.resize_method_cvshift.Location = new System.Drawing.Point(195, 72);
      this.resize_method_cvshift.Maximum = new decimal(new int[] {
            14,
            0,
            0,
            65536});
      this.resize_method_cvshift.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            65536});
      this.resize_method_cvshift.Name = "resize_method_cvshift";
      this.resize_method_cvshift.Size = new System.Drawing.Size(59, 18);
      this.resize_method_cvshift.TabIndex = 30;
      this.resize_method_cvshift.Value = new decimal(new int[] {
            8,
            0,
            0,
            65536});
      // 
      // kLSharpen
      // 
      this.kLSharpen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.kLSharpen.AutoSize = true;
      this.kLSharpen.Location = new System.Drawing.Point(8, 45);
      this.kLSharpen.Name = "kLSharpen";
      this.kLSharpen.Size = new System.Drawing.Size(53, 24);
      this.kLSharpen.TabIndex = 28;
      this.kLSharpen.Text = "L Sharpen";
      this.kLSharpen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // resize_method_lsharpen
      // 
      this.resize_method_lsharpen.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.layoutParameterBindingSource, "SWScaleConfig.LumaSharpen", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.resize_method_lsharpen.DecimalPlaces = 2;
      this.resize_method_lsharpen.Enabled = false;
      this.resize_method_lsharpen.Increment = new decimal(new int[] {
            16,
            0,
            0,
            131072});
      this.resize_method_lsharpen.Location = new System.Drawing.Point(67, 48);
      this.resize_method_lsharpen.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            131072});
      this.resize_method_lsharpen.Name = "resize_method_lsharpen";
      this.resize_method_lsharpen.Size = new System.Drawing.Size(58, 18);
      this.resize_method_lsharpen.TabIndex = 30;
      // 
      // kCSharpen
      // 
      this.kCSharpen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.kCSharpen.AutoSize = true;
      this.kCSharpen.Location = new System.Drawing.Point(135, 45);
      this.kCSharpen.Name = "kCSharpen";
      this.kCSharpen.Size = new System.Drawing.Size(54, 24);
      this.kCSharpen.TabIndex = 29;
      this.kCSharpen.Text = "C Sharpen";
      this.kCSharpen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // resize_method_csharpen
      // 
      this.resize_method_csharpen.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.layoutParameterBindingSource, "SWScaleConfig.ChromaSharpen", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.resize_method_csharpen.DecimalPlaces = 2;
      this.resize_method_csharpen.Enabled = false;
      this.resize_method_csharpen.Increment = new decimal(new int[] {
            16,
            0,
            0,
            131072});
      this.resize_method_csharpen.Location = new System.Drawing.Point(195, 48);
      this.resize_method_csharpen.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            131072});
      this.resize_method_csharpen.Name = "resize_method_csharpen";
      this.resize_method_csharpen.Size = new System.Drawing.Size(59, 18);
      this.resize_method_csharpen.TabIndex = 30;
      // 
      // kCGBlur
      // 
      this.kCGBlur.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.kCGBlur.AutoSize = true;
      this.kCGBlur.Location = new System.Drawing.Point(148, 21);
      this.kCGBlur.Name = "kCGBlur";
      this.kCGBlur.Size = new System.Drawing.Size(41, 24);
      this.kCGBlur.TabIndex = 27;
      this.kCGBlur.Text = "C GBlur";
      this.kCGBlur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // kLGBlur
      // 
      this.kLGBlur.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.kLGBlur.AutoSize = true;
      this.kLGBlur.Location = new System.Drawing.Point(21, 21);
      this.kLGBlur.Name = "kLGBlur";
      this.kLGBlur.Size = new System.Drawing.Size(40, 24);
      this.kLGBlur.TabIndex = 26;
      this.kLGBlur.Text = "L GBlur";
      this.kLGBlur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // resize_method_lgblur
      // 
      this.resize_method_lgblur.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.layoutParameterBindingSource, "SWScaleConfig.LumaGBlur", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.resize_method_lgblur.DecimalPlaces = 2;
      this.resize_method_lgblur.Enabled = false;
      this.resize_method_lgblur.Increment = new decimal(new int[] {
            2,
            0,
            0,
            65536});
      this.resize_method_lgblur.Location = new System.Drawing.Point(67, 24);
      this.resize_method_lgblur.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            65536});
      this.resize_method_lgblur.Name = "resize_method_lgblur";
      this.resize_method_lgblur.Size = new System.Drawing.Size(58, 18);
      this.resize_method_lgblur.TabIndex = 30;
      // 
      // resize_method_cgblur
      // 
      this.resize_method_cgblur.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.layoutParameterBindingSource, "SWScaleConfig.ChromaGBlur", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.resize_method_cgblur.DecimalPlaces = 2;
      this.resize_method_cgblur.Enabled = false;
      this.resize_method_cgblur.Increment = new decimal(new int[] {
            2,
            0,
            0,
            65536});
      this.resize_method_cgblur.Location = new System.Drawing.Point(195, 24);
      this.resize_method_cgblur.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            65536});
      this.resize_method_cgblur.Name = "resize_method_cgblur";
      this.resize_method_cgblur.Size = new System.Drawing.Size(59, 18);
      this.resize_method_cgblur.TabIndex = 30;
      // 
      // kResizeMethodTable
      // 
      this.kResizeMethodTable.ColumnCount = 2;
      this.kResizeMethodTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.kResizeMethodTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.kResizeMethodTable.Controls.Add(this.resize_method_accurate_rnd, 1, 0);
      this.kResizeMethodTable.Controls.Add(this.resize_method_combo, 0, 0);
      this.kResizeMethodTable.Dock = System.Windows.Forms.DockStyle.Top;
      this.kResizeMethodTable.Location = new System.Drawing.Point(6, 14);
      this.kResizeMethodTable.Name = "kResizeMethodTable";
      this.kResizeMethodTable.RowCount = 1;
      this.kResizeMethodTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.kResizeMethodTable.Size = new System.Drawing.Size(263, 28);
      this.kResizeMethodTable.TabIndex = 31;
      // 
      // kMainButtonPanel
      // 
      this.kMainButtonPanel.AutoSize = true;
      this.kMainButtonPanel.Controls.Add(this.apply);
      this.kMainButtonPanel.Controls.Add(this.auto_apply);
      this.kMainButtonPanel.Controls.Add(this.splash);
      this.kMainButtonPanel.Font = new System.Drawing.Font("MS UI Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      this.kMainButtonPanel.Location = new System.Drawing.Point(5, 576);
      this.kMainButtonPanel.Name = "kMainButtonPanel";
      this.kMainButtonPanel.Size = new System.Drawing.Size(275, 28);
      this.kMainButtonPanel.TabIndex = 26;
      // 
      // kLayout
      // 
      this.kLayout.Controls.Add(this.layout_bound_table);
      this.kLayout.Controls.Add(this.kLayoutButtonTable);
      this.kLayout.Controls.Add(this.layout_list);
      this.kLayout.Font = new System.Drawing.Font("MS UI Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      this.kLayout.Location = new System.Drawing.Point(284, 99);
      this.kLayout.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.kLayout.Name = "kLayout";
      this.kLayout.Padding = new System.Windows.Forms.Padding(6, 3, 6, 8);
      this.kLayout.Size = new System.Drawing.Size(195, 425);
      this.kLayout.TabIndex = 27;
      this.kLayout.TabStop = false;
      this.kLayout.Text = "Layout";
      // 
      // kProcessPanel
      // 
      this.kProcessPanel.AutoSize = true;
      this.kProcessPanel.Controls.Add(this.process_combo);
      this.kProcessPanel.Controls.Add(this.process_refresh);
      this.kProcessPanel.Location = new System.Drawing.Point(5, 66);
      this.kProcessPanel.Name = "kProcessPanel";
      this.kProcessPanel.Size = new System.Drawing.Size(275, 31);
      this.kProcessPanel.TabIndex = 28;
      // 
      // kProfilePanel
      // 
      this.kProfilePanel.Controls.Add(this.layout_profile_combo);
      this.kProfilePanel.Location = new System.Drawing.Point(284, 66);
      this.kProfilePanel.Name = "kProfilePanel";
      this.kProfilePanel.Size = new System.Drawing.Size(195, 31);
      this.kProfilePanel.TabIndex = 29;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.ClientSize = new System.Drawing.Size(515, 635);
      this.Controls.Add(this.kProcessPanel);
      this.Controls.Add(this.kHeaderTable);
      this.Controls.Add(this.kProfilePanel);
      this.Controls.Add(this.main_menu);
      this.Controls.Add(this.kTarget);
      this.Controls.Add(this.kResizeMethod);
      this.Controls.Add(this.kLayout);
      this.Controls.Add(this.kMainButtonPanel);
      this.Controls.Add(this.kOption);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.MaximizeBox = false;
      this.Name = "Form1";
      this.Text = "SCFF DirectShow Filter Ver.0.1.0";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
      this.Shown += new System.EventHandler(this.Form1_Shown);
      this.main_menu.ResumeLayout(false);
      this.main_menu.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.layout_bound_relative_bottom)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutParameterBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layout_bound_relative_right)).EndInit();
      this.kWindow.ResumeLayout(false);
      this.kWindow.PerformLayout();
      this.kWindowTable.ResumeLayout(false);
      this.kWindowTable.PerformLayout();
      this.kArea.ResumeLayout(false);
      this.kArea.PerformLayout();
      this.kAreaTable.ResumeLayout(false);
      this.kAreaTable.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.area_clipping_height)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.area_clipping_width)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.area_clipping_y)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.area_clipping_x)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layout_bound_relative_top)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layout_bound_relative_left)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.entryBindingSource)).EndInit();
      this.kTarget.ResumeLayout(false);
      this.kTarget.PerformLayout();
      this.kOption.ResumeLayout(false);
      this.kOption.PerformLayout();
      this.kOptionTable.ResumeLayout(false);
      this.kOptionTable.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.option_thread_num)).EndInit();
      this.layout_bound_table.ResumeLayout(false);
      this.layout_bound_table.PerformLayout();
      this.kLayoutButtonTable.ResumeLayout(false);
      this.kHeaderTable.ResumeLayout(false);
      this.kHeaderTable.PerformLayout();
      this.kResizeMethod.ResumeLayout(false);
      this.kResizeMethod.PerformLayout();
      this.kResizeMethodFilter.ResumeLayout(false);
      this.kResizeMethodFilter.PerformLayout();
      this.kResizeMethodFilterTable.ResumeLayout(false);
      this.kResizeMethodFilterTable.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.resize_method_chshift)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.resize_method_cvshift)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.resize_method_lsharpen)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.resize_method_csharpen)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.resize_method_lgblur)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.resize_method_cgblur)).EndInit();
      this.kResizeMethodTable.ResumeLayout(false);
      this.kResizeMethodTable.PerformLayout();
      this.kMainButtonPanel.ResumeLayout(false);
      this.kLayout.ResumeLayout(false);
      this.kLayout.PerformLayout();
      this.kProcessPanel.ResumeLayout(false);
      this.kProfilePanel.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button layout_layout;
    private System.Windows.Forms.MenuStrip main_menu;
    private System.Windows.Forms.ToolStripMenuItem tools_menu;
    private System.Windows.Forms.ToolStripMenuItem cts_item;
    private System.Windows.Forms.ToolStripMenuItem ctc_item;
    private System.Windows.Forms.ToolStripSeparator kToolsSeparator;
    private System.Windows.Forms.ToolStripMenuItem aero_on_item;
    private System.Windows.Forms.ToolStripMenuItem language_menu;
    private System.Windows.Forms.ToolStripMenuItem english_item;
    private System.Windows.Forms.ToolStripMenuItem external_item;
    private System.Windows.Forms.NumericUpDown layout_bound_relative_bottom;
    private System.Windows.Forms.Button window_desktop;
    private System.Windows.Forms.NumericUpDown layout_bound_relative_right;
    private System.Windows.Forms.GroupBox kWindow;
    private System.Windows.Forms.Button window_draghere;
    private System.Windows.Forms.TextBox window_handle;
    private System.Windows.Forms.Label kCaption;
    private System.Windows.Forms.CheckBox area_fit;
    private System.Windows.Forms.Button target_area_select;
    private System.Windows.Forms.GroupBox kArea;
    private System.Windows.Forms.NumericUpDown area_clipping_height;
    private System.Windows.Forms.NumericUpDown area_clipping_width;
    private System.Windows.Forms.NumericUpDown area_clipping_y;
    private System.Windows.Forms.NumericUpDown area_clipping_x;
    private System.Windows.Forms.Label kCross;
    private System.Windows.Forms.Label kSize;
    private System.Windows.Forms.Label kY;
    private System.Windows.Forms.Label kX;
    private System.Windows.Forms.NumericUpDown layout_bound_relative_top;
    private System.Windows.Forms.NumericUpDown layout_bound_relative_left;
    private System.Windows.Forms.Button process_refresh;
    private System.Windows.Forms.Label kLayoutBoundRelativeBottom;
    private System.Windows.Forms.ComboBox process_combo;
    private System.Windows.Forms.Label kLayoutBoundRelativeRight;
    private System.Windows.Forms.Label kLayoutBoundRelativeTop;
    private System.Windows.Forms.GroupBox kTarget;
    private System.Windows.Forms.Label kLayoutBoundRelativeLeft;
    private System.Windows.Forms.Button layout_remove;
    private System.Windows.Forms.Button layout_add;
    private System.Windows.Forms.CheckBox option_show_mouse_cursor;
    private System.Windows.Forms.CheckBox option_show_layered_window;
    private System.Windows.Forms.Label kDirectShowFilter;
    private System.Windows.Forms.Label kSCFF;
    private System.Windows.Forms.Button apply;
    private System.Windows.Forms.Button splash;
    private System.Windows.Forms.GroupBox kOption;
    private System.Windows.Forms.ComboBox resize_method_combo;
    private System.Windows.Forms.Label kThreadNum;
    private System.Windows.Forms.CheckBox option_over_sampling;
    private System.Windows.Forms.CheckBox option_enable_enlargement;
    private System.Windows.Forms.CheckBox option_keep_aspect_ratio;
    private System.Windows.Forms.Label kVersion;
    private System.Windows.Forms.ComboBox layout_profile_combo;
    private System.Windows.Forms.CheckBox auto_apply;
    private System.Windows.Forms.ListBox layout_list;
    private System.Windows.Forms.TableLayoutPanel kAreaTable;
    private System.Windows.Forms.TableLayoutPanel kWindowTable;
    private System.Windows.Forms.TableLayoutPanel kOptionTable;
    private System.Windows.Forms.TableLayoutPanel layout_bound_table;
    private System.Windows.Forms.TableLayoutPanel kLayoutButtonTable;
    private System.Windows.Forms.BindingSource layoutParameterBindingSource;
    private System.Windows.Forms.BindingSource entryBindingSource;
    private System.Windows.Forms.CheckBox resize_method_accurate_rnd;
    private System.Windows.Forms.TableLayoutPanel kHeaderTable;
    private System.Windows.Forms.GroupBox kResizeMethod;
    private System.Windows.Forms.TableLayoutPanel kResizeMethodFilterTable;
    private System.Windows.Forms.Label kCVShift;
    private System.Windows.Forms.Label kCHShift;
    private System.Windows.Forms.Label kCSharpen;
    private System.Windows.Forms.Label kLSharpen;
    private System.Windows.Forms.Label kLGBlur;
    private System.Windows.Forms.NumericUpDown option_thread_num;
    private System.Windows.Forms.Label kCGBlur;
    private System.Windows.Forms.Panel kMainButtonPanel;
    private System.Windows.Forms.GroupBox kLayout;
    private System.Windows.Forms.Panel kProcessPanel;
    private System.Windows.Forms.Panel kProfilePanel;
    private System.Windows.Forms.NumericUpDown resize_method_cvshift;
    private System.Windows.Forms.NumericUpDown resize_method_chshift;
    private System.Windows.Forms.NumericUpDown resize_method_lsharpen;
    private System.Windows.Forms.NumericUpDown resize_method_csharpen;
    private System.Windows.Forms.NumericUpDown resize_method_cgblur;
    private System.Windows.Forms.NumericUpDown resize_method_lgblur;
    private System.Windows.Forms.CheckBox resize_method_is_filter_enabled;
    private System.Windows.Forms.GroupBox kResizeMethodFilter;
    private System.Windows.Forms.TableLayoutPanel kResizeMethodTable;



  }
}

