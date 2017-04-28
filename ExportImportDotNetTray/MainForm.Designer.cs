namespace ExportImportDotNetTray
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.cms_MainMenuTray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showHideNotificationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tc_Main = new System.Windows.Forms.TabControl();
            this.tp_XML = new System.Windows.Forms.TabPage();
            this.chB_XMLDisable = new System.Windows.Forms.CheckBox();
            this.gb_XML = new System.Windows.Forms.GroupBox();
            this.chb_XML_IncSub = new System.Windows.Forms.CheckBox();
            this.nud_XML = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.btn_XmlSourcePathSelectDir = new System.Windows.Forms.Button();
            this.tb_XmlSourcePath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_XmlDestinationPathSelectDir = new System.Windows.Forms.Button();
            this.tb_XmlDestinationPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tp_HTML = new System.Windows.Forms.TabPage();
            this.chB_HTMLDisable = new System.Windows.Forms.CheckBox();
            this.gb_HTML = new System.Windows.Forms.GroupBox();
            this.chb_HTML_IncSub = new System.Windows.Forms.CheckBox();
            this.nud_HTML = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.btn_HtmlSourcePathSelectDir = new System.Windows.Forms.Button();
            this.tb_HtmlSourcePath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_HtmlDestinationPathSelectDir = new System.Windows.Forms.Button();
            this.tb_HtmlDestinationPath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tp_Types = new System.Windows.Forms.TabPage();
            this.chB_TypesDisable = new System.Windows.Forms.CheckBox();
            this.gb_Types = new System.Windows.Forms.GroupBox();
            this.chb_TYPES_IncSub = new System.Windows.Forms.CheckBox();
            this.btn_TypesSourcePathSelectDir = new System.Windows.Forms.Button();
            this.tb_TypesSourcePath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_TypesDestinationPathSelectDir = new System.Windows.Forms.Button();
            this.tb_TypesDestinationPath = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tp_Testmodules = new System.Windows.Forms.TabPage();
            this.chB_TestmodulesDisable = new System.Windows.Forms.CheckBox();
            this.gb_Testmodules = new System.Windows.Forms.GroupBox();
            this.chb_TESTMODULES_IncSub = new System.Windows.Forms.CheckBox();
            this.btn_TestmodulesDestinationPathSelectDir = new System.Windows.Forms.Button();
            this.tb_TestmodulesDestinationPath = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_TestmodulesSourcePathSelectDir = new System.Windows.Forms.Button();
            this.tb_TestmodulesSourcePath = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tp_Users = new System.Windows.Forms.TabPage();
            this.chB_UsersDisable = new System.Windows.Forms.CheckBox();
            this.gb_Users = new System.Windows.Forms.GroupBox();
            this.chb_USERS_IncSub = new System.Windows.Forms.CheckBox();
            this.btn_UsersDestinationPathSelectDir = new System.Windows.Forms.Button();
            this.tb_UsersDestinationPath = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_UsersSourcePathSelectDir = new System.Windows.Forms.Button();
            this.tb_UsersSourcePath = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tp_Configs = new System.Windows.Forms.TabPage();
            this.chB_ConfigsDisable = new System.Windows.Forms.CheckBox();
            this.gb_Configs = new System.Windows.Forms.GroupBox();
            this.chb_CONFIGS_IncSub = new System.Windows.Forms.CheckBox();
            this.btn_ConfigsDestinationPathSelectDir = new System.Windows.Forms.Button();
            this.tb_ConfigsDestinationPath = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_ConfigsSourcePathSelectDir = new System.Windows.Forms.Button();
            this.tb_ConfigsSourcePath = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tp_Models = new System.Windows.Forms.TabPage();
            this.chB_ModelsDisable = new System.Windows.Forms.CheckBox();
            this.gb_Models = new System.Windows.Forms.GroupBox();
            this.chb_MODELS_IncSub = new System.Windows.Forms.CheckBox();
            this.btn_ModelsDestinationPathSelectDir = new System.Windows.Forms.Button();
            this.tb_ModelsDestinationPath = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_ModelsSourcePathSelectDir = new System.Windows.Forms.Button();
            this.tb_ModelsSourcePath = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tp_TestPrograms = new System.Windows.Forms.TabPage();
            this.chB_TestProgramsDisable = new System.Windows.Forms.CheckBox();
            this.gb_TestPrograms = new System.Windows.Forms.GroupBox();
            this.chb_TESTPROGRAMS_IncSub = new System.Windows.Forms.CheckBox();
            this.btn_TestProgramsDestinationPathSelectDir = new System.Windows.Forms.Button();
            this.tb_TestProgramsDestinationPath = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btn_TestProgramsSourcePathSelectDir = new System.Windows.Forms.Button();
            this.tb_TestProgramsSourcePath = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tp_BelMes = new System.Windows.Forms.TabPage();
            this.chB_BelMESDisable = new System.Windows.Forms.CheckBox();
            this.gb_BelMES = new System.Windows.Forms.GroupBox();
            this.chb_BELMES_IncSub = new System.Windows.Forms.CheckBox();
            this.btn_BelMESDestinationPathSelectDir = new System.Windows.Forms.Button();
            this.tb_BelMESDestinationPath = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btn_BelMESSourcePathSelectDir = new System.Windows.Forms.Button();
            this.tb_BelMESSourcePath = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_ImportAll = new System.Windows.Forms.Button();
            this.timer_Main = new System.Windows.Forms.Timer(this.components);
            this.timer_XML = new System.Windows.Forms.Timer(this.components);
            this.timer_HTML = new System.Windows.Forms.Timer(this.components);
            this.btn_SaveAll = new System.Windows.Forms.Button();
            this.showHideExportNotificationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cms_MainMenuTray.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tc_Main.SuspendLayout();
            this.tp_XML.SuspendLayout();
            this.gb_XML.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_XML)).BeginInit();
            this.tp_HTML.SuspendLayout();
            this.gb_HTML.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_HTML)).BeginInit();
            this.tp_Types.SuspendLayout();
            this.gb_Types.SuspendLayout();
            this.tp_Testmodules.SuspendLayout();
            this.gb_Testmodules.SuspendLayout();
            this.tp_Users.SuspendLayout();
            this.gb_Users.SuspendLayout();
            this.tp_Configs.SuspendLayout();
            this.gb_Configs.SuspendLayout();
            this.tp_Models.SuspendLayout();
            this.gb_Models.SuspendLayout();
            this.tp_TestPrograms.SuspendLayout();
            this.gb_TestPrograms.SuspendLayout();
            this.tp_BelMes.SuspendLayout();
            this.gb_BelMES.SuspendLayout();
            this.SuspendLayout();
            // 
            // TrayIcon
            // 
            this.TrayIcon.ContextMenuStrip = this.cms_MainMenuTray;
            this.TrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("TrayIcon.Icon")));
            this.TrayIcon.Text = "Export Import";
            this.TrayIcon.Visible = true;
            this.TrayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TrayIcon_MouseDoubleClick);
            // 
            // cms_MainMenuTray
            // 
            this.cms_MainMenuTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.showHideNotificationsToolStripMenuItem,
            this.showHideExportNotificationsToolStripMenuItem,
            this.setupToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.cms_MainMenuTray.Name = "cms_MainMenuTray";
            this.cms_MainMenuTray.Size = new System.Drawing.Size(244, 180);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.importToolStripMenuItem.Text = "Import";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // showHideNotificationsToolStripMenuItem
            // 
            this.showHideNotificationsToolStripMenuItem.Name = "showHideNotificationsToolStripMenuItem";
            this.showHideNotificationsToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.showHideNotificationsToolStripMenuItem.Text = "Show/Hide Import Notifications";
            this.showHideNotificationsToolStripMenuItem.Click += new System.EventHandler(this.showHideNotificationsToolStripMenuItem_Click);
            // 
            // setupToolStripMenuItem
            // 
            this.setupToolStripMenuItem.Name = "setupToolStripMenuItem";
            this.setupToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.setupToolStripMenuItem.Text = "Setup";
            this.setupToolStripMenuItem.Click += new System.EventHandler(this.setupToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(816, 122);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // tc_Main
            // 
            this.tc_Main.Controls.Add(this.tp_XML);
            this.tc_Main.Controls.Add(this.tp_HTML);
            this.tc_Main.Controls.Add(this.tp_Types);
            this.tc_Main.Controls.Add(this.tp_Testmodules);
            this.tc_Main.Controls.Add(this.tp_Users);
            this.tc_Main.Controls.Add(this.tp_Configs);
            this.tc_Main.Controls.Add(this.tp_Models);
            this.tc_Main.Controls.Add(this.tp_TestPrograms);
            this.tc_Main.Controls.Add(this.tp_BelMes);
            this.tc_Main.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tc_Main.Location = new System.Drawing.Point(16, 145);
            this.tc_Main.Margin = new System.Windows.Forms.Padding(4);
            this.tc_Main.Name = "tc_Main";
            this.tc_Main.SelectedIndex = 0;
            this.tc_Main.Size = new System.Drawing.Size(816, 286);
            this.tc_Main.TabIndex = 2;
            // 
            // tp_XML
            // 
            this.tp_XML.Controls.Add(this.chB_XMLDisable);
            this.tp_XML.Controls.Add(this.gb_XML);
            this.tp_XML.Location = new System.Drawing.Point(4, 24);
            this.tp_XML.Margin = new System.Windows.Forms.Padding(4);
            this.tp_XML.Name = "tp_XML";
            this.tp_XML.Padding = new System.Windows.Forms.Padding(4);
            this.tp_XML.Size = new System.Drawing.Size(808, 258);
            this.tp_XML.TabIndex = 0;
            this.tp_XML.Text = "XML";
            this.tp_XML.UseVisualStyleBackColor = true;
            // 
            // chB_XMLDisable
            // 
            this.chB_XMLDisable.AutoSize = true;
            this.chB_XMLDisable.Location = new System.Drawing.Point(7, 173);
            this.chB_XMLDisable.Name = "chB_XMLDisable";
            this.chB_XMLDisable.Size = new System.Drawing.Size(68, 19);
            this.chB_XMLDisable.TabIndex = 1;
            this.chB_XMLDisable.Text = "Disable";
            this.chB_XMLDisable.UseVisualStyleBackColor = true;
            this.chB_XMLDisable.CheckedChanged += new System.EventHandler(this.chB_XMLDisable_CheckedChanged);
            // 
            // gb_XML
            // 
            this.gb_XML.Controls.Add(this.chb_XML_IncSub);
            this.gb_XML.Controls.Add(this.nud_XML);
            this.gb_XML.Controls.Add(this.label17);
            this.gb_XML.Controls.Add(this.btn_XmlSourcePathSelectDir);
            this.gb_XML.Controls.Add(this.tb_XmlSourcePath);
            this.gb_XML.Controls.Add(this.label2);
            this.gb_XML.Controls.Add(this.btn_XmlDestinationPathSelectDir);
            this.gb_XML.Controls.Add(this.tb_XmlDestinationPath);
            this.gb_XML.Controls.Add(this.label1);
            this.gb_XML.Location = new System.Drawing.Point(7, 7);
            this.gb_XML.Name = "gb_XML";
            this.gb_XML.Size = new System.Drawing.Size(794, 160);
            this.gb_XML.TabIndex = 0;
            this.gb_XML.TabStop = false;
            this.gb_XML.Text = "XML Export: (exports all *.XML files)";
            // 
            // chb_XML_IncSub
            // 
            this.chb_XML_IncSub.AutoSize = true;
            this.chb_XML_IncSub.Location = new System.Drawing.Point(657, 126);
            this.chb_XML_IncSub.Name = "chb_XML_IncSub";
            this.chb_XML_IncSub.Size = new System.Drawing.Size(128, 19);
            this.chb_XML_IncSub.TabIndex = 8;
            this.chb_XML_IncSub.Text = "Include Subfolders";
            this.chb_XML_IncSub.UseVisualStyleBackColor = true;
            // 
            // nud_XML
            // 
            this.nud_XML.Location = new System.Drawing.Point(140, 124);
            this.nud_XML.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.nud_XML.Minimum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nud_XML.Name = "nud_XML";
            this.nud_XML.Size = new System.Drawing.Size(59, 21);
            this.nud_XML.TabIndex = 7;
            this.nud_XML.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 126);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(117, 15);
            this.label17.TabIndex = 6;
            this.label17.Text = "Export Interval (sec):";
            // 
            // btn_XmlSourcePathSelectDir
            // 
            this.btn_XmlSourcePathSelectDir.Location = new System.Drawing.Point(752, 40);
            this.btn_XmlSourcePathSelectDir.Name = "btn_XmlSourcePathSelectDir";
            this.btn_XmlSourcePathSelectDir.Size = new System.Drawing.Size(33, 23);
            this.btn_XmlSourcePathSelectDir.TabIndex = 5;
            this.btn_XmlSourcePathSelectDir.Text = "...";
            this.btn_XmlSourcePathSelectDir.UseVisualStyleBackColor = true;
            this.btn_XmlSourcePathSelectDir.Click += new System.EventHandler(this.btn_XmlSourcePathSelectDir_Click);
            // 
            // tb_XmlSourcePath
            // 
            this.tb_XmlSourcePath.Location = new System.Drawing.Point(9, 41);
            this.tb_XmlSourcePath.Name = "tb_XmlSourcePath";
            this.tb_XmlSourcePath.Size = new System.Drawing.Size(740, 21);
            this.tb_XmlSourcePath.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "LOCAL Source Path:";
            // 
            // btn_XmlDestinationPathSelectDir
            // 
            this.btn_XmlDestinationPathSelectDir.Location = new System.Drawing.Point(752, 90);
            this.btn_XmlDestinationPathSelectDir.Name = "btn_XmlDestinationPathSelectDir";
            this.btn_XmlDestinationPathSelectDir.Size = new System.Drawing.Size(33, 23);
            this.btn_XmlDestinationPathSelectDir.TabIndex = 2;
            this.btn_XmlDestinationPathSelectDir.Text = "...";
            this.btn_XmlDestinationPathSelectDir.UseVisualStyleBackColor = true;
            this.btn_XmlDestinationPathSelectDir.Click += new System.EventHandler(this.btn_XmlDestinationPathSelectDir_Click);
            // 
            // tb_XmlDestinationPath
            // 
            this.tb_XmlDestinationPath.Location = new System.Drawing.Point(9, 91);
            this.tb_XmlDestinationPath.Name = "tb_XmlDestinationPath";
            this.tb_XmlDestinationPath.Size = new System.Drawing.Size(740, 21);
            this.tb_XmlDestinationPath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "NETWORK Destination Path:";
            // 
            // tp_HTML
            // 
            this.tp_HTML.Controls.Add(this.chB_HTMLDisable);
            this.tp_HTML.Controls.Add(this.gb_HTML);
            this.tp_HTML.Location = new System.Drawing.Point(4, 24);
            this.tp_HTML.Margin = new System.Windows.Forms.Padding(4);
            this.tp_HTML.Name = "tp_HTML";
            this.tp_HTML.Padding = new System.Windows.Forms.Padding(4);
            this.tp_HTML.Size = new System.Drawing.Size(808, 258);
            this.tp_HTML.TabIndex = 1;
            this.tp_HTML.Text = "HTML";
            this.tp_HTML.UseVisualStyleBackColor = true;
            // 
            // chB_HTMLDisable
            // 
            this.chB_HTMLDisable.AutoSize = true;
            this.chB_HTMLDisable.Location = new System.Drawing.Point(7, 173);
            this.chB_HTMLDisable.Name = "chB_HTMLDisable";
            this.chB_HTMLDisable.Size = new System.Drawing.Size(68, 19);
            this.chB_HTMLDisable.TabIndex = 2;
            this.chB_HTMLDisable.Text = "Disable";
            this.chB_HTMLDisable.UseVisualStyleBackColor = true;
            this.chB_HTMLDisable.CheckedChanged += new System.EventHandler(this.chB_HTMLDisable_CheckedChanged);
            // 
            // gb_HTML
            // 
            this.gb_HTML.Controls.Add(this.chb_HTML_IncSub);
            this.gb_HTML.Controls.Add(this.nud_HTML);
            this.gb_HTML.Controls.Add(this.label18);
            this.gb_HTML.Controls.Add(this.btn_HtmlSourcePathSelectDir);
            this.gb_HTML.Controls.Add(this.tb_HtmlSourcePath);
            this.gb_HTML.Controls.Add(this.label3);
            this.gb_HTML.Controls.Add(this.btn_HtmlDestinationPathSelectDir);
            this.gb_HTML.Controls.Add(this.tb_HtmlDestinationPath);
            this.gb_HTML.Controls.Add(this.label4);
            this.gb_HTML.Location = new System.Drawing.Point(7, 7);
            this.gb_HTML.Name = "gb_HTML";
            this.gb_HTML.Size = new System.Drawing.Size(794, 160);
            this.gb_HTML.TabIndex = 1;
            this.gb_HTML.TabStop = false;
            this.gb_HTML.Text = "HTML Export: (exports all *.HTML files)";
            // 
            // chb_HTML_IncSub
            // 
            this.chb_HTML_IncSub.AutoSize = true;
            this.chb_HTML_IncSub.Location = new System.Drawing.Point(657, 126);
            this.chb_HTML_IncSub.Name = "chb_HTML_IncSub";
            this.chb_HTML_IncSub.Size = new System.Drawing.Size(128, 19);
            this.chb_HTML_IncSub.TabIndex = 10;
            this.chb_HTML_IncSub.Text = "Include Subfolders";
            this.chb_HTML_IncSub.UseVisualStyleBackColor = true;
            // 
            // nud_HTML
            // 
            this.nud_HTML.Location = new System.Drawing.Point(140, 124);
            this.nud_HTML.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.nud_HTML.Minimum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nud_HTML.Name = "nud_HTML";
            this.nud_HTML.Size = new System.Drawing.Size(59, 21);
            this.nud_HTML.TabIndex = 9;
            this.nud_HTML.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 126);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(117, 15);
            this.label18.TabIndex = 8;
            this.label18.Text = "Export Interval (sec):";
            // 
            // btn_HtmlSourcePathSelectDir
            // 
            this.btn_HtmlSourcePathSelectDir.Location = new System.Drawing.Point(752, 40);
            this.btn_HtmlSourcePathSelectDir.Name = "btn_HtmlSourcePathSelectDir";
            this.btn_HtmlSourcePathSelectDir.Size = new System.Drawing.Size(33, 23);
            this.btn_HtmlSourcePathSelectDir.TabIndex = 5;
            this.btn_HtmlSourcePathSelectDir.Text = "...";
            this.btn_HtmlSourcePathSelectDir.UseVisualStyleBackColor = true;
            this.btn_HtmlSourcePathSelectDir.Click += new System.EventHandler(this.btn_HtmlSourcePathSelectDir_Click);
            // 
            // tb_HtmlSourcePath
            // 
            this.tb_HtmlSourcePath.Location = new System.Drawing.Point(9, 41);
            this.tb_HtmlSourcePath.Name = "tb_HtmlSourcePath";
            this.tb_HtmlSourcePath.Size = new System.Drawing.Size(740, 21);
            this.tb_HtmlSourcePath.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "LOCAL Source Path:";
            // 
            // btn_HtmlDestinationPathSelectDir
            // 
            this.btn_HtmlDestinationPathSelectDir.Location = new System.Drawing.Point(752, 90);
            this.btn_HtmlDestinationPathSelectDir.Name = "btn_HtmlDestinationPathSelectDir";
            this.btn_HtmlDestinationPathSelectDir.Size = new System.Drawing.Size(33, 23);
            this.btn_HtmlDestinationPathSelectDir.TabIndex = 2;
            this.btn_HtmlDestinationPathSelectDir.Text = "...";
            this.btn_HtmlDestinationPathSelectDir.UseVisualStyleBackColor = true;
            this.btn_HtmlDestinationPathSelectDir.Click += new System.EventHandler(this.btn_HtmlDestinationPathSelectDir_Click);
            // 
            // tb_HtmlDestinationPath
            // 
            this.tb_HtmlDestinationPath.Location = new System.Drawing.Point(9, 91);
            this.tb_HtmlDestinationPath.Name = "tb_HtmlDestinationPath";
            this.tb_HtmlDestinationPath.Size = new System.Drawing.Size(740, 21);
            this.tb_HtmlDestinationPath.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "NETWORK Destination Path:";
            // 
            // tp_Types
            // 
            this.tp_Types.Controls.Add(this.chB_TypesDisable);
            this.tp_Types.Controls.Add(this.gb_Types);
            this.tp_Types.Location = new System.Drawing.Point(4, 24);
            this.tp_Types.Margin = new System.Windows.Forms.Padding(4);
            this.tp_Types.Name = "tp_Types";
            this.tp_Types.Padding = new System.Windows.Forms.Padding(4);
            this.tp_Types.Size = new System.Drawing.Size(808, 258);
            this.tp_Types.TabIndex = 2;
            this.tp_Types.Text = "Types (INI)";
            this.tp_Types.UseVisualStyleBackColor = true;
            // 
            // chB_TypesDisable
            // 
            this.chB_TypesDisable.AutoSize = true;
            this.chB_TypesDisable.Location = new System.Drawing.Point(7, 173);
            this.chB_TypesDisable.Name = "chB_TypesDisable";
            this.chB_TypesDisable.Size = new System.Drawing.Size(68, 19);
            this.chB_TypesDisable.TabIndex = 3;
            this.chB_TypesDisable.Text = "Disable";
            this.chB_TypesDisable.UseVisualStyleBackColor = true;
            this.chB_TypesDisable.CheckedChanged += new System.EventHandler(this.chB_TypesDisable_CheckedChanged);
            // 
            // gb_Types
            // 
            this.gb_Types.Controls.Add(this.chb_TYPES_IncSub);
            this.gb_Types.Controls.Add(this.btn_TypesSourcePathSelectDir);
            this.gb_Types.Controls.Add(this.tb_TypesSourcePath);
            this.gb_Types.Controls.Add(this.label5);
            this.gb_Types.Controls.Add(this.btn_TypesDestinationPathSelectDir);
            this.gb_Types.Controls.Add(this.tb_TypesDestinationPath);
            this.gb_Types.Controls.Add(this.label6);
            this.gb_Types.Location = new System.Drawing.Point(7, 7);
            this.gb_Types.Name = "gb_Types";
            this.gb_Types.Size = new System.Drawing.Size(794, 160);
            this.gb_Types.TabIndex = 2;
            this.gb_Types.TabStop = false;
            this.gb_Types.Text = "Types INI Export: (exports all *.INI files)";
            // 
            // chb_TYPES_IncSub
            // 
            this.chb_TYPES_IncSub.AutoSize = true;
            this.chb_TYPES_IncSub.Location = new System.Drawing.Point(657, 126);
            this.chb_TYPES_IncSub.Name = "chb_TYPES_IncSub";
            this.chb_TYPES_IncSub.Size = new System.Drawing.Size(128, 19);
            this.chb_TYPES_IncSub.TabIndex = 11;
            this.chb_TYPES_IncSub.Text = "Include Subfolders";
            this.chb_TYPES_IncSub.UseVisualStyleBackColor = true;
            // 
            // btn_TypesSourcePathSelectDir
            // 
            this.btn_TypesSourcePathSelectDir.Location = new System.Drawing.Point(752, 40);
            this.btn_TypesSourcePathSelectDir.Name = "btn_TypesSourcePathSelectDir";
            this.btn_TypesSourcePathSelectDir.Size = new System.Drawing.Size(33, 23);
            this.btn_TypesSourcePathSelectDir.TabIndex = 5;
            this.btn_TypesSourcePathSelectDir.Text = "...";
            this.btn_TypesSourcePathSelectDir.UseVisualStyleBackColor = true;
            this.btn_TypesSourcePathSelectDir.Click += new System.EventHandler(this.btn_TypesSourcePathSelectDir_Click);
            // 
            // tb_TypesSourcePath
            // 
            this.tb_TypesSourcePath.Location = new System.Drawing.Point(9, 41);
            this.tb_TypesSourcePath.Name = "tb_TypesSourcePath";
            this.tb_TypesSourcePath.Size = new System.Drawing.Size(740, 21);
            this.tb_TypesSourcePath.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "LOCAL Source Path:";
            // 
            // btn_TypesDestinationPathSelectDir
            // 
            this.btn_TypesDestinationPathSelectDir.Location = new System.Drawing.Point(752, 90);
            this.btn_TypesDestinationPathSelectDir.Name = "btn_TypesDestinationPathSelectDir";
            this.btn_TypesDestinationPathSelectDir.Size = new System.Drawing.Size(33, 23);
            this.btn_TypesDestinationPathSelectDir.TabIndex = 2;
            this.btn_TypesDestinationPathSelectDir.Text = "...";
            this.btn_TypesDestinationPathSelectDir.UseVisualStyleBackColor = true;
            this.btn_TypesDestinationPathSelectDir.Click += new System.EventHandler(this.btn_TypesDestinationPathSelectDir_Click);
            // 
            // tb_TypesDestinationPath
            // 
            this.tb_TypesDestinationPath.Location = new System.Drawing.Point(9, 91);
            this.tb_TypesDestinationPath.Name = "tb_TypesDestinationPath";
            this.tb_TypesDestinationPath.Size = new System.Drawing.Size(740, 21);
            this.tb_TypesDestinationPath.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "NETWORK Destination Path:";
            // 
            // tp_Testmodules
            // 
            this.tp_Testmodules.Controls.Add(this.chB_TestmodulesDisable);
            this.tp_Testmodules.Controls.Add(this.gb_Testmodules);
            this.tp_Testmodules.Location = new System.Drawing.Point(4, 24);
            this.tp_Testmodules.Margin = new System.Windows.Forms.Padding(4);
            this.tp_Testmodules.Name = "tp_Testmodules";
            this.tp_Testmodules.Padding = new System.Windows.Forms.Padding(4);
            this.tp_Testmodules.Size = new System.Drawing.Size(808, 258);
            this.tp_Testmodules.TabIndex = 3;
            this.tp_Testmodules.Text = "Testmodules (DLL, UIR)";
            this.tp_Testmodules.UseVisualStyleBackColor = true;
            // 
            // chB_TestmodulesDisable
            // 
            this.chB_TestmodulesDisable.AutoSize = true;
            this.chB_TestmodulesDisable.Location = new System.Drawing.Point(7, 173);
            this.chB_TestmodulesDisable.Name = "chB_TestmodulesDisable";
            this.chB_TestmodulesDisable.Size = new System.Drawing.Size(68, 19);
            this.chB_TestmodulesDisable.TabIndex = 4;
            this.chB_TestmodulesDisable.Text = "Disable";
            this.chB_TestmodulesDisable.UseVisualStyleBackColor = true;
            this.chB_TestmodulesDisable.CheckedChanged += new System.EventHandler(this.chB_TestmodulesDisable_CheckedChanged);
            // 
            // gb_Testmodules
            // 
            this.gb_Testmodules.Controls.Add(this.chb_TESTMODULES_IncSub);
            this.gb_Testmodules.Controls.Add(this.btn_TestmodulesDestinationPathSelectDir);
            this.gb_Testmodules.Controls.Add(this.tb_TestmodulesDestinationPath);
            this.gb_Testmodules.Controls.Add(this.label7);
            this.gb_Testmodules.Controls.Add(this.btn_TestmodulesSourcePathSelectDir);
            this.gb_Testmodules.Controls.Add(this.tb_TestmodulesSourcePath);
            this.gb_Testmodules.Controls.Add(this.label8);
            this.gb_Testmodules.Location = new System.Drawing.Point(7, 7);
            this.gb_Testmodules.Name = "gb_Testmodules";
            this.gb_Testmodules.Size = new System.Drawing.Size(794, 160);
            this.gb_Testmodules.TabIndex = 3;
            this.gb_Testmodules.TabStop = false;
            this.gb_Testmodules.Text = "DLL, UIR Import: (imports all *.DLL and *.UIR files)";
            // 
            // chb_TESTMODULES_IncSub
            // 
            this.chb_TESTMODULES_IncSub.AutoSize = true;
            this.chb_TESTMODULES_IncSub.Location = new System.Drawing.Point(657, 126);
            this.chb_TESTMODULES_IncSub.Name = "chb_TESTMODULES_IncSub";
            this.chb_TESTMODULES_IncSub.Size = new System.Drawing.Size(128, 19);
            this.chb_TESTMODULES_IncSub.TabIndex = 12;
            this.chb_TESTMODULES_IncSub.Text = "Include Subfolders";
            this.chb_TESTMODULES_IncSub.UseVisualStyleBackColor = true;
            // 
            // btn_TestmodulesDestinationPathSelectDir
            // 
            this.btn_TestmodulesDestinationPathSelectDir.Location = new System.Drawing.Point(752, 90);
            this.btn_TestmodulesDestinationPathSelectDir.Name = "btn_TestmodulesDestinationPathSelectDir";
            this.btn_TestmodulesDestinationPathSelectDir.Size = new System.Drawing.Size(33, 23);
            this.btn_TestmodulesDestinationPathSelectDir.TabIndex = 5;
            this.btn_TestmodulesDestinationPathSelectDir.Text = "...";
            this.btn_TestmodulesDestinationPathSelectDir.UseVisualStyleBackColor = true;
            this.btn_TestmodulesDestinationPathSelectDir.Click += new System.EventHandler(this.btn_TestmodulesDestinationPathSelectDir_Click);
            // 
            // tb_TestmodulesDestinationPath
            // 
            this.tb_TestmodulesDestinationPath.Location = new System.Drawing.Point(9, 91);
            this.tb_TestmodulesDestinationPath.Name = "tb_TestmodulesDestinationPath";
            this.tb_TestmodulesDestinationPath.Size = new System.Drawing.Size(740, 21);
            this.tb_TestmodulesDestinationPath.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "LOCAL Destination Path:";
            // 
            // btn_TestmodulesSourcePathSelectDir
            // 
            this.btn_TestmodulesSourcePathSelectDir.Location = new System.Drawing.Point(752, 40);
            this.btn_TestmodulesSourcePathSelectDir.Name = "btn_TestmodulesSourcePathSelectDir";
            this.btn_TestmodulesSourcePathSelectDir.Size = new System.Drawing.Size(33, 23);
            this.btn_TestmodulesSourcePathSelectDir.TabIndex = 2;
            this.btn_TestmodulesSourcePathSelectDir.Text = "...";
            this.btn_TestmodulesSourcePathSelectDir.UseVisualStyleBackColor = true;
            this.btn_TestmodulesSourcePathSelectDir.Click += new System.EventHandler(this.btn_TestmodulesSourcePathSelectDir_Click);
            // 
            // tb_TestmodulesSourcePath
            // 
            this.tb_TestmodulesSourcePath.Location = new System.Drawing.Point(9, 41);
            this.tb_TestmodulesSourcePath.Name = "tb_TestmodulesSourcePath";
            this.tb_TestmodulesSourcePath.Size = new System.Drawing.Size(740, 21);
            this.tb_TestmodulesSourcePath.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "NETWORK Source Path:";
            // 
            // tp_Users
            // 
            this.tp_Users.Controls.Add(this.chB_UsersDisable);
            this.tp_Users.Controls.Add(this.gb_Users);
            this.tp_Users.Location = new System.Drawing.Point(4, 24);
            this.tp_Users.Margin = new System.Windows.Forms.Padding(4);
            this.tp_Users.Name = "tp_Users";
            this.tp_Users.Padding = new System.Windows.Forms.Padding(4);
            this.tp_Users.Size = new System.Drawing.Size(808, 258);
            this.tp_Users.TabIndex = 4;
            this.tp_Users.Text = "Users (INI)";
            this.tp_Users.UseVisualStyleBackColor = true;
            // 
            // chB_UsersDisable
            // 
            this.chB_UsersDisable.AutoSize = true;
            this.chB_UsersDisable.Location = new System.Drawing.Point(7, 173);
            this.chB_UsersDisable.Name = "chB_UsersDisable";
            this.chB_UsersDisable.Size = new System.Drawing.Size(68, 19);
            this.chB_UsersDisable.TabIndex = 5;
            this.chB_UsersDisable.Text = "Disable";
            this.chB_UsersDisable.UseVisualStyleBackColor = true;
            this.chB_UsersDisable.CheckedChanged += new System.EventHandler(this.chB_UsersDisable_CheckedChanged);
            // 
            // gb_Users
            // 
            this.gb_Users.Controls.Add(this.chb_USERS_IncSub);
            this.gb_Users.Controls.Add(this.btn_UsersDestinationPathSelectDir);
            this.gb_Users.Controls.Add(this.tb_UsersDestinationPath);
            this.gb_Users.Controls.Add(this.label9);
            this.gb_Users.Controls.Add(this.btn_UsersSourcePathSelectDir);
            this.gb_Users.Controls.Add(this.tb_UsersSourcePath);
            this.gb_Users.Controls.Add(this.label10);
            this.gb_Users.Location = new System.Drawing.Point(7, 7);
            this.gb_Users.Name = "gb_Users";
            this.gb_Users.Size = new System.Drawing.Size(794, 160);
            this.gb_Users.TabIndex = 4;
            this.gb_Users.TabStop = false;
            this.gb_Users.Text = "Users INI Import: (imports all *.INI files)";
            // 
            // chb_USERS_IncSub
            // 
            this.chb_USERS_IncSub.AutoSize = true;
            this.chb_USERS_IncSub.Location = new System.Drawing.Point(657, 126);
            this.chb_USERS_IncSub.Name = "chb_USERS_IncSub";
            this.chb_USERS_IncSub.Size = new System.Drawing.Size(128, 19);
            this.chb_USERS_IncSub.TabIndex = 13;
            this.chb_USERS_IncSub.Text = "Include Subfolders";
            this.chb_USERS_IncSub.UseVisualStyleBackColor = true;
            // 
            // btn_UsersDestinationPathSelectDir
            // 
            this.btn_UsersDestinationPathSelectDir.Location = new System.Drawing.Point(752, 90);
            this.btn_UsersDestinationPathSelectDir.Name = "btn_UsersDestinationPathSelectDir";
            this.btn_UsersDestinationPathSelectDir.Size = new System.Drawing.Size(33, 23);
            this.btn_UsersDestinationPathSelectDir.TabIndex = 5;
            this.btn_UsersDestinationPathSelectDir.Text = "...";
            this.btn_UsersDestinationPathSelectDir.UseVisualStyleBackColor = true;
            this.btn_UsersDestinationPathSelectDir.Click += new System.EventHandler(this.btn_UsersDestinationPathSelectDir_Click);
            // 
            // tb_UsersDestinationPath
            // 
            this.tb_UsersDestinationPath.Location = new System.Drawing.Point(9, 91);
            this.tb_UsersDestinationPath.Name = "tb_UsersDestinationPath";
            this.tb_UsersDestinationPath.Size = new System.Drawing.Size(740, 21);
            this.tb_UsersDestinationPath.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 15);
            this.label9.TabIndex = 3;
            this.label9.Text = "LOCAL Destination Path:";
            // 
            // btn_UsersSourcePathSelectDir
            // 
            this.btn_UsersSourcePathSelectDir.Location = new System.Drawing.Point(752, 40);
            this.btn_UsersSourcePathSelectDir.Name = "btn_UsersSourcePathSelectDir";
            this.btn_UsersSourcePathSelectDir.Size = new System.Drawing.Size(33, 23);
            this.btn_UsersSourcePathSelectDir.TabIndex = 2;
            this.btn_UsersSourcePathSelectDir.Text = "...";
            this.btn_UsersSourcePathSelectDir.UseVisualStyleBackColor = true;
            this.btn_UsersSourcePathSelectDir.Click += new System.EventHandler(this.btn_UsersSourcePathSelectDir_Click);
            // 
            // tb_UsersSourcePath
            // 
            this.tb_UsersSourcePath.Location = new System.Drawing.Point(9, 41);
            this.tb_UsersSourcePath.Name = "tb_UsersSourcePath";
            this.tb_UsersSourcePath.Size = new System.Drawing.Size(740, 21);
            this.tb_UsersSourcePath.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "NETWORK Source Path:";
            // 
            // tp_Configs
            // 
            this.tp_Configs.Controls.Add(this.chB_ConfigsDisable);
            this.tp_Configs.Controls.Add(this.gb_Configs);
            this.tp_Configs.Location = new System.Drawing.Point(4, 24);
            this.tp_Configs.Margin = new System.Windows.Forms.Padding(4);
            this.tp_Configs.Name = "tp_Configs";
            this.tp_Configs.Padding = new System.Windows.Forms.Padding(4);
            this.tp_Configs.Size = new System.Drawing.Size(808, 258);
            this.tp_Configs.TabIndex = 5;
            this.tp_Configs.Text = "Configs (INI, UDL)";
            this.tp_Configs.UseVisualStyleBackColor = true;
            // 
            // chB_ConfigsDisable
            // 
            this.chB_ConfigsDisable.AutoSize = true;
            this.chB_ConfigsDisable.Location = new System.Drawing.Point(7, 173);
            this.chB_ConfigsDisable.Name = "chB_ConfigsDisable";
            this.chB_ConfigsDisable.Size = new System.Drawing.Size(68, 19);
            this.chB_ConfigsDisable.TabIndex = 6;
            this.chB_ConfigsDisable.Text = "Disable";
            this.chB_ConfigsDisable.UseVisualStyleBackColor = true;
            this.chB_ConfigsDisable.CheckedChanged += new System.EventHandler(this.chB_ConfigsDisable_CheckedChanged);
            // 
            // gb_Configs
            // 
            this.gb_Configs.Controls.Add(this.chb_CONFIGS_IncSub);
            this.gb_Configs.Controls.Add(this.btn_ConfigsDestinationPathSelectDir);
            this.gb_Configs.Controls.Add(this.tb_ConfigsDestinationPath);
            this.gb_Configs.Controls.Add(this.label11);
            this.gb_Configs.Controls.Add(this.btn_ConfigsSourcePathSelectDir);
            this.gb_Configs.Controls.Add(this.tb_ConfigsSourcePath);
            this.gb_Configs.Controls.Add(this.label12);
            this.gb_Configs.Location = new System.Drawing.Point(7, 7);
            this.gb_Configs.Name = "gb_Configs";
            this.gb_Configs.Size = new System.Drawing.Size(794, 160);
            this.gb_Configs.TabIndex = 5;
            this.gb_Configs.TabStop = false;
            this.gb_Configs.Text = "Configuration INI Import: (imports all *.INI and *.UDL files)";
            // 
            // chb_CONFIGS_IncSub
            // 
            this.chb_CONFIGS_IncSub.AutoSize = true;
            this.chb_CONFIGS_IncSub.Location = new System.Drawing.Point(657, 126);
            this.chb_CONFIGS_IncSub.Name = "chb_CONFIGS_IncSub";
            this.chb_CONFIGS_IncSub.Size = new System.Drawing.Size(128, 19);
            this.chb_CONFIGS_IncSub.TabIndex = 14;
            this.chb_CONFIGS_IncSub.Text = "Include Subfolders";
            this.chb_CONFIGS_IncSub.UseVisualStyleBackColor = true;
            // 
            // btn_ConfigsDestinationPathSelectDir
            // 
            this.btn_ConfigsDestinationPathSelectDir.Location = new System.Drawing.Point(752, 90);
            this.btn_ConfigsDestinationPathSelectDir.Name = "btn_ConfigsDestinationPathSelectDir";
            this.btn_ConfigsDestinationPathSelectDir.Size = new System.Drawing.Size(33, 23);
            this.btn_ConfigsDestinationPathSelectDir.TabIndex = 5;
            this.btn_ConfigsDestinationPathSelectDir.Text = "...";
            this.btn_ConfigsDestinationPathSelectDir.UseVisualStyleBackColor = true;
            this.btn_ConfigsDestinationPathSelectDir.Click += new System.EventHandler(this.btn_ConfigsDestinationPathSelectDir_Click);
            // 
            // tb_ConfigsDestinationPath
            // 
            this.tb_ConfigsDestinationPath.Location = new System.Drawing.Point(9, 91);
            this.tb_ConfigsDestinationPath.Name = "tb_ConfigsDestinationPath";
            this.tb_ConfigsDestinationPath.Size = new System.Drawing.Size(740, 21);
            this.tb_ConfigsDestinationPath.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(141, 15);
            this.label11.TabIndex = 3;
            this.label11.Text = "LOCAL Destination Path:";
            // 
            // btn_ConfigsSourcePathSelectDir
            // 
            this.btn_ConfigsSourcePathSelectDir.Location = new System.Drawing.Point(752, 40);
            this.btn_ConfigsSourcePathSelectDir.Name = "btn_ConfigsSourcePathSelectDir";
            this.btn_ConfigsSourcePathSelectDir.Size = new System.Drawing.Size(33, 23);
            this.btn_ConfigsSourcePathSelectDir.TabIndex = 2;
            this.btn_ConfigsSourcePathSelectDir.Text = "...";
            this.btn_ConfigsSourcePathSelectDir.UseVisualStyleBackColor = true;
            this.btn_ConfigsSourcePathSelectDir.Click += new System.EventHandler(this.btn_ConfigsSourcePathSelectDir_Click);
            // 
            // tb_ConfigsSourcePath
            // 
            this.tb_ConfigsSourcePath.Location = new System.Drawing.Point(9, 41);
            this.tb_ConfigsSourcePath.Name = "tb_ConfigsSourcePath";
            this.tb_ConfigsSourcePath.Size = new System.Drawing.Size(740, 21);
            this.tb_ConfigsSourcePath.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(141, 15);
            this.label12.TabIndex = 0;
            this.label12.Text = "NETWORK Source Path:";
            // 
            // tp_Models
            // 
            this.tp_Models.Controls.Add(this.chB_ModelsDisable);
            this.tp_Models.Controls.Add(this.gb_Models);
            this.tp_Models.Location = new System.Drawing.Point(4, 24);
            this.tp_Models.Margin = new System.Windows.Forms.Padding(4);
            this.tp_Models.Name = "tp_Models";
            this.tp_Models.Padding = new System.Windows.Forms.Padding(4);
            this.tp_Models.Size = new System.Drawing.Size(808, 258);
            this.tp_Models.TabIndex = 6;
            this.tp_Models.Text = "Models (SEQ)";
            this.tp_Models.UseVisualStyleBackColor = true;
            // 
            // chB_ModelsDisable
            // 
            this.chB_ModelsDisable.AutoSize = true;
            this.chB_ModelsDisable.Location = new System.Drawing.Point(7, 173);
            this.chB_ModelsDisable.Name = "chB_ModelsDisable";
            this.chB_ModelsDisable.Size = new System.Drawing.Size(68, 19);
            this.chB_ModelsDisable.TabIndex = 7;
            this.chB_ModelsDisable.Text = "Disable";
            this.chB_ModelsDisable.UseVisualStyleBackColor = true;
            this.chB_ModelsDisable.CheckedChanged += new System.EventHandler(this.chB_ModelsDisable_CheckedChanged);
            // 
            // gb_Models
            // 
            this.gb_Models.Controls.Add(this.chb_MODELS_IncSub);
            this.gb_Models.Controls.Add(this.btn_ModelsDestinationPathSelectDir);
            this.gb_Models.Controls.Add(this.tb_ModelsDestinationPath);
            this.gb_Models.Controls.Add(this.label13);
            this.gb_Models.Controls.Add(this.btn_ModelsSourcePathSelectDir);
            this.gb_Models.Controls.Add(this.tb_ModelsSourcePath);
            this.gb_Models.Controls.Add(this.label14);
            this.gb_Models.Location = new System.Drawing.Point(7, 7);
            this.gb_Models.Name = "gb_Models";
            this.gb_Models.Size = new System.Drawing.Size(794, 160);
            this.gb_Models.TabIndex = 6;
            this.gb_Models.TabStop = false;
            this.gb_Models.Text = "P1 Sequential Models SEQ Import: (imports all *.SEQ files)";
            // 
            // chb_MODELS_IncSub
            // 
            this.chb_MODELS_IncSub.AutoSize = true;
            this.chb_MODELS_IncSub.Location = new System.Drawing.Point(657, 126);
            this.chb_MODELS_IncSub.Name = "chb_MODELS_IncSub";
            this.chb_MODELS_IncSub.Size = new System.Drawing.Size(128, 19);
            this.chb_MODELS_IncSub.TabIndex = 15;
            this.chb_MODELS_IncSub.Text = "Include Subfolders";
            this.chb_MODELS_IncSub.UseVisualStyleBackColor = true;
            // 
            // btn_ModelsDestinationPathSelectDir
            // 
            this.btn_ModelsDestinationPathSelectDir.Location = new System.Drawing.Point(752, 90);
            this.btn_ModelsDestinationPathSelectDir.Name = "btn_ModelsDestinationPathSelectDir";
            this.btn_ModelsDestinationPathSelectDir.Size = new System.Drawing.Size(33, 23);
            this.btn_ModelsDestinationPathSelectDir.TabIndex = 5;
            this.btn_ModelsDestinationPathSelectDir.Text = "...";
            this.btn_ModelsDestinationPathSelectDir.UseVisualStyleBackColor = true;
            this.btn_ModelsDestinationPathSelectDir.Click += new System.EventHandler(this.btn_ModelsDestinationPathSelectDir_Click);
            // 
            // tb_ModelsDestinationPath
            // 
            this.tb_ModelsDestinationPath.Location = new System.Drawing.Point(9, 91);
            this.tb_ModelsDestinationPath.Name = "tb_ModelsDestinationPath";
            this.tb_ModelsDestinationPath.Size = new System.Drawing.Size(740, 21);
            this.tb_ModelsDestinationPath.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 72);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(141, 15);
            this.label13.TabIndex = 3;
            this.label13.Text = "LOCAL Destination Path:";
            // 
            // btn_ModelsSourcePathSelectDir
            // 
            this.btn_ModelsSourcePathSelectDir.Location = new System.Drawing.Point(752, 40);
            this.btn_ModelsSourcePathSelectDir.Name = "btn_ModelsSourcePathSelectDir";
            this.btn_ModelsSourcePathSelectDir.Size = new System.Drawing.Size(33, 23);
            this.btn_ModelsSourcePathSelectDir.TabIndex = 2;
            this.btn_ModelsSourcePathSelectDir.Text = "...";
            this.btn_ModelsSourcePathSelectDir.UseVisualStyleBackColor = true;
            this.btn_ModelsSourcePathSelectDir.Click += new System.EventHandler(this.btn_ModelsSourcePathSelectDir_Click);
            // 
            // tb_ModelsSourcePath
            // 
            this.tb_ModelsSourcePath.Location = new System.Drawing.Point(9, 41);
            this.tb_ModelsSourcePath.Name = "tb_ModelsSourcePath";
            this.tb_ModelsSourcePath.Size = new System.Drawing.Size(740, 21);
            this.tb_ModelsSourcePath.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(141, 15);
            this.label14.TabIndex = 0;
            this.label14.Text = "NETWORK Source Path:";
            // 
            // tp_TestPrograms
            // 
            this.tp_TestPrograms.Controls.Add(this.chB_TestProgramsDisable);
            this.tp_TestPrograms.Controls.Add(this.gb_TestPrograms);
            this.tp_TestPrograms.Location = new System.Drawing.Point(4, 24);
            this.tp_TestPrograms.Margin = new System.Windows.Forms.Padding(4);
            this.tp_TestPrograms.Name = "tp_TestPrograms";
            this.tp_TestPrograms.Padding = new System.Windows.Forms.Padding(4);
            this.tp_TestPrograms.Size = new System.Drawing.Size(808, 258);
            this.tp_TestPrograms.TabIndex = 7;
            this.tp_TestPrograms.Text = "Test Programs (*.*)";
            this.tp_TestPrograms.UseVisualStyleBackColor = true;
            // 
            // chB_TestProgramsDisable
            // 
            this.chB_TestProgramsDisable.AutoSize = true;
            this.chB_TestProgramsDisable.Location = new System.Drawing.Point(7, 173);
            this.chB_TestProgramsDisable.Name = "chB_TestProgramsDisable";
            this.chB_TestProgramsDisable.Size = new System.Drawing.Size(68, 19);
            this.chB_TestProgramsDisable.TabIndex = 8;
            this.chB_TestProgramsDisable.Text = "Disable";
            this.chB_TestProgramsDisable.UseVisualStyleBackColor = true;
            this.chB_TestProgramsDisable.CheckedChanged += new System.EventHandler(this.chB_TestProgramsDisable_CheckedChanged);
            // 
            // gb_TestPrograms
            // 
            this.gb_TestPrograms.Controls.Add(this.chb_TESTPROGRAMS_IncSub);
            this.gb_TestPrograms.Controls.Add(this.btn_TestProgramsDestinationPathSelectDir);
            this.gb_TestPrograms.Controls.Add(this.tb_TestProgramsDestinationPath);
            this.gb_TestPrograms.Controls.Add(this.label15);
            this.gb_TestPrograms.Controls.Add(this.btn_TestProgramsSourcePathSelectDir);
            this.gb_TestPrograms.Controls.Add(this.tb_TestProgramsSourcePath);
            this.gb_TestPrograms.Controls.Add(this.label16);
            this.gb_TestPrograms.Location = new System.Drawing.Point(7, 7);
            this.gb_TestPrograms.Name = "gb_TestPrograms";
            this.gb_TestPrograms.Size = new System.Drawing.Size(794, 160);
            this.gb_TestPrograms.TabIndex = 7;
            this.gb_TestPrograms.TabStop = false;
            this.gb_TestPrograms.Text = "Test Programs Import: (imports all subdirectories and files)";
            // 
            // chb_TESTPROGRAMS_IncSub
            // 
            this.chb_TESTPROGRAMS_IncSub.AutoSize = true;
            this.chb_TESTPROGRAMS_IncSub.Location = new System.Drawing.Point(657, 126);
            this.chb_TESTPROGRAMS_IncSub.Name = "chb_TESTPROGRAMS_IncSub";
            this.chb_TESTPROGRAMS_IncSub.Size = new System.Drawing.Size(128, 19);
            this.chb_TESTPROGRAMS_IncSub.TabIndex = 16;
            this.chb_TESTPROGRAMS_IncSub.Text = "Include Subfolders";
            this.chb_TESTPROGRAMS_IncSub.UseVisualStyleBackColor = true;
            // 
            // btn_TestProgramsDestinationPathSelectDir
            // 
            this.btn_TestProgramsDestinationPathSelectDir.Location = new System.Drawing.Point(752, 90);
            this.btn_TestProgramsDestinationPathSelectDir.Name = "btn_TestProgramsDestinationPathSelectDir";
            this.btn_TestProgramsDestinationPathSelectDir.Size = new System.Drawing.Size(33, 23);
            this.btn_TestProgramsDestinationPathSelectDir.TabIndex = 5;
            this.btn_TestProgramsDestinationPathSelectDir.Text = "...";
            this.btn_TestProgramsDestinationPathSelectDir.UseVisualStyleBackColor = true;
            this.btn_TestProgramsDestinationPathSelectDir.Click += new System.EventHandler(this.btn_TestProgramsDestinationPathSelectDir_Click);
            // 
            // tb_TestProgramsDestinationPath
            // 
            this.tb_TestProgramsDestinationPath.Location = new System.Drawing.Point(9, 91);
            this.tb_TestProgramsDestinationPath.Name = "tb_TestProgramsDestinationPath";
            this.tb_TestProgramsDestinationPath.Size = new System.Drawing.Size(740, 21);
            this.tb_TestProgramsDestinationPath.TabIndex = 4;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 72);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(141, 15);
            this.label15.TabIndex = 3;
            this.label15.Text = "LOCAL Destination Path:";
            // 
            // btn_TestProgramsSourcePathSelectDir
            // 
            this.btn_TestProgramsSourcePathSelectDir.Location = new System.Drawing.Point(752, 40);
            this.btn_TestProgramsSourcePathSelectDir.Name = "btn_TestProgramsSourcePathSelectDir";
            this.btn_TestProgramsSourcePathSelectDir.Size = new System.Drawing.Size(33, 23);
            this.btn_TestProgramsSourcePathSelectDir.TabIndex = 2;
            this.btn_TestProgramsSourcePathSelectDir.Text = "...";
            this.btn_TestProgramsSourcePathSelectDir.UseVisualStyleBackColor = true;
            this.btn_TestProgramsSourcePathSelectDir.Click += new System.EventHandler(this.btn_TestProgramsSourcePathSelectDir_Click);
            // 
            // tb_TestProgramsSourcePath
            // 
            this.tb_TestProgramsSourcePath.Location = new System.Drawing.Point(9, 41);
            this.tb_TestProgramsSourcePath.Name = "tb_TestProgramsSourcePath";
            this.tb_TestProgramsSourcePath.Size = new System.Drawing.Size(740, 21);
            this.tb_TestProgramsSourcePath.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(141, 15);
            this.label16.TabIndex = 0;
            this.label16.Text = "NETWORK Source Path:";
            // 
            // tp_BelMes
            // 
            this.tp_BelMes.Controls.Add(this.chB_BelMESDisable);
            this.tp_BelMes.Controls.Add(this.gb_BelMES);
            this.tp_BelMes.Location = new System.Drawing.Point(4, 24);
            this.tp_BelMes.Name = "tp_BelMes";
            this.tp_BelMes.Padding = new System.Windows.Forms.Padding(3);
            this.tp_BelMes.Size = new System.Drawing.Size(808, 258);
            this.tp_BelMes.TabIndex = 8;
            this.tp_BelMes.Text = "BelMES (DLL, INI)";
            this.tp_BelMes.UseVisualStyleBackColor = true;
            // 
            // chB_BelMESDisable
            // 
            this.chB_BelMESDisable.AutoSize = true;
            this.chB_BelMESDisable.Location = new System.Drawing.Point(7, 173);
            this.chB_BelMESDisable.Name = "chB_BelMESDisable";
            this.chB_BelMESDisable.Size = new System.Drawing.Size(68, 19);
            this.chB_BelMESDisable.TabIndex = 10;
            this.chB_BelMESDisable.Text = "Disable";
            this.chB_BelMESDisable.UseVisualStyleBackColor = true;
            this.chB_BelMESDisable.CheckedChanged += new System.EventHandler(this.chB_BelMESDisable_CheckedChanged);
            // 
            // gb_BelMES
            // 
            this.gb_BelMES.Controls.Add(this.chb_BELMES_IncSub);
            this.gb_BelMES.Controls.Add(this.btn_BelMESDestinationPathSelectDir);
            this.gb_BelMES.Controls.Add(this.tb_BelMESDestinationPath);
            this.gb_BelMES.Controls.Add(this.label19);
            this.gb_BelMES.Controls.Add(this.btn_BelMESSourcePathSelectDir);
            this.gb_BelMES.Controls.Add(this.tb_BelMESSourcePath);
            this.gb_BelMES.Controls.Add(this.label20);
            this.gb_BelMES.Location = new System.Drawing.Point(7, 7);
            this.gb_BelMES.Name = "gb_BelMES";
            this.gb_BelMES.Size = new System.Drawing.Size(794, 160);
            this.gb_BelMES.TabIndex = 9;
            this.gb_BelMES.TabStop = false;
            this.gb_BelMES.Text = "BelMES: (imports all DLL and INI files)";
            // 
            // chb_BELMES_IncSub
            // 
            this.chb_BELMES_IncSub.AutoSize = true;
            this.chb_BELMES_IncSub.Location = new System.Drawing.Point(657, 126);
            this.chb_BELMES_IncSub.Name = "chb_BELMES_IncSub";
            this.chb_BELMES_IncSub.Size = new System.Drawing.Size(128, 19);
            this.chb_BELMES_IncSub.TabIndex = 17;
            this.chb_BELMES_IncSub.Text = "Include Subfolders";
            this.chb_BELMES_IncSub.UseVisualStyleBackColor = true;
            // 
            // btn_BelMESDestinationPathSelectDir
            // 
            this.btn_BelMESDestinationPathSelectDir.Location = new System.Drawing.Point(752, 90);
            this.btn_BelMESDestinationPathSelectDir.Name = "btn_BelMESDestinationPathSelectDir";
            this.btn_BelMESDestinationPathSelectDir.Size = new System.Drawing.Size(33, 23);
            this.btn_BelMESDestinationPathSelectDir.TabIndex = 5;
            this.btn_BelMESDestinationPathSelectDir.Text = "...";
            this.btn_BelMESDestinationPathSelectDir.UseVisualStyleBackColor = true;
            this.btn_BelMESDestinationPathSelectDir.Click += new System.EventHandler(this.btn_BelMESDestinationPathSelectDir_Click);
            // 
            // tb_BelMESDestinationPath
            // 
            this.tb_BelMESDestinationPath.Location = new System.Drawing.Point(9, 91);
            this.tb_BelMESDestinationPath.Name = "tb_BelMESDestinationPath";
            this.tb_BelMESDestinationPath.Size = new System.Drawing.Size(740, 21);
            this.tb_BelMESDestinationPath.TabIndex = 4;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 72);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(141, 15);
            this.label19.TabIndex = 3;
            this.label19.Text = "LOCAL Destination Path:";
            // 
            // btn_BelMESSourcePathSelectDir
            // 
            this.btn_BelMESSourcePathSelectDir.Location = new System.Drawing.Point(752, 40);
            this.btn_BelMESSourcePathSelectDir.Name = "btn_BelMESSourcePathSelectDir";
            this.btn_BelMESSourcePathSelectDir.Size = new System.Drawing.Size(33, 23);
            this.btn_BelMESSourcePathSelectDir.TabIndex = 2;
            this.btn_BelMESSourcePathSelectDir.Text = "...";
            this.btn_BelMESSourcePathSelectDir.UseVisualStyleBackColor = true;
            this.btn_BelMESSourcePathSelectDir.Click += new System.EventHandler(this.btn_BelMESSourcePathSelectDir_Click);
            // 
            // tb_BelMESSourcePath
            // 
            this.tb_BelMESSourcePath.Location = new System.Drawing.Point(9, 41);
            this.tb_BelMESSourcePath.Name = "tb_BelMESSourcePath";
            this.tb_BelMESSourcePath.Size = new System.Drawing.Size(740, 21);
            this.tb_BelMESSourcePath.TabIndex = 1;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 22);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(141, 15);
            this.label20.TabIndex = 0;
            this.label20.Text = "NETWORK Source Path:";
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(709, 434);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(123, 34);
            this.btn_Close.TabIndex = 3;
            this.btn_Close.Text = "CLOSE";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_ImportAll
            // 
            this.btn_ImportAll.Location = new System.Drawing.Point(580, 434);
            this.btn_ImportAll.Name = "btn_ImportAll";
            this.btn_ImportAll.Size = new System.Drawing.Size(123, 34);
            this.btn_ImportAll.TabIndex = 4;
            this.btn_ImportAll.Text = "IMPORT ALL";
            this.btn_ImportAll.UseVisualStyleBackColor = true;
            this.btn_ImportAll.Click += new System.EventHandler(this.btn_ImportAll_Click);
            // 
            // timer_Main
            // 
            this.timer_Main.Interval = 120000;
            this.timer_Main.Tick += new System.EventHandler(this.MainTimer_Tick);
            // 
            // timer_XML
            // 
            this.timer_XML.Tick += new System.EventHandler(this.timer_XML_Tick);
            // 
            // timer_HTML
            // 
            this.timer_HTML.Tick += new System.EventHandler(this.timer_HTML_Tick);
            // 
            // btn_SaveAll
            // 
            this.btn_SaveAll.Location = new System.Drawing.Point(16, 434);
            this.btn_SaveAll.Name = "btn_SaveAll";
            this.btn_SaveAll.Size = new System.Drawing.Size(558, 34);
            this.btn_SaveAll.TabIndex = 5;
            this.btn_SaveAll.Text = "SAVE ALL";
            this.btn_SaveAll.UseVisualStyleBackColor = true;
            this.btn_SaveAll.Click += new System.EventHandler(this.btn_SaveAll_Click);
            // 
            // showHideExportNotificationsToolStripMenuItem
            // 
            this.showHideExportNotificationsToolStripMenuItem.Name = "showHideExportNotificationsToolStripMenuItem";
            this.showHideExportNotificationsToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.showHideExportNotificationsToolStripMenuItem.Text = "Show/Hide Export Notifications";
            this.showHideExportNotificationsToolStripMenuItem.Click += new System.EventHandler(this.showHideExportNotificationsToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 480);
            this.Controls.Add(this.btn_SaveAll);
            this.Controls.Add(this.btn_ImportAll);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.tc_Main);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Export Import";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.cms_MainMenuTray.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tc_Main.ResumeLayout(false);
            this.tp_XML.ResumeLayout(false);
            this.tp_XML.PerformLayout();
            this.gb_XML.ResumeLayout(false);
            this.gb_XML.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_XML)).EndInit();
            this.tp_HTML.ResumeLayout(false);
            this.tp_HTML.PerformLayout();
            this.gb_HTML.ResumeLayout(false);
            this.gb_HTML.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_HTML)).EndInit();
            this.tp_Types.ResumeLayout(false);
            this.tp_Types.PerformLayout();
            this.gb_Types.ResumeLayout(false);
            this.gb_Types.PerformLayout();
            this.tp_Testmodules.ResumeLayout(false);
            this.tp_Testmodules.PerformLayout();
            this.gb_Testmodules.ResumeLayout(false);
            this.gb_Testmodules.PerformLayout();
            this.tp_Users.ResumeLayout(false);
            this.tp_Users.PerformLayout();
            this.gb_Users.ResumeLayout(false);
            this.gb_Users.PerformLayout();
            this.tp_Configs.ResumeLayout(false);
            this.tp_Configs.PerformLayout();
            this.gb_Configs.ResumeLayout(false);
            this.gb_Configs.PerformLayout();
            this.tp_Models.ResumeLayout(false);
            this.tp_Models.PerformLayout();
            this.gb_Models.ResumeLayout(false);
            this.gb_Models.PerformLayout();
            this.tp_TestPrograms.ResumeLayout(false);
            this.tp_TestPrograms.PerformLayout();
            this.gb_TestPrograms.ResumeLayout(false);
            this.gb_TestPrograms.PerformLayout();
            this.tp_BelMes.ResumeLayout(false);
            this.tp_BelMes.PerformLayout();
            this.gb_BelMES.ResumeLayout(false);
            this.gb_BelMES.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon TrayIcon;
        private System.Windows.Forms.ContextMenuStrip cms_MainMenuTray;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tc_Main;
        private System.Windows.Forms.TabPage tp_XML;
        private System.Windows.Forms.TabPage tp_HTML;
        private System.Windows.Forms.TabPage tp_Types;
        private System.Windows.Forms.TabPage tp_Testmodules;
        private System.Windows.Forms.TabPage tp_Users;
        private System.Windows.Forms.TabPage tp_Configs;
        private System.Windows.Forms.TabPage tp_Models;
        private System.Windows.Forms.TabPage tp_TestPrograms;
        private System.Windows.Forms.GroupBox gb_XML;
        private System.Windows.Forms.Button btn_XmlSourcePathSelectDir;
        private System.Windows.Forms.TextBox tb_XmlSourcePath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_XmlDestinationPathSelectDir;
        private System.Windows.Forms.TextBox tb_XmlDestinationPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gb_HTML;
        private System.Windows.Forms.Button btn_HtmlSourcePathSelectDir;
        private System.Windows.Forms.TextBox tb_HtmlSourcePath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_HtmlDestinationPathSelectDir;
        private System.Windows.Forms.TextBox tb_HtmlDestinationPath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gb_Types;
        private System.Windows.Forms.Button btn_TypesSourcePathSelectDir;
        private System.Windows.Forms.TextBox tb_TypesSourcePath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_TypesDestinationPathSelectDir;
        private System.Windows.Forms.TextBox tb_TypesDestinationPath;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gb_Testmodules;
        private System.Windows.Forms.Button btn_TestmodulesDestinationPathSelectDir;
        private System.Windows.Forms.TextBox tb_TestmodulesDestinationPath;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_TestmodulesSourcePathSelectDir;
        private System.Windows.Forms.TextBox tb_TestmodulesSourcePath;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_ImportAll;
        private System.Windows.Forms.GroupBox gb_Users;
        private System.Windows.Forms.Button btn_UsersDestinationPathSelectDir;
        private System.Windows.Forms.TextBox tb_UsersDestinationPath;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_UsersSourcePathSelectDir;
        private System.Windows.Forms.TextBox tb_UsersSourcePath;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox gb_Configs;
        private System.Windows.Forms.Button btn_ConfigsDestinationPathSelectDir;
        private System.Windows.Forms.TextBox tb_ConfigsDestinationPath;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_ConfigsSourcePathSelectDir;
        private System.Windows.Forms.TextBox tb_ConfigsSourcePath;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox gb_Models;
        private System.Windows.Forms.Button btn_ModelsDestinationPathSelectDir;
        private System.Windows.Forms.TextBox tb_ModelsDestinationPath;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btn_ModelsSourcePathSelectDir;
        private System.Windows.Forms.TextBox tb_ModelsSourcePath;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox gb_TestPrograms;
        private System.Windows.Forms.Button btn_TestProgramsDestinationPathSelectDir;
        private System.Windows.Forms.TextBox tb_TestProgramsDestinationPath;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btn_TestProgramsSourcePathSelectDir;
        private System.Windows.Forms.TextBox tb_TestProgramsSourcePath;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Timer timer_Main;
        private System.Windows.Forms.Timer timer_XML;
        private System.Windows.Forms.Timer timer_HTML;
        private System.Windows.Forms.NumericUpDown nud_XML;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btn_SaveAll;
        private System.Windows.Forms.NumericUpDown nud_HTML;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.CheckBox chB_XMLDisable;
        private System.Windows.Forms.CheckBox chB_HTMLDisable;
        private System.Windows.Forms.CheckBox chB_TypesDisable;
        private System.Windows.Forms.CheckBox chB_TestmodulesDisable;
        private System.Windows.Forms.CheckBox chB_UsersDisable;
        private System.Windows.Forms.CheckBox chB_ConfigsDisable;
        private System.Windows.Forms.CheckBox chB_ModelsDisable;
        private System.Windows.Forms.CheckBox chB_TestProgramsDisable;
        private System.Windows.Forms.TabPage tp_BelMes;
        private System.Windows.Forms.CheckBox chB_BelMESDisable;
        private System.Windows.Forms.GroupBox gb_BelMES;
        private System.Windows.Forms.Button btn_BelMESDestinationPathSelectDir;
        private System.Windows.Forms.TextBox tb_BelMESDestinationPath;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btn_BelMESSourcePathSelectDir;
        private System.Windows.Forms.TextBox tb_BelMESSourcePath;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.CheckBox chb_XML_IncSub;
        private System.Windows.Forms.CheckBox chb_HTML_IncSub;
        private System.Windows.Forms.CheckBox chb_TYPES_IncSub;
        private System.Windows.Forms.CheckBox chb_TESTMODULES_IncSub;
        private System.Windows.Forms.CheckBox chb_USERS_IncSub;
        private System.Windows.Forms.CheckBox chb_CONFIGS_IncSub;
        private System.Windows.Forms.CheckBox chb_MODELS_IncSub;
        private System.Windows.Forms.CheckBox chb_TESTPROGRAMS_IncSub;
        private System.Windows.Forms.CheckBox chb_BELMES_IncSub;
        private System.Windows.Forms.ToolStripMenuItem showHideNotificationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showHideExportNotificationsToolStripMenuItem;
    }
}

