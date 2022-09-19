using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Coursework.MessageBox;
using System.Net;
using System.Net.Mail;
using System.IO;
using System.Drawing.Imaging;

namespace Coursework.user_frms
{
    public partial class frm_cart : Form
    {
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);
        public static string payment_option;
        public static string delivery_option;
        public static int total = 0;
        public static int order_Id = 0;
        List<string> body = new List<string>();
        Database db = new Database();

        public frm_cart()
        {
            InitializeComponent();

            int ID = GetMaxID();

            this.AutoScroll = true;

            int x = 30; int y = 20;
            int c = 1;

            while (c < ID + 1)
            {
                SetComp(x, y, c);

                y = y + 50;
                c++;
            }

            ShowTotal(10, 375, GetTotal());

        }

        private void frm_cart_Load(object sender, EventArgs e)
        { }

            public int GetMaxID()
            {
                
                return db.ReadDataInt("Select Max(ID) from table_cart");
            }
            public int GetTotal()
            {
                
                return db.ReadDataInt("Select SUM(Price) from table_cart");
            }
            public string GetPName(int pid)
            {
                
                return  db.ReadDataString("Select product_Name from table_cart where ID = '" + pid + "'");
            }

            public int GetQuantity(int pid)
            {
                
                return  db.ReadDataInt("Select quantity from table_cart where ID = '" + pid + "'");
            }

            public int GetPrice(int pid)
            {
                int price;
                return price = db.ReadDataInt("Select price from table_cart where ID = '" + pid + "'");
            }
        
            public void SetComp(int x, int y, int c)
            {

                Label lblname = new Label();
                Label lblquantity = new Label();
                Label lblprice = new Label();
                //Button btn_delete = new Button();



                lblname.AutoSize = true;
                lblname.Text = GetPName(c);
                lblname.Location = new System.Drawing.Point(x, y);
                lblname.Name = "lbl_PName" + c.ToString();
                lblname.Size = new System.Drawing.Size(44, 16);
                lblname.Font = new Font("Nirmala UI", 14, FontStyle.Bold);
                lblname.ForeColor = System.Drawing.Color.FromArgb(0, 126, 249);
                lblname.TabIndex = 2;

                lblprice.AutoSize = true;
                lblprice.Text = GetQuantity(c).ToString();
                lblprice.Location = new System.Drawing.Point((x + 150), y);
                lblprice.Name = "lbl_qunatity" + c.ToString();
                lblprice.Size = new System.Drawing.Size(44, 16);
                lblprice.Font = new Font("Nirmala UI", 14, FontStyle.Bold);
                lblprice.ForeColor = System.Drawing.Color.FromArgb(0, 126, 249);
                lblprice.TabIndex = 3;

                lblquantity.AutoSize = true;
                lblquantity.Text = GetPrice(c).ToString();
                lblquantity.Location = new System.Drawing.Point((x + 250), y);
                lblquantity.Name = "lbl_Pprice" + c.ToString();
                lblquantity.Size = new System.Drawing.Size(44, 16);
                lblquantity.Font = new Font("Nirmala UI", 14, FontStyle.Bold);
                lblquantity.ForeColor = System.Drawing.Color.FromArgb(0, 126, 249);
                lblquantity.TabIndex = 4;

                /*btn_delete.AutoSize = true;
                btn_delete.Text = "Delete";
                btn_delete.Location = new System.Drawing.Point((x + 350), y);
                btn_delete.Name = "btn_delete" + c.ToString();
                btn_delete.Size = new System.Drawing.Size(25, 25);
                btn_delete.TabIndex = 5;
                btn_delete.Font = new Font("Nirmala UI", 14, FontStyle.Bold);
                btn_delete.ForeColor = System.Drawing.Color.FromArgb(0, 126, 249);
                btn_delete.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_delete_MouseClick);*/

                panel4.Controls.Add(lblname);
                panel4.Controls.Add(lblquantity);
                panel4.Controls.Add(lblprice);
                //panel4.Controls.Add(btn_delete);
            }

            public void ShowTotal(int x, int y, int total)
            {
                Label lbltotal = new Label();

                lbltotal.AutoSize = true;
                lbltotal.Text = "Total = " + total.ToString();
                lbltotal.Location = new System.Drawing.Point(x, y);
                lbltotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
                lbltotal.Name = "lbl_total";
                lbltotal.Size = new System.Drawing.Size(44, 16);
                lbltotal.Font = new Font("Nirmala UI", 14, FontStyle.Bold);
                lbltotal.ForeColor = System.Drawing.Color.FromArgb(200, 0, 0);
                lbltotal.TabIndex = 6;

                panel1.Controls.Add(lbltotal);
            }

            /*private void btn_delete_MouseClick(object sender, MouseEventArgs e)
            {

            }*/

            private void panel2_Paint(object sender, PaintEventArgs e)
            {

            }

            private void panel4_Paint(object sender, PaintEventArgs e)
            {

            }

            private void btn_back_Click(object sender, EventArgs e)
            {
                this.Hide();
            }

            private void panel3_MouseDown(object sender, MouseEventArgs e)
            {
                dragging = true;
                startPoint = new Point(e.X, e.Y);
            }

            private void panel3_MouseUp(object sender, MouseEventArgs e)
            {
                dragging = false;
            }

            private void panel3_MouseMove(object sender, MouseEventArgs e)
            {
                if (dragging)
                {
                    Point p = PointToScreen(e.Location);
                    Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);

                }
            }

            private void panel3_Paint(object sender, PaintEventArgs e)
            {

            }

            private void cmb_delivery_SelectedIndexChanged(object sender, EventArgs e)
            {
                if (cmb_delivery.SelectedIndex == 0)
                {
                    payment_option = "Cash On Site";
                    lbl_payment.Text = payment_option;
                }
                else if (cmb_delivery.SelectedIndex == 1)
                {
                    payment_option = "Cash On Delivery";
                    lbl_payment.Text = payment_option;
                }
            }

            private void panel1_Paint(object sender, PaintEventArgs e)
            {

            }

            private void btn_clear_Click(object sender, EventArgs e)
            {
                EmptyCart();
                this.Hide();
            }

            public void EmptyCart()
            {
                db.insertQuery("truncate table table_cart");
            }



            public void AddOrder()
            {
                total = GetTotal();
                payment_option = lbl_payment.Text;
                delivery_option = cmb_delivery.SelectedItem.ToString();
                db.insertQuery("Insert into Orders (Price,Order_status,CID,Payment_method,Delivery_method) values ('" + total + "','Pending','" + frm_Login.username + "','" + payment_option + "','" + delivery_option + "')");
            }

            List<int> pId = new List<int>();

            public void GetProductID()
            {
                int ID = GetMaxID();
                int c = 1;

                while (c < ID + 1)
                {
                    int i = db.ReadDataInt("Select Product_id from table_cart where ID = '" + c + "'");
                    pId.Add(i);
                    c++;
                }
            }

            public int GetOrderId()
            {
                return db.ReadDataInt("Select MAX(Order_ID) from Orders");
            }

            public int GetProductQuantity(int pid)
            {
                return db.ReadDataInt("Select quantity from Product where Product_Id = '" + pid + "'");
            }

            public void AddOrderProduct()
            {
                GetProductID();
                int loop = pId.Count;
                int c = 0;

                while (c < loop)
                {
                    int i = pId[c];
                    int quantity = GetQuantity(c + 1);
                    int price = GetPrice(c + 1);
                    int orderId = GetOrderId();

                    db.insertQuery("Insert into Product_Order values ('" + pId[c] + "','" + orderId + "','" + quantity + "','" + price + "')");
                    ++c;
                }

            }

            public void updateQuantity()
            {
                int loop = pId.Count;
                int c = 0;

                while (c < loop)
                {
                    int i = pId[c];
                    int q = GetQuantity(pId[c]);
                    int quantity = GetProductQuantity(pId[c]);

                    db.insertQuery("Update Product set quantity = '" + (quantity - q) + "' where Product_id = '" + i + "'");
                    c++;
                }
            }

        public string GetMail()
        {
           return db.ReadDataString("Select Email from Customer where NIC = '"+frm_Login.username+"'");
        }
        public void SendMail()
        {
            QRCoder.QRCodeGenerator QG = new QRCoder.QRCodeGenerator();
            var PB = QG.CreateQrCode(GetOrderId().ToString(), QRCoder.QRCodeGenerator.ECCLevel.H);
            var code = new QRCoder.QRCode(PB);
            pb1_qr.Image = code.GetGraphic(50);

            try
            {
                string email = GetMail();
                DataTable products = db.ListData("select Product_name,Quantity,Price from table_cart");
                string message = getHtml(products);
                string tempImage = Path.Combine(Path.GetTempPath(), "Attachment.jpg");
                pb1_qr.Image.Save(tempImage, ImageFormat.Jpeg);

                using (SmtpClient client = new SmtpClient("smtp.gmail.com", 587))
                {
                    
                    client.EnableSsl = true;
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                    client.UseDefaultCredentials = true;
                    client.Credentials = new NetworkCredential("medicarepharmacy579@gmail.com", "tqmgvhixzrmfjffo");
                    MailMessage msgObj = new MailMessage();
                    msgObj.To.Add(email);
                    msgObj.From = new MailAddress("medicarepharmacy579@gmail.com");
                    msgObj.Subject = "Order Placed " + " #" + GetOrderId();
                    msgObj.IsBodyHtml = true;
                    msgObj.Body = message + "<br><br><br><br> Total = " + GetTotal() + "";
                    msgObj.Attachments.Add(new Attachment(tempImage));

                    client.Send(msgObj);
                }
                body.Clear();
            }
            catch(Exception)
            {
                CustomMessageBox.ShowBox("Mail sending Error","Error","Error");
            }

        }

        public string getHtml(DataTable table)
        {

            string messageBody = "<font> Order Placed #" + GetOrderId() + "</font><br><br>";
            if (table.Rows.Count == 0) return messageBody;
            string htmlTableStart = "<tbale style=\" border-collapse:collapse; text-align:center;\" >";
            string htmlTableEnd = "</table>";
            string htmlHeaderRowStart = "<tr style=\"background-color:#6FA1D2; color:#ffffff;\">";
            string htmlHeaderRowEnd = "</tr>";
            string htmlTrStart = "<tr style=\"color:#555555;\">";
            string htmlTrEnd = "</tr>";
            string htmlTdStart = "<td style=\" bordder-color:#5c87b2; border-style:solid; border-width:this; padding: 5px;\">";
            string htmlTdEnd = "</td>";
            messageBody += htmlTableStart;
            messageBody += htmlHeaderRowStart;
            messageBody += htmlTdStart + "Name" + htmlTdEnd;
            messageBody += htmlTdStart + "Quantity" + htmlTdEnd;
            messageBody += htmlTdStart + "Price" + htmlTdEnd;
            messageBody += htmlHeaderRowEnd;

            for(int i = 0; i<=table.Rows.Count-1; i++)
            {
                messageBody += htmlTrStart;
                messageBody = messageBody + htmlTdStart + table.Rows[i][0] + htmlTdEnd;
                messageBody = messageBody + htmlTdStart + table.Rows[i][1] + htmlTdEnd;
                messageBody = messageBody + htmlTdStart + table.Rows[i][2] + htmlTdEnd;
                messageBody += htmlTrEnd;
            }

            messageBody += htmlTableEnd;
            return messageBody;

        }

        private void btn_Order_Click(object sender, EventArgs e)
            {
                if (cmb_delivery.SelectedIndex == 0 || cmb_delivery.SelectedIndex == 1)
                {
                    txt_Errormsg.Clear();
                    AddOrder();
                    AddOrderProduct();
                    updateQuantity();
                    

                    SendMail();
                    EmptyCart();
                    CustomMessageBox.ShowBox("Your Order Has Been Placed ", "Info", "Success");
                }
                else
                {
                    txt_Errormsg.Text = "Select Delivery Method";
                }
            }
        }
    }
