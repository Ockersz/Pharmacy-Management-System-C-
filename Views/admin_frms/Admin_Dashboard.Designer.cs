
namespace Coursework
{
    partial class Admin_Dashboard
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
            this.btn_prdcts = new System.Windows.Forms.Button();
            this.lbl_date = new System.Windows.Forms.Label();
            this.btn_orders = new System.Windows.Forms.Button();
            this.btn_dashboard = new System.Windows.Forms.Button();
            this.btn_empstng = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PnlNav = new System.Windows.Forms.Panel();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PnlFormLoader = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
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
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.PnvNav);
            this.panel1.Controls.Add(this.lbl_time);
            this.panel1.Controls.Add(this.btn_prdcts);
            this.panel1.Controls.Add(this.lbl_date);
            this.panel1.Controls.Add(this.btn_orders);
            this.panel1.Controls.Add(this.btn_dashboard);
            this.panel1.Controls.Add(this.btn_empstng);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 694);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // PnvNav
            // 
            this.PnvNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.PnvNav.Location = new System.Drawing.Point(3, 407);
            this.PnvNav.Name = "PnvNav";
            this.PnvNav.Size = new System.Drawing.Size(3, 100);
            this.PnvNav.TabIndex = 2;
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lbl_time.Location = new System.Drawing.Point(10, 643);
            this.lbl_time.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(41, 18);
            this.lbl_time.TabIndex = 3;
            this.lbl_time.Text = "Time";
            this.lbl_time.Click += new System.EventHandler(this.lbl_time_Click);
            // 
            // btn_prdcts
            // 
            this.btn_prdcts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_prdcts.FlatAppearance.BorderSize = 0;
            this.btn_prdcts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_prdcts.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prdcts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_prdcts.Image = global::Coursework.Properties.Resources.Conact;
            this.btn_prdcts.Location = new System.Drawing.Point(0, 362);
            this.btn_prdcts.Name = "btn_prdcts";
            this.btn_prdcts.Size = new System.Drawing.Size(206, 50);
            this.btn_prdcts.TabIndex = 1;
            this.btn_prdcts.Text = "  Products       ";
            this.btn_prdcts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_prdcts.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_prdcts.UseVisualStyleBackColor = true;
            this.btn_prdcts.Click += new System.EventHandler(this.btn_prdcts_Click);
            this.btn_prdcts.Leave += new System.EventHandler(this.btn_prdcts_Leave);
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lbl_date.Location = new System.Drawing.Point(10, 671);
            this.lbl_date.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(38, 17);
            this.lbl_date.TabIndex = 3;
            this.lbl_date.Text = "Date";
            // 
            // btn_orders
            // 
            this.btn_orders.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_orders.FlatAppearance.BorderSize = 0;
            this.btn_orders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_orders.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_orders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_orders.Image = global::Coursework.Properties.Resources.diagram1;
            this.btn_orders.Location = new System.Drawing.Point(0, 312);
            this.btn_orders.Name = "btn_orders";
            this.btn_orders.Size = new System.Drawing.Size(206, 50);
            this.btn_orders.TabIndex = 1;
            this.btn_orders.Text = "  Orders           ";
            this.btn_orders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_orders.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_orders.UseVisualStyleBackColor = true;
            this.btn_orders.Click += new System.EventHandler(this.btn_orders_Click);
            this.btn_orders.Leave += new System.EventHandler(this.btn_orders_Leave);
            // 
            // btn_dashboard
            // 
            this.btn_dashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_dashboard.FlatAppearance.BorderSize = 0;
            this.btn_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dashboard.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_dashboard.Image = global::Coursework.Properties.Resources.home;
            this.btn_dashboard.Location = new System.Drawing.Point(0, 262);
            this.btn_dashboard.Name = "btn_dashboard";
            this.btn_dashboard.Size = new System.Drawing.Size(206, 50);
            this.btn_dashboard.TabIndex = 1;
            this.btn_dashboard.Text = "  Dashboard    ";
            this.btn_dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_dashboard.UseVisualStyleBackColor = true;
            this.btn_dashboard.Click += new System.EventHandler(this.btn_dashboard_Click);
            this.btn_dashboard.Leave += new System.EventHandler(this.btn_dashboard_Leave);
            // 
            // btn_empstng
            // 
            this.btn_empstng.FlatAppearance.BorderSize = 0;
            this.btn_empstng.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_empstng.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_empstng.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_empstng.Image = global::Coursework.Properties.Resources.settings;
            this.btn_empstng.Location = new System.Drawing.Point(0, 513);
            this.btn_empstng.Name = "btn_empstng";
            this.btn_empstng.Size = new System.Drawing.Size(206, 50);
            this.btn_empstng.TabIndex = 1;
            this.btn_empstng.Text = "Employee Settings";
            this.btn_empstng.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_empstng.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_empstng.UseVisualStyleBackColor = true;
            this.btn_empstng.Click += new System.EventHandler(this.btn_empstng_Click);
            this.btn_empstng.Leave += new System.EventHandler(this.btn_empstng_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.PnlNav);
            this.panel2.Controls.Add(this.lbl_name);
            this.panel2.Controls.Add(this.lbl_username);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(206, 156);
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
            // lbl_name
            // 
            this.lbl_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.lbl_name.Location = new System.Drawing.Point(69, 118);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(69, 15);
            this.lbl_name.TabIndex = 2;
            this.lbl_name.Text = "Text Here\r\n";
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_name.Click += new System.EventHandler(this.lbl_name_Click);
            // 
            // lbl_username
            // 
            this.lbl_username.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lbl_username.Location = new System.Drawing.Point(73, 88);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(61, 20);
            this.lbl_username.TabIndex = 1;
            this.lbl_username.Text = "Admin";
            this.lbl_username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_username.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Coursework.Properties.Resources.Untitled_11;
            this.pictureBox1.Location = new System.Drawing.Point(72, 22);
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
            this.pictureBox2.Size = new System.Drawing.Size(206, 88);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(206, 18);
            this.panel3.TabIndex = 5;
            // 
            // PnlFormLoader
            // 
            this.PnlFormLoader.Location = new System.Drawing.Point(209, 69);
            this.PnlFormLoader.Name = "PnlFormLoader";
            this.PnlFormLoader.Size = new System.Drawing.Size(925, 553);
            this.PnlFormLoader.TabIndex = 8;
            this.PnlFormLoader.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlFormLoader_Paint);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lbl_title.Location = new System.Drawing.Point(225, 13);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(195, 39);
            this.lbl_title.TabIndex = 5;
            this.lbl_title.Text = "Dashboard";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_ext
            // 
            this.btn_ext.FlatAppearance.BorderSize = 0;
            this.btn_ext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ext.ForeColor = System.Drawing.Color.White;
            this.btn_ext.Location = new System.Drawing.Point(1084, 12);
            this.btn_ext.Name = "btn_ext";
            this.btn_ext.Size = new System.Drawing.Size(40, 40);
            this.btn_ext.TabIndex = 4;
            this.btn_ext.Text = "X";
            this.btn_ext.UseVisualStyleBackColor = true;
            this.btn_ext.Click += new System.EventHandler(this.btn_ext_Click);
            // 
            // btn_logoout
            // 
            this.btn_logoout.FlatAppearance.BorderSize = 0;
            this.btn_logoout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logoout.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logoout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_logoout.Image = global::Coursework.Properties.Resources.Webp_net_resizeimage;
            this.btn_logoout.Location = new System.Drawing.Point(966, 632);
            this.btn_logoout.Name = "btn_logoout";
            this.btn_logoout.Size = new System.Drawing.Size(158, 50);
            this.btn_logoout.TabIndex = 6;
            this.btn_logoout.Text = "LOG OUT";
            this.btn_logoout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logoout.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_logoout.UseVisualStyleBackColor = true;
            this.btn_logoout.Click += new System.EventHandler(this.btn_logoout_Click);
            // 
            // Admin_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1136, 694);
            this.Controls.Add(this.PnlFormLoader);
            this.Controls.Add(this.btn_logoout);
            this.Controls.Add(this.btn_ext);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin_Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_Dashboard";
            this.Load += new System.EventHandler(this.Admin_Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PnvNav;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Button btn_prdcts;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Button btn_orders;
        private System.Windows.Forms.Button btn_dashboard;
        private System.Windows.Forms.Button btn_empstng;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel PnlNav;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel PnlFormLoader;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_ext;
        private System.Windows.Forms.Button btn_logoout;
    }
}