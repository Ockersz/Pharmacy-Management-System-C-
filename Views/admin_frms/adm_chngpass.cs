using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Coursework.MessageBox;

namespace Coursework.admin_frms
{
    public partial class adm_chngpass : Form
    {

        Database db = new Database();
        public adm_chngpass()
        {
            InitializeComponent();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

            try
            {

                if (string.IsNullOrEmpty(txt_currentpwd.Text))
                {
                    txt_Errormsg.Text = "*Current Password cannot be blank";
                    txt_pwd.Focus();
                }
                else if (string.IsNullOrEmpty(txt_pwd.Text))
                {
                    txt_Errormsg.Text = "* Password cannot be blank";
                    txt_pwd.Focus();
                }
                else if (txt_confirmpwd.Text != txt_pwd.Text)
                {
                    txt_Errormsg.Text = "* Passwords Mismatch";
                    txt_confirmpwd.Focus();
                }
                else
                {
                    txt_Errormsg.Clear();
                    int i = db.insertQuery("Update Employee_cred set Password='" + txt_pwd.Text + "'  where username = '" + frm_Login.username + "' and Password='" + txt_currentpwd.Text + "'");

                    if (i == 1)
                    {
                        CustomMessageBox.ShowBox("Data Entered Successfully", "Succes", "Success");
                    }
                    else
                    {
                        CustomMessageBox.ShowBox("Data Enter Failed", "Error", "Error");
                    }
                    txt_pwd.Clear();
                    txt_currentpwd.Clear();
                    txt_confirmpwd.Clear();
                }

            }
            catch (Exception)
            {
                CustomMessageBox.ShowBox("Errors", "Try again", "Error");
            }


        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txt_pwd_TextChanged(object sender, EventArgs e)
        {
            txt_pwd.PasswordChar = '*';
            txt_pwd.MaxLength = 10;
        }

        private void txt_confirmpwd_TextChanged(object sender, EventArgs e)
        {
            txt_confirmpwd.PasswordChar = '*';
            txt_confirmpwd.MaxLength = 10;
        }

        private void txt_currentpwd_TextChanged(object sender, EventArgs e)
        {
            txt_currentpwd.PasswordChar = '*';
            txt_currentpwd.MaxLength = 10;
        }
    }
}
