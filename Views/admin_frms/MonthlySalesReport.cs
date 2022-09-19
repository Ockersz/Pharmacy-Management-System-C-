using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework.Views.admin_frms
{
    public partial class MonthlySalesReport : Form
    {
        public MonthlySalesReport()
        {
            InitializeComponent();
        }

        private void MonthlySalesReport_Load(object sender, EventArgs e)
        {
            
            
        }
        private void btn_search_Click(object sender, EventArgs e)
        {
            this.ordersTableAdapter.Fill(this.monthlySalesDataSet.Orders, dtp_start.Value, dtp_end.Value);
            this.rpt_Sales.RefreshReport();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
