namespace Tenant_Application
{
    partial class UserInterfaceForm
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
            this.tabSwitch = new System.Windows.Forms.TabControl();
            this.timerAnnouncement = new System.Windows.Forms.Timer(this.components);
            this.timerRefreshUDP = new System.Windows.Forms.Timer(this.components);
            this.timerAnnDisp = new System.Windows.Forms.Timer(this.components);
            this.tabCalendar = new System.Windows.Forms.TabPage();
            this.lblCalendarMain = new System.Windows.Forms.Label();
            this.pbxCalendarLogo = new System.Windows.Forms.PictureBox();
            this.tbAccount = new System.Windows.Forms.TextBox();
            this.btnTempDB = new System.Windows.Forms.Button();
            this.btnCalendarSelect = new System.Windows.Forms.Button();
            this.lbxCalendarChores = new System.Windows.Forms.ListBox();
            this.lbxCalendarDays = new System.Windows.Forms.ListBox();
            this.lblAnnCalendar = new System.Windows.Forms.Label();
            this.panelAnnCalendar = new System.Windows.Forms.Panel();
            this.tbxAnnCalendar = new System.Windows.Forms.TextBox();
            this.pbxCalendarLegend = new System.Windows.Forms.PictureBox();
            this.btnAnnCalendar = new System.Windows.Forms.Button();
            this.tabChatRoom = new System.Windows.Forms.TabPage();
            this.lblChatMain = new System.Windows.Forms.Label();
            this.pbxChatLogo = new System.Windows.Forms.PictureBox();
            this.tbxChat = new System.Windows.Forms.TextBox();
            this.tbxChatMsg = new System.Windows.Forms.TextBox();
            this.lblAnnChat = new System.Windows.Forms.Label();
            this.btnChatSend = new System.Windows.Forms.Button();
            this.panelAnnChat = new System.Windows.Forms.Panel();
            this.tbxAnnChat = new System.Windows.Forms.TextBox();
            this.btn = new System.Windows.Forms.Button();
            this.lbxOnlineUsers = new System.Windows.Forms.ListBox();
            this.tabGrading = new System.Windows.Forms.TabPage();
            this.lblScoreboardMain = new System.Windows.Forms.Label();
            this.pbxScoreboardLogo = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbxScoreboard = new System.Windows.Forms.ListBox();
            this.lblAnnScore = new System.Windows.Forms.Label();
            this.panelAnnScore = new System.Windows.Forms.Panel();
            this.tbxAnnScore = new System.Windows.Forms.TextBox();
            this.btnAnnScore = new System.Windows.Forms.Button();
            this.tabComplaints = new System.Windows.Forms.TabPage();
            this.lblComplaintsMain = new System.Windows.Forms.Label();
            this.pbxComplaintsLogo = new System.Windows.Forms.PictureBox();
            this.panelAnnComplaints = new System.Windows.Forms.Panel();
            this.tbxAnnComplaints = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAnnComplaints = new System.Windows.Forms.Button();
            this.btnSendMail = new System.Windows.Forms.Button();
            this.tbxComplaint = new System.Windows.Forms.RichTextBox();
            this.lblAnnComplaints = new System.Windows.Forms.Label();
            this.pbxChatLegend = new System.Windows.Forms.PictureBox();
            this.pbxScoreboardLegend = new System.Windows.Forms.PictureBox();
            this.pbxComplaintsLegend = new System.Windows.Forms.PictureBox();
            this.tabSwitch.SuspendLayout();
            this.tabCalendar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCalendarLogo)).BeginInit();
            this.panelAnnCalendar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCalendarLegend)).BeginInit();
            this.tabChatRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxChatLogo)).BeginInit();
            this.panelAnnChat.SuspendLayout();
            this.tabGrading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxScoreboardLogo)).BeginInit();
            this.panelAnnScore.SuspendLayout();
            this.tabComplaints.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxComplaintsLogo)).BeginInit();
            this.panelAnnComplaints.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxChatLegend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxScoreboardLegend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxComplaintsLegend)).BeginInit();
            this.SuspendLayout();
            // 
            // tabSwitch
            // 
            this.tabSwitch.Controls.Add(this.tabCalendar);
            this.tabSwitch.Controls.Add(this.tabChatRoom);
            this.tabSwitch.Controls.Add(this.tabGrading);
            this.tabSwitch.Controls.Add(this.tabComplaints);
            this.tabSwitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabSwitch.Location = new System.Drawing.Point(8, 7);
            this.tabSwitch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabSwitch.Multiline = true;
            this.tabSwitch.Name = "tabSwitch";
            this.tabSwitch.SelectedIndex = 0;
            this.tabSwitch.Size = new System.Drawing.Size(1572, 828);
            this.tabSwitch.TabIndex = 0;
            this.tabSwitch.SelectedIndexChanged += new System.EventHandler(this.TabSwitch_SelectedIndexChanged);
            // 
            // timerAnnouncement
            // 
            this.timerAnnouncement.Interval = 10000;
            this.timerAnnouncement.Tick += new System.EventHandler(this.TimerAnnouncement_Tick);
            // 
            // timerRefreshUDP
            // 
            this.timerRefreshUDP.Enabled = true;
            // 
            // timerAnnDisp
            // 
            this.timerAnnDisp.Enabled = true;
            this.timerAnnDisp.Interval = 1000;
            this.timerAnnDisp.Tick += new System.EventHandler(this.TimerAnnDisp_Tick);
            // 
            // tabCalendar
            // 
            this.tabCalendar.BackgroundImage = global::Tenant_Application.Properties.Resources.background1;
            this.tabCalendar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabCalendar.Controls.Add(this.panelAnnCalendar);
            this.tabCalendar.Controls.Add(this.lblCalendarMain);
            this.tabCalendar.Controls.Add(this.pbxCalendarLegend);
            this.tabCalendar.Controls.Add(this.pbxCalendarLogo);
            this.tabCalendar.Controls.Add(this.tbAccount);
            this.tabCalendar.Controls.Add(this.btnTempDB);
            this.tabCalendar.Controls.Add(this.btnCalendarSelect);
            this.tabCalendar.Controls.Add(this.lbxCalendarChores);
            this.tabCalendar.Controls.Add(this.lbxCalendarDays);
            this.tabCalendar.Controls.Add(this.lblAnnCalendar);
            this.tabCalendar.Controls.Add(this.btnAnnCalendar);
            this.tabCalendar.Location = new System.Drawing.Point(4, 27);
            this.tabCalendar.Margin = new System.Windows.Forms.Padding(4);
            this.tabCalendar.Name = "tabCalendar";
            this.tabCalendar.Size = new System.Drawing.Size(1564, 797);
            this.tabCalendar.TabIndex = 2;
            this.tabCalendar.Text = "Calendar";
            this.tabCalendar.UseVisualStyleBackColor = true;
            // 
            // lblCalendarMain
            // 
            this.lblCalendarMain.AutoSize = true;
            this.lblCalendarMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCalendarMain.ForeColor = System.Drawing.Color.White;
            this.lblCalendarMain.Location = new System.Drawing.Point(213, 100);
            this.lblCalendarMain.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCalendarMain.Name = "lblCalendarMain";
            this.lblCalendarMain.Size = new System.Drawing.Size(697, 54);
            this.lblCalendarMain.TabIndex = 14;
            this.lblCalendarMain.Text = "Choose a day and a chore to do.\r\n";
            // 
            // pbxCalendarLogo
            // 
            this.pbxCalendarLogo.Image = global::Tenant_Application.Properties.Resources.onlylogo;
            this.pbxCalendarLogo.Location = new System.Drawing.Point(41, 25);
            this.pbxCalendarLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pbxCalendarLogo.Name = "pbxCalendarLogo";
            this.pbxCalendarLogo.Size = new System.Drawing.Size(200, 185);
            this.pbxCalendarLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCalendarLogo.TabIndex = 1;
            this.pbxCalendarLogo.TabStop = false;
            // 
            // tbAccount
            // 
            this.tbAccount.Location = new System.Drawing.Point(919, 510);
            this.tbAccount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbAccount.Name = "tbAccount";
            this.tbAccount.Size = new System.Drawing.Size(100, 24);
            this.tbAccount.TabIndex = 16;
            // 
            // btnTempDB
            // 
            this.btnTempDB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.btnTempDB.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.btnTempDB.FlatAppearance.BorderSize = 0;
            this.btnTempDB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnTempDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTempDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTempDB.ForeColor = System.Drawing.Color.White;
            this.btnTempDB.Location = new System.Drawing.Point(731, 465);
            this.btnTempDB.Margin = new System.Windows.Forms.Padding(4);
            this.btnTempDB.Name = "btnTempDB";
            this.btnTempDB.Size = new System.Drawing.Size(181, 68);
            this.btnTempDB.TabIndex = 15;
            this.btnTempDB.Text = "List items from DB";
            this.btnTempDB.UseVisualStyleBackColor = false;
            // 
            // btnCalendarSelect
            // 
            this.btnCalendarSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.btnCalendarSelect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.btnCalendarSelect.FlatAppearance.BorderSize = 0;
            this.btnCalendarSelect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCalendarSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalendarSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCalendarSelect.ForeColor = System.Drawing.Color.White;
            this.btnCalendarSelect.Location = new System.Drawing.Point(731, 367);
            this.btnCalendarSelect.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalendarSelect.Name = "btnCalendarSelect";
            this.btnCalendarSelect.Size = new System.Drawing.Size(181, 68);
            this.btnCalendarSelect.TabIndex = 13;
            this.btnCalendarSelect.Text = "Choose chore";
            this.btnCalendarSelect.UseVisualStyleBackColor = false;
            // 
            // lbxCalendarChores
            // 
            this.lbxCalendarChores.FormattingEnabled = true;
            this.lbxCalendarChores.ItemHeight = 18;
            this.lbxCalendarChores.Location = new System.Drawing.Point(417, 286);
            this.lbxCalendarChores.Margin = new System.Windows.Forms.Padding(4);
            this.lbxCalendarChores.Name = "lbxCalendarChores";
            this.lbxCalendarChores.Size = new System.Drawing.Size(281, 220);
            this.lbxCalendarChores.TabIndex = 12;
            // 
            // lbxCalendarDays
            // 
            this.lbxCalendarDays.FormattingEnabled = true;
            this.lbxCalendarDays.ItemHeight = 18;
            this.lbxCalendarDays.Location = new System.Drawing.Point(137, 286);
            this.lbxCalendarDays.Margin = new System.Windows.Forms.Padding(4);
            this.lbxCalendarDays.Name = "lbxCalendarDays";
            this.lbxCalendarDays.Size = new System.Drawing.Size(240, 220);
            this.lbxCalendarDays.TabIndex = 11;
            // 
            // lblAnnCalendar
            // 
            this.lblAnnCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAnnCalendar.ForeColor = System.Drawing.Color.White;
            this.lblAnnCalendar.Location = new System.Drawing.Point(981, 42);
            this.lblAnnCalendar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnnCalendar.Name = "lblAnnCalendar";
            this.lblAnnCalendar.Size = new System.Drawing.Size(361, 50);
            this.lblAnnCalendar.TabIndex = 10;
            this.lblAnnCalendar.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panelAnnCalendar
            // 
            this.panelAnnCalendar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.panelAnnCalendar.Controls.Add(this.tbxAnnCalendar);
            this.panelAnnCalendar.Location = new System.Drawing.Point(1065, 100);
            this.panelAnnCalendar.Margin = new System.Windows.Forms.Padding(4);
            this.panelAnnCalendar.Name = "panelAnnCalendar";
            this.panelAnnCalendar.Size = new System.Drawing.Size(484, 681);
            this.panelAnnCalendar.TabIndex = 9;
            this.panelAnnCalendar.Visible = false;
            // 
            // tbxAnnCalendar
            // 
            this.tbxAnnCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxAnnCalendar.Location = new System.Drawing.Point(19, 15);
            this.tbxAnnCalendar.Margin = new System.Windows.Forms.Padding(4);
            this.tbxAnnCalendar.Multiline = true;
            this.tbxAnnCalendar.Name = "tbxAnnCalendar";
            this.tbxAnnCalendar.ReadOnly = true;
            this.tbxAnnCalendar.Size = new System.Drawing.Size(451, 650);
            this.tbxAnnCalendar.TabIndex = 2;
            // 
            // pbxCalendarLegend
            // 
            this.pbxCalendarLegend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxCalendarLegend.Image = global::Tenant_Application.Properties.Resources.legend;
            this.pbxCalendarLegend.Location = new System.Drawing.Point(1065, 100);
            this.pbxCalendarLegend.Name = "pbxCalendarLegend";
            this.pbxCalendarLegend.Size = new System.Drawing.Size(484, 681);
            this.pbxCalendarLegend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCalendarLegend.TabIndex = 3;
            this.pbxCalendarLegend.TabStop = false;
            // 
            // btnAnnCalendar
            // 
            this.btnAnnCalendar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.btnAnnCalendar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.btnAnnCalendar.FlatAppearance.BorderSize = 0;
            this.btnAnnCalendar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAnnCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAnnCalendar.ForeColor = System.Drawing.Color.White;
            this.btnAnnCalendar.Location = new System.Drawing.Point(1368, 26);
            this.btnAnnCalendar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnnCalendar.Name = "btnAnnCalendar";
            this.btnAnnCalendar.Size = new System.Drawing.Size(181, 68);
            this.btnAnnCalendar.TabIndex = 8;
            this.btnAnnCalendar.Text = "Announcements";
            this.btnAnnCalendar.UseVisualStyleBackColor = false;
            this.btnAnnCalendar.Click += new System.EventHandler(this.BtnAnnCalendar_Click);
            // 
            // tabChatRoom
            // 
            this.tabChatRoom.BackgroundImage = global::Tenant_Application.Properties.Resources.background1;
            this.tabChatRoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabChatRoom.Controls.Add(this.lblChatMain);
            this.tabChatRoom.Controls.Add(this.pbxChatLogo);
            this.tabChatRoom.Controls.Add(this.tbxChat);
            this.tabChatRoom.Controls.Add(this.tbxChatMsg);
            this.tabChatRoom.Controls.Add(this.lblAnnChat);
            this.tabChatRoom.Controls.Add(this.btnChatSend);
            this.tabChatRoom.Controls.Add(this.panelAnnChat);
            this.tabChatRoom.Controls.Add(this.btn);
            this.tabChatRoom.Controls.Add(this.lbxOnlineUsers);
            this.tabChatRoom.Controls.Add(this.pbxChatLegend);
            this.tabChatRoom.Location = new System.Drawing.Point(4, 27);
            this.tabChatRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabChatRoom.Name = "tabChatRoom";
            this.tabChatRoom.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabChatRoom.Size = new System.Drawing.Size(1564, 797);
            this.tabChatRoom.TabIndex = 0;
            this.tabChatRoom.Text = "Chat Room";
            this.tabChatRoom.UseVisualStyleBackColor = true;
            // 
            // lblChatMain
            // 
            this.lblChatMain.AutoSize = true;
            this.lblChatMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblChatMain.ForeColor = System.Drawing.Color.White;
            this.lblChatMain.Location = new System.Drawing.Point(213, 100);
            this.lblChatMain.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChatMain.Name = "lblChatMain";
            this.lblChatMain.Size = new System.Drawing.Size(749, 54);
            this.lblChatMain.TabIndex = 1;
            this.lblChatMain.Text = "Welcome <name> to the chat room";
            // 
            // pbxChatLogo
            // 
            this.pbxChatLogo.Image = global::Tenant_Application.Properties.Resources.onlylogo;
            this.pbxChatLogo.Location = new System.Drawing.Point(41, 25);
            this.pbxChatLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pbxChatLogo.Name = "pbxChatLogo";
            this.pbxChatLogo.Size = new System.Drawing.Size(200, 185);
            this.pbxChatLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxChatLogo.TabIndex = 10;
            this.pbxChatLogo.TabStop = false;
            // 
            // tbxChat
            // 
            this.tbxChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxChat.Location = new System.Drawing.Point(71, 279);
            this.tbxChat.Margin = new System.Windows.Forms.Padding(4);
            this.tbxChat.Multiline = true;
            this.tbxChat.Name = "tbxChat";
            this.tbxChat.ReadOnly = true;
            this.tbxChat.Size = new System.Drawing.Size(757, 384);
            this.tbxChat.TabIndex = 3;
            // 
            // tbxChatMsg
            // 
            this.tbxChatMsg.Location = new System.Drawing.Point(71, 693);
            this.tbxChatMsg.Margin = new System.Windows.Forms.Padding(4);
            this.tbxChatMsg.Multiline = true;
            this.tbxChatMsg.Name = "tbxChatMsg";
            this.tbxChatMsg.Size = new System.Drawing.Size(552, 32);
            this.tbxChatMsg.TabIndex = 9;
            // 
            // lblAnnChat
            // 
            this.lblAnnChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAnnChat.ForeColor = System.Drawing.Color.White;
            this.lblAnnChat.Location = new System.Drawing.Point(975, 46);
            this.lblAnnChat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnnChat.Name = "lblAnnChat";
            this.lblAnnChat.Size = new System.Drawing.Size(361, 50);
            this.lblAnnChat.TabIndex = 0;
            this.lblAnnChat.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnChatSend
            // 
            this.btnChatSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.btnChatSend.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.btnChatSend.FlatAppearance.BorderSize = 0;
            this.btnChatSend.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnChatSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChatSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChatSend.ForeColor = System.Drawing.Color.White;
            this.btnChatSend.Location = new System.Drawing.Point(645, 693);
            this.btnChatSend.Margin = new System.Windows.Forms.Padding(4);
            this.btnChatSend.Name = "btnChatSend";
            this.btnChatSend.Size = new System.Drawing.Size(184, 33);
            this.btnChatSend.TabIndex = 8;
            this.btnChatSend.Text = "Send";
            this.btnChatSend.UseVisualStyleBackColor = false;
            // 
            // panelAnnChat
            // 
            this.panelAnnChat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.panelAnnChat.Controls.Add(this.tbxAnnChat);
            this.panelAnnChat.Location = new System.Drawing.Point(1065, 100);
            this.panelAnnChat.Margin = new System.Windows.Forms.Padding(4);
            this.panelAnnChat.Name = "panelAnnChat";
            this.panelAnnChat.Size = new System.Drawing.Size(484, 681);
            this.panelAnnChat.TabIndex = 7;
            this.panelAnnChat.Visible = false;
            // 
            // tbxAnnChat
            // 
            this.tbxAnnChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxAnnChat.Location = new System.Drawing.Point(19, 15);
            this.tbxAnnChat.Margin = new System.Windows.Forms.Padding(4);
            this.tbxAnnChat.Multiline = true;
            this.tbxAnnChat.Name = "tbxAnnChat";
            this.tbxAnnChat.ReadOnly = true;
            this.tbxAnnChat.Size = new System.Drawing.Size(447, 648);
            this.tbxAnnChat.TabIndex = 2;
            // 
            // btn
            // 
            this.btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.btn.FlatAppearance.BorderSize = 0;
            this.btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn.ForeColor = System.Drawing.Color.White;
            this.btn.Location = new System.Drawing.Point(1368, 26);
            this.btn.Margin = new System.Windows.Forms.Padding(4);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(181, 68);
            this.btn.TabIndex = 5;
            this.btn.Text = "Announcements";
            this.btn.UseVisualStyleBackColor = false;
            this.btn.Click += new System.EventHandler(this.BtnAnnCalendar_Click);
            // 
            // lbxOnlineUsers
            // 
            this.lbxOnlineUsers.FormattingEnabled = true;
            this.lbxOnlineUsers.ItemHeight = 18;
            this.lbxOnlineUsers.Location = new System.Drawing.Point(837, 279);
            this.lbxOnlineUsers.Margin = new System.Windows.Forms.Padding(4);
            this.lbxOnlineUsers.Name = "lbxOnlineUsers";
            this.lbxOnlineUsers.Size = new System.Drawing.Size(211, 166);
            this.lbxOnlineUsers.TabIndex = 2;
            // 
            // tabGrading
            // 
            this.tabGrading.BackgroundImage = global::Tenant_Application.Properties.Resources.background1;
            this.tabGrading.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabGrading.Controls.Add(this.lblScoreboardMain);
            this.tabGrading.Controls.Add(this.pbxScoreboardLogo);
            this.tabGrading.Controls.Add(this.label4);
            this.tabGrading.Controls.Add(this.lbxScoreboard);
            this.tabGrading.Controls.Add(this.lblAnnScore);
            this.tabGrading.Controls.Add(this.panelAnnScore);
            this.tabGrading.Controls.Add(this.btnAnnScore);
            this.tabGrading.Controls.Add(this.pbxScoreboardLegend);
            this.tabGrading.Location = new System.Drawing.Point(4, 27);
            this.tabGrading.Margin = new System.Windows.Forms.Padding(4);
            this.tabGrading.Name = "tabGrading";
            this.tabGrading.Size = new System.Drawing.Size(1564, 797);
            this.tabGrading.TabIndex = 3;
            this.tabGrading.Text = "Scoreboard";
            this.tabGrading.UseVisualStyleBackColor = true;
            // 
            // lblScoreboardMain
            // 
            this.lblScoreboardMain.AutoSize = true;
            this.lblScoreboardMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblScoreboardMain.ForeColor = System.Drawing.Color.White;
            this.lblScoreboardMain.Location = new System.Drawing.Point(213, 100);
            this.lblScoreboardMain.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScoreboardMain.Name = "lblScoreboardMain";
            this.lblScoreboardMain.Size = new System.Drawing.Size(573, 54);
            this.lblScoreboardMain.TabIndex = 16;
            this.lblScoreboardMain.Text = "Tenant activity scoreboard";
            // 
            // pbxScoreboardLogo
            // 
            this.pbxScoreboardLogo.Image = global::Tenant_Application.Properties.Resources.onlylogo;
            this.pbxScoreboardLogo.Location = new System.Drawing.Point(41, 25);
            this.pbxScoreboardLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pbxScoreboardLogo.Name = "pbxScoreboardLogo";
            this.pbxScoreboardLogo.Size = new System.Drawing.Size(200, 185);
            this.pbxScoreboardLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxScoreboardLogo.TabIndex = 17;
            this.pbxScoreboardLogo.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(355, 97);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(235, 48);
            this.label4.TabIndex = 15;
            this.label4.Text = "Scoreboard";
            // 
            // lbxScoreboard
            // 
            this.lbxScoreboard.FormattingEnabled = true;
            this.lbxScoreboard.ItemHeight = 18;
            this.lbxScoreboard.Location = new System.Drawing.Point(351, 213);
            this.lbxScoreboard.Margin = new System.Windows.Forms.Padding(4);
            this.lbxScoreboard.Name = "lbxScoreboard";
            this.lbxScoreboard.Size = new System.Drawing.Size(293, 328);
            this.lbxScoreboard.TabIndex = 11;
            // 
            // lblAnnScore
            // 
            this.lblAnnScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAnnScore.ForeColor = System.Drawing.Color.White;
            this.lblAnnScore.Location = new System.Drawing.Point(984, 47);
            this.lblAnnScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnnScore.Name = "lblAnnScore";
            this.lblAnnScore.Size = new System.Drawing.Size(361, 50);
            this.lblAnnScore.TabIndex = 10;
            this.lblAnnScore.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panelAnnScore
            // 
            this.panelAnnScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.panelAnnScore.Controls.Add(this.tbxAnnScore);
            this.panelAnnScore.Location = new System.Drawing.Point(1065, 101);
            this.panelAnnScore.Margin = new System.Windows.Forms.Padding(4);
            this.panelAnnScore.Name = "panelAnnScore";
            this.panelAnnScore.Size = new System.Drawing.Size(484, 681);
            this.panelAnnScore.TabIndex = 9;
            this.panelAnnScore.Visible = false;
            // 
            // tbxAnnScore
            // 
            this.tbxAnnScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxAnnScore.Location = new System.Drawing.Point(19, 15);
            this.tbxAnnScore.Margin = new System.Windows.Forms.Padding(4);
            this.tbxAnnScore.Multiline = true;
            this.tbxAnnScore.Name = "tbxAnnScore";
            this.tbxAnnScore.ReadOnly = true;
            this.tbxAnnScore.Size = new System.Drawing.Size(448, 648);
            this.tbxAnnScore.TabIndex = 2;
            // 
            // btnAnnScore
            // 
            this.btnAnnScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.btnAnnScore.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.btnAnnScore.FlatAppearance.BorderSize = 0;
            this.btnAnnScore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAnnScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAnnScore.ForeColor = System.Drawing.Color.White;
            this.btnAnnScore.Location = new System.Drawing.Point(1368, 26);
            this.btnAnnScore.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnnScore.Name = "btnAnnScore";
            this.btnAnnScore.Size = new System.Drawing.Size(181, 68);
            this.btnAnnScore.TabIndex = 8;
            this.btnAnnScore.Text = "Announcements";
            this.btnAnnScore.UseVisualStyleBackColor = false;
            this.btnAnnScore.Click += new System.EventHandler(this.BtnAnnCalendar_Click);
            // 
            // tabComplaints
            // 
            this.tabComplaints.BackgroundImage = global::Tenant_Application.Properties.Resources.background1;
            this.tabComplaints.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabComplaints.Controls.Add(this.lblComplaintsMain);
            this.tabComplaints.Controls.Add(this.pbxComplaintsLogo);
            this.tabComplaints.Controls.Add(this.panelAnnComplaints);
            this.tabComplaints.Controls.Add(this.textBox1);
            this.tabComplaints.Controls.Add(this.button1);
            this.tabComplaints.Controls.Add(this.btnAnnComplaints);
            this.tabComplaints.Controls.Add(this.btnSendMail);
            this.tabComplaints.Controls.Add(this.tbxComplaint);
            this.tabComplaints.Controls.Add(this.lblAnnComplaints);
            this.tabComplaints.Controls.Add(this.pbxComplaintsLegend);
            this.tabComplaints.Location = new System.Drawing.Point(4, 27);
            this.tabComplaints.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabComplaints.Name = "tabComplaints";
            this.tabComplaints.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabComplaints.Size = new System.Drawing.Size(1564, 797);
            this.tabComplaints.TabIndex = 1;
            this.tabComplaints.Text = "Complaints";
            this.tabComplaints.UseVisualStyleBackColor = true;
            // 
            // lblComplaintsMain
            // 
            this.lblComplaintsMain.AutoSize = true;
            this.lblComplaintsMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblComplaintsMain.ForeColor = System.Drawing.Color.White;
            this.lblComplaintsMain.Location = new System.Drawing.Point(213, 100);
            this.lblComplaintsMain.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComplaintsMain.Name = "lblComplaintsMain";
            this.lblComplaintsMain.Size = new System.Drawing.Size(585, 54);
            this.lblComplaintsMain.TabIndex = 18;
            this.lblComplaintsMain.Text = "Enter your complaint below";
            // 
            // pbxComplaintsLogo
            // 
            this.pbxComplaintsLogo.Image = global::Tenant_Application.Properties.Resources.onlylogo;
            this.pbxComplaintsLogo.Location = new System.Drawing.Point(41, 25);
            this.pbxComplaintsLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pbxComplaintsLogo.Name = "pbxComplaintsLogo";
            this.pbxComplaintsLogo.Size = new System.Drawing.Size(200, 185);
            this.pbxComplaintsLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxComplaintsLogo.TabIndex = 19;
            this.pbxComplaintsLogo.TabStop = false;
            // 
            // panelAnnComplaints
            // 
            this.panelAnnComplaints.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.panelAnnComplaints.Controls.Add(this.tbxAnnComplaints);
            this.panelAnnComplaints.Location = new System.Drawing.Point(1065, 97);
            this.panelAnnComplaints.Margin = new System.Windows.Forms.Padding(4);
            this.panelAnnComplaints.Name = "panelAnnComplaints";
            this.panelAnnComplaints.Size = new System.Drawing.Size(484, 681);
            this.panelAnnComplaints.TabIndex = 5;
            this.panelAnnComplaints.Visible = false;
            // 
            // tbxAnnComplaints
            // 
            this.tbxAnnComplaints.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxAnnComplaints.Location = new System.Drawing.Point(19, 15);
            this.tbxAnnComplaints.Margin = new System.Windows.Forms.Padding(4);
            this.tbxAnnComplaints.Multiline = true;
            this.tbxAnnComplaints.Name = "tbxAnnComplaints";
            this.tbxAnnComplaints.ReadOnly = true;
            this.tbxAnnComplaints.Size = new System.Drawing.Size(445, 650);
            this.tbxAnnComplaints.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(901, 678);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 24);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "TEMPORARY";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(901, 710);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 68);
            this.button1.TabIndex = 6;
            this.button1.Text = "Temp Button";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnAnnComplaints
            // 
            this.btnAnnComplaints.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.btnAnnComplaints.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.btnAnnComplaints.FlatAppearance.BorderSize = 0;
            this.btnAnnComplaints.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAnnComplaints.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnComplaints.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAnnComplaints.ForeColor = System.Drawing.Color.White;
            this.btnAnnComplaints.Location = new System.Drawing.Point(1368, 26);
            this.btnAnnComplaints.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnnComplaints.Name = "btnAnnComplaints";
            this.btnAnnComplaints.Size = new System.Drawing.Size(181, 68);
            this.btnAnnComplaints.TabIndex = 4;
            this.btnAnnComplaints.Text = "Announcements";
            this.btnAnnComplaints.UseVisualStyleBackColor = false;
            this.btnAnnComplaints.Click += new System.EventHandler(this.BtnAnnCalendar_Click);
            // 
            // btnSendMail
            // 
            this.btnSendMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.btnSendMail.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.btnSendMail.FlatAppearance.BorderSize = 0;
            this.btnSendMail.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSendMail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSendMail.ForeColor = System.Drawing.Color.White;
            this.btnSendMail.Location = new System.Drawing.Point(384, 706);
            this.btnSendMail.Margin = new System.Windows.Forms.Padding(4);
            this.btnSendMail.Name = "btnSendMail";
            this.btnSendMail.Size = new System.Drawing.Size(260, 70);
            this.btnSendMail.TabIndex = 3;
            this.btnSendMail.Text = "Send ";
            this.btnSendMail.UseVisualStyleBackColor = false;
            this.btnSendMail.Click += new System.EventHandler(this.BtnSendMail_Click);
            // 
            // tbxComplaint
            // 
            this.tbxComplaint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxComplaint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxComplaint.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxComplaint.Location = new System.Drawing.Point(271, 219);
            this.tbxComplaint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxComplaint.Name = "tbxComplaint";
            this.tbxComplaint.Size = new System.Drawing.Size(475, 480);
            this.tbxComplaint.TabIndex = 1;
            this.tbxComplaint.Text = "";
            // 
            // lblAnnComplaints
            // 
            this.lblAnnComplaints.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAnnComplaints.ForeColor = System.Drawing.Color.White;
            this.lblAnnComplaints.Location = new System.Drawing.Point(925, 43);
            this.lblAnnComplaints.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnnComplaints.Name = "lblAnnComplaints";
            this.lblAnnComplaints.Size = new System.Drawing.Size(415, 51);
            this.lblAnnComplaints.TabIndex = 0;
            this.lblAnnComplaints.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pbxChatLegend
            // 
            this.pbxChatLegend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxChatLegend.Image = global::Tenant_Application.Properties.Resources.legend;
            this.pbxChatLegend.Location = new System.Drawing.Point(1065, 100);
            this.pbxChatLegend.Name = "pbxChatLegend";
            this.pbxChatLegend.Size = new System.Drawing.Size(484, 681);
            this.pbxChatLegend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxChatLegend.TabIndex = 11;
            this.pbxChatLegend.TabStop = false;
            // 
            // pbxScoreboardLegend
            // 
            this.pbxScoreboardLegend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxScoreboardLegend.Image = global::Tenant_Application.Properties.Resources.legend;
            this.pbxScoreboardLegend.Location = new System.Drawing.Point(1065, 100);
            this.pbxScoreboardLegend.Name = "pbxScoreboardLegend";
            this.pbxScoreboardLegend.Size = new System.Drawing.Size(484, 681);
            this.pbxScoreboardLegend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxScoreboardLegend.TabIndex = 18;
            this.pbxScoreboardLegend.TabStop = false;
            // 
            // pbxComplaintsLegend
            // 
            this.pbxComplaintsLegend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxComplaintsLegend.Image = global::Tenant_Application.Properties.Resources.legend;
            this.pbxComplaintsLegend.Location = new System.Drawing.Point(1065, 100);
            this.pbxComplaintsLegend.Name = "pbxComplaintsLegend";
            this.pbxComplaintsLegend.Size = new System.Drawing.Size(484, 681);
            this.pbxComplaintsLegend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxComplaintsLegend.TabIndex = 20;
            this.pbxComplaintsLegend.TabStop = false;
            // 
            // UserInterfaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1571, 846);
            this.Controls.Add(this.tabSwitch);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "UserInterfaceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserInterfaceForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserInterfaceForm_FormClosing);
            this.Load += new System.EventHandler(this.UserInterfaceForm_Load);
            this.tabSwitch.ResumeLayout(false);
            this.tabCalendar.ResumeLayout(false);
            this.tabCalendar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCalendarLogo)).EndInit();
            this.panelAnnCalendar.ResumeLayout(false);
            this.panelAnnCalendar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCalendarLegend)).EndInit();
            this.tabChatRoom.ResumeLayout(false);
            this.tabChatRoom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxChatLogo)).EndInit();
            this.panelAnnChat.ResumeLayout(false);
            this.panelAnnChat.PerformLayout();
            this.tabGrading.ResumeLayout(false);
            this.tabGrading.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxScoreboardLogo)).EndInit();
            this.panelAnnScore.ResumeLayout(false);
            this.panelAnnScore.PerformLayout();
            this.tabComplaints.ResumeLayout(false);
            this.tabComplaints.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxComplaintsLogo)).EndInit();
            this.panelAnnComplaints.ResumeLayout(false);
            this.panelAnnComplaints.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxChatLegend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxScoreboardLegend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxComplaintsLegend)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabChatRoom;
        private System.Windows.Forms.TabPage tabComplaints;
        private System.Windows.Forms.RichTextBox tbxComplaint;
        private System.Windows.Forms.ListBox lbxOnlineUsers;
        private System.Windows.Forms.Label lblChatMain;
        private System.Windows.Forms.TabControl tabSwitch;
        private System.Windows.Forms.Button btnSendMail;
        private System.Windows.Forms.Timer timerAnnouncement;
        private System.Windows.Forms.Panel panelAnnComplaints;
        private System.Windows.Forms.Button btnAnnComplaints;
        private System.Windows.Forms.Label lblAnnComplaints;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabCalendar;
        private System.Windows.Forms.TabPage tabGrading;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Panel panelAnnChat;
        private System.Windows.Forms.Button btnChatSend;
        private System.Windows.Forms.TextBox tbxAnnComplaints;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tbxAnnChat;
        private System.Windows.Forms.Label lblAnnChat;
        private System.Windows.Forms.Panel panelAnnScore;
        private System.Windows.Forms.TextBox tbxAnnScore;
        private System.Windows.Forms.Button btnAnnScore;
        private System.Windows.Forms.Panel panelAnnCalendar;
        private System.Windows.Forms.TextBox tbxAnnCalendar;
        private System.Windows.Forms.Button btnAnnCalendar;
        private System.Windows.Forms.Label lblAnnCalendar;
        private System.Windows.Forms.Label lblAnnScore;
        private System.Windows.Forms.TextBox tbxChatMsg;
        private System.Windows.Forms.TextBox tbxChat;
        private System.Windows.Forms.Button btnCalendarSelect;
        private System.Windows.Forms.ListBox lbxCalendarChores;
        private System.Windows.Forms.ListBox lbxCalendarDays;
        private System.Windows.Forms.Label lblCalendarMain;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbxScoreboard;
        private System.Windows.Forms.Button btnTempDB;
        private System.Windows.Forms.TextBox tbAccount;
        private System.Windows.Forms.Timer timerRefreshUDP;
        private System.Windows.Forms.Timer timerAnnDisp;
        private System.Windows.Forms.PictureBox pbxCalendarLogo;
        private System.Windows.Forms.PictureBox pbxChatLogo;
        private System.Windows.Forms.Label lblScoreboardMain;
        private System.Windows.Forms.PictureBox pbxScoreboardLogo;
        private System.Windows.Forms.Label lblComplaintsMain;
        private System.Windows.Forms.PictureBox pbxComplaintsLogo;
        private System.Windows.Forms.PictureBox pbxCalendarLegend;
        private System.Windows.Forms.PictureBox pbxChatLegend;
        private System.Windows.Forms.PictureBox pbxScoreboardLegend;
        private System.Windows.Forms.PictureBox pbxComplaintsLegend;
    }
}