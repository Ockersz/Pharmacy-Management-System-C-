using Coursework.Views.admin_frms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Coursework.admin_frms
{
    public partial class admin_frmdashboard : Form
    {
        Database db = new Database();


        public admin_frmdashboard()
        {
            InitializeComponent();
            GetTotalIncome();
            GetTotalUsers();
            GetUserLogins();

            int dd = db.ReadDataInt("SELECT COUNT(Delivery_method) AS onsite FROM     Orders WHERE Delivery_method = 'Doorstep Delivey'");
            int po = db.ReadDataInt("SELECT COUNT(Delivery_method) AS onsite FROM     Orders WHERE Delivery_method = 'Pickup Onsite'");

            chart1.Series["Series1"].IsValueShownAsLabel = true;

            chart1.Series["Series1"].Points.AddXY("Pickup Onsite", po);
            chart1.Series["Series1"].Points.AddXY("Doorstep Delivey", dd);     


        }

        private void admin_frmdashboard_Load(object sender, EventArgs e)
        {

        }

        private void lbl_income_Click(object sender, EventArgs e)
        {

        }

        public void GetTotalIncome()
        {
            lbl_income.Text = "Rs." + db.ReadDataInt("Select SUM(Price) from orders").ToString();
        }

        public void GetUserLogins()
        {
            DateTime d1 = DateTime.Now;
            d1 = d1.AddDays(-1);
            DateTime d2 = DateTime.Now;

            lbl_userlogin.Text = db.ReadDataInt("Select Count(Login_ID) from Customer_log where time between '" + d1 + "' and '" + d2 + "'").ToString(); ;
            
        }

        public void GetTotalUsers()
        {
            lbl_totalUsers.Text = db.ReadDataInt("Select Count(NIC) from Customer").ToString();
        }

      

        private void btn_view_Click(object sender, EventArgs e)
        {
            MonthlySalesReport obj = new MonthlySalesReport();
            obj.ShowDialog();
        }
    }
    
}
