using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tenant_Application
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        int CenterLocationFormX;
        int CenterLocationFormY;

        int CenterLocationTextBoxX;
        int CenterLocationTextBoxY;

        int CenterLocationPanel3X;
        int CenterLocationPanel3Y;
        private void LoginForm_Load(object sender, EventArgs e)
        {
            //Init the values of the LoginForm
            this.Width = 1200;
            this.Height = 720;

            CenterLocationFormX = this.Width / 2;
            CenterLocationFormY = this.Height / 2;

            //General Values of TextBox
            CenterLocationTextBoxX = tbxUserName.Width / 2;
            CenterLocationTextBoxY = tbxUserName.Height / 2;

            //UserName TextBox
            tbxUserName.Width = 200;

            tbxUserName.Font = new Font("Calibri", 12);

            tbxUserName.BringToFront();

            tbxUserName.Text = "UserName";

            tbxUserName.BorderStyle = BorderStyle.None;

            tbxUserName.Location = new Point(CenterLocationFormX - CenterLocationTextBoxX, (CenterLocationFormY - CenterLocationTextBoxY) - 25);

            tbxUserName.BackColor = Color.FromArgb(83, 83, 83);

            //PassWord TextBox
            tbxPassWord.Width = 200;

            tbxPassWord.Font = new Font("Calibri", 12);

            tbxPassWord.BringToFront();



            tbxPassWord.Text = "PassWord";

            tbxPassWord.BorderStyle = BorderStyle.None;

            tbxPassWord.Location = new Point(CenterLocationFormX - CenterLocationTextBoxX, (CenterLocationFormY - CenterLocationTextBoxY) + 25);

            tbxPassWord.BackColor = this.BackColor;

            //Panel1
            panel1.Width = 200;
            panel1.Height = 1;

            panel1.BringToFront();

            panel1.BackColor = Color.White;

            panel1.Location = new Point(CenterLocationFormX - CenterLocationTextBoxX, ((CenterLocationFormY - CenterLocationTextBoxY) - 25) + tbxUserName.Height + 5);

            //Panel2
            panel2.Width = 200;
            panel2.Height = 1;

            panel2.BringToFront();

            panel2.BackColor = Color.White;

            panel2.Location = new Point(CenterLocationFormX - CenterLocationTextBoxX, ((CenterLocationFormY - CenterLocationTextBoxY) + 25) + tbxUserName.Height + 5);

            //Panel3
            panel3.Width = 400;
            panel3.Height = 400;



            CenterLocationPanel3X = panel3.Width / 2;
            CenterLocationPanel3Y = panel3.Height / 2;

            panel3.BackColor = Color.Transparent;

            panel3.Location = new Point(CenterLocationFormX - CenterLocationPanel3X, CenterLocationFormY - CenterLocationPanel3Y);

        }

        private void TbxUserName_Click(object sender, EventArgs e)
        {
            tbxUserName.Clear();
        }

        private void TbxPassWord_Click(object sender, EventArgs e)
        {
            tbxPassWord.Clear();
            tbxPassWord.PasswordChar = '*';
        }


    }
}
