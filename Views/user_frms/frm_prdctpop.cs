using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Coursework.MessageBox;

namespace Coursework.user_frms
{
    public partial class frm_prdctpop : Form
    {
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);

        Database db = new Database();
        public static int quantity;
        public static string pName;
        public static int price;

        public frm_prdctpop()
        {
            InitializeComponent();
        }

        private void frm_prdctpop_Load(object sender, EventArgs e)
        {
            pName = db.ReadDataString("Select Name from Product where Product_ID ='" + frm_products.product_ID + "'");
            lbl_name.Text = pName;
            lbl_brand.Text = db.ReadDataString("Select Brand from Product where Product_ID ='" + frm_products.product_ID + "'");
            price = db.ReadDataInt("Select price from Product where Product_ID ='" + frm_products.product_ID + "'");
            lbl_price.Text = price.ToString();
            quantity = db.ReadDataInt("Select quantity from Product where Product_ID ='" + frm_products.product_ID + "'");
            lbl_availablequantity.Text = quantity.ToString();
            pictureBox1.Image = Image.FromFile(db.ReadDataString("Select Image from Product where Product_ID ='" + frm_products.product_ID + "'"));

            num_quantity.Maximum = quantity;
            num_quantity.Minimum = 1;
        }

        

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_addToCart_Click_1(object sender, EventArgs e)
        {
            int i = CheckAvailability();
            lbl_availablequantity.Text = (quantity - i).ToString();
            int selectedquantity = Convert.ToInt32(num_quantity.Value);
            if (i == 0)
            {
                AddIntoCart();
            }
            else if (i+selectedquantity <= quantity)
            {
                UpdateCart(i);
            }
            else
            {
                CustomMessageBox.ShowBox("Selected quantity exceeds available quantity." ,"Error","Error");
            }
        }

        public void AddIntoCart()
        {
            int unitQuantity = Convert.ToInt32(num_quantity.Value);
            int i = db.insertQuery("INSERT INTO table_cart  (Product_Id, Product_name, Quantity, Price) VALUES ('" + frm_products.product_ID + "','" + pName + "','" + unitQuantity + "','" + (unitQuantity * price) + "') ");
            if (i == 1)
            {
                this.Close();
            }
            else
            {
                CustomMessageBox.ShowBox("Data entered failed", "Error", "Error");
            }
        }

        public void UpdateCart(int prequantity)
        {
            int unitQuantity = Convert.ToInt32(num_quantity.Value);
            unitQuantity += prequantity;
            int i = db.insertQuery("Update table_cart set quantity = '" + unitQuantity + "' , price = '" + (unitQuantity * price) + "' where product_id = '" + frm_products.product_ID + "'");
            if (i == 1)
            {
                this.Close();
            }
            else
            {
                CustomMessageBox.ShowBox("Data entered failed", "Error", "Error");
            }
        }

        public int CheckAvailability()
        {
            int presentQuantity;
            int row = db.GetRowCount("Select Product_Id from table_cart where product_Id = '" + frm_products.product_ID + "'");

            if (row == 1)
            {
                return presentQuantity = db.ReadDataInt("Select Quantity from table_cart where product_Id = '" + frm_products.product_ID + "'");
            }
            return 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
