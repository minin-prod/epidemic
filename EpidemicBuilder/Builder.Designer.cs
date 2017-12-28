namespace Epidemic.Builder
{
    partial class Builder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Builder));
            this.toolStrip = new System.Windows.Forms.MenuStrip();
            this.toolStrip_fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_open = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_save = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_saveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_editMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_projectMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.hierarchy = new System.Windows.Forms.Panel();
            this.hierarchyContent = new System.Windows.Forms.TreeView();
            this.hierarchyLabelBox = new System.Windows.Forms.Panel();
            this.hierarchyManageButton = new System.Windows.Forms.Button();
            this.hierarchyLabel = new System.Windows.Forms.Label();
            this.editor = new System.Windows.Forms.Panel();
            this.editorTabs = new System.Windows.Forms.TabControl();
            this.editorTabs_editor = new System.Windows.Forms.TabPage();
            this.editorEngine = new Epidemic.Runtime.EngineWindow();
            this.editorTabs_preview = new System.Windows.Forms.TabPage();
            this.previewEngine = new Epidemic.Runtime.EngineWindow();
            this.properties = new System.Windows.Forms.Panel();
            this.propertiesContent = new System.Windows.Forms.PropertyGrid();
            this.propertiesLabelBox = new System.Windows.Forms.Panel();
            this.propertiesLabel = new System.Windows.Forms.Label();
            this.toolbox = new System.Windows.Forms.Panel();
            this.toolboxContents = new System.Windows.Forms.ListBox();
            this.toolboxLabelBox = new System.Windows.Forms.Panel();
            this.toolboxLabel = new System.Windows.Forms.Label();
            this.console = new System.Windows.Forms.Panel();
            this.consoleLabelBox = new System.Windows.Forms.Panel();
            this.consoleLabel = new System.Windows.Forms.Label();
            this.layoutTop = new System.Windows.Forms.TableLayoutPanel();
            this.layoutBottom = new System.Windows.Forms.TableLayoutPanel();
            this.editorReloadButton = new System.Windows.Forms.Button();
            this.toolStrip.SuspendLayout();
            this.hierarchy.SuspendLayout();
            this.hierarchyLabelBox.SuspendLayout();
            this.editor.SuspendLayout();
            this.editorTabs.SuspendLayout();
            this.editorTabs_editor.SuspendLayout();
            this.editorTabs_preview.SuspendLayout();
            this.properties.SuspendLayout();
            this.propertiesLabelBox.SuspendLayout();
            this.toolbox.SuspendLayout();
            this.toolboxLabelBox.SuspendLayout();
            this.console.SuspendLayout();
            this.consoleLabelBox.SuspendLayout();
            this.layoutTop.SuspendLayout();
            this.layoutBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrip_fileMenu,
            this.toolStrip_editMenu,
            this.toolStrip_projectMenu,
            this.toolStrip_helpMenu});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(844, 28);
            this.toolStrip.TabIndex = 0;
            // 
            // toolStrip_fileMenu
            // 
            this.toolStrip_fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrip_open,
            this.toolStrip_save,
            this.toolStrip_saveAs,
            this.toolStripSeparator1,
            this.toolStrip_exit});
            this.toolStrip_fileMenu.ForeColor = System.Drawing.Color.LightGray;
            this.toolStrip_fileMenu.Name = "toolStrip_fileMenu";
            this.toolStrip_fileMenu.Size = new System.Drawing.Size(44, 24);
            this.toolStrip_fileMenu.Text = "File";
            // 
            // toolStrip_open
            // 
            this.toolStrip_open.Name = "toolStrip_open";
            this.toolStrip_open.Size = new System.Drawing.Size(135, 26);
            this.toolStrip_open.Text = "Open";
            // 
            // toolStrip_save
            // 
            this.toolStrip_save.Name = "toolStrip_save";
            this.toolStrip_save.Size = new System.Drawing.Size(135, 26);
            this.toolStrip_save.Text = "Save";
            // 
            // toolStrip_saveAs
            // 
            this.toolStrip_saveAs.Name = "toolStrip_saveAs";
            this.toolStrip_saveAs.Size = new System.Drawing.Size(135, 26);
            this.toolStrip_saveAs.Text = "Save As";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripSeparator1.Size = new System.Drawing.Size(132, 6);
            // 
            // toolStrip_exit
            // 
            this.toolStrip_exit.Name = "toolStrip_exit";
            this.toolStrip_exit.Size = new System.Drawing.Size(135, 26);
            this.toolStrip_exit.Text = "Exit";
            // 
            // toolStrip_editMenu
            // 
            this.toolStrip_editMenu.ForeColor = System.Drawing.Color.LightGray;
            this.toolStrip_editMenu.Name = "toolStrip_editMenu";
            this.toolStrip_editMenu.Size = new System.Drawing.Size(47, 24);
            this.toolStrip_editMenu.Text = "Edit";
            // 
            // toolStrip_projectMenu
            // 
            this.toolStrip_projectMenu.ForeColor = System.Drawing.Color.LightGray;
            this.toolStrip_projectMenu.Name = "toolStrip_projectMenu";
            this.toolStrip_projectMenu.Size = new System.Drawing.Size(67, 24);
            this.toolStrip_projectMenu.Text = "Project";
            // 
            // toolStrip_helpMenu
            // 
            this.toolStrip_helpMenu.ForeColor = System.Drawing.Color.LightGray;
            this.toolStrip_helpMenu.Name = "toolStrip_helpMenu";
            this.toolStrip_helpMenu.Size = new System.Drawing.Size(53, 24);
            this.toolStrip_helpMenu.Text = "Help";
            // 
            // hierarchy
            // 
            this.hierarchy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hierarchy.Controls.Add(this.hierarchyContent);
            this.hierarchy.Controls.Add(this.hierarchyLabelBox);
            this.hierarchy.Location = new System.Drawing.Point(3, 3);
            this.hierarchy.Name = "hierarchy";
            this.hierarchy.Size = new System.Drawing.Size(204, 341);
            this.hierarchy.TabIndex = 0;
            // 
            // hierarchyContent
            // 
            this.hierarchyContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.hierarchyContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hierarchyContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hierarchyContent.ForeColor = System.Drawing.Color.White;
            this.hierarchyContent.Location = new System.Drawing.Point(0, 24);
            this.hierarchyContent.Name = "hierarchyContent";
            this.hierarchyContent.Size = new System.Drawing.Size(204, 317);
            this.hierarchyContent.TabIndex = 2;
            this.hierarchyContent.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.hierarchyContent_NodeMouseDoubleClick);
            // 
            // hierarchyLabelBox
            // 
            this.hierarchyLabelBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.hierarchyLabelBox.Controls.Add(this.hierarchyManageButton);
            this.hierarchyLabelBox.Controls.Add(this.hierarchyLabel);
            this.hierarchyLabelBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.hierarchyLabelBox.Location = new System.Drawing.Point(0, 0);
            this.hierarchyLabelBox.Name = "hierarchyLabelBox";
            this.hierarchyLabelBox.Size = new System.Drawing.Size(204, 24);
            this.hierarchyLabelBox.TabIndex = 1;
            // 
            // hierarchyManageButton
            // 
            this.hierarchyManageButton.BackColor = System.Drawing.Color.Maroon;
            this.hierarchyManageButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.hierarchyManageButton.FlatAppearance.BorderSize = 0;
            this.hierarchyManageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hierarchyManageButton.ForeColor = System.Drawing.Color.White;
            this.hierarchyManageButton.Location = new System.Drawing.Point(129, 0);
            this.hierarchyManageButton.Name = "hierarchyManageButton";
            this.hierarchyManageButton.Size = new System.Drawing.Size(75, 24);
            this.hierarchyManageButton.TabIndex = 1;
            this.hierarchyManageButton.Text = "Manage";
            this.hierarchyManageButton.UseVisualStyleBackColor = false;
            this.hierarchyManageButton.Click += new System.EventHandler(this.hierarchyManageButton_Click);
            // 
            // hierarchyLabel
            // 
            this.hierarchyLabel.AutoSize = true;
            this.hierarchyLabel.BackColor = System.Drawing.Color.Transparent;
            this.hierarchyLabel.ForeColor = System.Drawing.Color.White;
            this.hierarchyLabel.Location = new System.Drawing.Point(3, 3);
            this.hierarchyLabel.Name = "hierarchyLabel";
            this.hierarchyLabel.Size = new System.Drawing.Size(69, 17);
            this.hierarchyLabel.TabIndex = 0;
            this.hierarchyLabel.Text = "Hierarchy";
            // 
            // editor
            // 
            this.editor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.editor.Controls.Add(this.editorReloadButton);
            this.editor.Controls.Add(this.editorTabs);
            this.editor.Location = new System.Drawing.Point(213, 3);
            this.editor.Name = "editor";
            this.editor.Size = new System.Drawing.Size(416, 341);
            this.editor.TabIndex = 2;
            // 
            // editorTabs
            // 
            this.editorTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editorTabs.Controls.Add(this.editorTabs_editor);
            this.editorTabs.Controls.Add(this.editorTabs_preview);
            this.editorTabs.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.editorTabs.ItemSize = new System.Drawing.Size(36, 21);
            this.editorTabs.Location = new System.Drawing.Point(0, 3);
            this.editorTabs.Name = "editorTabs";
            this.editorTabs.Padding = new System.Drawing.Point(0, 0);
            this.editorTabs.SelectedIndex = 0;
            this.editorTabs.Size = new System.Drawing.Size(416, 338);
            this.editorTabs.TabIndex = 0;
            this.editorTabs.SelectedIndexChanged += new System.EventHandler(this.editorTabs_SelectedIndexChanged);
            // 
            // editorTabs_editor
            // 
            this.editorTabs_editor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.editorTabs_editor.Controls.Add(this.editorEngine);
            this.editorTabs_editor.Location = new System.Drawing.Point(4, 25);
            this.editorTabs_editor.Margin = new System.Windows.Forms.Padding(0);
            this.editorTabs_editor.Name = "editorTabs_editor";
            this.editorTabs_editor.Size = new System.Drawing.Size(408, 309);
            this.editorTabs_editor.TabIndex = 0;
            this.editorTabs_editor.Text = "Editor";
            // 
            // editorEngine
            // 
            this.editorEngine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editorEngine.IsEditor = true;
            this.editorEngine.Location = new System.Drawing.Point(0, 0);
            this.editorEngine.Name = "editorEngine";
            this.editorEngine.PostProcessing = false;
            this.editorEngine.Size = new System.Drawing.Size(408, 309);
            this.editorEngine.TabIndex = 0;
            // 
            // editorTabs_preview
            // 
            this.editorTabs_preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.editorTabs_preview.Controls.Add(this.previewEngine);
            this.editorTabs_preview.Location = new System.Drawing.Point(4, 25);
            this.editorTabs_preview.Margin = new System.Windows.Forms.Padding(0);
            this.editorTabs_preview.Name = "editorTabs_preview";
            this.editorTabs_preview.Size = new System.Drawing.Size(408, 308);
            this.editorTabs_preview.TabIndex = 1;
            this.editorTabs_preview.Text = "Preview";
            // 
            // previewEngine
            // 
            this.previewEngine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previewEngine.IsEditor = false;
            this.previewEngine.Location = new System.Drawing.Point(0, 0);
            this.previewEngine.Name = "previewEngine";
            this.previewEngine.PostProcessing = true;
            this.previewEngine.Size = new System.Drawing.Size(408, 308);
            this.previewEngine.TabIndex = 0;
            // 
            // properties
            // 
            this.properties.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.properties.Controls.Add(this.propertiesContent);
            this.properties.Controls.Add(this.propertiesLabelBox);
            this.properties.Location = new System.Drawing.Point(635, 3);
            this.properties.Name = "properties";
            this.properties.Size = new System.Drawing.Size(206, 341);
            this.properties.TabIndex = 1;
            // 
            // propertiesContent
            // 
            this.propertiesContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.propertiesContent.CanShowVisualStyleGlyphs = false;
            this.propertiesContent.CategoryForeColor = System.Drawing.Color.LightGray;
            this.propertiesContent.CategorySplitterColor = System.Drawing.SystemColors.ControlDarkDark;
            this.propertiesContent.CommandsBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.propertiesContent.CommandsBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.propertiesContent.CommandsForeColor = System.Drawing.Color.LightGray;
            this.propertiesContent.DisabledItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.propertiesContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertiesContent.HelpBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.propertiesContent.HelpBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.propertiesContent.HelpForeColor = System.Drawing.Color.LightGray;
            this.propertiesContent.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.propertiesContent.Location = new System.Drawing.Point(0, 24);
            this.propertiesContent.Name = "propertiesContent";
            this.propertiesContent.SelectedItemWithFocusForeColor = System.Drawing.SystemColors.Control;
            this.propertiesContent.Size = new System.Drawing.Size(206, 317);
            this.propertiesContent.TabIndex = 2;
            this.propertiesContent.ViewBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.propertiesContent.ViewBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.propertiesContent.ViewForeColor = System.Drawing.Color.LightGray;
            this.propertiesContent.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.propertiesContent_PropertyValueChanged);
            // 
            // propertiesLabelBox
            // 
            this.propertiesLabelBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.propertiesLabelBox.Controls.Add(this.propertiesLabel);
            this.propertiesLabelBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.propertiesLabelBox.Location = new System.Drawing.Point(0, 0);
            this.propertiesLabelBox.Name = "propertiesLabelBox";
            this.propertiesLabelBox.Size = new System.Drawing.Size(206, 24);
            this.propertiesLabelBox.TabIndex = 2;
            // 
            // propertiesLabel
            // 
            this.propertiesLabel.AutoSize = true;
            this.propertiesLabel.BackColor = System.Drawing.Color.Transparent;
            this.propertiesLabel.ForeColor = System.Drawing.Color.White;
            this.propertiesLabel.Location = new System.Drawing.Point(3, 3);
            this.propertiesLabel.Name = "propertiesLabel";
            this.propertiesLabel.Size = new System.Drawing.Size(73, 17);
            this.propertiesLabel.TabIndex = 1;
            this.propertiesLabel.Text = "Properties";
            // 
            // toolbox
            // 
            this.toolbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolbox.Controls.Add(this.toolboxContents);
            this.toolbox.Controls.Add(this.toolboxLabelBox);
            this.toolbox.Location = new System.Drawing.Point(3, 3);
            this.toolbox.Name = "toolbox";
            this.toolbox.Size = new System.Drawing.Size(318, 160);
            this.toolbox.TabIndex = 3;
            // 
            // toolboxContents
            // 
            this.toolboxContents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolboxContents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.toolboxContents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolboxContents.ForeColor = System.Drawing.Color.White;
            this.toolboxContents.FormattingEnabled = true;
            this.toolboxContents.ItemHeight = 16;
            this.toolboxContents.Items.AddRange(new object[] {
            "Loading..."});
            this.toolboxContents.Location = new System.Drawing.Point(0, 24);
            this.toolboxContents.Name = "toolboxContents";
            this.toolboxContents.Size = new System.Drawing.Size(318, 136);
            this.toolboxContents.TabIndex = 4;
            this.toolboxContents.SelectedIndexChanged += new System.EventHandler(this.toolboxContents_SelectedIndexChanged);
            // 
            // toolboxLabelBox
            // 
            this.toolboxLabelBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.toolboxLabelBox.Controls.Add(this.toolboxLabel);
            this.toolboxLabelBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolboxLabelBox.Location = new System.Drawing.Point(0, 0);
            this.toolboxLabelBox.Name = "toolboxLabelBox";
            this.toolboxLabelBox.Size = new System.Drawing.Size(318, 24);
            this.toolboxLabelBox.TabIndex = 2;
            // 
            // toolboxLabel
            // 
            this.toolboxLabel.AutoSize = true;
            this.toolboxLabel.BackColor = System.Drawing.Color.Transparent;
            this.toolboxLabel.ForeColor = System.Drawing.Color.White;
            this.toolboxLabel.Location = new System.Drawing.Point(3, 3);
            this.toolboxLabel.Name = "toolboxLabel";
            this.toolboxLabel.Size = new System.Drawing.Size(58, 17);
            this.toolboxLabel.TabIndex = 0;
            this.toolboxLabel.Text = "Toolbox";
            // 
            // console
            // 
            this.console.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.console.Controls.Add(this.consoleLabelBox);
            this.console.Location = new System.Drawing.Point(327, 3);
            this.console.Name = "console";
            this.console.Size = new System.Drawing.Size(514, 160);
            this.console.TabIndex = 4;
            // 
            // consoleLabelBox
            // 
            this.consoleLabelBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.consoleLabelBox.Controls.Add(this.consoleLabel);
            this.consoleLabelBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.consoleLabelBox.Location = new System.Drawing.Point(0, 0);
            this.consoleLabelBox.Name = "consoleLabelBox";
            this.consoleLabelBox.Size = new System.Drawing.Size(514, 24);
            this.consoleLabelBox.TabIndex = 3;
            // 
            // consoleLabel
            // 
            this.consoleLabel.AutoSize = true;
            this.consoleLabel.BackColor = System.Drawing.Color.Transparent;
            this.consoleLabel.ForeColor = System.Drawing.Color.White;
            this.consoleLabel.Location = new System.Drawing.Point(3, 3);
            this.consoleLabel.Name = "consoleLabel";
            this.consoleLabel.Size = new System.Drawing.Size(59, 17);
            this.consoleLabel.TabIndex = 1;
            this.consoleLabel.Text = "Console";
            // 
            // layoutTop
            // 
            this.layoutTop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.layoutTop.ColumnCount = 3;
            this.layoutTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.88152F));
            this.layoutTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layoutTop.Controls.Add(this.properties, 2, 0);
            this.layoutTop.Controls.Add(this.editor, 1, 0);
            this.layoutTop.Controls.Add(this.hierarchy, 0, 0);
            this.layoutTop.Location = new System.Drawing.Point(0, 31);
            this.layoutTop.Name = "layoutTop";
            this.layoutTop.RowCount = 1;
            this.layoutTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.layoutTop.Size = new System.Drawing.Size(844, 347);
            this.layoutTop.TabIndex = 2;
            // 
            // layoutBottom
            // 
            this.layoutBottom.ColumnCount = 2;
            this.layoutBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.38863F));
            this.layoutBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.61137F));
            this.layoutBottom.Controls.Add(this.console, 1, 0);
            this.layoutBottom.Controls.Add(this.toolbox, 0, 0);
            this.layoutBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.layoutBottom.Location = new System.Drawing.Point(0, 380);
            this.layoutBottom.Name = "layoutBottom";
            this.layoutBottom.RowCount = 1;
            this.layoutBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutBottom.Size = new System.Drawing.Size(844, 166);
            this.layoutBottom.TabIndex = 5;
            // 
            // editorReloadButton
            // 
            this.editorReloadButton.BackColor = System.Drawing.Color.Maroon;
            this.editorReloadButton.FlatAppearance.BorderSize = 0;
            this.editorReloadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editorReloadButton.ForeColor = System.Drawing.Color.White;
            this.editorReloadButton.Location = new System.Drawing.Point(341, 0);
            this.editorReloadButton.Name = "editorReloadButton";
            this.editorReloadButton.Size = new System.Drawing.Size(75, 24);
            this.editorReloadButton.TabIndex = 2;
            this.editorReloadButton.Text = "Reload";
            this.editorReloadButton.UseVisualStyleBackColor = false;
            this.editorReloadButton.Click += new System.EventHandler(this.editorReloadButton_Click);
            // 
            // Builder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(844, 546);
            this.Controls.Add(this.layoutBottom);
            this.Controls.Add(this.layoutTop);
            this.Controls.Add(this.toolStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.toolStrip;
            this.MinimumSize = new System.Drawing.Size(500, 350);
            this.Name = "Builder";
            this.Text = "Epidemic Builder";
            this.Load += new System.EventHandler(this.Builder_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.hierarchy.ResumeLayout(false);
            this.hierarchyLabelBox.ResumeLayout(false);
            this.hierarchyLabelBox.PerformLayout();
            this.editor.ResumeLayout(false);
            this.editorTabs.ResumeLayout(false);
            this.editorTabs_editor.ResumeLayout(false);
            this.editorTabs_preview.ResumeLayout(false);
            this.properties.ResumeLayout(false);
            this.propertiesLabelBox.ResumeLayout(false);
            this.propertiesLabelBox.PerformLayout();
            this.toolbox.ResumeLayout(false);
            this.toolboxLabelBox.ResumeLayout(false);
            this.toolboxLabelBox.PerformLayout();
            this.console.ResumeLayout(false);
            this.consoleLabelBox.ResumeLayout(false);
            this.consoleLabelBox.PerformLayout();
            this.layoutTop.ResumeLayout(false);
            this.layoutBottom.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip toolStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStrip_fileMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStrip_open;
        private System.Windows.Forms.ToolStripMenuItem toolStrip_save;
        private System.Windows.Forms.ToolStripMenuItem toolStrip_saveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStrip_exit;
        private System.Windows.Forms.ToolStripMenuItem toolStrip_editMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStrip_projectMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStrip_helpMenu;
        private System.Windows.Forms.Panel hierarchy;
        private System.Windows.Forms.Panel editor;
        private System.Windows.Forms.Panel properties;
        private System.Windows.Forms.Panel toolbox;
        private System.Windows.Forms.Panel console;
        private System.Windows.Forms.TabControl editorTabs;
        private System.Windows.Forms.TabPage editorTabs_editor;
        private System.Windows.Forms.TabPage editorTabs_preview;
        private System.Windows.Forms.Label toolboxLabel;
        private System.Windows.Forms.Label consoleLabel;
        private System.Windows.Forms.Panel hierarchyLabelBox;
        private System.Windows.Forms.Label hierarchyLabel;
        private System.Windows.Forms.Panel propertiesLabelBox;
        private System.Windows.Forms.Label propertiesLabel;
        private System.Windows.Forms.Panel toolboxLabelBox;
        private System.Windows.Forms.Panel consoleLabelBox;
        private System.Windows.Forms.PropertyGrid propertiesContent;
        private System.Windows.Forms.TableLayoutPanel layoutTop;
        private System.Windows.Forms.TableLayoutPanel layoutBottom;
        private System.Windows.Forms.TreeView hierarchyContent;
        private System.Windows.Forms.ListBox toolboxContents;
        private Runtime.EngineWindow previewEngine;
        private Runtime.EngineWindow editorEngine;
        private System.Windows.Forms.Button hierarchyManageButton;
        private System.Windows.Forms.Button editorReloadButton;
    }
}

