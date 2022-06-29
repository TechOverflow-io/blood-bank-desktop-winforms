using Blood_Bank_Management_System_Layred.BL;
using Blood_Bank_Management_System_Layred.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood_Bank_Management_System_Layred
{
    public partial class LoginGUI : Form
    {
        LoginDTO loginDto;
        LoginBL lgBL;
        public LoginGUI()
        {
            InitializeComponent();
            loginDto = new LoginDTO();
            lgBL = new LoginBL();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txt_password.Text = "";
            txt_UserName.Text = "";
            txt_UserName.Focus();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {

            if (!(txt_UserName.Text == "" || txt_password.Text == ""))
            {

                loginDto.UserName = txt_UserName.Text;
                loginDto.Password = txt_password.Text;
                this.Hide();
                lgBL.VerifyUser(loginDto).ShowDialog();
                this.Close();
                btnReset_Click(sender, e);

            }
            else
            {
                MessageBox.Show("Please Fill All Fields First....!!", "Error...!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnHideShow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (btnHideShow.Text == "Show")
            {
                btnHideShow.Text = "Hide";
                txt_password.PasswordChar = '\0';
            }
            else
            {
                btnHideShow.Text = "Show";
                txt_password.PasswordChar = '*';
            }
        }

        private void LoginGUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private void txt_UserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8);
            e.Handled = !(Char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == 8);
        }

        private void txt_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 32);
            //if (char.IsLetterOrDigit(e.KeyChar) || (Keys)e.KeyChar == Keys.Space || (Keys)e.KeyChar == Keys.Back)
            //    e.Handled = true;
        }

        private void txt_UserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginGUI_Load(object sender, EventArgs e)
        {

        }
    }
}
