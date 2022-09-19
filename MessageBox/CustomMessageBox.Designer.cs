
namespace Coursework.MessageBox
{
    partial class CustomMessageBox
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_message = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.pic_success = new System.Windows.Forms.PictureBox();
            this.pic_error = new System.Windows.Forms.PictureBox();
            this.pic_info = new System.Windows.Forms.PictureBox();
            this.btn_ext = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_success)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_info)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.btn_ext);
            this.panel1.Controls.Add(this.lbl_title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 42);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lbl_title.Location = new System.Drawing.Point(12, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(0, 24);
            this.lbl_title.TabIndex = 0;
            // 
            // lbl_message
            // 
            this.lbl_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_message.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lbl_message.Location = new System.Drawing.Point(103, 65);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(345, 125);
            this.lbl_message.TabIndex = 1;
            this.lbl_message.Text = "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            this.lbl_message.Click += new System.EventHandler(this.lbl_message_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ok.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ok.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_ok.Location = new System.Drawing.Point(376, 206);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(94, 35);
            this.btn_ok.TabIndex = 2;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = false;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // pic_success
            // 
            this.pic_success.Image = global::Coursework.Properties.Resources.success;
            this.pic_success.Location = new System.Drawing.Point(23, 65);
            this.pic_success.Name = "pic_success";
            this.pic_success.Size = new System.Drawing.Size(55, 55);
            this.pic_success.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_success.TabIndex = 5;
            this.pic_success.TabStop = false;
            this.pic_success.Click += new System.EventHandler(this.pic_success_Click);
            // 
            // pic_error
            // 
            this.pic_error.Image = global::Coursework.Properties.Resources.error_logo;
            this.pic_error.Location = new System.Drawing.Point(23, 65);
            this.pic_error.Name = "pic_error";
            this.pic_error.Size = new System.Drawing.Size(55, 55);
            this.pic_error.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_error.TabIndex = 5;
            this.pic_error.TabStop = false;
            // 
            // pic_info
            // 
            this.pic_info.Image = global::Coursework.Properties.Resources.info_logo;
            this.pic_info.Location = new System.Drawing.Point(23, 65);
            this.pic_info.Name = "pic_info";
            this.pic_info.Size = new System.Drawing.Size(55, 55);
            this.pic_info.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_info.TabIndex = 4;
            this.pic_info.TabStop = false;
            this.pic_info.Click += new System.EventHandler(this.pic_info_Click);
            // 
            // btn_ext
            // 
            this.btn_ext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ext.FlatAppearance.BorderSize = 0;
            this.btn_ext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ext.ForeColor = System.Drawing.Color.White;
            this.btn_ext.Location = new System.Drawing.Point(448, 3);
            this.btn_ext.Name = "btn_ext";
            this.btn_ext.Size = new System.Drawing.Size(31, 33);
            this.btn_ext.TabIndex = 6;
            this.btn_ext.Text = "X";
            this.btn_ext.UseVisualStyleBackColor = true;
            this.btn_ext.Click += new System.EventHandler(this.btn_ext_Click);
            // 
            // CustomMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(482, 253);
            this.Controls.Add(this.pic_success);
            this.Controls.Add(this.pic_error);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.lbl_message);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pic_info);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomMessageBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomMessageBox";
            this.Load += new System.EventHandler(this.CustomMessageBox_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CustomMessageBox_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CustomMessageBox_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CustomMessageBox_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_success)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_info)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_message;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.PictureBox pic_info;
        private System.Windows.Forms.PictureBox pic_error;
        private System.Windows.Forms.PictureBox pic_success;
        private System.Windows.Forms.Button btn_ext;
    }
}