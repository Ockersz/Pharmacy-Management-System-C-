using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Coursework.MessageBox;
using System.Text.RegularExpressions;

namespace Coursework.user_frms
{
    
    public partial class frm_register : Form
    {
        string Gender;
        Database db = new Database();

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
        public frm_register()
        {
           InitializeComponent();
           Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void frm_register_Load(object sender, EventArgs e)
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
                else if(!txt_city.Text.Any(char.IsLetter))
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
                else if (string.IsNullOrEmpty(txt_nic.Text))
                {
                    txt_Errormsg.Text = "* NIC Number cannot be blank";
                    txt_nic.Focus();
                }
                else if ( !Regex.IsMatch(txt_nic.Text, @"^([0-9]{9}[x|X|v|V]|[0-9]{12})$"))
                {
                   txt_Errormsg.Text = "* NIC Number is not in correct format.";
                   txt_nic.Focus();
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
                    int i = db.insertQuery("INSERT INTO Customer VALUES ('" + txt_nic.Text + "','" + txt_fname.Text + "','" + txt_Lname.Text + "','" + txt_email.Text + "','" + this.dtp_birthdate.Value + "','" + Convert.ToInt32(txt_TP.Text) + "','" + Gender + "','" + txt_homeno.Text + "','" + txt_street.Text + "','" + txt_city.Text + "','" + cmb_district.SelectedItem.ToString() + "','" + cmb_province.SelectedItem.ToString() + "')");
                    int j = db.insertQuery("INSERT INTO Customer_cred VALUES ('" + txt_nic.Text + "','" + txt_pwd.Text + "')");
                   
                    if (i == 1 && j ==1)
                    {
                        CustomMessageBox.ShowBox("Data Entered Successfully", "Succes", "Success");
                    }
                    else
                    {
                        CustomMessageBox.ShowBox("Data Enter Failed", "Error", "Error");
                    }

                    txt_fname.Clear();
                    txt_Lname.Clear();
                    txt_homeno.Clear();
                    txt_street.Clear();
                    txt_city.Clear();
                    txt_email.Clear();
                    txt_TP.Clear();
                    txt_nic.Clear();
                    txt_pwd.Clear();
                    txt_confirmpwd.Clear();
                    cmb_district.SelectedIndex = 0;
                    cmb_province.SelectedIndex = 0;
                    dtp_birthdate.Value = DateTime.Today;

                    this.Hide();
                    new frm_Login().Show();
                }
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txt_street_TextChanged(object sender, EventArgs e)
        {
            txt_street.MaxLength = 20;
        }

        private void txt_city_TextChanged(object sender, EventArgs e)
        {
            txt_city.MaxLength = 20;
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

        private void rdbtn_male_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Male";
        }

        private void rdbtn_female_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Female";
        }

        private void txt_fname_TextChanged(object sender, EventArgs e)
        {
            txt_fname.MaxLength = 20;
        }

        private void txt_Lname_TextChanged(object sender, EventArgs e)
        {
            txt_Lname.MaxLength = 20;
        }

        private void txt_homeno_TextChanged(object sender, EventArgs e)
        {
            txt_homeno.MaxLength = 5;
        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {
            txt_email.MaxLength = 50;
        }

        private void txt_TP_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_nic_TextChanged(object sender, EventArgs e)
        {
            txt_nic.MaxLength = 15;
        }
    }
}
