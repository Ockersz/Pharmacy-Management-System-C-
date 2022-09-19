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
    public partial class admin_frmempSettings : Form
    {
        public admin_frmempSettings()
        {
            InitializeComponent();
        }

        private void btn_emppsnldetils_Click(object sender, EventArgs e)
        {
            adm_stnpersonal obj = new adm_stnpersonal();
            obj.ShowDialog();
        }

        private void btn_chngpass_Click(object sender, EventArgs e)
        {
            adm_chngpass obj = new adm_chngpass();
            obj.ShowDialog();
        }

        private void btn_addemp_Click(object sender, EventArgs e)
        {
            adm_addemp obj = new adm_addemp();
            obj.ShowDialog();
        }
    }
}
