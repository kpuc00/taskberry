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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInterfaceForm));
            this.tabEmailComplaint = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxComplaint = new System.Windows.Forms.RichTextBox();
            this.btnSendMail = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.tabEmailComplaint.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabEmailComplaint
            // 
            this.tabEmailComplaint.Controls.Add(this.tabPage1);
            this.tabEmailComplaint.Controls.Add(this.tabPage2);
            this.tabEmailComplaint.Location = new System.Drawing.Point(6, 6);
            this.tabEmailComplaint.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabEmailComplaint.Name = "tabEmailComplaint";
            this.tabEmailComplaint.SelectedIndex = 0;
            this.tabEmailComplaint.Size = new System.Drawing.Size(1179, 673);
            this.tabEmailComplaint.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::Tenant_Application.Properties.Resources.background;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.listBox2);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(1171, 647);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Chat Room";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.tbxComplaint);
            this.tabPage2.Controls.Add(this.btnSendMail);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(1171, 647);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Complaints";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.TabPage2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(98, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter your complaint down below and press send";
            // 
            // tbxComplaint
            // 
            this.tbxComplaint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxComplaint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxComplaint.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxComplaint.Location = new System.Drawing.Point(403, 249);
            this.tbxComplaint.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxComplaint.Name = "tbxComplaint";
            this.tbxComplaint.Size = new System.Drawing.Size(357, 106);
            this.tbxComplaint.TabIndex = 1;
            this.tbxComplaint.Text = "";
            // 
            // btnSendMail
            // 
            this.btnSendMail.BackColor = System.Drawing.Color.White;
            this.btnSendMail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendMail.ForeColor = System.Drawing.Color.White;
            this.btnSendMail.Location = new System.Drawing.Point(491, 370);
            this.btnSendMail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSendMail.Name = "btnSendMail";
            this.btnSendMail.Size = new System.Drawing.Size(200, 52);
            this.btnSendMail.TabIndex = 0;
            this.btnSendMail.Text = "btnSendMail";
            this.btnSendMail.UseVisualStyleBackColor = false;
            this.btnSendMail.Click += new System.EventHandler(this.Button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(258, 155);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(569, 329);
            this.listBox1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(251, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(545, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Welcome <name> to the chat room";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(858, 155);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(197, 160);
            this.listBox2.TabIndex = 2;
            // 
            // UserInterfaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.Controls.Add(this.tabEmailComplaint);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UserInterfaceForm";
            this.Text = "UserInterfaceForm";
            this.Load += new System.EventHandler(this.UserInterfaceForm_Load);
            this.tabEmailComplaint.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabEmailComplaint;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnSendMail;
        private System.Windows.Forms.RichTextBox tbxComplaint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label2;
    }
}