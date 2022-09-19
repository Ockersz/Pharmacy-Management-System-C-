using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Coursework
{
    public partial class frmOrders : Form
    {
       
        public frmOrders()
        {
            InitializeComponent();
            
        }

        Database db = new Database();
        
        private void frmOrders_Load(object sender, EventArgs e)
        {          
           dataGridView1.DataSource = db.ListData ("Select * from Orders where CID = '"+frm_Login.username+"'");                        
        }
    }
}
