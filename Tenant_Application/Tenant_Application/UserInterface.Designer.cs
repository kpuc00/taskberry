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
            this.tabCalendar = new System.Windows.Forms.TabPage();
            this.lblAnnCalendar = new System.Windows.Forms.Label();
            this.panelAnnCalendar = new System.Windows.Forms.Panel();
            this.tbxAnnCalendar = new System.Windows.Forms.TextBox();
            this.btnAnnCalendar = new System.Windows.Forms.Button();
            this.tabChatRoom = new System.Windows.Forms.TabPage();
            this.tbxChatMsg = new System.Windows.Forms.TextBox();
            this.lblAnnChat = new System.Windows.Forms.Label();
            this.btnChatSend = new System.Windows.Forms.Button();
            this.panelAnnChat = new System.Windows.Forms.Panel();
            this.tbxAnnChat = new System.Windows.Forms.TextBox();
            this.btn = new System.Windows.Forms.Button();
            this.lbxOnlineUsers = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabGrading = new System.Windows.Forms.TabPage();
            this.lblAnnScore = new System.Windows.Forms.Label();
            this.panelAnnScore = new System.Windows.Forms.Panel();
            this.tbxAnnScore = new System.Windows.Forms.TextBox();
            this.btnAnnScore = new System.Windows.Forms.Button();
            this.tabComplaints = new System.Windows.Forms.TabPage();
            this.panelAnnComplaints = new System.Windows.Forms.Panel();
            this.tbxAnnComplaints = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAnnComplaints = new System.Windows.Forms.Button();
            this.btnSendMail = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxComplaint = new System.Windows.Forms.RichTextBox();
            this.lblAnnComplaints = new System.Windows.Forms.Label();
            this.timerAnnouncement = new System.Windows.Forms.Timer(this.components);
            this.tbxChat = new System.Windows.Forms.TextBox();
            this.tabSwitch.SuspendLayout();
            this.tabCalendar.SuspendLayout();
            this.panelAnnCalendar.SuspendLayout();
            this.tabChatRoom.SuspendLayout();
            this.panelAnnChat.SuspendLayout();
            this.tabGrading.SuspendLayout();
            this.panelAnnScore.SuspendLayout();
            this.tabComplaints.SuspendLayout();
            this.panelAnnComplaints.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabSwitch
            // 
            this.tabSwitch.Controls.Add(this.tabCalendar);
            this.tabSwitch.Controls.Add(this.tabChatRoom);
            this.tabSwitch.Controls.Add(this.tabGrading);
            this.tabSwitch.Controls.Add(this.tabComplaints);
            this.tabSwitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabSwitch.Location = new System.Drawing.Point(6, 6);
            this.tabSwitch.Margin = new System.Windows.Forms.Padding(2);
            this.tabSwitch.Multiline = true;
            this.tabSwitch.Name = "tabSwitch";
            this.tabSwitch.SelectedIndex = 0;
            this.tabSwitch.Size = new System.Drawing.Size(1179, 673);
            this.tabSwitch.TabIndex = 0;
            // 
            // tabCalendar
            // 
            this.tabCalendar.BackgroundImage = global::Tenant_Application.Properties.Resources.background;
            this.tabCalendar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabCalendar.Controls.Add(this.lblAnnCalendar);
            this.tabCalendar.Controls.Add(this.panelAnnCalendar);
            this.tabCalendar.Controls.Add(this.btnAnnCalendar);
            this.tabCalendar.Location = new System.Drawing.Point(4, 24);
            this.tabCalendar.Name = "tabCalendar";
            this.tabCalendar.Size = new System.Drawing.Size(1171, 645);
            this.tabCalendar.TabIndex = 2;
            this.tabCalendar.Text = "Calendar";
            this.tabCalendar.UseVisualStyleBackColor = true;
            // 
            // lblAnnCalendar
            // 
            this.lblAnnCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAnnCalendar.ForeColor = System.Drawing.Color.White;
            this.lblAnnCalendar.Location = new System.Drawing.Point(736, 34);
            this.lblAnnCalendar.Name = "lblAnnCalendar";
            this.lblAnnCalendar.Size = new System.Drawing.Size(271, 41);
            this.lblAnnCalendar.TabIndex = 10;
            this.lblAnnCalendar.TextAlign = System.Drawing.ContentAlignment.TopRight;
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
            this.tbxAnnCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxAnnCalendar.Location = new System.Drawing.Point(14, 12);
            this.tbxAnnCalendar.Multiline = true;
            this.tbxAnnCalendar.Name = "tbxAnnCalendar";
            this.tbxAnnCalendar.ReadOnly = true;
            this.tbxAnnCalendar.Size = new System.Drawing.Size(334, 529);
            this.tbxAnnCalendar.TabIndex = 2;
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
            this.btnAnnCalendar.Location = new System.Drawing.Point(1026, 20);
            this.btnAnnCalendar.Name = "btnAnnCalendar";
            this.btnAnnCalendar.Size = new System.Drawing.Size(136, 55);
            this.btnAnnCalendar.TabIndex = 8;
            this.btnAnnCalendar.Text = "Announcements";
            this.btnAnnCalendar.UseVisualStyleBackColor = false;
            this.btnAnnCalendar.Click += new System.EventHandler(this.BtnAnnCalendar_Click);
            // 
            // tabChatRoom
            // 
            this.tabChatRoom.BackgroundImage = global::Tenant_Application.Properties.Resources.background;
            this.tabChatRoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabChatRoom.Controls.Add(this.tbxChat);
            this.tabChatRoom.Controls.Add(this.tbxChatMsg);
            this.tabChatRoom.Controls.Add(this.lblAnnChat);
            this.tabChatRoom.Controls.Add(this.btnChatSend);
            this.tabChatRoom.Controls.Add(this.panelAnnChat);
            this.tabChatRoom.Controls.Add(this.btn);
            this.tabChatRoom.Controls.Add(this.lbxOnlineUsers);
            this.tabChatRoom.Controls.Add(this.label2);
            this.tabChatRoom.Location = new System.Drawing.Point(4, 24);
            this.tabChatRoom.Margin = new System.Windows.Forms.Padding(2);
            this.tabChatRoom.Name = "tabChatRoom";
            this.tabChatRoom.Padding = new System.Windows.Forms.Padding(2);
            this.tabChatRoom.Size = new System.Drawing.Size(1171, 645);
            this.tabChatRoom.TabIndex = 0;
            this.tabChatRoom.Text = "Chat Room";
            this.tabChatRoom.UseVisualStyleBackColor = true;
            // 
            // tbxChatMsg
            // 
            this.tbxChatMsg.Location = new System.Drawing.Point(59, 487);
            this.tbxChatMsg.Multiline = true;
            this.tbxChatMsg.Name = "tbxChatMsg";
            this.tbxChatMsg.Size = new System.Drawing.Size(415, 27);
            this.tbxChatMsg.TabIndex = 9;
            // 
            // lblAnnChat
            // 
            this.lblAnnChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAnnChat.ForeColor = System.Drawing.Color.White;
            this.lblAnnChat.Location = new System.Drawing.Point(731, 37);
            this.lblAnnChat.Name = "lblAnnChat";
            this.lblAnnChat.Size = new System.Drawing.Size(271, 41);
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
            this.btnChatSend.Location = new System.Drawing.Point(490, 487);
            this.btnChatSend.Name = "btnChatSend";
            this.btnChatSend.Size = new System.Drawing.Size(138, 27);
            this.btnChatSend.TabIndex = 8;
            this.btnChatSend.Text = "Send";
            this.btnChatSend.UseVisualStyleBackColor = false;
            this.btnChatSend.Click += new System.EventHandler(this.BtnChatSend_Click);
            // 
            // panelAnnChat
            // 
            this.panelAnnChat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.panelAnnChat.Controls.Add(this.tbxAnnChat);
            this.panelAnnChat.Location = new System.Drawing.Point(799, 81);
            this.panelAnnChat.Name = "panelAnnChat";
            this.panelAnnChat.Size = new System.Drawing.Size(363, 553);
            this.panelAnnChat.TabIndex = 7;
            this.panelAnnChat.Visible = false;
            // 
            // tbxAnnChat
            // 
            this.tbxAnnChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxAnnChat.Location = new System.Drawing.Point(14, 12);
            this.tbxAnnChat.Multiline = true;
            this.tbxAnnChat.Name = "tbxAnnChat";
            this.tbxAnnChat.ReadOnly = true;
            this.tbxAnnChat.Size = new System.Drawing.Size(334, 529);
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
            this.btn.Location = new System.Drawing.Point(1026, 20);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(136, 55);
            this.btn.TabIndex = 5;
            this.btn.Text = "Announcements";
            this.btn.UseVisualStyleBackColor = false;
            this.btn.Click += new System.EventHandler(this.Btn_Click);
            // 
            // lbxOnlineUsers
            // 
            this.lbxOnlineUsers.FormattingEnabled = true;
            this.lbxOnlineUsers.ItemHeight = 15;
            this.lbxOnlineUsers.Location = new System.Drawing.Point(634, 151);
            this.lbxOnlineUsers.Name = "lbxOnlineUsers";
            this.lbxOnlineUsers.Size = new System.Drawing.Size(159, 154);
            this.lbxOnlineUsers.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(52, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(545, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Welcome <name> to the chat room";
            // 
            // tabGrading
            // 
            this.tabGrading.BackgroundImage = global::Tenant_Application.Properties.Resources.background;
            this.tabGrading.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabGrading.Controls.Add(this.lblAnnScore);
            this.tabGrading.Controls.Add(this.panelAnnScore);
            this.tabGrading.Controls.Add(this.btnAnnScore);
            this.tabGrading.Location = new System.Drawing.Point(4, 24);
            this.tabGrading.Name = "tabGrading";
            this.tabGrading.Size = new System.Drawing.Size(1171, 645);
            this.tabGrading.TabIndex = 3;
            this.tabGrading.Text = "Scoreboard";
            this.tabGrading.UseVisualStyleBackColor = true;
            // 
            // lblAnnScore
            // 
            this.lblAnnScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAnnScore.ForeColor = System.Drawing.Color.White;
            this.lblAnnScore.Location = new System.Drawing.Point(738, 38);
            this.lblAnnScore.Name = "lblAnnScore";
            this.lblAnnScore.Size = new System.Drawing.Size(271, 41);
            this.lblAnnScore.TabIndex = 10;
            this.lblAnnScore.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panelAnnScore
            // 
            this.panelAnnScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.panelAnnScore.Controls.Add(this.tbxAnnScore);
            this.panelAnnScore.Location = new System.Drawing.Point(799, 82);
            this.panelAnnScore.Name = "panelAnnScore";
            this.panelAnnScore.Size = new System.Drawing.Size(363, 553);
            this.panelAnnScore.TabIndex = 9;
            this.panelAnnScore.Visible = false;
            // 
            // tbxAnnScore
            // 
            this.tbxAnnScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxAnnScore.Location = new System.Drawing.Point(14, 12);
            this.tbxAnnScore.Multiline = true;
            this.tbxAnnScore.Name = "tbxAnnScore";
            this.tbxAnnScore.ReadOnly = true;
            this.tbxAnnScore.Size = new System.Drawing.Size(334, 529);
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
            this.btnAnnScore.Location = new System.Drawing.Point(1026, 21);
            this.btnAnnScore.Name = "btnAnnScore";
            this.btnAnnScore.Size = new System.Drawing.Size(136, 55);
            this.btnAnnScore.TabIndex = 8;
            this.btnAnnScore.Text = "Announcements";
            this.btnAnnScore.UseVisualStyleBackColor = false;
            this.btnAnnScore.Click += new System.EventHandler(this.BtnAnnScore_Click);
            // 
            // tabComplaints
            // 
            this.tabComplaints.BackgroundImage = global::Tenant_Application.Properties.Resources.background;
            this.tabComplaints.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabComplaints.Controls.Add(this.panelAnnComplaints);
            this.tabComplaints.Controls.Add(this.textBox1);
            this.tabComplaints.Controls.Add(this.button1);
            this.tabComplaints.Controls.Add(this.btnAnnComplaints);
            this.tabComplaints.Controls.Add(this.btnSendMail);
            this.tabComplaints.Controls.Add(this.label1);
            this.tabComplaints.Controls.Add(this.tbxComplaint);
            this.tabComplaints.Controls.Add(this.lblAnnComplaints);
            this.tabComplaints.Location = new System.Drawing.Point(4, 24);
            this.tabComplaints.Margin = new System.Windows.Forms.Padding(2);
            this.tabComplaints.Name = "tabComplaints";
            this.tabComplaints.Padding = new System.Windows.Forms.Padding(2);
            this.tabComplaints.Size = new System.Drawing.Size(1171, 645);
            this.tabComplaints.TabIndex = 1;
            this.tabComplaints.Text = "Complaints";
            this.tabComplaints.UseVisualStyleBackColor = true;
            this.tabComplaints.Click += new System.EventHandler(this.TabPage2_Click);
            // 
            // panelAnnComplaints
            // 
            this.panelAnnComplaints.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.panelAnnComplaints.Controls.Add(this.tbxAnnComplaints);
            this.panelAnnComplaints.Location = new System.Drawing.Point(799, 79);
            this.panelAnnComplaints.Name = "panelAnnComplaints";
            this.panelAnnComplaints.Size = new System.Drawing.Size(363, 553);
            this.panelAnnComplaints.TabIndex = 5;
            this.panelAnnComplaints.Visible = false;
            // 
            // tbxAnnComplaints
            // 
            this.tbxAnnComplaints.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxAnnComplaints.Location = new System.Drawing.Point(14, 12);
            this.tbxAnnComplaints.Multiline = true;
            this.tbxAnnComplaints.Name = "tbxAnnComplaints";
            this.tbxAnnComplaints.ReadOnly = true;
            this.tbxAnnComplaints.Size = new System.Drawing.Size(334, 529);
            this.tbxAnnComplaints.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(676, 551);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
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
            this.button1.Location = new System.Drawing.Point(676, 577);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 55);
            this.button1.TabIndex = 6;
            this.button1.Text = "Temp Button";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
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
            this.btnAnnComplaints.Location = new System.Drawing.Point(1026, 18);
            this.btnAnnComplaints.Name = "btnAnnComplaints";
            this.btnAnnComplaints.Size = new System.Drawing.Size(136, 55);
            this.btnAnnComplaints.TabIndex = 4;
            this.btnAnnComplaints.Text = "Announcements";
            this.btnAnnComplaints.UseVisualStyleBackColor = false;
            this.btnAnnComplaints.Click += new System.EventHandler(this.BtnAnnComplaints_Click);
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
            this.btnSendMail.Location = new System.Drawing.Point(203, 574);
            this.btnSendMail.Name = "btnSendMail";
            this.btnSendMail.Size = new System.Drawing.Size(195, 57);
            this.btnSendMail.TabIndex = 3;
            this.btnSendMail.Text = "Send ";
            this.btnSendMail.UseVisualStyleBackColor = false;
            this.btnSendMail.Click += new System.EventHandler(this.BtnSendMail_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(604, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter your complaint down below and press send";
            // 
            // tbxComplaint
            // 
            this.tbxComplaint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxComplaint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxComplaint.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxComplaint.Location = new System.Drawing.Point(122, 127);
            this.tbxComplaint.Margin = new System.Windows.Forms.Padding(2);
            this.tbxComplaint.Name = "tbxComplaint";
            this.tbxComplaint.Size = new System.Drawing.Size(357, 430);
            this.tbxComplaint.TabIndex = 1;
            this.tbxComplaint.Text = "";
            // 
            // lblAnnComplaints
            // 
            this.lblAnnComplaints.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAnnComplaints.ForeColor = System.Drawing.Color.White;
            this.lblAnnComplaints.Location = new System.Drawing.Point(694, 35);
            this.lblAnnComplaints.Name = "lblAnnComplaints";
            this.lblAnnComplaints.Size = new System.Drawing.Size(311, 175);
            this.lblAnnComplaints.TabIndex = 0;
            this.lblAnnComplaints.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // timerAnnouncement
            // 
            this.timerAnnouncement.Interval = 10000;
            this.timerAnnouncement.Tick += new System.EventHandler(this.TimerAnnouncement_Tick);
            // 
            // tbxChat
            // 
            this.tbxChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxChat.Location = new System.Drawing.Point(59, 151);
            this.tbxChat.Multiline = true;
            this.tbxChat.Name = "tbxChat";
            this.tbxChat.ReadOnly = true;
            this.tbxChat.Size = new System.Drawing.Size(569, 313);
            this.tbxChat.TabIndex = 3;
            // 
            // UserInterfaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.Controls.Add(this.tabSwitch);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserInterfaceForm";
            this.Text = "UserInterfaceForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserInterfaceForm_FormClosing);
            this.Load += new System.EventHandler(this.UserInterfaceForm_Load);
            this.tabSwitch.ResumeLayout(false);
            this.tabCalendar.ResumeLayout(false);
            this.panelAnnCalendar.ResumeLayout(false);
            this.panelAnnCalendar.PerformLayout();
            this.tabChatRoom.ResumeLayout(false);
            this.tabChatRoom.PerformLayout();
            this.panelAnnChat.ResumeLayout(false);
            this.panelAnnChat.PerformLayout();
            this.tabGrading.ResumeLayout(false);
            this.panelAnnScore.ResumeLayout(false);
            this.panelAnnScore.PerformLayout();
            this.tabComplaints.ResumeLayout(false);
            this.tabComplaints.PerformLayout();
            this.panelAnnComplaints.ResumeLayout(false);
            this.panelAnnComplaints.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabChatRoom;
        private System.Windows.Forms.TabPage tabComplaints;
        private System.Windows.Forms.RichTextBox tbxComplaint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbxOnlineUsers;
        private System.Windows.Forms.Label label2;
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
    }
}