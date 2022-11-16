namespace Code_editor
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.titleBar = new System.Windows.Forms.Panel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFolderMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rtbxCode = new System.Windows.Forms.RichTextBox();
            this.pnlBigWrapper = new System.Windows.Forms.Panel();
            this.pnlCodeWrapper = new System.Windows.Forms.Panel();
            this.pnlCode = new System.Windows.Forms.Panel();
            this.pnlLineNumbers = new System.Windows.Forms.Panel();
            this.lblLineNumbers = new System.Windows.Forms.Label();
            this.flpCodeTabs = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlFileHeader = new System.Windows.Forms.Panel();
            this.tbxFileName = new System.Windows.Forms.TextBox();
            this.btnCloseFile = new System.Windows.Forms.Button();
            this.lblNotSaved = new System.Windows.Forms.Label();
            this.flpNoProject = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNoTreeChooseFolder = new System.Windows.Forms.Button();
            this.btnNoTreeNewFile = new System.Windows.Forms.Button();
            this.pnlFolderHeader = new System.Windows.Forms.Panel();
            this.flpProjectButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddProjectFile = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnAddProjectFolder = new System.Windows.Forms.Button();
            this.lblProjectName = new System.Windows.Forms.Label();
            this.tvwProject = new System.Windows.Forms.TreeView();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnProjectToggle = new System.Windows.Forms.Button();
            this.flpProject = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlProjectTop = new System.Windows.Forms.Panel();
            this.pnlProjectTree = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.titleBar.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlBigWrapper.SuspendLayout();
            this.pnlCodeWrapper.SuspendLayout();
            this.pnlCode.SuspendLayout();
            this.pnlLineNumbers.SuspendLayout();
            this.flpCodeTabs.SuspendLayout();
            this.pnlFileHeader.SuspendLayout();
            this.flpNoProject.SuspendLayout();
            this.pnlFolderHeader.SuspendLayout();
            this.flpProjectButtons.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            this.flpProject.SuspendLayout();
            this.pnlProjectTree.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.titleBar);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 40);
            this.panel1.TabIndex = 0;
            // 
            // titleBar
            // 
            this.titleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.titleBar.Controls.Add(this.menuStrip);
            this.titleBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleBar.Location = new System.Drawing.Point(60, 0);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(1040, 40);
            this.titleBar.TabIndex = 7;
            this.titleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleBar_MouseDown);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(15, 8, 15, 8);
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip.Size = new System.Drawing.Size(116, 42);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            this.menuStrip.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleBar_MouseDown);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFileMenuItem,
            this.openFileMenuItem,
            this.openFolderMenuItem,
            this.saveMenuItem,
            this.saveAsMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(41, 26);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newFileMenuItem
            // 
            this.newFileMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.newFileMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.newFileMenuItem.ForeColor = System.Drawing.Color.White;
            this.newFileMenuItem.Name = "newFileMenuItem";
            this.newFileMenuItem.Size = new System.Drawing.Size(151, 26);
            this.newFileMenuItem.Text = "New File";
            this.newFileMenuItem.Click += new System.EventHandler(this.newFileMenuItem_Click);
            // 
            // openFileMenuItem
            // 
            this.openFileMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.openFileMenuItem.ForeColor = System.Drawing.Color.White;
            this.openFileMenuItem.Name = "openFileMenuItem";
            this.openFileMenuItem.Size = new System.Drawing.Size(151, 26);
            this.openFileMenuItem.Text = "Open File";
            this.openFileMenuItem.Click += new System.EventHandler(this.openFileMenuItem_Click);
            // 
            // openFolderMenuItem
            // 
            this.openFolderMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.openFolderMenuItem.ForeColor = System.Drawing.Color.White;
            this.openFolderMenuItem.Name = "openFolderMenuItem";
            this.openFolderMenuItem.Size = new System.Drawing.Size(151, 26);
            this.openFolderMenuItem.Text = "Open Folder";
            this.openFolderMenuItem.Click += new System.EventHandler(this.openFolderMenuItem_Click);
            // 
            // saveMenuItem
            // 
            this.saveMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.saveMenuItem.ForeColor = System.Drawing.Color.White;
            this.saveMenuItem.Name = "saveMenuItem";
            this.saveMenuItem.Size = new System.Drawing.Size(151, 26);
            this.saveMenuItem.Text = "Save";
            this.saveMenuItem.Click += new System.EventHandler(this.saveMenuItem_Click);
            // 
            // saveAsMenuItem
            // 
            this.saveAsMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.saveAsMenuItem.ForeColor = System.Drawing.Color.White;
            this.saveAsMenuItem.Name = "saveAsMenuItem";
            this.saveAsMenuItem.Size = new System.Drawing.Size(151, 26);
            this.saveAsMenuItem.Text = "Save As";
            this.saveAsMenuItem.Click += new System.EventHandler(this.saveAsMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem});
            this.editToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(43, 26);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.undoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(112, 26);
            this.undoToolStripMenuItem.Text = "Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.redoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(112, 26);
            this.redoToolStripMenuItem.Text = "Redo";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnMinimize);
            this.flowLayoutPanel1.Controls.Add(this.btnMaximize);
            this.flowLayoutPanel1.Controls.Add(this.btnClose);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1100, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(180, 40);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // btnMinimize
            // 
            this.btnMinimize.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Poppins", 12F);
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(0, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnMinimize.Size = new System.Drawing.Size(60, 40);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.Text = "-";
            this.btnMinimize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Font = new System.Drawing.Font("Poppins", 12F);
            this.btnMaximize.ForeColor = System.Drawing.Color.White;
            this.btnMaximize.Location = new System.Drawing.Point(60, 0);
            this.btnMaximize.Margin = new System.Windows.Forms.Padding(0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnMaximize.Size = new System.Drawing.Size(60, 40);
            this.btnMaximize.TabIndex = 3;
            this.btnMaximize.Text = "🗖";
            this.btnMaximize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Poppins", 12F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(120, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.btnClose.Size = new System.Drawing.Size(60, 40);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "X";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(60, 40);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Code_editor.Properties.Resources.Rityta_10;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // rtbxCode
            // 
            this.rtbxCode.AcceptsTab = true;
            this.rtbxCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.rtbxCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbxCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbxCode.Font = new System.Drawing.Font("Poppins", 12F);
            this.rtbxCode.ForeColor = System.Drawing.Color.LightBlue;
            this.rtbxCode.Location = new System.Drawing.Point(0, 0);
            this.rtbxCode.Margin = new System.Windows.Forms.Padding(25);
            this.rtbxCode.Name = "rtbxCode";
            this.rtbxCode.Size = new System.Drawing.Size(845, 580);
            this.rtbxCode.TabIndex = 0;
            this.rtbxCode.Text = "";
            this.rtbxCode.Visible = false;
            this.rtbxCode.TextChanged += new System.EventHandler(this.rtbxCode_TextChanged);
            this.rtbxCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtbxCode_KeyDown);
            this.rtbxCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtbxCode_KeyPress);
            // 
            // pnlBigWrapper
            // 
            this.pnlBigWrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.pnlBigWrapper.Controls.Add(this.pnlCodeWrapper);
            this.pnlBigWrapper.Controls.Add(this.flpCodeTabs);
            this.pnlBigWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBigWrapper.Location = new System.Drawing.Point(360, 40);
            this.pnlBigWrapper.Name = "pnlBigWrapper";
            this.pnlBigWrapper.Size = new System.Drawing.Size(920, 680);
            this.pnlBigWrapper.TabIndex = 2;
            // 
            // pnlCodeWrapper
            // 
            this.pnlCodeWrapper.Controls.Add(this.pnlCode);
            this.pnlCodeWrapper.Controls.Add(this.pnlLineNumbers);
            this.pnlCodeWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCodeWrapper.Location = new System.Drawing.Point(0, 50);
            this.pnlCodeWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.pnlCodeWrapper.Name = "pnlCodeWrapper";
            this.pnlCodeWrapper.Padding = new System.Windows.Forms.Padding(0, 25, 25, 25);
            this.pnlCodeWrapper.Size = new System.Drawing.Size(920, 630);
            this.pnlCodeWrapper.TabIndex = 4;
            // 
            // pnlCode
            // 
            this.pnlCode.Controls.Add(this.rtbxCode);
            this.pnlCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCode.Location = new System.Drawing.Point(50, 25);
            this.pnlCode.Name = "pnlCode";
            this.pnlCode.Size = new System.Drawing.Size(845, 580);
            this.pnlCode.TabIndex = 3;
            // 
            // pnlLineNumbers
            // 
            this.pnlLineNumbers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.pnlLineNumbers.Controls.Add(this.lblLineNumbers);
            this.pnlLineNumbers.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLineNumbers.ForeColor = System.Drawing.Color.DarkGray;
            this.pnlLineNumbers.Location = new System.Drawing.Point(0, 25);
            this.pnlLineNumbers.Margin = new System.Windows.Forms.Padding(0);
            this.pnlLineNumbers.Name = "pnlLineNumbers";
            this.pnlLineNumbers.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.pnlLineNumbers.Size = new System.Drawing.Size(50, 580);
            this.pnlLineNumbers.TabIndex = 2;
            // 
            // lblLineNumbers
            // 
            this.lblLineNumbers.AutoSize = true;
            this.lblLineNumbers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLineNumbers.Location = new System.Drawing.Point(15, 0);
            this.lblLineNumbers.Name = "lblLineNumbers";
            this.lblLineNumbers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblLineNumbers.Size = new System.Drawing.Size(0, 28);
            this.lblLineNumbers.TabIndex = 1;
            // 
            // flpCodeTabs
            // 
            this.flpCodeTabs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.flpCodeTabs.Controls.Add(this.pnlFileHeader);
            this.flpCodeTabs.Controls.Add(this.lblNotSaved);
            this.flpCodeTabs.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpCodeTabs.Location = new System.Drawing.Point(0, 0);
            this.flpCodeTabs.Name = "flpCodeTabs";
            this.flpCodeTabs.Size = new System.Drawing.Size(920, 50);
            this.flpCodeTabs.TabIndex = 3;
            this.flpCodeTabs.Visible = false;
            // 
            // pnlFileHeader
            // 
            this.pnlFileHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.pnlFileHeader.Controls.Add(this.tbxFileName);
            this.pnlFileHeader.Controls.Add(this.btnCloseFile);
            this.pnlFileHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlFileHeader.Margin = new System.Windows.Forms.Padding(0);
            this.pnlFileHeader.Name = "pnlFileHeader";
            this.pnlFileHeader.Size = new System.Drawing.Size(200, 50);
            this.pnlFileHeader.TabIndex = 0;
            // 
            // tbxFileName
            // 
            this.tbxFileName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.tbxFileName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxFileName.ForeColor = System.Drawing.Color.White;
            this.tbxFileName.Location = new System.Drawing.Point(15, 14);
            this.tbxFileName.Name = "tbxFileName";
            this.tbxFileName.Size = new System.Drawing.Size(142, 24);
            this.tbxFileName.TabIndex = 7;
            this.tbxFileName.Text = "script.cs";
            this.tbxFileName.TextChanged += new System.EventHandler(this.tbxFileName_TextChanged);
            // 
            // btnCloseFile
            // 
            this.btnCloseFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.btnCloseFile.FlatAppearance.BorderSize = 0;
            this.btnCloseFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCloseFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCloseFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseFile.Font = new System.Drawing.Font("Poppins", 12F);
            this.btnCloseFile.ForeColor = System.Drawing.Color.White;
            this.btnCloseFile.Location = new System.Drawing.Point(160, 10);
            this.btnCloseFile.Margin = new System.Windows.Forms.Padding(0);
            this.btnCloseFile.Name = "btnCloseFile";
            this.btnCloseFile.Size = new System.Drawing.Size(30, 30);
            this.btnCloseFile.TabIndex = 6;
            this.btnCloseFile.Text = "X";
            this.btnCloseFile.UseVisualStyleBackColor = false;
            this.btnCloseFile.Click += new System.EventHandler(this.btnCloseFile_Click);
            // 
            // lblNotSaved
            // 
            this.lblNotSaved.AutoSize = true;
            this.lblNotSaved.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblNotSaved.Font = new System.Drawing.Font("Poppins", 8F);
            this.lblNotSaved.ForeColor = System.Drawing.Color.LightGray;
            this.lblNotSaved.Location = new System.Drawing.Point(210, 0);
            this.lblNotSaved.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.lblNotSaved.Name = "lblNotSaved";
            this.lblNotSaved.Size = new System.Drawing.Size(67, 50);
            this.lblNotSaved.TabIndex = 1;
            this.lblNotSaved.Text = "Not Saved!";
            this.lblNotSaved.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNotSaved.Visible = false;
            // 
            // flpNoProject
            // 
            this.flpNoProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.flpNoProject.Controls.Add(this.label1);
            this.flpNoProject.Controls.Add(this.btnNoTreeChooseFolder);
            this.flpNoProject.Controls.Add(this.btnNoTreeNewFile);
            this.flpNoProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpNoProject.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpNoProject.Location = new System.Drawing.Point(0, 0);
            this.flpNoProject.Margin = new System.Windows.Forms.Padding(0);
            this.flpNoProject.Name = "flpNoProject";
            this.flpNoProject.Size = new System.Drawing.Size(300, 504);
            this.flpNoProject.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 10F);
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(57, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(57, 20, 57, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "You have no folder open";
            // 
            // btnNoTreeChooseFolder
            // 
            this.btnNoTreeChooseFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.btnNoTreeChooseFolder.ForeColor = System.Drawing.Color.White;
            this.btnNoTreeChooseFolder.Location = new System.Drawing.Point(50, 65);
            this.btnNoTreeChooseFolder.Margin = new System.Windows.Forms.Padding(50, 10, 50, 10);
            this.btnNoTreeChooseFolder.Name = "btnNoTreeChooseFolder";
            this.btnNoTreeChooseFolder.Size = new System.Drawing.Size(200, 40);
            this.btnNoTreeChooseFolder.TabIndex = 2;
            this.btnNoTreeChooseFolder.Text = "Open Folder";
            this.btnNoTreeChooseFolder.UseVisualStyleBackColor = false;
            this.btnNoTreeChooseFolder.Click += new System.EventHandler(this.btnNoTreeChooseFolder_Click);
            // 
            // btnNoTreeNewFile
            // 
            this.btnNoTreeNewFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.btnNoTreeNewFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNoTreeNewFile.FlatAppearance.BorderSize = 0;
            this.btnNoTreeNewFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.btnNoTreeNewFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.btnNoTreeNewFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNoTreeNewFile.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Underline);
            this.btnNoTreeNewFile.ForeColor = System.Drawing.Color.White;
            this.btnNoTreeNewFile.Location = new System.Drawing.Point(70, 125);
            this.btnNoTreeNewFile.Margin = new System.Windows.Forms.Padding(70, 10, 70, 10);
            this.btnNoTreeNewFile.Name = "btnNoTreeNewFile";
            this.btnNoTreeNewFile.Size = new System.Drawing.Size(160, 30);
            this.btnNoTreeNewFile.TabIndex = 5;
            this.btnNoTreeNewFile.Text = "Or create a new file";
            this.btnNoTreeNewFile.UseVisualStyleBackColor = false;
            this.btnNoTreeNewFile.Click += new System.EventHandler(this.btnNoTreeNewFile_Click);
            // 
            // pnlFolderHeader
            // 
            this.pnlFolderHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.pnlFolderHeader.Controls.Add(this.flpProjectButtons);
            this.pnlFolderHeader.Controls.Add(this.lblProjectName);
            this.pnlFolderHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFolderHeader.Location = new System.Drawing.Point(0, 50);
            this.pnlFolderHeader.Margin = new System.Windows.Forms.Padding(0);
            this.pnlFolderHeader.Name = "pnlFolderHeader";
            this.pnlFolderHeader.Size = new System.Drawing.Size(300, 30);
            this.pnlFolderHeader.TabIndex = 6;
            // 
            // flpProjectButtons
            // 
            this.flpProjectButtons.Controls.Add(this.btnAddProjectFile);
            this.flpProjectButtons.Controls.Add(this.btnAddProjectFolder);
            this.flpProjectButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this.flpProjectButtons.Location = new System.Drawing.Point(240, 0);
            this.flpProjectButtons.Margin = new System.Windows.Forms.Padding(70, 0, 0, 0);
            this.flpProjectButtons.Name = "flpProjectButtons";
            this.flpProjectButtons.Size = new System.Drawing.Size(60, 30);
            this.flpProjectButtons.TabIndex = 1;
            this.flpProjectButtons.Visible = false;
            // 
            // btnAddProjectFile
            // 
            this.btnAddProjectFile.FlatAppearance.BorderSize = 0;
            this.btnAddProjectFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProjectFile.ForeColor = System.Drawing.Color.White;
            this.btnAddProjectFile.ImageKey = "new-file.png";
            this.btnAddProjectFile.ImageList = this.imageList1;
            this.btnAddProjectFile.Location = new System.Drawing.Point(0, 0);
            this.btnAddProjectFile.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddProjectFile.Name = "btnAddProjectFile";
            this.btnAddProjectFile.Size = new System.Drawing.Size(30, 30);
            this.btnAddProjectFile.TabIndex = 0;
            this.btnAddProjectFile.UseVisualStyleBackColor = true;
            this.btnAddProjectFile.Click += new System.EventHandler(this.btnAddProjectFile_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "folder.png");
            this.imageList1.Images.SetKeyName(1, "open-folder.png");
            this.imageList1.Images.SetKeyName(2, "file.png");
            this.imageList1.Images.SetKeyName(3, "new-file.png");
            this.imageList1.Images.SetKeyName(4, "add-folder.png");
            // 
            // btnAddProjectFolder
            // 
            this.btnAddProjectFolder.FlatAppearance.BorderSize = 0;
            this.btnAddProjectFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProjectFolder.ForeColor = System.Drawing.Color.White;
            this.btnAddProjectFolder.ImageKey = "add-folder.png";
            this.btnAddProjectFolder.ImageList = this.imageList1;
            this.btnAddProjectFolder.Location = new System.Drawing.Point(30, 0);
            this.btnAddProjectFolder.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddProjectFolder.Name = "btnAddProjectFolder";
            this.btnAddProjectFolder.Size = new System.Drawing.Size(30, 30);
            this.btnAddProjectFolder.TabIndex = 1;
            this.btnAddProjectFolder.UseVisualStyleBackColor = true;
            this.btnAddProjectFolder.Click += new System.EventHandler(this.btnAddProjectFolder_Click);
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.Font = new System.Drawing.Font("Poppins", 10F);
            this.lblProjectName.ForeColor = System.Drawing.Color.White;
            this.lblProjectName.Location = new System.Drawing.Point(10, 5);
            this.lblProjectName.Margin = new System.Windows.Forms.Padding(10, 5, 10, 0);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(137, 25);
            this.lblProjectName.TabIndex = 0;
            this.lblProjectName.Text = "No Folder Opened";
            // 
            // tvwProject
            // 
            this.tvwProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.tvwProject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvwProject.ForeColor = System.Drawing.Color.White;
            this.tvwProject.ImageIndex = 0;
            this.tvwProject.ImageList = this.imageList1;
            this.tvwProject.Indent = 15;
            this.tvwProject.LineColor = System.Drawing.Color.DimGray;
            this.tvwProject.Location = new System.Drawing.Point(15, 20);
            this.tvwProject.Margin = new System.Windows.Forms.Padding(0);
            this.tvwProject.Name = "tvwProject";
            this.tvwProject.SelectedImageIndex = 0;
            this.tvwProject.ShowLines = false;
            this.tvwProject.ShowPlusMinus = false;
            this.tvwProject.ShowRootLines = false;
            this.tvwProject.Size = new System.Drawing.Size(270, 550);
            this.tvwProject.StateImageList = this.imageList1;
            this.tvwProject.TabIndex = 0;
            this.tvwProject.AfterCollapse += new System.Windows.Forms.TreeViewEventHandler(this.tvwProject_AfterCollapse);
            this.tvwProject.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.tvwProject_AfterExpand);
            this.tvwProject.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvwProject_MouseClick);
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.pnlSidebar.Controls.Add(this.btnProjectToggle);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 40);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(60, 680);
            this.pnlSidebar.TabIndex = 0;
            // 
            // btnProjectToggle
            // 
            this.btnProjectToggle.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProjectToggle.FlatAppearance.BorderSize = 0;
            this.btnProjectToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProjectToggle.Font = new System.Drawing.Font("Poppins", 16F);
            this.btnProjectToggle.Location = new System.Drawing.Point(0, 0);
            this.btnProjectToggle.Name = "btnProjectToggle";
            this.btnProjectToggle.Size = new System.Drawing.Size(60, 60);
            this.btnProjectToggle.TabIndex = 0;
            this.btnProjectToggle.Text = "=";
            this.btnProjectToggle.UseVisualStyleBackColor = true;
            this.btnProjectToggle.Click += new System.EventHandler(this.btnProjectToggle_Click);
            // 
            // flpProject
            // 
            this.flpProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.flpProject.Controls.Add(this.pnlProjectTop);
            this.flpProject.Controls.Add(this.pnlFolderHeader);
            this.flpProject.Controls.Add(this.pnlProjectTree);
            this.flpProject.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpProject.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpProject.Location = new System.Drawing.Point(60, 40);
            this.flpProject.Margin = new System.Windows.Forms.Padding(0);
            this.flpProject.Name = "flpProject";
            this.flpProject.Size = new System.Drawing.Size(300, 680);
            this.flpProject.TabIndex = 4;
            // 
            // pnlProjectTop
            // 
            this.pnlProjectTop.Location = new System.Drawing.Point(0, 0);
            this.pnlProjectTop.Margin = new System.Windows.Forms.Padding(0);
            this.pnlProjectTop.Name = "pnlProjectTop";
            this.pnlProjectTop.Size = new System.Drawing.Size(300, 50);
            this.pnlProjectTop.TabIndex = 1;
            // 
            // pnlProjectTree
            // 
            this.pnlProjectTree.Controls.Add(this.flpNoProject);
            this.pnlProjectTree.Controls.Add(this.tvwProject);
            this.pnlProjectTree.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlProjectTree.Location = new System.Drawing.Point(0, 80);
            this.pnlProjectTree.Margin = new System.Windows.Forms.Padding(0);
            this.pnlProjectTree.Name = "pnlProjectTree";
            this.pnlProjectTree.Size = new System.Drawing.Size(300, 504);
            this.pnlProjectTree.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.pnlBigWrapper);
            this.Controls.Add(this.flpProject);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximumSize = new System.Drawing.Size(2560, 1440);
            this.Name = "Form1";
            this.Text = "Code Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.titleBar.ResumeLayout(false);
            this.titleBar.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlBigWrapper.ResumeLayout(false);
            this.pnlCodeWrapper.ResumeLayout(false);
            this.pnlCode.ResumeLayout(false);
            this.pnlLineNumbers.ResumeLayout(false);
            this.pnlLineNumbers.PerformLayout();
            this.flpCodeTabs.ResumeLayout(false);
            this.flpCodeTabs.PerformLayout();
            this.pnlFileHeader.ResumeLayout(false);
            this.pnlFileHeader.PerformLayout();
            this.flpNoProject.ResumeLayout(false);
            this.flpNoProject.PerformLayout();
            this.pnlFolderHeader.ResumeLayout(false);
            this.pnlFolderHeader.PerformLayout();
            this.flpProjectButtons.ResumeLayout(false);
            this.pnlSidebar.ResumeLayout(false);
            this.flpProject.ResumeLayout(false);
            this.pnlProjectTree.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel titleBar;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newFileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFolderMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.RichTextBox rtbxCode;
        private System.Windows.Forms.Panel pnlBigWrapper;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.TreeView tvwProject;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.FlowLayoutPanel flpCodeTabs;
        private System.Windows.Forms.Panel pnlFileHeader;
        private System.Windows.Forms.Button btnCloseFile;
        private System.Windows.Forms.Label lblNotSaved;
        private System.Windows.Forms.FlowLayoutPanel flpNoProject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNoTreeChooseFolder;
        private System.Windows.Forms.Button btnNoTreeNewFile;
        private System.Windows.Forms.FlowLayoutPanel flpProject;
        private System.Windows.Forms.Panel pnlProjectTop;
        private System.Windows.Forms.Panel pnlProjectTree;
        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.FlowLayoutPanel flpProjectButtons;
        private System.Windows.Forms.Button btnAddProjectFile;
        private System.Windows.Forms.Button btnAddProjectFolder;
        private System.Windows.Forms.Panel pnlCodeWrapper;
        private System.Windows.Forms.Panel pnlFolderHeader;
        private System.Windows.Forms.Panel pnlCode;
        private System.Windows.Forms.Panel pnlLineNumbers;
        private System.Windows.Forms.Label lblLineNumbers;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnProjectToggle;
        private System.Windows.Forms.TextBox tbxFileName;
    }
}

