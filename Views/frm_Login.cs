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
using Coursework.user_frms;

namespace Coursework
{
    public partial class frm_Login : Form
    {
        Database db = new Database();
        public static string EID;
        public static string username = "";
        public static string password = "";

        public frm_Login()
        {
            InitializeComponent();
           
        }
        private void frm_Login_Load(object sender, EventArgs e)
        {
            txt_username.Focus();
        }
        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            txt_password.PasswordChar = '*';
            txt_password.MaxLength = 10;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            username = txt_username.Text;
            password = txt_password.Text;
            int row;
                if (string.IsNullOrEmpty(txt_username.Text) || string.IsNullOrEmpty(txt_password.Text))
                {
                    CustomMessageBox.ShowBox("Please Provide Username and Password", "Error", "Error");
                }
                else
                {
                    row = db.GetRowCount("Select NIC,Password from Customer_cred where NIC = '" + txt_username.Text + "' and Password ='" + txt_password.Text + "'");
                    if (row == 1)
                    {
                        this.Hide();
                        new Dashboard().Show();
                        RecordCustomer();
                    }

                    else
                    {
                        row = db.GetRowCount("select Username,Password from Employee_cred where Username='" + txt_username.Text + "' and Password='" + txt_password.Text + "'");

                        if (row == 1)
                        {
                            this.Hide();
                            new Admin_Dashboard().Show();
                            GetEid();
                            RecordEmployee();
                        }
                        else
                        {
                            CustomMessageBox.ShowBox("Username And Password does not exist, Try again or Register", "Error", "Error");
                        }

                    }
                }
          
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frm_register().Show();
        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_username.Clear();
            txt_password.Clear();
            txt_username.Focus();
        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void GetEid()
        {
            EID = db.ReadDataString("Select EID from Employee_cred where username = '" + username + "'");
        }
        public void RecordEmployee()
        {
            db.insertQuery("Insert into Employeee_log (EID) values ('" + EID + "') ");
        }
        public void RecordCustomer()
        {
            db.insertQuery("Insert into Customer_log (NIC) values ('" + username + "') ");
        }

        private void btn_hide_Click(object sender, EventArgs e)
        {
            if (txt_password.PasswordChar == '\0')
            {
                btn_show.BringToFront();
                txt_password.PasswordChar = '*';
            }

        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            if (txt_password.PasswordChar == '*')
            {
                btn_hide.BringToFront();
                txt_password.PasswordChar = '\0';
            }
        }
    }
}
