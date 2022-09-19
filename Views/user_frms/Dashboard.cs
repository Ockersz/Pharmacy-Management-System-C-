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
using System.Data.SqlClient;
using Coursework.user_frms;

namespace Coursework
{
    public partial class Dashboard : Form
    {
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);

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

        SqlConnection Con;
        SqlCommand Cmd;

        public Dashboard()
        {
            InitializeComponent();
            Con = new SqlConnection("Data Source=LAPTOP-0S8DH0AS;Initial Catalog=Pharmacy;Persist Security Info=True;User ID=sa;Password=123");

            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            PnvNav.Height = btn_Products.Height;
            PnvNav.Top = btn_Products.Top;
            PnvNav.Left = btn_Products.Left;
            btn_Products.BackColor = Color.FromArgb(46, 51, 73);


            lbl_title.Text = "Products";
            this.PnlFormLoader.Controls.Clear();
            frm_products FrmDashboard_Vrb = new frm_products() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();

            
        }

        private void btn_Orders_Click(object sender, EventArgs e)
        {
            PnvNav.Height = btn_Orders.Height;
            PnvNav.Top = btn_Orders.Top;
            PnvNav.Left = btn_Orders.Left;
            btn_Orders.BackColor = Color.FromArgb(46, 51, 73);

            lbl_title.Text = "Orders";
            this.PnlFormLoader.Controls.Clear();
            frmOrders FrmDashboard_Vrb = new frmOrders() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            Con.Open();
            Cmd = new SqlCommand("Select NIC,First_name from Customer where NIC= '" + frm_Login.username + "' ", Con);
            SqlDataReader dr = Cmd.ExecuteReader();
            while (dr.Read())
            {
                lbl_nic.Text = dr.GetString(0);
                lbl_username.Text = dr.GetString(1);
            }
            Con.Close();
            Cmd.Dispose();
        }

        private void btn_Products_Click(object sender, EventArgs e)
        {
            PnvNav.Height = btn_Products.Height;
            PnvNav.Top = btn_Products.Top;
            PnvNav.Left = btn_Products.Left;
            btn_Products.BackColor = Color.FromArgb(46, 51, 73);

            lbl_title.Text = "Products";
            this.PnlFormLoader.Controls.Clear();
            frm_products FrmDashboard_Vrb = new frm_products() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
        }

       

        private void btn_contactus_Click(object sender, EventArgs e)
        {
            PnvNav.Height = btn_contactus.Height;
            PnvNav.Top = btn_contactus.Top;
            PnvNav.Left = btn_contactus.Left;
            btn_contactus.BackColor = Color.FromArgb(46, 51, 73);

            lbl_title.Text = "Contact Us";
            this.PnlFormLoader.Controls.Clear();
            frmContactUs FrmDashboard_Vrb = new frmContactUs() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
        }
        private void btn_settings_Click(object sender, EventArgs e)
        {
            PnvNav.Height = btn_settings.Height;
            PnvNav.Top = btn_settings.Top;
            PnvNav.Left = btn_settings.Left;
            btn_settings.BackColor = Color.FromArgb(46, 51, 73);

            lbl_title.Text = "Settings";
            this.PnlFormLoader.Controls.Clear();
            frmSettings FrmDashboard_Vrb = new frmSettings() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
        }

        private void btn_Products_Leave(object sender, EventArgs e)
        {
            btn_Products.BackColor = Color.FromArgb(24,30,54);
        }

        private void btn_Orders_Leave(object sender, EventArgs e)
        {
            btn_Orders.BackColor = Color.FromArgb(24, 30, 54);
        }

       
        private void btn_contactus_Leave(object sender, EventArgs e)
        {
            btn_contactus.BackColor = Color.FromArgb(24, 30, 54);
        }

        

        private void btn_settings_Leave(object sender, EventArgs e)
        {
            btn_settings.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_time.Text = DateTime.Now.ToLongTimeString();
            lbl_date.Text = DateTime.Now.ToLongDateString();
        }

        private void lbl_date_Click(object sender, EventArgs e)
        {

        }

        private void lbl_time_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_ext_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PnlFormLoader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_title_Click(object sender, EventArgs e)
        {

        }

        private void btn_logoout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frm_Login().Show();
        }

        private void lbl_username_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void Dashboard_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void Dashboard_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);

            }
        }
    }
}
