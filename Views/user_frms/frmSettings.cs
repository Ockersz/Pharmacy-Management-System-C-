using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Coursework.user_frms;

namespace Coursework
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        private void btn_psnldetils_Click(object sender, EventArgs e)
        {
            stn_personal obj = new stn_personal();
            obj.Show();
        }

        private void btn_cngepwd_Click(object sender, EventArgs e)
        {
            stn_chngepwd obj = new stn_chngepwd();
                obj.Show();
        }
    }
}
