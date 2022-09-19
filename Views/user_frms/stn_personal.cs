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
using System.Text.RegularExpressions;

namespace Coursework.user_frms
{
    public partial class stn_personal : Form
    {
        Database db = new Database();
        
        private void stn_personal_Load(object sender, EventArgs e)
        {
            cmb_district.SelectedIndex = 0;
            cmb_province.SelectedIndex = 0;
            dtp_birthdate.MaxDate = DateTime.Today;
            dtp_birthdate.Value = DateTime.Today;

            txt_nic.Text = db.ReadDataString("Select NIC from Customer where NIC ='" + frm_Login.username + "'");
            txt_fname.Text = db.ReadDataString("Select First_name from Customer where NIC ='" + frm_Login.username + "'");
            txt_Lname.Text = db.ReadDataString("Select Last_name from Customer where NIC ='" + frm_Login.username + "'");
            txt_email.Text = db.ReadDataString("Select Email from Customer where NIC ='" + frm_Login.username + "'");
            dtp_birthdate.Value = db.ReadDataDate("Select DOB from Customer where NIC ='" + frm_Login.username + "'");
            txt_TP.Text = db.ReadDataInt("Select TP from Customer where NIC ='" + frm_Login.username + "'").ToString();
            txt_homeno.Text = db.ReadDataString("Select Home_number from Customer where NIC ='" + frm_Login.username + "'");
            txt_street.Text = db.ReadDataString("Select Street from Customer where NIC ='" + frm_Login.username + "'");
            txt_city.Text = db.ReadDataString("Select City from Customer where NIC ='" + frm_Login.username + "'");
            cmb_district.SelectedItem = db.ReadDataValue("Select District from Customer where NIC ='" + frm_Login.username + "'");
            cmb_province.SelectedItem = db.ReadDataValue("Select Province from Customer where NIC ='" + frm_Login.username + "'");
        }
        public stn_personal()
        {
            InitializeComponent();                    
        }
       
        private void btn_update_Click(object sender, EventArgs e)
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
               int i = db.insertQuery("Update Customer set  First_name='" + txt_fname.Text + "',Last_name='" + txt_Lname.Text + "',Email='" + txt_email.Text + "',DOB='" + this.dtp_birthdate.Value + "',TP='" + Convert.ToInt32(txt_TP.Text) + "',Home_number='" + txt_homeno.Text + "',Street='" + txt_street.Text + "',City='" + txt_city.Text + "',District='" + cmb_district.SelectedItem.ToString() + "',Province='" + cmb_province.SelectedItem.ToString() + "' where NIC = '" + txt_nic.Text + "' ");
               if (i == 1)
               {
                  CustomMessageBox.ShowBox("Data Entered Successfully", "Succes", "Success");
                        
               }
               else
               {
                  CustomMessageBox.ShowBox("Data Enter Failed", "Error", "Error");
               }
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
