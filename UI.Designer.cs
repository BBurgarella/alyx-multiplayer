
namespace alyx_multiplayer
{
    partial class UI
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
            System.Windows.Forms.ToolStripStatusLabel labelHeader;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI));
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxLog = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelLog = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.checkBoxIsServer = new System.Windows.Forms.CheckBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.labelClientPort = new System.Windows.Forms.Label();
            this.textBoxClientPort = new System.Windows.Forms.TextBox();
            this.buttonClientPort = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.labelClientIp = new System.Windows.Forms.Label();
            this.textBoxClientIP = new System.Windows.Forms.TextBox();
            this.buttonClientIP = new System.Windows.Forms.Button();
            this.buttonEntSearch = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.labelServerPort = new System.Windows.Forms.Label();
            this.textBoxServerPort = new System.Windows.Forms.TextBox();
            this.buttonServerPort = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.labelPath = new System.Windows.Forms.Label();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.buttonPath = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelOptions = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.tempToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemConsole = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.labelVersionNumber = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelIP = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTipIP = new System.Windows.Forms.ToolTip(this.components);
            this.panel9 = new System.Windows.Forms.Panel();
            this.labelServerIp = new System.Windows.Forms.Label();
            this.textBoxServerIp = new System.Windows.Forms.TextBox();
            this.buttonServerIp = new System.Windows.Forms.Button();
            labelHeader = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelHeader
            // 
            labelHeader.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            labelHeader.Margin = new System.Windows.Forms.Padding(3, 3, 0, 2);
            labelHeader.Name = "labelHeader";
            labelHeader.Size = new System.Drawing.Size(36, 24);
            labelHeader.Text = "  IP:";
            // 
            // splitContainer
            // 
            this.splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer.Location = new System.Drawing.Point(0, 30);
            this.splitContainer.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.panel3);
            this.splitContainer.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.panel4);
            this.splitContainer.Panel2.Controls.Add(this.panel2);
            this.splitContainer.Size = new System.Drawing.Size(1580, 868);
            this.splitContainer.SplitterDistance = 522;
            this.splitContainer.SplitterWidth = 5;
            this.splitContainer.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBoxLog);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 16);
            this.panel3.Margin = new System.Windows.Forms.Padding(0, 0, 0, 25);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(522, 852);
            this.panel3.TabIndex = 3;
            // 
            // textBoxLog
            // 
            this.textBoxLog.BackColor = System.Drawing.Color.Black;
            this.textBoxLog.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxLog.ForeColor = System.Drawing.Color.White;
            this.textBoxLog.Location = new System.Drawing.Point(0, 0);
            this.textBoxLog.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ReadOnly = true;
            this.textBoxLog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.textBoxLog.Size = new System.Drawing.Size(522, 852);
            this.textBoxLog.TabIndex = 1;
            this.textBoxLog.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelLog);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(522, 16);
            this.panel1.TabIndex = 2;
            // 
            // labelLog
            // 
            this.labelLog.AutoSize = true;
            this.labelLog.Location = new System.Drawing.Point(8, 0);
            this.labelLog.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLog.Name = "labelLog";
            this.labelLog.Size = new System.Drawing.Size(30, 16);
            this.labelLog.TabIndex = 0;
            this.labelLog.Text = "Log";
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.Controls.Add(this.panel9);
            this.panel4.Controls.Add(this.checkBoxIsServer);
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.buttonEntSearch);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 16);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1053, 852);
            this.panel4.TabIndex = 4;
            // 
            // checkBoxIsServer
            // 
            this.checkBoxIsServer.AutoSize = true;
            this.checkBoxIsServer.Location = new System.Drawing.Point(6, 197);
            this.checkBoxIsServer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxIsServer.Name = "checkBoxIsServer";
            this.checkBoxIsServer.Size = new System.Drawing.Size(95, 20);
            this.checkBoxIsServer.TabIndex = 6;
            this.checkBoxIsServer.Text = "I am server";
            this.checkBoxIsServer.UseVisualStyleBackColor = true;
            this.checkBoxIsServer.CheckedChanged += new System.EventHandler(this.checkBoxIsServer_CheckedChanged);
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.Controls.Add(this.labelClientPort);
            this.panel8.Controls.Add(this.textBoxClientPort);
            this.panel8.Controls.Add(this.buttonClientPort);
            this.panel8.Location = new System.Drawing.Point(0, 143);
            this.panel8.Margin = new System.Windows.Forms.Padding(0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1053, 32);
            this.panel8.TabIndex = 5;
            // 
            // labelClientPort
            // 
            this.labelClientPort.AutoSize = true;
            this.labelClientPort.Location = new System.Drawing.Point(3, 7);
            this.labelClientPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelClientPort.Name = "labelClientPort";
            this.labelClientPort.Size = new System.Drawing.Size(69, 16);
            this.labelClientPort.TabIndex = 2;
            this.labelClientPort.Text = "Client port:";
            // 
            // textBoxClientPort
            // 
            this.textBoxClientPort.Location = new System.Drawing.Point(144, 4);
            this.textBoxClientPort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxClientPort.Name = "textBoxClientPort";
            this.textBoxClientPort.Size = new System.Drawing.Size(392, 22);
            this.textBoxClientPort.TabIndex = 2;
            this.textBoxClientPort.Text = "6655";
            this.textBoxClientPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPeerPort_KeyPress);
            // 
            // buttonClientPort
            // 
            this.buttonClientPort.Location = new System.Drawing.Point(545, 1);
            this.buttonClientPort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonClientPort.MaximumSize = new System.Drawing.Size(100, 28);
            this.buttonClientPort.MinimumSize = new System.Drawing.Size(100, 28);
            this.buttonClientPort.Name = "buttonClientPort";
            this.buttonClientPort.Size = new System.Drawing.Size(100, 28);
            this.buttonClientPort.TabIndex = 3;
            this.buttonClientPort.Text = "Submit";
            this.buttonClientPort.UseVisualStyleBackColor = true;
            this.buttonClientPort.Click += new System.EventHandler(this.buttonPeerPort_Click);
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.Controls.Add(this.labelClientIp);
            this.panel7.Controls.Add(this.textBoxClientIP);
            this.panel7.Controls.Add(this.buttonClientIP);
            this.panel7.Location = new System.Drawing.Point(0, 110);
            this.panel7.Margin = new System.Windows.Forms.Padding(0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1053, 32);
            this.panel7.TabIndex = 4;
            // 
            // labelClientIp
            // 
            this.labelClientIp.AutoSize = true;
            this.labelClientIp.Location = new System.Drawing.Point(3, 7);
            this.labelClientIp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelClientIp.Name = "labelClientIp";
            this.labelClientIp.Size = new System.Drawing.Size(58, 16);
            this.labelClientIp.TabIndex = 2;
            this.labelClientIp.Text = "Client IP:";
            // 
            // textBoxClientIP
            // 
            this.textBoxClientIP.Location = new System.Drawing.Point(144, 4);
            this.textBoxClientIP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxClientIP.Name = "textBoxClientIP";
            this.textBoxClientIP.Size = new System.Drawing.Size(392, 22);
            this.textBoxClientIP.TabIndex = 2;
            this.textBoxClientIP.Text = "127.0.0.1";
            this.textBoxClientIP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPeerIP_KeyPress);
            // 
            // buttonClientIP
            // 
            this.buttonClientIP.Location = new System.Drawing.Point(545, 1);
            this.buttonClientIP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonClientIP.MaximumSize = new System.Drawing.Size(100, 28);
            this.buttonClientIP.MinimumSize = new System.Drawing.Size(100, 28);
            this.buttonClientIP.Name = "buttonClientIP";
            this.buttonClientIP.Size = new System.Drawing.Size(100, 28);
            this.buttonClientIP.TabIndex = 3;
            this.buttonClientIP.Text = "Submit";
            this.buttonClientIP.UseVisualStyleBackColor = true;
            this.buttonClientIP.Click += new System.EventHandler(this.buttonPeerIP_Click);
            // 
            // buttonEntSearch
            // 
            this.buttonEntSearch.Location = new System.Drawing.Point(6, 239);
            this.buttonEntSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonEntSearch.MaximumSize = new System.Drawing.Size(147, 28);
            this.buttonEntSearch.MinimumSize = new System.Drawing.Size(147, 28);
            this.buttonEntSearch.Name = "buttonEntSearch";
            this.buttonEntSearch.Size = new System.Drawing.Size(147, 28);
            this.buttonEntSearch.TabIndex = 4;
            this.buttonEntSearch.Text = "Restart Ent Search";
            this.buttonEntSearch.UseVisualStyleBackColor = true;
            this.buttonEntSearch.Click += new System.EventHandler(this.buttonEntSearch_Click);
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.Controls.Add(this.labelServerPort);
            this.panel6.Controls.Add(this.textBoxServerPort);
            this.panel6.Controls.Add(this.buttonServerPort);
            this.panel6.Location = new System.Drawing.Point(0, 77);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1053, 32);
            this.panel6.TabIndex = 3;
            // 
            // labelServerPort
            // 
            this.labelServerPort.AutoSize = true;
            this.labelServerPort.Location = new System.Drawing.Point(3, 7);
            this.labelServerPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelServerPort.Name = "labelServerPort";
            this.labelServerPort.Size = new System.Drawing.Size(76, 16);
            this.labelServerPort.TabIndex = 2;
            this.labelServerPort.Text = "Server port:";
            // 
            // textBoxServerPort
            // 
            this.textBoxServerPort.Location = new System.Drawing.Point(144, 4);
            this.textBoxServerPort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxServerPort.Name = "textBoxServerPort";
            this.textBoxServerPort.Size = new System.Drawing.Size(392, 22);
            this.textBoxServerPort.TabIndex = 2;
            this.textBoxServerPort.Text = "6655";
            this.textBoxServerPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLocalPort_KeyPress);
            // 
            // buttonServerPort
            // 
            this.buttonServerPort.Location = new System.Drawing.Point(545, 1);
            this.buttonServerPort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonServerPort.MaximumSize = new System.Drawing.Size(100, 28);
            this.buttonServerPort.MinimumSize = new System.Drawing.Size(100, 28);
            this.buttonServerPort.Name = "buttonServerPort";
            this.buttonServerPort.Size = new System.Drawing.Size(100, 28);
            this.buttonServerPort.TabIndex = 3;
            this.buttonServerPort.Text = "Submit";
            this.buttonServerPort.UseVisualStyleBackColor = true;
            this.buttonServerPort.Click += new System.EventHandler(this.buttonLocalPort_Click);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.labelPath);
            this.panel5.Controls.Add(this.textBoxPath);
            this.panel5.Controls.Add(this.buttonPath);
            this.panel5.Location = new System.Drawing.Point(0, 9);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1053, 32);
            this.panel5.TabIndex = 1;
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Location = new System.Drawing.Point(3, 7);
            this.labelPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(127, 16);
            this.labelPath.TabIndex = 2;
            this.labelPath.Text = "Folder path of script:";
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(144, 4);
            this.textBoxPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(392, 22);
            this.textBoxPath.TabIndex = 0;
            this.textBoxPath.Text = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Half-Life Alyx\\game\\hlvr_addons\\aly" +
    "x_multiplayer\\scripts\\vscripts";
            this.textBoxPath.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPath_KeyPress);
            // 
            // buttonPath
            // 
            this.buttonPath.Location = new System.Drawing.Point(545, 1);
            this.buttonPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonPath.MaximumSize = new System.Drawing.Size(100, 28);
            this.buttonPath.MinimumSize = new System.Drawing.Size(100, 28);
            this.buttonPath.Name = "buttonPath";
            this.buttonPath.Size = new System.Drawing.Size(100, 28);
            this.buttonPath.TabIndex = 1;
            this.buttonPath.Text = "Submit";
            this.buttonPath.UseVisualStyleBackColor = true;
            this.buttonPath.Click += new System.EventHandler(this.buttonPath_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelOptions);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1053, 16);
            this.panel2.TabIndex = 3;
            // 
            // labelOptions
            // 
            this.labelOptions.AutoSize = true;
            this.labelOptions.Location = new System.Drawing.Point(3, 0);
            this.labelOptions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOptions.Name = "labelOptions";
            this.labelOptions.Size = new System.Drawing.Size(53, 16);
            this.labelOptions.TabIndex = 1;
            this.labelOptions.Text = "Options";
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tempToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1580, 28);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip";
            // 
            // tempToolStripMenuItem
            // 
            this.tempToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemConsole,
            this.toolStripMenuItemInfo});
            this.tempToolStripMenuItem.Name = "tempToolStripMenuItem";
            this.tempToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.tempToolStripMenuItem.Text = "File";
            // 
            // toolStripMenuItemConsole
            // 
            this.toolStripMenuItemConsole.Name = "toolStripMenuItemConsole";
            this.toolStripMenuItemConsole.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItemConsole.Text = "Show/Hide Console";
            this.toolStripMenuItemConsole.Click += new System.EventHandler(this.toolStripMenuItemConsole_Click);
            // 
            // toolStripMenuItemInfo
            // 
            this.toolStripMenuItemInfo.Name = "toolStripMenuItemInfo";
            this.toolStripMenuItemInfo.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItemInfo.Text = "Info";
            this.toolStripMenuItemInfo.Click += new System.EventHandler(this.toolStripMenuItemInfo_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelVersionNumber,
            labelHeader,
            this.labelIP});
            this.statusStrip.Location = new System.Drawing.Point(0, 900);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(1580, 29);
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "statusStrip";
            // 
            // labelVersionNumber
            // 
            this.labelVersionNumber.Margin = new System.Windows.Forms.Padding(0, 3, 3, 2);
            this.labelVersionNumber.Name = "labelVersionNumber";
            this.labelVersionNumber.Size = new System.Drawing.Size(46, 24);
            this.labelVersionNumber.Text = "v1.0.1";
            // 
            // labelIP
            // 
            this.labelIP.Name = "labelIP";
            this.labelIP.Size = new System.Drawing.Size(92, 23);
            this.labelIP.Text = "Not fetched!";
            this.labelIP.Click += new System.EventHandler(this.labelIP_Click);
            this.labelIP.MouseHover += new System.EventHandler(this.labelIP_MouseHover);
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.Controls.Add(this.labelServerIp);
            this.panel9.Controls.Add(this.textBoxServerIp);
            this.panel9.Controls.Add(this.buttonServerIp);
            this.panel9.Location = new System.Drawing.Point(0, 42);
            this.panel9.Margin = new System.Windows.Forms.Padding(0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1053, 32);
            this.panel9.TabIndex = 7;
            // 
            // labelServerIp
            // 
            this.labelServerIp.AutoSize = true;
            this.labelServerIp.Location = new System.Drawing.Point(3, 7);
            this.labelServerIp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelServerIp.Name = "labelServerIp";
            this.labelServerIp.Size = new System.Drawing.Size(65, 16);
            this.labelServerIp.TabIndex = 2;
            this.labelServerIp.Text = "Server IP:";
            // 
            // textBoxServerIp
            // 
            this.textBoxServerIp.Location = new System.Drawing.Point(144, 4);
            this.textBoxServerIp.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxServerIp.Name = "textBoxServerIp";
            this.textBoxServerIp.Size = new System.Drawing.Size(392, 22);
            this.textBoxServerIp.TabIndex = 2;
            this.textBoxServerIp.Text = "0.0.0.0";
            // 
            // buttonServerIp
            // 
            this.buttonServerIp.Location = new System.Drawing.Point(545, 1);
            this.buttonServerIp.Margin = new System.Windows.Forms.Padding(4);
            this.buttonServerIp.MaximumSize = new System.Drawing.Size(100, 28);
            this.buttonServerIp.MinimumSize = new System.Drawing.Size(100, 28);
            this.buttonServerIp.Name = "buttonServerIp";
            this.buttonServerIp.Size = new System.Drawing.Size(100, 28);
            this.buttonServerIp.TabIndex = 3;
            this.buttonServerIp.Text = "Submit";
            this.buttonServerIp.UseVisualStyleBackColor = true;
            this.buttonServerIp.Click += new System.EventHandler(this.buttonServerIp_Click);
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1580, 929);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UI";
            this.Text = "alyx-multiplayer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UI_FormClosed);
            this.Load += new System.EventHandler(this.form_Load);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Label labelLog;
        private System.Windows.Forms.Button buttonPath;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem tempToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemInfo;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel labelVersionNumber;
        private System.Windows.Forms.RichTextBox textBoxLog;
        private System.Windows.Forms.Label labelOptions;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemConsole;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label labelServerPort;
        private System.Windows.Forms.TextBox textBoxServerPort;
        private System.Windows.Forms.Button buttonServerPort;
        private System.Windows.Forms.ToolStripStatusLabel labelIP;
        private System.Windows.Forms.ToolTip toolTipIP;
        private System.Windows.Forms.Button buttonEntSearch;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label labelClientPort;
        private System.Windows.Forms.TextBox textBoxClientPort;
        private System.Windows.Forms.Button buttonClientPort;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label labelClientIp;
        private System.Windows.Forms.TextBox textBoxClientIP;
        private System.Windows.Forms.Button buttonClientIP;
        private System.Windows.Forms.CheckBox checkBoxIsServer;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label labelServerIp;
        private System.Windows.Forms.TextBox textBoxServerIp;
        private System.Windows.Forms.Button buttonServerIp;
    }
}