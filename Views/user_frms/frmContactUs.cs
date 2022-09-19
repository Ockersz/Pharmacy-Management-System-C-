using Coursework.user_frms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
namespace Coursework

{
    public partial class frmContactUs : Form
    {
        public frmContactUs()
        {
            InitializeComponent();
            gmap.Hide();
            btn_back.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*frm_location obj = new frm_location();
            obj.ShowDialog();*/
            gmap.Show();
            btn_back.Show();
            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            button1.Hide();

            gmap.DragButton = MouseButtons.Left;
            gmap.MapProvider = GMapProviders.GoogleMap;
            gmap.Position = new PointLatLng(6.90624, 79.87088);
            gmap.MinZoom = 1;
            gmap.MaxZoom = 100;
            gmap.Zoom = 17;

            PointLatLng point = new PointLatLng(6.90624, 79.87088);
            GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.red_dot);

            GMapOverlay markers = new GMapOverlay("markers");
            markers.Markers.Add(marker);
            gmap.Overlays.Add(markers);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            gmap.Hide();
            btn_back.Hide();
            pictureBox1.Show();
            pictureBox2.Show();
            pictureBox3.Show();
            pictureBox4.Show();
            label1.Show();
            label2.Show();
            label3.Show();
            label4.Show();
            label5.Show();
            label6.Show();
            button1.Show();

        }

        private void gmap_Load(object sender, EventArgs e)
        {

        }
    }
}
