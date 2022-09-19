
namespace Coursework
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PnvNav = new System.Windows.Forms.Panel();
            this.lbl_time = new System.Windows.Forms.Label();
            this.btn_contactus = new System.Windows.Forms.Button();
            this.lbl_date = new System.Windows.Forms.Label();
            this.btn_Orders = new System.Windows.Forms.Button();
            this.btn_Products = new System.Windows.Forms.Button();
            this.btn_settings = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PnlNav = new System.Windows.Forms.Panel();
            this.lbl_nic = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.PnlFormLoader = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_ext = new System.Windows.Forms.Button();
            this.btn_logoout = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.PnvNav);
            this.panel1.Controls.Add(this.lbl_time);
            this.panel1.Controls.Add(this.btn_contactus);
            this.panel1.Controls.Add(this.lbl_date);
            this.panel1.Controls.Add(this.btn_Orders);
            this.panel1.Controls.Add(this.btn_Products);
            this.panel1.Controls.Add(this.btn_settings);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(198, 694);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // PnvNav
            // 
            this.PnvNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.PnvNav.Location = new System.Drawing.Point(3, 285);
            this.PnvNav.Name = "PnvNav";
            this.PnvNav.Size = new System.Drawing.Size(3, 100);
            this.PnvNav.TabIndex = 2;
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lbl_time.Location = new System.Drawing.Point(10, 637);
            this.lbl_time.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(41, 18);
            this.lbl_time.TabIndex = 3;
            this.lbl_time.Text = "Time";
            this.lbl_time.Click += new System.EventHandler(this.lbl_time_Click);
            // 
            // btn_contactus
            // 
            this.btn_contactus.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_contactus.FlatAppearance.BorderSize = 0;
            this.btn_contactus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_contactus.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_contactus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_contactus.Image = global::Coursework.Properties.Resources.Conact;
            this.btn_contactus.Location = new System.Drawing.Point(0, 362);
            this.btn_contactus.Name = "btn_contactus";
            this.btn_contactus.Size = new System.Drawing.Size(198, 50);
            this.btn_contactus.TabIndex = 1;
            this.btn_contactus.Text = "Contact Us";
            this.btn_contactus.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_contactus.UseVisualStyleBackColor = true;
            this.btn_contactus.Click += new System.EventHandler(this.btn_contactus_Click);
            this.btn_contactus.Leave += new System.EventHandler(this.btn_contactus_Leave);
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lbl_date.Location = new System.Drawing.Point(10, 665);
            this.lbl_date.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(38, 17);
            this.lbl_date.TabIndex = 3;
            this.lbl_date.Text = "Date";
            this.lbl_date.Click += new System.EventHandler(this.lbl_date_Click);
            // 
            // btn_Orders
            // 
            this.btn_Orders.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Orders.FlatAppearance.BorderSize = 0;
            this.btn_Orders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Orders.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Orders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_Orders.Image = global::Coursework.Properties.Resources.Order;
            this.btn_Orders.Location = new System.Drawing.Point(0, 312);
            this.btn_Orders.Name = "btn_Orders";
            this.btn_Orders.Size = new System.Drawing.Size(198, 50);
            this.btn_Orders.TabIndex = 1;
            this.btn_Orders.Text = "Orders   ";
            this.btn_Orders.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Orders.UseVisualStyleBackColor = true;
            this.btn_Orders.Click += new System.EventHandler(this.btn_Orders_Click);
            this.btn_Orders.Leave += new System.EventHandler(this.btn_Orders_Leave);
            // 
            // btn_Products
            // 
            this.btn_Products.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Products.FlatAppearance.BorderSize = 0;
            this.btn_Products.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Products.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Products.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_Products.Image = global::Coursework.Properties.Resources.mdicine;
            this.btn_Products.Location = new System.Drawing.Point(0, 262);
            this.btn_Products.Name = "btn_Products";
            this.btn_Products.Size = new System.Drawing.Size(198, 50);
            this.btn_Products.TabIndex = 1;
            this.btn_Products.Text = "Products";
            this.btn_Products.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Products.UseVisualStyleBackColor = true;
            this.btn_Products.Click += new System.EventHandler(this.btn_Products_Click);
            this.btn_Products.Leave += new System.EventHandler(this.btn_Products_Leave);
            // 
            // btn_settings
            // 
            this.btn_settings.FlatAppearance.BorderSize = 0;
            this.btn_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_settings.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_settings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_settings.Image = global::Coursework.Properties.Resources.settings;
            this.btn_settings.Location = new System.Drawing.Point(0, 514);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(198, 50);
            this.btn_settings.TabIndex = 1;
            this.btn_settings.Text = "Settings";
            this.btn_settings.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_settings.UseVisualStyleBackColor = true;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            this.btn_settings.Leave += new System.EventHandler(this.btn_settings_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.PnlNav);
            this.panel2.Controls.Add(this.lbl_nic);
            this.panel2.Controls.Add(this.lbl_username);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(198, 156);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // PnlNav
            // 
            this.PnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.PnlNav.Location = new System.Drawing.Point(0, 193);
            this.PnlNav.Name = "PnlNav";
            this.PnlNav.Size = new System.Drawing.Size(3, 100);
            this.PnlNav.TabIndex = 3;
            // 
            // lbl_nic
            // 
            this.lbl_nic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_nic.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.lbl_nic.Location = new System.Drawing.Point(24, 117);
            this.lbl_nic.Name = "lbl_nic";
            this.lbl_nic.Size = new System.Drawing.Size(144, 15);
            this.lbl_nic.TabIndex = 2;
            this.lbl_nic.Text = "Some User Text Here";
            this.lbl_nic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_username
            // 
            this.lbl_username.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lbl_username.Location = new System.Drawing.Point(47, 88);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(103, 20);
            this.lbl_username.TabIndex = 1;
            this.lbl_username.Text = "User Name";
            this.lbl_username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_username.Click += new System.EventHandler(this.lbl_username_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Coursework.Properties.Resources.Untitled_11;
            this.pictureBox1.Location = new System.Drawing.Point(68, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Image = global::Coursework.Properties.Resources.alpha_logo_dashboard_41;
            this.pictureBox2.Location = new System.Drawing.Point(0, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(198, 88);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(198, 18);
            this.panel3.TabIndex = 5;
            // 
            // lbl_title
            // 
            this.lbl_title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lbl_title.Location = new System.Drawing.Point(225, 21);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(163, 39);
            this.lbl_title.TabIndex = 1;
            this.lbl_title.Text = "Products";
            this.lbl_title.Click += new System.EventHandler(this.lbl_title_Click);
            // 
            // PnlFormLoader
            // 
            this.PnlFormLoader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlFormLoader.Location = new System.Drawing.Point(199, 63);
            this.PnlFormLoader.Name = "PnlFormLoader";
            this.PnlFormLoader.Size = new System.Drawing.Size(925, 553);
            this.PnlFormLoader.TabIndex = 4;
            this.PnlFormLoader.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlFormLoader_Paint);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_ext
            // 
            this.btn_ext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ext.FlatAppearance.BorderSize = 0;
            this.btn_ext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ext.ForeColor = System.Drawing.Color.White;
            this.btn_ext.Location = new System.Drawing.Point(1084, 12);
            this.btn_ext.Name = "btn_ext";
            this.btn_ext.Size = new System.Drawing.Size(40, 40);
            this.btn_ext.TabIndex = 5;
            this.btn_ext.Text = "X";
            this.btn_ext.UseVisualStyleBackColor = true;
            this.btn_ext.Click += new System.EventHandler(this.btn_ext_Click);
            // 
            // btn_logoout
            // 
            this.btn_logoout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_logoout.FlatAppearance.BorderSize = 0;
            this.btn_logoout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logoout.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logoout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_logoout.Image = global::Coursework.Properties.Resources.Webp_net_resizeimage;
            this.btn_logoout.Location = new System.Drawing.Point(937, 632);
            this.btn_logoout.Name = "btn_logoout";
            this.btn_logoout.Size = new System.Drawing.Size(174, 50);
            this.btn_logoout.TabIndex = 7;
            this.btn_logoout.Text = "LOG OUT";
            this.btn_logoout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logoout.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_logoout.UseVisualStyleBackColor = true;
            this.btn_logoout.Click += new System.EventHandler(this.btn_logoout_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1136, 694);
            this.Controls.Add(this.btn_logoout);
            this.Controls.Add(this.btn_ext);
            this.Controls.Add(this.PnlFormLoader);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Dashboard_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Dashboard_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Dashboard_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Products;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_nic;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_settings;
        private System.Windows.Forms.Button btn_contactus;
        private System.Windows.Forms.Button btn_Orders;
        private System.Windows.Forms.Panel PnlNav;
        private System.Windows.Forms.Panel PnvNav;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Panel PnlFormLoader;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_ext;
        private System.Windows.Forms.Button btn_logoout;
    }
}

