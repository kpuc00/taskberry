namespace Tenant_Application
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LandLordForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabScoreBoard = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxPoint = new System.Windows.Forms.TextBox();
            this.btnRmvPoint = new System.Windows.Forms.Button();
            this.btnAddPoint = new System.Windows.Forms.Button();
            this.lbxScoreBoard = new System.Windows.Forms.ListBox();
            this.tabAnnouncement = new System.Windows.Forms.TabPage();
            this.btnSend = new System.Windows.Forms.Button();
            this.tbxAnnouncement = new System.Windows.Forms.RichTextBox();
            this.timerRefreshScoreBoard = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabScoreBoard.SuspendLayout();
            this.tabAnnouncement.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabScoreBoard);
            this.tabControl1.Controls.Add(this.tabAnnouncement);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(2344, 1284);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Tag = "";
            // 
            // tabScoreBoard
            // 
            this.tabScoreBoard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabScoreBoard.BackgroundImage")));
            this.tabScoreBoard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabScoreBoard.Controls.Add(this.label1);
            this.tabScoreBoard.Controls.Add(this.tbxPoint);
            this.tabScoreBoard.Controls.Add(this.btnRmvPoint);
            this.tabScoreBoard.Controls.Add(this.btnAddPoint);
            this.tabScoreBoard.Controls.Add(this.lbxScoreBoard);
            this.tabScoreBoard.Location = new System.Drawing.Point(8, 39);
            this.tabScoreBoard.Name = "tabScoreBoard";
            this.tabScoreBoard.Padding = new System.Windows.Forms.Padding(3);
            this.tabScoreBoard.Size = new System.Drawing.Size(2328, 1237);
            this.tabScoreBoard.TabIndex = 0;
            this.tabScoreBoard.Text = "Scoreboard";
            this.tabScoreBoard.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(896, 741);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(538, 59);
            this.label1.TabIndex = 4;
            this.label1.Text = "Set Points";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxPoint
            // 
            this.tbxPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPoint.Location = new System.Drawing.Point(896, 803);
            this.tbxPoint.Name = "tbxPoint";
            this.tbxPoint.Size = new System.Drawing.Size(538, 44);
            this.tbxPoint.TabIndex = 3;
            this.tbxPoint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnRmvPoint
            // 
            this.btnRmvPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRmvPoint.Location = new System.Drawing.Point(1184, 853);
            this.btnRmvPoint.Name = "btnRmvPoint";
            this.btnRmvPoint.Size = new System.Drawing.Size(250, 125);
            this.btnRmvPoint.TabIndex = 2;
            this.btnRmvPoint.Text = "Remove Points";
            this.btnRmvPoint.UseVisualStyleBackColor = true;
            this.btnRmvPoint.Click += new System.EventHandler(this.BtnRmvPoint_Click);
            // 
            // btnAddPoint
            // 
            this.btnAddPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPoint.Location = new System.Drawing.Point(896, 853);
            this.btnAddPoint.Name = "btnAddPoint";
            this.btnAddPoint.Size = new System.Drawing.Size(250, 125);
            this.btnAddPoint.TabIndex = 1;
            this.btnAddPoint.Text = "Add Points";
            this.btnAddPoint.UseVisualStyleBackColor = true;
            this.btnAddPoint.Click += new System.EventHandler(this.BtnAddPoint_Click);
            // 
            // lbxScoreBoard
            // 
            this.lbxScoreBoard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxScoreBoard.FormattingEnabled = true;
            this.lbxScoreBoard.ItemHeight = 25;
            this.lbxScoreBoard.Location = new System.Drawing.Point(830, 232);
            this.lbxScoreBoard.Name = "lbxScoreBoard";
            this.lbxScoreBoard.Size = new System.Drawing.Size(678, 479);
            this.lbxScoreBoard.TabIndex = 0;
            // 
            // tabAnnouncement
            // 
            this.tabAnnouncement.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabAnnouncement.BackgroundImage")));
            this.tabAnnouncement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabAnnouncement.Controls.Add(this.btnSend);
            this.tabAnnouncement.Controls.Add(this.tbxAnnouncement);
            this.tabAnnouncement.Location = new System.Drawing.Point(8, 39);
            this.tabAnnouncement.Name = "tabAnnouncement";
            this.tabAnnouncement.Padding = new System.Windows.Forms.Padding(3);
            this.tabAnnouncement.Size = new System.Drawing.Size(2328, 1237);
            this.tabAnnouncement.TabIndex = 1;
            this.tabAnnouncement.Text = "Announcement";
            this.tabAnnouncement.UseVisualStyleBackColor = true;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(187)))), ((int)(((byte)(238)))));
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(828, 746);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(717, 103);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // tbxAnnouncement
            // 
            this.tbxAnnouncement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxAnnouncement.Location = new System.Drawing.Point(568, 207);
            this.tbxAnnouncement.Name = "tbxAnnouncement";
            this.tbxAnnouncement.Size = new System.Drawing.Size(1240, 498);
            this.tbxAnnouncement.TabIndex = 0;
            this.tbxAnnouncement.Text = "";
            // 
            // timerRefreshScoreBoard
            // 
            this.timerRefreshScoreBoard.Interval = 60000;
            this.timerRefreshScoreBoard.Tick += new System.EventHandler(this.TimerRefreshScoreBoard_Tick);
            // 
            // LandLordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2302, 1166);
            this.Controls.Add(this.tabControl1);
            this.Name = "LandLordForm";
            this.Text = "LandLordForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LandLordForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LandLordForm_FormClosed);
            this.Load += new System.EventHandler(this.LandLordForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabScoreBoard.ResumeLayout(false);
            this.tabScoreBoard.PerformLayout();
            this.tabAnnouncement.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabScoreBoard;
        private System.Windows.Forms.TabPage tabAnnouncement;
        private System.Windows.Forms.Button btnRmvPoint;
        private System.Windows.Forms.Button btnAddPoint;
        private System.Windows.Forms.ListBox lbxScoreBoard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxPoint;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.RichTextBox tbxAnnouncement;
        private System.Windows.Forms.Timer timerRefreshScoreBoard;
    }
}