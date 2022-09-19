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
using Coursework.admin_frms;
namespace Coursework
{
    public partial class Admin_Dashboard : Form
    {
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

      

        Database db = new Database();
        public Admin_Dashboard()
        {
            InitializeComponent();
  
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            PnvNav.Height = btn_dashboard.Height;
            PnvNav.Top = btn_dashboard.Top;
            PnvNav.Left = btn_dashboard.Left;
            btn_dashboard.BackColor = Color.FromArgb(46, 51, 73);

            lbl_title.Text = "Dashboard";
            this.PnlFormLoader.Controls.Clear();
            admin_frmdashboard FrmDashboard_Vrb = new admin_frmdashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            timer1.Start();
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            PnvNav.Height = btn_dashboard.Height;
            PnvNav.Top = btn_dashboard.Top;
            PnvNav.Left = btn_dashboard.Left;
            btn_dashboard.BackColor = Color.FromArgb(46, 51, 73);

            lbl_title.Text = "Dashboard";
            this.PnlFormLoader.Controls.Clear();
            admin_frmdashboard FrmDashboard_Vrb = new admin_frmdashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();

            btn_logoout.Show();

        }

        private void btn_orders_Click(object sender, EventArgs e)
        {
            PnvNav.Height = btn_orders.Height;
            PnvNav.Top = btn_orders.Top;
            PnvNav.Left = btn_orders.Left;
            btn_orders.BackColor = Color.FromArgb(46, 51, 73);

            lbl_title.Text = "Orders";
            this.PnlFormLoader.Controls.Clear();
            admin_frmorders FrmDashboard_Vrb = new admin_frmorders() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();

            btn_logoout.Hide();
        }

        private void btn_prdcts_Click(object sender, EventArgs e)
        {
            PnvNav.Height = btn_prdcts.Height;
            PnvNav.Top = btn_prdcts.Top;
            PnvNav.Left = btn_prdcts.Left;
            btn_prdcts.BackColor = Color.FromArgb(46, 51, 73);

            lbl_title.Text = "Products";
            this.PnlFormLoader.Controls.Clear();
            admin_prdcts FrmDashboard_Vrb = new admin_prdcts() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();

            btn_logoout.Hide();
        }


        private void btn_empstng_Click(object sender, EventArgs e)
        {
            PnvNav.Height = btn_empstng.Height;
            PnvNav.Top = btn_empstng.Top;
            PnvNav.Left = btn_empstng.Left;
            btn_empstng.BackColor = Color.FromArgb(46, 51, 73);

            lbl_title.Text = "Employee Settings";
            this.PnlFormLoader.Controls.Clear();
            admin_frmempSettings FrmDashboard_Vrb = new admin_frmempSettings() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();

            btn_logoout.Hide();
        }

        private void btn_dashboard_Leave(object sender, EventArgs e)
        {
            btn_dashboard.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btn_orders_Leave(object sender, EventArgs e)
        {
            btn_orders.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btn_prdcts_Leave(object sender, EventArgs e)
        {
            btn_prdcts.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btn_empstng_Leave(object sender, EventArgs e)
        {
            btn_empstng.BackColor = Color.FromArgb(24,30,54);
        }

        private void btn_ext_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_time.Text = DateTime.Now.ToLongTimeString();
            lbl_date.Text = DateTime.Now.ToLongDateString();
        }

        private void Admin_Dashboard_Load(object sender, EventArgs e)
        {
            lbl_username.Text = db.ReadDataString("Select Username from Employee_cred where Username= '" + frm_Login.username + "' ");
            lbl_name.Text = db.ReadDataString("select Employee.First_name from Employee inner join Employee_cred on Employee.Employee_ID = Employee_cred.EID where Username = '"+frm_Login.username+"' ");
        }

        private void PnlFormLoader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btn_logoout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frm_Login().Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_time_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_name_Click(object sender, EventArgs e)
        {

        }
    }
}
