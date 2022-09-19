using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlTypes;
using Coursework.MessageBox;

namespace Coursework.user_frms
{
    public partial class frm_products : Form
    {
        Database db = new Database();
        public static int product_ID = 0;
        public frm_products()
        {
            InitializeComponent();

            EmptyCart();

            int id = GetMaxID();


            int x = 37; int y = 50;
            int c = 1;
            /*   setcomp(x, y,1);
               x = x +10 ;
               y = y + 370;
               setcomp(x, y, 2);   */


            //panel2.AutoScroll = true;
           

            while (c < id + 1)
            {

                string filelocation = GetPImage(c);
                string PName = GetPName(c);
                int price = GetPPrice(c);
                int quantity = GetQuantity(c);
                if (filelocation == null && PName == null && price == 0)
                {
                   
                }
                else
                {
                    if (quantity == 0)
                    { }
                    else
                    {
                        Setcomp(x, y, c, filelocation, PName, price);

                        if ((x + 200) > panel2.Size.Width)
                        {
                            y += 200;
                            x = 37;
                        }
                        else
                        {
                            x += 150;
                        }
                    }
                }
                c++;
            }     
        }

        public void Setcomp(int x, int y, int c, string imgloc,string pname,int price)
        {
         
                PictureBox pb1 = new PictureBox();
                Label lblname = new Label();
                Label lblprice = new Label();
                CheckBox chkb = new CheckBox();

                pb1.Location = new System.Drawing.Point(x, y);
                pb1.Name = c.ToString();
                pb1.Size = new System.Drawing.Size(100, 100);
                pb1.TabIndex = 1;
                pb1.SizeMode = PictureBoxSizeMode.Zoom;
               
                pb1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pb1_MouseClick);

            if (imgloc != "")
            {
                pb1.Image = Image.FromFile(imgloc);
            }
            else
            {
                pb1.Image = Image.FromFile(null);
            }

                lblname.AutoSize = true;
                lblname.Text = pname;
                lblname.Location = new System.Drawing.Point(x, (y + 110));
                lblname.Name = "lbl_PName" + c.ToString();
                lblname.Size = new System.Drawing.Size(44, 16);
                lblname.ForeColor = System.Drawing.Color.FromArgb(158, 161, 176);
                lblname.Font = new Font("Nirmala U", 12, FontStyle.Bold);
                lblname.TabIndex = 2;

                lblprice.AutoSize = true;
                lblprice.Text = "Rs. " + price.ToString();
                lblprice.Location = new System.Drawing.Point(x, (y + 130));
                lblprice.Name = "lbl_Pprice" + c.ToString();
                lblprice.Size = new System.Drawing.Size(44, 16);
                lblprice.ForeColor = System.Drawing.Color.FromArgb(0, 126, 249);
                lblprice.Font = new Font("Nirmala UI", 12);
                lblprice.TabIndex = 3;

                panel2.Controls.Add(pb1);
                panel2.Controls.Add(lblname);
                panel2.Controls.Add(lblprice);
         
        }

        public string GetPImage(int pid)
        {
            string image;
            image = db.ReadDataString("Select Image from product where product_id = '" + pid + "'");
            if (image != "")
            {
                return image;
            }
            else
            {
                return null;
            }
            return null;
        }

        public string GetPName(int pid)
        {
            string PName ;
            return PName = db.ReadDataString("Select Name from product where product_id = '" + pid + "'");
        }

        public int GetPPrice(int pid)
        {
            int price;
            return price = db.ReadDataInt("Select Price from product where product_id = '" + pid + "'");
        }

        public int GetMaxID()
        {
            int id;
            return id = db.ReadDataInt("Select MAX(Product_id) from product");
        }

        public int GetQuantity(int pid)
        {
          int quantity = 0;
          return  quantity = db.ReadDataInt("Select Quantity from product where product_id = '" + pid + "'");
        
        }

        private void pb1_MouseClick(object sender, MouseEventArgs e)
        {
            product_ID = Convert.ToInt32(((PictureBox)sender).Name);
            frm_prdctpop obj = new frm_prdctpop();
            obj.ShowDialog();
        }

        public void EmptyCart()
        {
            db.insertQuery("truncate table table_cart;");
        }

        private void btn_cart_Click(object sender, EventArgs e)
        {
            frm_cart obj = new frm_cart();
            obj.ShowDialog();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }
    } 
}
