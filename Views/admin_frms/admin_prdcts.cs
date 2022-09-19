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
using System.IO;

namespace Coursework.admin_frms
{
    public partial class admin_prdcts : Form
    {        
        string imagePath = null;
        int indexRow;
        int product_id;
        public admin_prdcts()
        {
            InitializeComponent();
        }

        Database db = new Database();
        private void admin_prdcts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacyDataSet2.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.pharmacyDataSet.Product);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DeleteProduct();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex == -1)
            { 
            }
            else
            {
                indexRow = e.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[indexRow];
                product_id = Convert.ToInt32(row.Cells[0].Value.ToString());
                txt_name.Text = row.Cells[1].Value.ToString();
                txt_brand.Text = row.Cells[2].Value.ToString();
                txt_qty.Text = row.Cells[3].Value.ToString();
                txt_price.Text = row.Cells[4].Value.ToString();
                String pic = row.Cells[5].Value.ToString();
                //pictureBox1.Image = Image.FromFile(row.Cells[5].Value.ToString());
                imagePath = row.Cells[5].Value.ToString();
                if (pic != "")
                {
                    pictureBox1.Image = Image.FromFile(pic);
                }
                else
                {
                    pictureBox1.Image = null;
                }
 

            }
          

        }
        private void btn_refresh_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.ListData("Select * from Product");
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_name.Text))
            {
                txt_error.Text = "Product name cannot be blank";
                txt_name.Focus();
            }
            else if (!txt_name.Text.Any(char.IsLetter))
            {
                txt_name.Text = "Product Name cannot contain symbols";
                txt_name.Focus();
            }
            else if (string.IsNullOrEmpty(txt_brand.Text))
            {
                txt_error.Text = "Brand Name cannot be blank";
                txt_brand.Focus();
            }
            else if (txt_brand.Text.Any(char.IsDigit))
            {
                txt_error.Text = "Brand name cannot contain numbers";
                txt_brand.Focus();
            }
            else if (string.IsNullOrEmpty(txt_qty.Text))
            {
                txt_error.Text = "Product Quantity cannot be blank";
                txt_qty.Focus();
            }
            else if (txt_qty.Text.Any(char.IsLetter))
            {
                txt_error.Text = "Product Quantity cannot contain letter";
                txt_qty.Focus();
            }
            else if (!txt_qty.Text.All(char.IsDigit))
            {
                txt_error.Text = "Product Quantity cannot contain Symbols";
                txt_qty.Focus();
            }
            else if (string.IsNullOrEmpty(txt_price.Text))
            {
                txt_error.Text = "Product price cannot be blank";
                txt_price.Focus();
            }
            else if (txt_price.Text.Any(char.IsLetter))
            {
                txt_error.Text = "Product price cannot contain letter";
                txt_price.Focus();
            }
            else if (!txt_price.Text.All(char.IsDigit))
            {
                txt_error.Text = "Product price cannot contain Symbols";
                txt_qty.Focus();
            }
            else
            {
                UpdateProduct();
            }
        }
        private void btn_upload_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        imagePath = ofd.FileName;
                        pictureBox1.Image = Image.FromFile(ofd.FileName);
                    }
                }
            }
            catch (OutOfMemoryException)
            {
                CustomMessageBox.ShowBox("please select image", "Error","Error");
            }
            catch (FileNotFoundException)
            {
                CustomMessageBox.ShowBox("please select a file", "Error", "Error");
            }
            catch (Exception)
            {
                CustomMessageBox.ShowBox("please check again", "Error", "Error");
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_name.Text))
            {
                txt_error.Text = "Product name cannot be blank";
                txt_name.Focus();
            }
            else if (!txt_name.Text.Any(char.IsLetter))
            {
                txt_name.Text = "Product Name cannot contain symbols";
                txt_name.Focus();
            }
            else if (string.IsNullOrEmpty(txt_brand.Text))
            {
                txt_error.Text = "Brand Name cannot be blank";
                txt_brand.Focus();
            }
            else if (txt_brand.Text.Any(char.IsDigit))
            {
                txt_error.Text = "Brand name cannot contain numbers";
                txt_brand.Focus();
            }
            else if (string.IsNullOrEmpty(txt_qty.Text))
            {
                txt_error.Text = "Product Quantity cannot be blank";
                txt_qty.Focus();
            }
            else if (txt_qty.Text.Any(char.IsLetter))
            {
                txt_error.Text = "Product Quantity cannot contain letter";
                txt_qty.Focus();
            }
            else if (!txt_qty.Text.All(char.IsDigit))
            {
                txt_error.Text = "Product Quantity cannot contain Symbols";
                txt_qty.Focus();
            }
            else if (string.IsNullOrEmpty(txt_price.Text))
            {
                txt_error.Text = "Product price cannot be blank";
                txt_price.Focus();
            }
            else if (txt_price.Text.Any(char.IsLetter))
            {
                txt_error.Text = "Product price cannot contain letter";
                txt_price.Focus();
            }
            else if (!txt_price.Text.All(char.IsDigit))
            {
                txt_error.Text = "Product price cannot contain Symbols";
                txt_price.Focus();
            }
            else if (pictureBox1.Image == null)
            {
                txt_error.Text = "Picture cannot be empty";
            }
            else                
            {
                txt_error.Clear();
                AddProduct();
            }
        }

        public void DeleteProduct()
        {
            int i = db.insertQuery("Update product set quantity = '" + 0 + "' where Product_id ='" + product_id + "' ");
            if (i == 1)
            {
                CustomMessageBox.ShowBox("Product deleted Successfully", "Info", "Success");
            }
            else
            {
                CustomMessageBox.ShowBox("Product deletion Unsuccessful", "Error", "Error");
            }
        }

        public void UpdateProduct()
        {
            int i = db.insertQuery("Update product set Name = '" + txt_name.Text + "', Brand = '" + txt_brand.Text + "', quantity = '" + Convert.ToInt32(txt_qty.Text) + "', Price = '" + Convert.ToInt32(txt_price.Text) + "',image = '" + imagePath + "' where Product_id ='" + product_id + "' ");
            if (i == 1)
            {
                CustomMessageBox.ShowBox("Product Updated Successfully", "Info", "Success");
            }
            else
            {
                CustomMessageBox.ShowBox("Product Update Unsuccessful", "Error", "Error");
            }        
        }

        public void AddProduct()
        {
            int i = db.insertQuery("Insert into Product (Name,Brand,Quantity,Price,image) values ('" + txt_name.Text + "','" + txt_brand.Text + "','" + Convert.ToInt32(txt_qty.Text) + "' , '" + Convert.ToInt32(txt_price.Text) + "' , '" + imagePath + "')");
            if (i == 1)
            {
                CustomMessageBox.ShowBox("Product Added Successfully","Info","Success");
            }
            else
            {
                CustomMessageBox.ShowBox("Product Add Unsuccessfull", "Error", "Error");
            }          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
