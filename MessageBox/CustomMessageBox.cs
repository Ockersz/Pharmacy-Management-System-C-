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
using Coursework.MessageBox;

namespace Coursework.MessageBox
{
    public partial class CustomMessageBox : Form
    {
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);


        static CustomMessageBox newMessageBox;
        static string Buttin_ID;
        public CustomMessageBox()
        {
            InitializeComponent();
          
            


        }
        public static string ShowBox(string txtMessage)
        {
            newMessageBox = new CustomMessageBox();
            newMessageBox.lbl_message.Text = txtMessage;
            newMessageBox.ShowDialog();
            return Buttin_ID;
        }
        public static string ShowBox(string txtMessage,string txtTitle)
        {
            newMessageBox = new CustomMessageBox();
            newMessageBox.lbl_message.Text = txtMessage;
            newMessageBox.lbl_title.Text = txtTitle;
            newMessageBox.ShowDialog();
            return Buttin_ID;
        }
        public static string ShowBox(string txtMessage,string txtTitle,string pic)
        {
            newMessageBox = new CustomMessageBox();
            newMessageBox.lbl_message.Text = txtMessage;
            newMessageBox.lbl_title.Text = txtTitle;
            if (pic == "Info")
            {
                newMessageBox.pic_error.Visible = false;
                newMessageBox.pic_success.Visible = false;
                newMessageBox.pic_info.Visible = true;
            }
            else if(pic == "Error")
            {
                newMessageBox.pic_info.Visible = false;
                newMessageBox.pic_success.Visible = false;
                newMessageBox.pic_error.Visible = true;
            }
            else if (pic == "Success")
            {
                newMessageBox.pic_info.Visible = false;
                newMessageBox.pic_error.Visible = false;
                newMessageBox.pic_success.Visible = true;

            }
            newMessageBox.ShowDialog();
            return Buttin_ID;
        }

        

        private void CustomMessageBox_Load(object sender, EventArgs e)
        {
            
        }
        private void btn_ok_Click(object sender, EventArgs e)
        {
            Buttin_ID = "1";
            newMessageBox.Dispose();
        }

        private void pic_info_Click(object sender, EventArgs e)
        {

        }

        private void pic_success_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void lbl_message_Click(object sender, EventArgs e)
        {

        }

        private void CustomMessageBox_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void CustomMessageBox_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void CustomMessageBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);

            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);

            }
        }

        private void btn_ext_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
