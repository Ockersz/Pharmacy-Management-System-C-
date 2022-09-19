using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using Coursework.MessageBox;

namespace Coursework.admin_frms
{
    public partial class adm_stnpersonal : Form
    {
        SqlConnection Con;
        SqlCommand Cmd;

        Database db = new Database();
        private void adm_stnpersonal_Load(object sender, EventArgs e)
        {
            Con = new SqlConnection("Data Source=LAPTOP-0S8DH0AS;Initial Catalog=Pharmacy;Integrated Security=True");
            cmb_district.SelectedIndex = 0;
            cmb_province.SelectedIndex = 0;
            dtp_birthdate.MaxDate = DateTime.Today;
            dtp_birthdate.Value = DateTime.Today;

            string EID = db.ReadDataString("Select EID from Employee_cred where Username = '" + frm_Login.username + "'");

            Con.Close();
            Con.Open();
            Cmd = new SqlCommand("Select First_name,Last_name,email,DOB,TP,Home_number,Street,City,District,Province from Employee where Employee_ID ='" + EID + "'", Con);
            SqlDataReader dr = Cmd.ExecuteReader();

            while (dr.Read())
            {

                txt_fname.Text = dr.GetString(0);
                txt_Lname.Text = dr.GetString(1);
                txt_email.Text = dr.GetString(2);
                dtp_birthdate.Value = dr.GetDateTime(3);
                txt_TP.Text = dr.GetInt32(4).ToString();
                txt_homeno.Text = dr.GetString(5);
                txt_street.Text = dr.GetString(6);
                txt_city.Text = dr.GetString(7);
                cmb_district.SelectedItem = dr.GetValue(8);
                cmb_province.SelectedItem = dr.GetValue(9);


                // DateTime.ParseExact(dr.GetString(4), "dd-MM-yyyy", null

            }
            Con.Close();
            Cmd.Dispose();
        }
        public adm_stnpersonal()
        {
            InitializeComponent();
        }


        private void btn_update_Click(object sender, EventArgs e)
        {
          try
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
               string EID = db.ReadDataString("Select EID from Employee_cred where Username = '" + frm_Login.username + "'");
               txt_Errormsg.Clear();
               int i = db.insertQuery("Update Employee set  First_name='" + txt_fname.Text + "',Last_name='" + txt_Lname.Text + "',Email='" + txt_email.Text + "',DOB='" + this.dtp_birthdate.Value + "',TP='" + Convert.ToInt32(txt_TP.Text) + "',Home_number='" + txt_homeno.Text + "',Street='" + txt_street.Text + "',City='" + txt_city.Text + "',District='" + cmb_district.SelectedItem.ToString() + "',Province='" + cmb_province.SelectedItem.ToString() + "' where Employee_id = '" + EID + "' ");

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
          catch (Exception)
          {
                CustomMessageBox.ShowBox("Errors", "Try again", "Error");
          }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
