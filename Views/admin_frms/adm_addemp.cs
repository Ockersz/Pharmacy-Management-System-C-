using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Coursework.MessageBox;

namespace Coursework.admin_frms
{
    public partial class adm_addemp : Form
    {

        public string EID;
        string Gender;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
    (
        int nLeftRect,
        int nTopRect,
        int nRightRect,
        int nBottomRect,
        int nWidthEllipse,
        int nHeightEllipse
    );
        public adm_addemp()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        Database db = new Database();

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_fname.Text))
            {
                txt_Errormsg.Text = "* First name cannot be blank";
                txt_fname.Focus();
            }
            else if (txt_fname.Text.Any(char.IsDigit))
            {
                txt_Errormsg.Text = "* First name cannot contain numbers";
                txt_fname.Focus();
            }
            else if (!txt_fname.Text.Any(char.IsLetter))
            {
                txt_Errormsg.Text = "* First name cannot contain Symbols";
                txt_Lname.Focus();
            }
            else if (string.IsNullOrEmpty(txt_Lname.Text))
            {
                txt_Errormsg.Text = "* Last name cannot be blank";
                txt_Lname.Focus();
            }
            else if (txt_Lname.Text.Any(char.IsDigit))
            {
                txt_Errormsg.Text = "* Last name cannot contain numbers";
                txt_Lname.Focus();
            }
            else if (!txt_Lname.Text.Any(char.IsLetter))
            {
                txt_Errormsg.Text = "* Last name cannot contain Symbols";
                txt_Lname.Focus();
            }
            else if (string.IsNullOrEmpty(txt_homeno.Text))
            {
                txt_Errormsg.Text = "* Home number cannot be blank";
                txt_homeno.Focus();
            }
            else if (string.IsNullOrEmpty(txt_street.Text))
            {
                txt_Errormsg.Text = "* Street cannot be blank";
                txt_street.Focus();
            }
            else if (string.IsNullOrEmpty(txt_city.Text))
            {
                txt_Errormsg.Text = "* City cannot be blank";
                txt_city.Focus();
            }
            else if (txt_city.Text.Any(char.IsDigit))
            {
                txt_Errormsg.Text = "* City cannot contain numbers";
                txt_city.Focus();
            }
            else if (!Regex.IsMatch(txt_email.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                txt_Errormsg.Text = "Enter a valid email. Ex:name@sample.com";
                txt_email.Focus();
            }
            else if (dtp_birthdate.Value == DateTime.Today)
            {
                txt_Errormsg.Text = "* Date of birth cannot be today";
                dtp_birthdate.Focus();
            }
            else if (!Regex.IsMatch(txt_TP.Text, @"^(?:7|0|(?:\+94))[0-9]{8,9}$"))
            {
                txt_Errormsg.Text = "* Telphone must have 10 numbers";
                txt_TP.Focus();
            }

            else
            {
                txt_Errormsg.Clear();
           
                
                    label20.Visible = true;
                    panel1.Visible = true;
                    btn_register.Visible = true;

                    txt_fname.ReadOnly = true;
                    txt_Lname.ReadOnly = true;
                    txt_email.ReadOnly = true;
                    dtp_birthdate.Enabled = false;
                    txt_TP.ReadOnly = true;
                    txt_homeno.ReadOnly = true;
                    txt_street.ReadOnly = true;
                    txt_city.ReadOnly = true;
                    cmb_district.Enabled = false;
                    cmb_province.Enabled = false;
                
            }
        }

        private void rdbtn_male_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Male";
        }

        private void rdbtn_female_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Female";
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

        private void adm_addemp_Load(object sender, EventArgs e)
        {
            cmb_district.SelectedIndex = 0;
            cmb_province.SelectedIndex = 0;
            dtp_birthdate.MaxDate = DateTime.Today;
            dtp_birthdate.Value = DateTime.Today;
        }

        private void btn_ext_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frm_Login().Show();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_usrname.Text))
            {
                txt_Errormsg.Text = "* Username cannot be blank";
                txt_usrname.Focus();
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
                EID = db.ReadDataString("Select MAX(Employee_id) from employee");
                
                int employee = db.GetRowCount("Select Username from employee_cred where username = '" + txt_usrname.Text + "'");
                if (employee == 1)
                {
                    CustomMessageBox.ShowBox("Username already exists try another.","Error","Error");
                }

                else 
                {
                    int j = db.insertQuery("EXEC InsertEmployee '" + txt_fname.Text + "','" + txt_Lname.Text + "','" + txt_email.Text + "','" + this.dtp_birthdate.Value + "','" + Convert.ToInt32(txt_TP.Text) + "', '" + Gender + "', '" + txt_homeno.Text + "', '" + txt_street.Text + "', '" + txt_city.Text + "','" + cmb_district.SelectedItem.ToString() + "','" + cmb_province.SelectedItem.ToString() + "'");

                    int i = db.insertQuery("Insert into Employee_cred values ('" + txt_usrname.Text + "','" + EID + "','" + txt_pwd.Text + "')");
                    if (i == 1 && j == 1)
                    {
                        CustomMessageBox.ShowBox("Data entered Successfully", "Info", "Success");
                    }
                    else
                    {
                        CustomMessageBox.ShowBox("Data Enter Unsuccessfull", "Error", "Error");
                    }
                }

                
            }
        }

        private void adm_addemp_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
