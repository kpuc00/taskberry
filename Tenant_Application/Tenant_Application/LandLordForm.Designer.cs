﻿namespace Tenant_Application
{
    partial class LandLordForm
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
            this.tabControlLandlord = new System.Windows.Forms.TabControl();
            this.tabScoreBoard = new System.Windows.Forms.TabPage();
            this.panelCalendarObject = new System.Windows.Forms.Panel();
            this.lblCalendar = new System.Windows.Forms.Label();
            this.btnResetCalendar = new System.Windows.Forms.Button();
            this.lblPointsSet = new System.Windows.Forms.Label();
            this.btnAddPoint = new System.Windows.Forms.Button();
            this.lblCalendarMain = new System.Windows.Forms.Label();
            this.lbxScoreBoard = new System.Windows.Forms.ListBox();
            this.tbxPoint = new System.Windows.Forms.TextBox();
            this.pbxCalendarLegend = new System.Windows.Forms.PictureBox();
            this.btnScoreboardLogout = new System.Windows.Forms.Button();
            this.tabAnnouncement = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblComplaintsMain = new System.Windows.Forms.Label();
            this.tbxAnnouncement = new System.Windows.Forms.RichTextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnAnnouncementLogout = new System.Windows.Forms.Button();
            this.tabRegistration = new System.Windows.Forms.TabPage();
            this.btnLogoutMng = new System.Windows.Forms.Button();
            this.panelAccMng = new System.Windows.Forms.Panel();
            this.lblAccMng = new System.Windows.Forms.Label();
            this.lbxAccInfo = new System.Windows.Forms.ListBox();
            this.btnCreateAcc = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.timerUpdateAccounts = new System.Windows.Forms.Timer(this.components);
            this.tabControlLandlord.SuspendLayout();
            this.tabScoreBoard.SuspendLayout();
            this.panelCalendarObject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCalendarLegend)).BeginInit();
            this.tabAnnouncement.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabRegistration.SuspendLayout();
            this.panelAccMng.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlLandlord
            // 
            this.tabControlLandlord.Controls.Add(this.tabScoreBoard);
            this.tabControlLandlord.Controls.Add(this.tabAnnouncement);
            this.tabControlLandlord.Controls.Add(this.tabRegistration);
            this.tabControlLandlord.Location = new System.Drawing.Point(6, 6);
            this.tabControlLandlord.Margin = new System.Windows.Forms.Padding(2);
            this.tabControlLandlord.Name = "tabControlLandlord";
            this.tabControlLandlord.SelectedIndex = 0;
            this.tabControlLandlord.Size = new System.Drawing.Size(1172, 668);
            this.tabControlLandlord.TabIndex = 0;
            this.tabControlLandlord.Tag = "";
            this.tabControlLandlord.SelectedIndexChanged += new System.EventHandler(this.TabControl1_SelectedIndexChanged);
            // 
            // tabScoreBoard
            // 
            this.tabScoreBoard.BackgroundImage = global::Tenant_Application.Properties.Resources.background1;
            this.tabScoreBoard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabScoreBoard.Controls.Add(this.panelCalendarObject);
            this.tabScoreBoard.Controls.Add(this.pbxCalendarLegend);
            this.tabScoreBoard.Controls.Add(this.btnScoreboardLogout);
            this.tabScoreBoard.Location = new System.Drawing.Point(4, 22);
            this.tabScoreBoard.Margin = new System.Windows.Forms.Padding(2);
            this.tabScoreBoard.Name = "tabScoreBoard";
            this.tabScoreBoard.Padding = new System.Windows.Forms.Padding(2);
            this.tabScoreBoard.Size = new System.Drawing.Size(1164, 642);
            this.tabScoreBoard.TabIndex = 0;
            this.tabScoreBoard.Text = "Scoreboard";
            this.tabScoreBoard.UseVisualStyleBackColor = true;
            // 
            // panelCalendarObject
            // 
            this.panelCalendarObject.BackgroundImage = global::Tenant_Application.Properties.Resources.panelobject;
            this.panelCalendarObject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelCalendarObject.Controls.Add(this.lblCalendar);
            this.panelCalendarObject.Controls.Add(this.btnResetCalendar);
            this.panelCalendarObject.Controls.Add(this.lblPointsSet);
            this.panelCalendarObject.Controls.Add(this.btnAddPoint);
            this.panelCalendarObject.Controls.Add(this.lblCalendarMain);
            this.panelCalendarObject.Controls.Add(this.lbxScoreBoard);
            this.panelCalendarObject.Controls.Add(this.tbxPoint);
            this.panelCalendarObject.Location = new System.Drawing.Point(217, 77);
            this.panelCalendarObject.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelCalendarObject.Name = "panelCalendarObject";
            this.panelCalendarObject.Size = new System.Drawing.Size(544, 553);
            this.panelCalendarObject.TabIndex = 28;
            // 
            // lblCalendar
            // 
            this.lblCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCalendar.ForeColor = System.Drawing.Color.White;
            this.lblCalendar.Location = new System.Drawing.Point(350, 247);
            this.lblCalendar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCalendar.Name = "lblCalendar";
            this.lblCalendar.Size = new System.Drawing.Size(194, 24);
            this.lblCalendar.TabIndex = 28;
            this.lblCalendar.Text = "Manually reset the calendar";
            // 
            // btnResetCalendar
            // 
            this.btnResetCalendar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(66)))), ((int)(((byte)(120)))));
            this.btnResetCalendar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.btnResetCalendar.FlatAppearance.BorderSize = 0;
            this.btnResetCalendar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnResetCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnResetCalendar.ForeColor = System.Drawing.Color.White;
            this.btnResetCalendar.Location = new System.Drawing.Point(353, 275);
            this.btnResetCalendar.Name = "btnResetCalendar";
            this.btnResetCalendar.Size = new System.Drawing.Size(181, 57);
            this.btnResetCalendar.TabIndex = 27;
            this.btnResetCalendar.Text = "Reset Calendar";
            this.btnResetCalendar.UseVisualStyleBackColor = false;
            this.btnResetCalendar.Click += new System.EventHandler(this.BtnResetCalendar_Click);
            // 
            // lblPointsSet
            // 
            this.lblPointsSet.AutoSize = true;
            this.lblPointsSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPointsSet.ForeColor = System.Drawing.Color.White;
            this.lblPointsSet.Location = new System.Drawing.Point(142, 415);
            this.lblPointsSet.Name = "lblPointsSet";
            this.lblPointsSet.Size = new System.Drawing.Size(112, 26);
            this.lblPointsSet.TabIndex = 16;
            this.lblPointsSet.Text = "Set Points";
            // 
            // btnAddPoint
            // 
            this.btnAddPoint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(66)))), ((int)(((byte)(120)))));
            this.btnAddPoint.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.btnAddPoint.FlatAppearance.BorderSize = 0;
            this.btnAddPoint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAddPoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddPoint.ForeColor = System.Drawing.Color.White;
            this.btnAddPoint.Location = new System.Drawing.Point(86, 472);
            this.btnAddPoint.Name = "btnAddPoint";
            this.btnAddPoint.Size = new System.Drawing.Size(212, 57);
            this.btnAddPoint.TabIndex = 26;
            this.btnAddPoint.Text = "Set";
            this.btnAddPoint.UseVisualStyleBackColor = false;
            this.btnAddPoint.Click += new System.EventHandler(this.BtnAddPoint_Click);
            // 
            // lblCalendarMain
            // 
            this.lblCalendarMain.AutoSize = true;
            this.lblCalendarMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCalendarMain.ForeColor = System.Drawing.Color.White;
            this.lblCalendarMain.Location = new System.Drawing.Point(12, 16);
            this.lblCalendarMain.Name = "lblCalendarMain";
            this.lblCalendarMain.Size = new System.Drawing.Size(393, 42);
            this.lblCalendarMain.TabIndex = 14;
            this.lblCalendarMain.Text = "Set the score of a user";
            // 
            // lbxScoreBoard
            // 
            this.lbxScoreBoard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxScoreBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbxScoreBoard.FormattingEnabled = true;
            this.lbxScoreBoard.ItemHeight = 20;
            this.lbxScoreBoard.Location = new System.Drawing.Point(49, 93);
            this.lbxScoreBoard.Margin = new System.Windows.Forms.Padding(2);
            this.lbxScoreBoard.Name = "lbxScoreBoard";
            this.lbxScoreBoard.Size = new System.Drawing.Size(288, 284);
            this.lbxScoreBoard.TabIndex = 0;
            // 
            // tbxPoint
            // 
            this.tbxPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxPoint.Location = new System.Drawing.Point(49, 443);
            this.tbxPoint.Margin = new System.Windows.Forms.Padding(2);
            this.tbxPoint.Name = "tbxPoint";
            this.tbxPoint.Size = new System.Drawing.Size(288, 26);
            this.tbxPoint.TabIndex = 3;
            this.tbxPoint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pbxCalendarLegend
            // 
            this.pbxCalendarLegend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxCalendarLegend.Image = global::Tenant_Application.Properties.Resources.legend;
            this.pbxCalendarLegend.Location = new System.Drawing.Point(778, 77);
            this.pbxCalendarLegend.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbxCalendarLegend.Name = "pbxCalendarLegend";
            this.pbxCalendarLegend.Size = new System.Drawing.Size(363, 553);
            this.pbxCalendarLegend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCalendarLegend.TabIndex = 27;
            this.pbxCalendarLegend.TabStop = false;
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
            this.btnScoreboardLogout.Location = new System.Drawing.Point(31, 567);
            this.btnScoreboardLogout.Name = "btnScoreboardLogout";
            this.btnScoreboardLogout.Size = new System.Drawing.Size(124, 55);
            this.btnScoreboardLogout.TabIndex = 25;
            this.btnScoreboardLogout.Text = "<--   Logout";
            this.btnScoreboardLogout.UseVisualStyleBackColor = false;
            this.btnScoreboardLogout.Click += new System.EventHandler(this.BtnAnnouncementLogout_Click);
            // 
            // tabAnnouncement
            // 
            this.tabAnnouncement.BackgroundImage = global::Tenant_Application.Properties.Resources.background1;
            this.tabAnnouncement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabAnnouncement.Controls.Add(this.panel3);
            this.tabAnnouncement.Controls.Add(this.btnAnnouncementLogout);
            this.tabAnnouncement.Location = new System.Drawing.Point(4, 22);
            this.tabAnnouncement.Margin = new System.Windows.Forms.Padding(2);
            this.tabAnnouncement.Name = "tabAnnouncement";
            this.tabAnnouncement.Padding = new System.Windows.Forms.Padding(2);
            this.tabAnnouncement.Size = new System.Drawing.Size(1164, 642);
            this.tabAnnouncement.TabIndex = 1;
            this.tabAnnouncement.Text = "Announcement";
            this.tabAnnouncement.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::Tenant_Application.Properties.Resources.panelobject;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.lblComplaintsMain);
            this.panel3.Controls.Add(this.tbxAnnouncement);
            this.panel3.Controls.Add(this.btnSend);
            this.panel3.Location = new System.Drawing.Point(255, 81);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(692, 469);
            this.panel3.TabIndex = 29;
            // 
            // lblComplaintsMain
            // 
            this.lblComplaintsMain.AutoSize = true;
            this.lblComplaintsMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblComplaintsMain.ForeColor = System.Drawing.Color.White;
            this.lblComplaintsMain.Location = new System.Drawing.Point(108, 40);
            this.lblComplaintsMain.Name = "lblComplaintsMain";
            this.lblComplaintsMain.Size = new System.Drawing.Size(525, 42);
            this.lblComplaintsMain.TabIndex = 18;
            this.lblComplaintsMain.Text = "Enter an announcement below";
            // 
            // tbxAnnouncement
            // 
            this.tbxAnnouncement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxAnnouncement.Location = new System.Drawing.Point(35, 98);
            this.tbxAnnouncement.Margin = new System.Windows.Forms.Padding(2);
            this.tbxAnnouncement.Name = "tbxAnnouncement";
            this.tbxAnnouncement.Size = new System.Drawing.Size(622, 273);
            this.tbxAnnouncement.TabIndex = 0;
            this.tbxAnnouncement.Text = "";
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(66)))), ((int)(((byte)(120)))));
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(162, 388);
            this.btnSend.Margin = new System.Windows.Forms.Padding(2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(358, 54);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // btnAnnouncementLogout
            // 
            this.btnAnnouncementLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.btnAnnouncementLogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.btnAnnouncementLogout.FlatAppearance.BorderSize = 0;
            this.btnAnnouncementLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAnnouncementLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnouncementLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAnnouncementLogout.ForeColor = System.Drawing.Color.White;
            this.btnAnnouncementLogout.Location = new System.Drawing.Point(31, 567);
            this.btnAnnouncementLogout.Name = "btnAnnouncementLogout";
            this.btnAnnouncementLogout.Size = new System.Drawing.Size(124, 55);
            this.btnAnnouncementLogout.TabIndex = 25;
            this.btnAnnouncementLogout.Text = "<--   Logout";
            this.btnAnnouncementLogout.UseVisualStyleBackColor = false;
            this.btnAnnouncementLogout.Click += new System.EventHandler(this.BtnAnnouncementLogout_Click);
            // 
            // tabRegistration
            // 
            this.tabRegistration.BackgroundImage = global::Tenant_Application.Properties.Resources.background2;
            this.tabRegistration.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabRegistration.Controls.Add(this.btnLogoutMng);
            this.tabRegistration.Controls.Add(this.panelAccMng);
            this.tabRegistration.Location = new System.Drawing.Point(4, 22);
            this.tabRegistration.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabRegistration.Name = "tabRegistration";
            this.tabRegistration.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabRegistration.Size = new System.Drawing.Size(1164, 642);
            this.tabRegistration.TabIndex = 2;
            this.tabRegistration.Text = "Account Managment";
            this.tabRegistration.UseVisualStyleBackColor = true;
            // 
            // btnLogoutMng
            // 
            this.btnLogoutMng.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.btnLogoutMng.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.btnLogoutMng.FlatAppearance.BorderSize = 0;
            this.btnLogoutMng.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnLogoutMng.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogoutMng.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLogoutMng.ForeColor = System.Drawing.Color.White;
            this.btnLogoutMng.Location = new System.Drawing.Point(31, 567);
            this.btnLogoutMng.Name = "btnLogoutMng";
            this.btnLogoutMng.Size = new System.Drawing.Size(124, 55);
            this.btnLogoutMng.TabIndex = 26;
            this.btnLogoutMng.Text = "<--   Logout";
            this.btnLogoutMng.UseVisualStyleBackColor = false;
            this.btnLogoutMng.Click += new System.EventHandler(this.BtnAnnouncementLogout_Click);
            // 
            // panelAccMng
            // 
            this.panelAccMng.BackgroundImage = global::Tenant_Application.Properties.Resources.panelobject;
            this.panelAccMng.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelAccMng.Controls.Add(this.lblAccMng);
            this.panelAccMng.Controls.Add(this.lbxAccInfo);
            this.panelAccMng.Controls.Add(this.btnCreateAcc);
            this.panelAccMng.Controls.Add(this.btnDelete);
            this.panelAccMng.Controls.Add(this.btnModify);
            this.panelAccMng.Location = new System.Drawing.Point(218, 33);
            this.panelAccMng.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelAccMng.Name = "panelAccMng";
            this.panelAccMng.Size = new System.Drawing.Size(770, 593);
            this.panelAccMng.TabIndex = 5;
            // 
            // lblAccMng
            // 
            this.lblAccMng.AutoSize = true;
            this.lblAccMng.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAccMng.ForeColor = System.Drawing.Color.White;
            this.lblAccMng.Location = new System.Drawing.Point(55, 21);
            this.lblAccMng.Name = "lblAccMng";
            this.lblAccMng.Size = new System.Drawing.Size(357, 42);
            this.lblAccMng.TabIndex = 19;
            this.lblAccMng.Text = "All existing accounts";
            // 
            // lbxAccInfo
            // 
            this.lbxAccInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbxAccInfo.FormattingEnabled = true;
            this.lbxAccInfo.ItemHeight = 20;
            this.lbxAccInfo.Location = new System.Drawing.Point(62, 78);
            this.lbxAccInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbxAccInfo.Name = "lbxAccInfo";
            this.lbxAccInfo.Size = new System.Drawing.Size(416, 424);
            this.lbxAccInfo.TabIndex = 0;
            // 
            // btnCreateAcc
            // 
            this.btnCreateAcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(66)))), ((int)(((byte)(120)))));
            this.btnCreateAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreateAcc.ForeColor = System.Drawing.Color.White;
            this.btnCreateAcc.Location = new System.Drawing.Point(512, 220);
            this.btnCreateAcc.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateAcc.Name = "btnCreateAcc";
            this.btnCreateAcc.Size = new System.Drawing.Size(231, 54);
            this.btnCreateAcc.TabIndex = 4;
            this.btnCreateAcc.Text = "Create a new account";
            this.btnCreateAcc.UseVisualStyleBackColor = false;
            this.btnCreateAcc.Click += new System.EventHandler(this.BtnCreateAcc_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(62, 522);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(122, 54);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete Account";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(66)))), ((int)(((byte)(120)))));
            this.btnModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnModify.ForeColor = System.Drawing.Color.White;
            this.btnModify.Location = new System.Drawing.Point(274, 522);
            this.btnModify.Margin = new System.Windows.Forms.Padding(2);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(202, 54);
            this.btnModify.TabIndex = 3;
            this.btnModify.Text = "Modify Account";
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.BtnModify_Click);
            // 
            // timerUpdateAccounts
            // 
            this.timerUpdateAccounts.Interval = 10000;
            this.timerUpdateAccounts.Tick += new System.EventHandler(this.TimerUpdateAccounts_Tick);
            // 
            // LandLordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 687);
            this.Controls.Add(this.tabControlLandlord);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "LandLordForm";
            this.Text = "LandLordForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LandLordForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LandLordForm_FormClosed);
            this.Load += new System.EventHandler(this.LandLordForm_Load);
            this.tabControlLandlord.ResumeLayout(false);
            this.tabScoreBoard.ResumeLayout(false);
            this.panelCalendarObject.ResumeLayout(false);
            this.panelCalendarObject.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCalendarLegend)).EndInit();
            this.tabAnnouncement.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabRegistration.ResumeLayout(false);
            this.panelAccMng.ResumeLayout(false);
            this.panelAccMng.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlLandlord;
        private System.Windows.Forms.TabPage tabScoreBoard;
        private System.Windows.Forms.TabPage tabAnnouncement;
        private System.Windows.Forms.ListBox lbxScoreBoard;
        private System.Windows.Forms.TextBox tbxPoint;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.RichTextBox tbxAnnouncement;
        private System.Windows.Forms.Button btnScoreboardLogout;
        private System.Windows.Forms.Button btnAnnouncementLogout;
        private System.Windows.Forms.Button btnAddPoint;
        private System.Windows.Forms.TabPage tabRegistration;
        private System.Windows.Forms.PictureBox pbxCalendarLegend;
        private System.Windows.Forms.Panel panelCalendarObject;
        private System.Windows.Forms.Label lblPointsSet;
        private System.Windows.Forms.Label lblCalendarMain;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblComplaintsMain;
        private System.Windows.Forms.Button btnCreateAcc;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListBox lbxAccInfo;
        private System.Windows.Forms.Panel panelAccMng;
        private System.Windows.Forms.Label lblAccMng;
        private System.Windows.Forms.Timer timerUpdateAccounts;
        private System.Windows.Forms.Button btnLogoutMng;
        private System.Windows.Forms.Button btnResetCalendar;
        private System.Windows.Forms.Label lblCalendar;
    }
}