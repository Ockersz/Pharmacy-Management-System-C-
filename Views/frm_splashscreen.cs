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
    public partial class frm_splashscreen : Form
    {
        public frm_splashscreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            prgs_bar.Increment(5);
            if (prgs_bar.Value == 100)
            {
                timer1.Enabled = false;
                frm_Login form = new frm_Login();
                form.Show();
                this.Hide();
            }
        }

        private void prgs_bar_Click(object sender, EventArgs e)
        {

        }
    }
}
