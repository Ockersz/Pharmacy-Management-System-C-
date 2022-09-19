using Coursework.MessageBox;
using Coursework.Views.admin_frms;
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

namespace Coursework.admin_frms
{
    public partial class admin_frmorders : Form
    {
        Database db = new Database();
        int indexRow;
        int orderId;
        public admin_frmorders()
        {
            InitializeComponent();
        }

        
        private void admin_frmorders_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacyDataSet1.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.pharmacyDataSet1.Orders);
        }

        private void btn_qr_Click(object sender, EventArgs e)
        {
            if(rbtn_qr.Checked == true )
            {
                QrCode_scanner obj = new QrCode_scanner();
                obj.ShowDialog();
            }
            else
            {
                CustomMessageBox.ShowBox("Please Select QR Code to Scan","Info","Info");
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {

            if(rbtn_nic.Checked == true)
            {
                if (string.IsNullOrEmpty(txt_search.Text))
                {
                    txt_error.Text = "Nic Cannot be Blank";
                }
                else if (!Regex.IsMatch(txt_search.Text, @"^([0-9]{9}[x|X|v|V]|[0-9]{12})$"))
                {
                    txt_error.Text = "NIC Number is not in correct format.";
                }
                else
                {
                    txt_error.Clear();
                    dataGridView1.DataSource = db.ListData("Select * from Orders where CID = '" + txt_search.Text + "'");
                }
            }
            else if (rbtn_orderId.Checked == true)
            {
                if(string.IsNullOrEmpty(txt_search.Text))
                {
                    txt_error.Text = "Order ID cannot be blank";
                }
                else if (txt_search.Text.All(char.IsLetter))
                {
                    txt_error.Text = "Order ID cannot Contain letters";
                }
                else if (!txt_search.Text.All(char.IsDigit))
                {
                    txt_error.Text = "Order ID cannot Contain Symbols";
                }
                else
                {
                    txt_error.Clear();
                    dataGridView1.DataSource = db.ListData("Select * from Orders where Order_ID = '" + txt_search.Text + "'");
                }
            }
            else if (rbtn_qr.Checked == true && QrCode_scanner.Code != null)
            {
                if (txt_search.Text.All(char.IsLetter))
                {
                    txt_error.Text = "Order ID cannot Contain letters";
                }
                else
                {

                    txt_error.Clear();
                    dataGridView1.DataSource = db.ListData("Select * from Orders where Order_ID = '" + QrCode_scanner.Code + "'");
                }
               
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.ListData("Select * from Orders");
            QrCode_scanner.Code = "";
            txt_search.Clear();
        }

        private void txt_search_Click(object sender, EventArgs e)
        {
            if (QrCode_scanner.Code != null)
            {
                txt_search.Text = QrCode_scanner.Code;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            { }
            else
            {

            indexRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[indexRow];
            orderId = Convert.ToInt32(row.Cells[0].Value);
            string status = row.Cells[3].Value.ToString();
                if (status == "Pending")
                {
                    cmb_orderstatus.SelectedIndex = 0;
                }
                else if (status == "Delivered")
                {
                    cmb_orderstatus.SelectedIndex = 1;
                }
                else if (status == "Canceled")
                {
                    cmb_orderstatus.SelectedIndex = 2;
                }  
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
  
                int i = db.insertQuery("Update Orders set Order_status = '" + cmb_orderstatus.SelectedItem.ToString() + "' where Order_ID = '" + orderId + "'");
                if (i == 1)
                {
                    CustomMessageBox.ShowBox("Update Successfull", "Info", "Success");
                }
                else
                {
                    CustomMessageBox.ShowBox("Update Unsuccessfull", "Error", "Error");
                }
       
            
        }
    }
}
