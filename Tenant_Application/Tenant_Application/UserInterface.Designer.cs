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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInterfaceForm));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabCalendar = new System.Windows.Forms.TabPage();
            this.btnAnnCalendar = new System.Windows.Forms.Button();
            this.panelCalendarObject = new System.Windows.Forms.Panel();
            this.btnOpenCalendar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCalendarMain = new System.Windows.Forms.Label();
            this.lbxCalendarChores = new System.Windows.Forms.ListBox();
            this.lbxCalendarDays = new System.Windows.Forms.ListBox();
            this.btnCalendarSelect = new System.Windows.Forms.Button();
            this.btnCalendarLogout = new System.Windows.Forms.Button();
            this.panelAnnCalendar = new System.Windows.Forms.Panel();
            this.tbxAnnCalendar = new System.Windows.Forms.RichTextBox();
            this.pbxCalendarLegend = new System.Windows.Forms.PictureBox();
            this.lblAnnCalendar = new System.Windows.Forms.Label();
            this.tabChatRoom = new System.Windows.Forms.TabPage();
            this.btnAnnCR = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbxChat = new System.Windows.Forms.TextBox();
            this.lbxOnlineUsers = new System.Windows.Forms.ListBox();
            this.lblChatMain = new System.Windows.Forms.Label();
            this.btnChatSend = new System.Windows.Forms.Button();
            this.tbxChatMsg = new System.Windows.Forms.TextBox();
            this.btnChatLogout = new System.Windows.Forms.Button();
            this.lblAnnChat = new System.Windows.Forms.Label();
            this.panelAnnChat = new System.Windows.Forms.Panel();
            this.tbxAnnCR = new System.Windows.Forms.RichTextBox();
            this.pbxChatLegend = new System.Windows.Forms.PictureBox();
            this.tabGrading = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblScoreboardMain = new System.Windows.Forms.Label();
            this.lbxScoreboard = new System.Windows.Forms.ListBox();
            this.btnScoreboardLogout = new System.Windows.Forms.Button();
            this.lblAnnScore = new System.Windows.Forms.Label();
            this.panelAnnScore = new System.Windows.Forms.Panel();
            this.tbxAnnScore = new System.Windows.Forms.RichTextBox();
            this.btnAnnScore = new System.Windows.Forms.Button();
            this.pbxScoreboardLegend = new System.Windows.Forms.PictureBox();
            this.tabComplaints = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbxComplaint = new System.Windows.Forms.RichTextBox();
            this.btnSendMail = new System.Windows.Forms.Button();
            this.lblComplaintsMain = new System.Windows.Forms.Label();
            this.btnComplaintLogout = new System.Windows.Forms.Button();
            this.panelAnnComplaints = new System.Windows.Forms.Panel();
            this.tbxAnnCom = new System.Windows.Forms.RichTextBox();
            this.btnAnnComplaints = new System.Windows.Forms.Button();
            this.lblAnnComplaints = new System.Windows.Forms.Label();
            this.pbxComplaintsLegend = new System.Windows.Forms.PictureBox();
            this.timerAnnouncement = new System.Windows.Forms.Timer(this.components);
            this.timerAnnDisp = new System.Windows.Forms.Timer(this.components);
            this.timerChatScoreboard = new System.Windows.Forms.Timer(this.components);
            this.tabControl.SuspendLayout();
            this.tabCalendar.SuspendLayout();
            this.panelCalendarObject.SuspendLayout();
            this.panelAnnCalendar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCalendarLegend)).BeginInit();
            this.tabChatRoom.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelAnnChat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxChatLegend)).BeginInit();
            this.tabGrading.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelAnnScore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxScoreboardLegend)).BeginInit();
            this.tabComplaints.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelAnnComplaints.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxComplaintsLegend)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabCalendar);
            this.tabControl.Controls.Add(this.tabChatRoom);
            this.tabControl.Controls.Add(this.tabGrading);
            this.tabControl.Controls.Add(this.tabComplaints);
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl.Location = new System.Drawing.Point(6, 6);
            this.tabControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1179, 673);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.TabSwitch_SelectedIndexChanged);
            // 
            // tabCalendar
            // 
            this.tabCalendar.BackgroundImage = global::Tenant_Application.Properties.Resources.background2;
            this.tabCalendar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabCalendar.Controls.Add(this.btnAnnCalendar);
            this.tabCalendar.Controls.Add(this.panelCalendarObject);
            this.tabCalendar.Controls.Add(this.btnCalendarLogout);
            this.tabCalendar.Controls.Add(this.panelAnnCalendar);
            this.tabCalendar.Controls.Add(this.pbxCalendarLegend);
            this.tabCalendar.Controls.Add(this.lblAnnCalendar);
            this.tabCalendar.Location = new System.Drawing.Point(4, 25);
            this.tabCalendar.Name = "tabCalendar";
            this.tabCalendar.Size = new System.Drawing.Size(1171, 644);
            this.tabCalendar.TabIndex = 2;
            this.tabCalendar.Text = "Calendar";
            this.tabCalendar.UseVisualStyleBackColor = true;
            // 
            // btnAnnCalendar
            // 
            this.btnAnnCalendar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.btnAnnCalendar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.btnAnnCalendar.FlatAppearance.BorderSize = 0;
            this.btnAnnCalendar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAnnCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAnnCalendar.ForeColor = System.Drawing.Color.White;
            this.btnAnnCalendar.Location = new System.Drawing.Point(977, 21);
            this.btnAnnCalendar.Name = "btnAnnCalendar";
            this.btnAnnCalendar.Size = new System.Drawing.Size(182, 55);
            this.btnAnnCalendar.TabIndex = 26;
            this.btnAnnCalendar.Text = "Announcements";
            this.btnAnnCalendar.UseVisualStyleBackColor = false;
            this.btnAnnCalendar.Click += new System.EventHandler(this.BtnAnnCalendar_Click);
            // 
            // panelCalendarObject
            // 
            this.panelCalendarObject.BackgroundImage = global::Tenant_Application.Properties.Resources.panelobject;
            this.panelCalendarObject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelCalendarObject.Controls.Add(this.btnOpenCalendar);
            this.panelCalendarObject.Controls.Add(this.label2);
            this.panelCalendarObject.Controls.Add(this.label1);
            this.panelCalendarObject.Controls.Add(this.lblCalendarMain);
            this.panelCalendarObject.Controls.Add(this.lbxCalendarChores);
            this.panelCalendarObject.Controls.Add(this.lbxCalendarDays);
            this.panelCalendarObject.Controls.Add(this.btnCalendarSelect);
            this.panelCalendarObject.Location = new System.Drawing.Point(55, 81);
            this.panelCalendarObject.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelCalendarObject.Name = "panelCalendarObject";
            this.panelCalendarObject.Size = new System.Drawing.Size(692, 414);
            this.panelCalendarObject.TabIndex = 25;
            // 
            // btnOpenCalendar
            // 
            this.btnOpenCalendar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(66)))), ((int)(((byte)(120)))));
            this.btnOpenCalendar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.btnOpenCalendar.FlatAppearance.BorderSize = 0;
            this.btnOpenCalendar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnOpenCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOpenCalendar.ForeColor = System.Drawing.Color.White;
            this.btnOpenCalendar.Location = new System.Drawing.Point(8, 318);
            this.btnOpenCalendar.Name = "btnOpenCalendar";
            this.btnOpenCalendar.Size = new System.Drawing.Size(248, 65);
            this.btnOpenCalendar.TabIndex = 17;
            this.btnOpenCalendar.Text = "Calendar";
            this.btnOpenCalendar.UseVisualStyleBackColor = false;
            this.btnOpenCalendar.Click += new System.EventHandler(this.btnOpenCalendar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(382, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 29);
            this.label2.TabIndex = 16;
            this.label2.Text = "Available Chores";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 29);
            this.label1.TabIndex = 15;
            this.label1.Text = "Day of the week";
            // 
            // lblCalendarMain
            // 
            this.lblCalendarMain.BackColor = System.Drawing.Color.Transparent;
            this.lblCalendarMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCalendarMain.ForeColor = System.Drawing.Color.White;
            this.lblCalendarMain.Location = new System.Drawing.Point(3, 15);
            this.lblCalendarMain.Name = "lblCalendarMain";
            this.lblCalendarMain.Size = new System.Drawing.Size(562, 52);
            this.lblCalendarMain.TabIndex = 14;
            this.lblCalendarMain.Text = "Choose a day and a chore to do.\r\n";
            // 
            // lbxCalendarChores
            // 
            this.lbxCalendarChores.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbxCalendarChores.FormattingEnabled = true;
            this.lbxCalendarChores.ItemHeight = 26;
            this.lbxCalendarChores.Location = new System.Drawing.Point(363, 89);
            this.lbxCalendarChores.Name = "lbxCalendarChores";
            this.lbxCalendarChores.Size = new System.Drawing.Size(271, 134);
            this.lbxCalendarChores.TabIndex = 12;
            // 
            // lbxCalendarDays
            // 
            this.lbxCalendarDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbxCalendarDays.FormattingEnabled = true;
            this.lbxCalendarDays.ItemHeight = 26;
            this.lbxCalendarDays.Location = new System.Drawing.Point(7, 89);
            this.lbxCalendarDays.Name = "lbxCalendarDays";
            this.lbxCalendarDays.Size = new System.Drawing.Size(256, 134);
            this.lbxCalendarDays.TabIndex = 11;
            this.lbxCalendarDays.SelectedIndexChanged += new System.EventHandler(this.LbxCalendarDays_SelectedIndexChanged);
            // 
            // btnCalendarSelect
            // 
            this.btnCalendarSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(66)))), ((int)(((byte)(120)))));
            this.btnCalendarSelect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.btnCalendarSelect.FlatAppearance.BorderSize = 0;
            this.btnCalendarSelect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCalendarSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalendarSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCalendarSelect.ForeColor = System.Drawing.Color.White;
            this.btnCalendarSelect.Location = new System.Drawing.Point(386, 318);
            this.btnCalendarSelect.Name = "btnCalendarSelect";
            this.btnCalendarSelect.Size = new System.Drawing.Size(248, 65);
            this.btnCalendarSelect.TabIndex = 13;
            this.btnCalendarSelect.Text = "Choose chore";
            this.btnCalendarSelect.UseVisualStyleBackColor = false;
            this.btnCalendarSelect.Click += new System.EventHandler(this.BtnCalendarSelect_Click);
            // 
            // btnCalendarLogout
            // 
            this.btnCalendarLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.btnCalendarLogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.btnCalendarLogout.FlatAppearance.BorderSize = 0;
            this.btnCalendarLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCalendarLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalendarLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCalendarLogout.ForeColor = System.Drawing.Color.White;
            this.btnCalendarLogout.Location = new System.Drawing.Point(16, 577);
            this.btnCalendarLogout.Name = "btnCalendarLogout";
            this.btnCalendarLogout.Size = new System.Drawing.Size(124, 55);
            this.btnCalendarLogout.TabIndex = 24;
            this.btnCalendarLogout.Text = "<--   Logout";
            this.btnCalendarLogout.UseVisualStyleBackColor = false;
            this.btnCalendarLogout.Click += new System.EventHandler(this.BtnComplaintLogout_Click);
            // 
            // panelAnnCalendar
            // 
            this.panelAnnCalendar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.panelAnnCalendar.Controls.Add(this.tbxAnnCalendar);
            this.panelAnnCalendar.Location = new System.Drawing.Point(799, 81);
            this.panelAnnCalendar.Name = "panelAnnCalendar";
            this.panelAnnCalendar.Size = new System.Drawing.Size(363, 553);
            this.panelAnnCalendar.TabIndex = 9;
            this.panelAnnCalendar.Visible = false;
            // 
            // tbxAnnCalendar
            // 
            this.tbxAnnCalendar.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.tbxAnnCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxAnnCalendar.Location = new System.Drawing.Point(15, 15);
            this.tbxAnnCalendar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxAnnCalendar.Name = "tbxAnnCalendar";
            this.tbxAnnCalendar.ReadOnly = true;
            this.tbxAnnCalendar.Size = new System.Drawing.Size(338, 523);
            this.tbxAnnCalendar.TabIndex = 0;
            this.tbxAnnCalendar.Text = "";
            // 
            // pbxCalendarLegend
            // 
            this.pbxCalendarLegend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxCalendarLegend.Image = global::Tenant_Application.Properties.Resources.legend2;
            this.pbxCalendarLegend.Location = new System.Drawing.Point(799, 81);
            this.pbxCalendarLegend.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbxCalendarLegend.Name = "pbxCalendarLegend";
            this.pbxCalendarLegend.Size = new System.Drawing.Size(363, 553);
            this.pbxCalendarLegend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCalendarLegend.TabIndex = 3;
            this.pbxCalendarLegend.TabStop = false;
            // 
            // lblAnnCalendar
            // 
            this.lblAnnCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAnnCalendar.ForeColor = System.Drawing.Color.White;
            this.lblAnnCalendar.Location = new System.Drawing.Point(668, 36);
            this.lblAnnCalendar.Name = "lblAnnCalendar";
            this.lblAnnCalendar.Size = new System.Drawing.Size(311, 41);
            this.lblAnnCalendar.TabIndex = 10;
            this.lblAnnCalendar.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tabChatRoom
            // 
            this.tabChatRoom.BackgroundImage = global::Tenant_Application.Properties.Resources.background1;
            this.tabChatRoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabChatRoom.Controls.Add(this.btnAnnCR);
            this.tabChatRoom.Controls.Add(this.panel1);
            this.tabChatRoom.Controls.Add(this.btnChatLogout);
            this.tabChatRoom.Controls.Add(this.lblAnnChat);
            this.tabChatRoom.Controls.Add(this.panelAnnChat);
            this.tabChatRoom.Controls.Add(this.pbxChatLegend);
            this.tabChatRoom.Location = new System.Drawing.Point(4, 25);
            this.tabChatRoom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabChatRoom.Name = "tabChatRoom";
            this.tabChatRoom.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabChatRoom.Size = new System.Drawing.Size(1171, 644);
            this.tabChatRoom.TabIndex = 0;
            this.tabChatRoom.Text = "Chat Room";
            this.tabChatRoom.UseVisualStyleBackColor = true;
            // 
            // btnAnnCR
            // 
            this.btnAnnCR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.btnAnnCR.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.btnAnnCR.FlatAppearance.BorderSize = 0;
            this.btnAnnCR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAnnCR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnCR.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAnnCR.ForeColor = System.Drawing.Color.White;
            this.btnAnnCR.Location = new System.Drawing.Point(977, 21);
            this.btnAnnCR.Name = "btnAnnCR";
            this.btnAnnCR.Size = new System.Drawing.Size(182, 55);
            this.btnAnnCR.TabIndex = 5;
            this.btnAnnCR.Text = "Announcements";
            this.btnAnnCR.UseVisualStyleBackColor = false;
            this.btnAnnCR.Click += new System.EventHandler(this.BtnAnnCalendar_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Tenant_Application.Properties.Resources.panelobject;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.tbxChat);
            this.panel1.Controls.Add(this.lbxOnlineUsers);
            this.panel1.Controls.Add(this.lblChatMain);
            this.panel1.Controls.Add(this.btnChatSend);
            this.panel1.Controls.Add(this.tbxChatMsg);
            this.panel1.Location = new System.Drawing.Point(16, 81);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(757, 474);
            this.panel1.TabIndex = 26;
            // 
            // tbxChat
            // 
            this.tbxChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxChat.Location = new System.Drawing.Point(9, 84);
            this.tbxChat.Multiline = true;
            this.tbxChat.Name = "tbxChat";
            this.tbxChat.ReadOnly = true;
            this.tbxChat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxChat.Size = new System.Drawing.Size(569, 331);
            this.tbxChat.TabIndex = 3;
            // 
            // lbxOnlineUsers
            // 
            this.lbxOnlineUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbxOnlineUsers.FormattingEnabled = true;
            this.lbxOnlineUsers.ItemHeight = 20;
            this.lbxOnlineUsers.Location = new System.Drawing.Point(584, 84);
            this.lbxOnlineUsers.Name = "lbxOnlineUsers";
            this.lbxOnlineUsers.Size = new System.Drawing.Size(170, 104);
            this.lbxOnlineUsers.TabIndex = 2;
            // 
            // lblChatMain
            // 
            this.lblChatMain.AutoSize = true;
            this.lblChatMain.BackColor = System.Drawing.Color.Transparent;
            this.lblChatMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblChatMain.ForeColor = System.Drawing.Color.White;
            this.lblChatMain.Location = new System.Drawing.Point(2, 14);
            this.lblChatMain.Name = "lblChatMain";
            this.lblChatMain.Size = new System.Drawing.Size(600, 42);
            this.lblChatMain.TabIndex = 1;
            this.lblChatMain.Text = "<name>, welcome to the chat room";
            // 
            // btnChatSend
            // 
            this.btnChatSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(66)))), ((int)(((byte)(120)))));
            this.btnChatSend.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.btnChatSend.FlatAppearance.BorderSize = 0;
            this.btnChatSend.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnChatSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChatSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChatSend.ForeColor = System.Drawing.Color.White;
            this.btnChatSend.Location = new System.Drawing.Point(440, 421);
            this.btnChatSend.Name = "btnChatSend";
            this.btnChatSend.Size = new System.Drawing.Size(138, 43);
            this.btnChatSend.TabIndex = 8;
            this.btnChatSend.Text = "Send";
            this.btnChatSend.UseVisualStyleBackColor = false;
            this.btnChatSend.Click += new System.EventHandler(this.BtnChatSend_Click);
            // 
            // tbxChatMsg
            // 
            this.tbxChatMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxChatMsg.Location = new System.Drawing.Point(9, 430);
            this.tbxChatMsg.MaxLength = 200;
            this.tbxChatMsg.Name = "tbxChatMsg";
            this.tbxChatMsg.Size = new System.Drawing.Size(415, 28);
            this.tbxChatMsg.TabIndex = 9;
            this.tbxChatMsg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxChatMsg_KeyPress);
            // 
            // btnChatLogout
            // 
            this.btnChatLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.btnChatLogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.btnChatLogout.FlatAppearance.BorderSize = 0;
            this.btnChatLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnChatLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChatLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChatLogout.ForeColor = System.Drawing.Color.White;
            this.btnChatLogout.Location = new System.Drawing.Point(16, 577);
            this.btnChatLogout.Name = "btnChatLogout";
            this.btnChatLogout.Size = new System.Drawing.Size(124, 55);
            this.btnChatLogout.TabIndex = 23;
            this.btnChatLogout.Text = "<--   Logout";
            this.btnChatLogout.UseVisualStyleBackColor = false;
            this.btnChatLogout.Click += new System.EventHandler(this.BtnComplaintLogout_Click);
            // 
            // lblAnnChat
            // 
            this.lblAnnChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAnnChat.ForeColor = System.Drawing.Color.White;
            this.lblAnnChat.Location = new System.Drawing.Point(668, 36);
            this.lblAnnChat.Name = "lblAnnChat";
            this.lblAnnChat.Size = new System.Drawing.Size(311, 41);
            this.lblAnnChat.TabIndex = 0;
            this.lblAnnChat.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panelAnnChat
            // 
            this.panelAnnChat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.panelAnnChat.Controls.Add(this.tbxAnnCR);
            this.panelAnnChat.Location = new System.Drawing.Point(799, 81);
            this.panelAnnChat.Name = "panelAnnChat";
            this.panelAnnChat.Size = new System.Drawing.Size(363, 553);
            this.panelAnnChat.TabIndex = 7;
            this.panelAnnChat.Visible = false;
            // 
            // tbxAnnCR
            // 
            this.tbxAnnCR.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.tbxAnnCR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxAnnCR.Location = new System.Drawing.Point(14, 15);
            this.tbxAnnCR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxAnnCR.Name = "tbxAnnCR";
            this.tbxAnnCR.ReadOnly = true;
            this.tbxAnnCR.Size = new System.Drawing.Size(338, 523);
            this.tbxAnnCR.TabIndex = 1;
            this.tbxAnnCR.Text = "";
            // 
            // pbxChatLegend
            // 
            this.pbxChatLegend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxChatLegend.Image = global::Tenant_Application.Properties.Resources.legend2;
            this.pbxChatLegend.Location = new System.Drawing.Point(799, 81);
            this.pbxChatLegend.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbxChatLegend.Name = "pbxChatLegend";
            this.pbxChatLegend.Size = new System.Drawing.Size(363, 553);
            this.pbxChatLegend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxChatLegend.TabIndex = 11;
            this.pbxChatLegend.TabStop = false;
            // 
            // tabGrading
            // 
            this.tabGrading.BackgroundImage = global::Tenant_Application.Properties.Resources.background1;
            this.tabGrading.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabGrading.Controls.Add(this.panel2);
            this.tabGrading.Controls.Add(this.btnScoreboardLogout);
            this.tabGrading.Controls.Add(this.lblAnnScore);
            this.tabGrading.Controls.Add(this.panelAnnScore);
            this.tabGrading.Controls.Add(this.btnAnnScore);
            this.tabGrading.Controls.Add(this.pbxScoreboardLegend);
            this.tabGrading.Location = new System.Drawing.Point(4, 25);
            this.tabGrading.Name = "tabGrading";
            this.tabGrading.Size = new System.Drawing.Size(1171, 644);
            this.tabGrading.TabIndex = 3;
            this.tabGrading.Text = "Scoreboard";
            this.tabGrading.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Tenant_Application.Properties.Resources.panelobject;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.lblScoreboardMain);
            this.panel2.Controls.Add(this.lbxScoreboard);
            this.panel2.Location = new System.Drawing.Point(43, 81);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(477, 440);
            this.panel2.TabIndex = 27;
            // 
            // lblScoreboardMain
            // 
            this.lblScoreboardMain.AutoSize = true;
            this.lblScoreboardMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblScoreboardMain.ForeColor = System.Drawing.Color.White;
            this.lblScoreboardMain.Location = new System.Drawing.Point(13, 41);
            this.lblScoreboardMain.Name = "lblScoreboardMain";
            this.lblScoreboardMain.Size = new System.Drawing.Size(457, 42);
            this.lblScoreboardMain.TabIndex = 16;
            this.lblScoreboardMain.Text = "Tenant activity scoreboard";
            // 
            // lbxScoreboard
            // 
            this.lbxScoreboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbxScoreboard.FormattingEnabled = true;
            this.lbxScoreboard.ItemHeight = 29;
            this.lbxScoreboard.Location = new System.Drawing.Point(20, 120);
            this.lbxScoreboard.Name = "lbxScoreboard";
            this.lbxScoreboard.Size = new System.Drawing.Size(424, 207);
            this.lbxScoreboard.TabIndex = 11;
            // 
            // btnScoreboardLogout
            // 
            this.btnScoreboardLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.btnScoreboardLogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.btnScoreboardLogout.FlatAppearance.BorderSize = 0;
            this.btnScoreboardLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnScoreboardLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScoreboardLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnScoreboardLogout.ForeColor = System.Drawing.Color.White;
            this.btnScoreboardLogout.Location = new System.Drawing.Point(16, 577);
            this.btnScoreboardLogout.Name = "btnScoreboardLogout";
            this.btnScoreboardLogout.Size = new System.Drawing.Size(124, 55);
            this.btnScoreboardLogout.TabIndex = 22;
            this.btnScoreboardLogout.Text = "<--   Logout";
            this.btnScoreboardLogout.UseVisualStyleBackColor = false;
            this.btnScoreboardLogout.Click += new System.EventHandler(this.BtnComplaintLogout_Click);
            // 
            // lblAnnScore
            // 
            this.lblAnnScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAnnScore.ForeColor = System.Drawing.Color.White;
            this.lblAnnScore.Location = new System.Drawing.Point(660, 36);
            this.lblAnnScore.Name = "lblAnnScore";
            this.lblAnnScore.Size = new System.Drawing.Size(311, 41);
            this.lblAnnScore.TabIndex = 10;
            this.lblAnnScore.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panelAnnScore
            // 
            this.panelAnnScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.panelAnnScore.Controls.Add(this.tbxAnnScore);
            this.panelAnnScore.Location = new System.Drawing.Point(799, 81);
            this.panelAnnScore.Name = "panelAnnScore";
            this.panelAnnScore.Size = new System.Drawing.Size(363, 553);
            this.panelAnnScore.TabIndex = 9;
            this.panelAnnScore.Visible = false;
            // 
            // tbxAnnScore
            // 
            this.tbxAnnScore.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.tbxAnnScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxAnnScore.Location = new System.Drawing.Point(14, 15);
            this.tbxAnnScore.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxAnnScore.Name = "tbxAnnScore";
            this.tbxAnnScore.ReadOnly = true;
            this.tbxAnnScore.Size = new System.Drawing.Size(338, 523);
            this.tbxAnnScore.TabIndex = 1;
            this.tbxAnnScore.Text = "";
            // 
            // btnAnnScore
            // 
            this.btnAnnScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.btnAnnScore.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.btnAnnScore.FlatAppearance.BorderSize = 0;
            this.btnAnnScore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAnnScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAnnScore.ForeColor = System.Drawing.Color.White;
            this.btnAnnScore.Location = new System.Drawing.Point(977, 21);
            this.btnAnnScore.Name = "btnAnnScore";
            this.btnAnnScore.Size = new System.Drawing.Size(184, 55);
            this.btnAnnScore.TabIndex = 8;
            this.btnAnnScore.Text = "Announcements";
            this.btnAnnScore.UseVisualStyleBackColor = false;
            this.btnAnnScore.Click += new System.EventHandler(this.BtnAnnCalendar_Click);
            // 
            // pbxScoreboardLegend
            // 
            this.pbxScoreboardLegend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxScoreboardLegend.Image = global::Tenant_Application.Properties.Resources.legend2;
            this.pbxScoreboardLegend.Location = new System.Drawing.Point(799, 81);
            this.pbxScoreboardLegend.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbxScoreboardLegend.Name = "pbxScoreboardLegend";
            this.pbxScoreboardLegend.Size = new System.Drawing.Size(363, 553);
            this.pbxScoreboardLegend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxScoreboardLegend.TabIndex = 18;
            this.pbxScoreboardLegend.TabStop = false;
            // 
            // tabComplaints
            // 
            this.tabComplaints.BackgroundImage = global::Tenant_Application.Properties.Resources.background1;
            this.tabComplaints.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabComplaints.Controls.Add(this.panel3);
            this.tabComplaints.Controls.Add(this.btnComplaintLogout);
            this.tabComplaints.Controls.Add(this.panelAnnComplaints);
            this.tabComplaints.Controls.Add(this.btnAnnComplaints);
            this.tabComplaints.Controls.Add(this.lblAnnComplaints);
            this.tabComplaints.Controls.Add(this.pbxComplaintsLegend);
            this.tabComplaints.Location = new System.Drawing.Point(4, 25);
            this.tabComplaints.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabComplaints.Name = "tabComplaints";
            this.tabComplaints.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabComplaints.Size = new System.Drawing.Size(1171, 644);
            this.tabComplaints.TabIndex = 1;
            this.tabComplaints.Text = "Complaints";
            this.tabComplaints.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::Tenant_Application.Properties.Resources.panelobject;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.tbxComplaint);
            this.panel3.Controls.Add(this.btnSendMail);
            this.panel3.Controls.Add(this.lblComplaintsMain);
            this.panel3.Location = new System.Drawing.Point(66, 81);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(496, 469);
            this.panel3.TabIndex = 28;
            // 
            // tbxComplaint
            // 
            this.tbxComplaint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxComplaint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxComplaint.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxComplaint.Location = new System.Drawing.Point(15, 82);
            this.tbxComplaint.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxComplaint.Name = "tbxComplaint";
            this.tbxComplaint.Size = new System.Drawing.Size(469, 297);
            this.tbxComplaint.TabIndex = 1;
            this.tbxComplaint.Text = "";
            // 
            // btnSendMail
            // 
            this.btnSendMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(66)))), ((int)(((byte)(120)))));
            this.btnSendMail.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.btnSendMail.FlatAppearance.BorderSize = 0;
            this.btnSendMail.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSendMail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSendMail.ForeColor = System.Drawing.Color.White;
            this.btnSendMail.Location = new System.Drawing.Point(151, 395);
            this.btnSendMail.Name = "btnSendMail";
            this.btnSendMail.Size = new System.Drawing.Size(195, 57);
            this.btnSendMail.TabIndex = 3;
            this.btnSendMail.Text = "Send ";
            this.btnSendMail.UseVisualStyleBackColor = false;
            this.btnSendMail.Click += new System.EventHandler(this.BtnSendMail_Click);
            // 
            // lblComplaintsMain
            // 
            this.lblComplaintsMain.AutoSize = true;
            this.lblComplaintsMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblComplaintsMain.ForeColor = System.Drawing.Color.White;
            this.lblComplaintsMain.Location = new System.Drawing.Point(8, 27);
            this.lblComplaintsMain.Name = "lblComplaintsMain";
            this.lblComplaintsMain.Size = new System.Drawing.Size(467, 42);
            this.lblComplaintsMain.TabIndex = 18;
            this.lblComplaintsMain.Text = "Enter your complaint below";
            // 
            // btnComplaintLogout
            // 
            this.btnComplaintLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.btnComplaintLogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.btnComplaintLogout.FlatAppearance.BorderSize = 0;
            this.btnComplaintLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnComplaintLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComplaintLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnComplaintLogout.ForeColor = System.Drawing.Color.White;
            this.btnComplaintLogout.Location = new System.Drawing.Point(16, 577);
            this.btnComplaintLogout.Name = "btnComplaintLogout";
            this.btnComplaintLogout.Size = new System.Drawing.Size(124, 55);
            this.btnComplaintLogout.TabIndex = 21;
            this.btnComplaintLogout.Text = "<--   Logout";
            this.btnComplaintLogout.UseVisualStyleBackColor = false;
            this.btnComplaintLogout.Click += new System.EventHandler(this.BtnComplaintLogout_Click);
            // 
            // panelAnnComplaints
            // 
            this.panelAnnComplaints.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.panelAnnComplaints.Controls.Add(this.tbxAnnCom);
            this.panelAnnComplaints.Location = new System.Drawing.Point(799, 81);
            this.panelAnnComplaints.Name = "panelAnnComplaints";
            this.panelAnnComplaints.Size = new System.Drawing.Size(363, 553);
            this.panelAnnComplaints.TabIndex = 5;
            this.panelAnnComplaints.Visible = false;
            // 
            // tbxAnnCom
            // 
            this.tbxAnnCom.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.tbxAnnCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxAnnCom.Location = new System.Drawing.Point(16, 15);
            this.tbxAnnCom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxAnnCom.Name = "tbxAnnCom";
            this.tbxAnnCom.ReadOnly = true;
            this.tbxAnnCom.Size = new System.Drawing.Size(338, 523);
            this.tbxAnnCom.TabIndex = 29;
            this.tbxAnnCom.Text = "";
            // 
            // btnAnnComplaints
            // 
            this.btnAnnComplaints.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.btnAnnComplaints.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.btnAnnComplaints.FlatAppearance.BorderSize = 0;
            this.btnAnnComplaints.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAnnComplaints.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnComplaints.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAnnComplaints.ForeColor = System.Drawing.Color.White;
            this.btnAnnComplaints.Location = new System.Drawing.Point(980, 21);
            this.btnAnnComplaints.Name = "btnAnnComplaints";
            this.btnAnnComplaints.Size = new System.Drawing.Size(182, 55);
            this.btnAnnComplaints.TabIndex = 4;
            this.btnAnnComplaints.Text = "Announcements";
            this.btnAnnComplaints.UseVisualStyleBackColor = false;
            this.btnAnnComplaints.Click += new System.EventHandler(this.BtnAnnCalendar_Click);
            // 
            // lblAnnComplaints
            // 
            this.lblAnnComplaints.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAnnComplaints.ForeColor = System.Drawing.Color.White;
            this.lblAnnComplaints.Location = new System.Drawing.Point(662, 28);
            this.lblAnnComplaints.Name = "lblAnnComplaints";
            this.lblAnnComplaints.Size = new System.Drawing.Size(311, 41);
            this.lblAnnComplaints.TabIndex = 0;
            this.lblAnnComplaints.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pbxComplaintsLegend
            // 
            this.pbxComplaintsLegend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxComplaintsLegend.Image = global::Tenant_Application.Properties.Resources.legend2;
            this.pbxComplaintsLegend.Location = new System.Drawing.Point(799, 81);
            this.pbxComplaintsLegend.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbxComplaintsLegend.Name = "pbxComplaintsLegend";
            this.pbxComplaintsLegend.Size = new System.Drawing.Size(363, 553);
            this.pbxComplaintsLegend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxComplaintsLegend.TabIndex = 20;
            this.pbxComplaintsLegend.TabStop = false;
            // 
            // timerAnnouncement
            // 
            this.timerAnnouncement.Enabled = true;
            this.timerAnnouncement.Interval = 10000;
            this.timerAnnouncement.Tick += new System.EventHandler(this.TimerAnnouncement_Tick);
            // 
            // timerAnnDisp
            // 
            this.timerAnnDisp.Enabled = true;
            this.timerAnnDisp.Interval = 1000;
            this.timerAnnDisp.Tick += new System.EventHandler(this.TimerAnnDisp_Tick);
            // 
            // timerChatScoreboard
            // 
            this.timerChatScoreboard.Interval = 1000;
            this.timerChatScoreboard.Tick += new System.EventHandler(this.TimerScoreboard_Tick);
            // 
            // UserInterfaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1178, 687);
            this.Controls.Add(this.tabControl);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "UserInterfaceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserInterfaceForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserInterfaceForm_FormClosing);
            this.tabControl.ResumeLayout(false);
            this.tabCalendar.ResumeLayout(false);
            this.panelCalendarObject.ResumeLayout(false);
            this.panelCalendarObject.PerformLayout();
            this.panelAnnCalendar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxCalendarLegend)).EndInit();
            this.tabChatRoom.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelAnnChat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxChatLegend)).EndInit();
            this.tabGrading.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelAnnScore.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxScoreboardLegend)).EndInit();
            this.tabComplaints.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelAnnComplaints.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxComplaintsLegend)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabChatRoom;
        private System.Windows.Forms.TabPage tabComplaints;
        private System.Windows.Forms.RichTextBox tbxComplaint;
        private System.Windows.Forms.ListBox lbxOnlineUsers;
        private System.Windows.Forms.Label lblChatMain;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.Button btnSendMail;
        private System.Windows.Forms.Timer timerAnnouncement;
        private System.Windows.Forms.Panel panelAnnComplaints;
        private System.Windows.Forms.Button btnAnnComplaints;
        private System.Windows.Forms.Label lblAnnComplaints;
        private System.Windows.Forms.TabPage tabCalendar;
        private System.Windows.Forms.TabPage tabGrading;
        private System.Windows.Forms.Panel panelAnnChat;
        private System.Windows.Forms.Button btnChatSend;
        private System.Windows.Forms.Label lblAnnChat;
        private System.Windows.Forms.Panel panelAnnScore;
        private System.Windows.Forms.Button btnAnnScore;
        private System.Windows.Forms.Panel panelAnnCalendar;
        private System.Windows.Forms.Label lblAnnCalendar;
        private System.Windows.Forms.TextBox tbxChatMsg;
        private System.Windows.Forms.TextBox tbxChat;
        private System.Windows.Forms.Button btnCalendarSelect;
        private System.Windows.Forms.ListBox lbxCalendarChores;
        private System.Windows.Forms.ListBox lbxCalendarDays;
        private System.Windows.Forms.Label lblCalendarMain;
        private System.Windows.Forms.ListBox lbxScoreboard;
        private System.Windows.Forms.Timer timerAnnDisp;
        private System.Windows.Forms.Label lblScoreboardMain;
        private System.Windows.Forms.Label lblComplaintsMain;
        private System.Windows.Forms.PictureBox pbxCalendarLegend;
        private System.Windows.Forms.PictureBox pbxChatLegend;
        private System.Windows.Forms.PictureBox pbxScoreboardLegend;
        private System.Windows.Forms.PictureBox pbxComplaintsLegend;
        private System.Windows.Forms.Label lblAnnScore;
        private System.Windows.Forms.Button btnComplaintLogout;
        private System.Windows.Forms.Button btnCalendarLogout;
        private System.Windows.Forms.Button btnChatLogout;
        private System.Windows.Forms.Button btnScoreboardLogout;
        private System.Windows.Forms.Timer timerChatScoreboard;
        private System.Windows.Forms.Panel panelCalendarObject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnOpenCalendar;
        private System.Windows.Forms.RichTextBox tbxAnnCalendar;
        private System.Windows.Forms.RichTextBox tbxAnnCR;
        private System.Windows.Forms.RichTextBox tbxAnnScore;
        private System.Windows.Forms.RichTextBox tbxAnnCom;
        private System.Windows.Forms.Button btnAnnCalendar;
        private System.Windows.Forms.Button btnAnnCR;
    }
}