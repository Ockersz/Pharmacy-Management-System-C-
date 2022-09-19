
namespace Coursework
{
    partial class frmSettings
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
            this.btn_cngepwd = new System.Windows.Forms.Button();
            this.btn_psnldetils = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_cngepwd
            // 
            this.btn_cngepwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cngepwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_cngepwd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(249)))));
            this.btn_cngepwd.Location = new System.Drawing.Point(45, 116);
            this.btn_cngepwd.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cngepwd.Name = "btn_cngepwd";
            this.btn_cngepwd.Size = new System.Drawing.Size(277, 41);
            this.btn_cngepwd.TabIndex = 3;
            this.btn_cngepwd.Text = "Change Password";
            this.btn_cngepwd.UseVisualStyleBackColor = true;
            this.btn_cngepwd.Click += new System.EventHandler(this.btn_cngepwd_Click);
            // 
            // btn_psnldetils
            // 
            this.btn_psnldetils.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_psnldetils.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_psnldetils.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(249)))));
            this.btn_psnldetils.Location = new System.Drawing.Point(45, 44);
            this.btn_psnldetils.Margin = new System.Windows.Forms.Padding(4);
            this.btn_psnldetils.Name = "btn_psnldetils";
            this.btn_psnldetils.Size = new System.Drawing.Size(277, 41);
            this.btn_psnldetils.TabIndex = 2;
            this.btn_psnldetils.Text = " Personal Details";
            this.btn_psnldetils.UseVisualStyleBackColor = true;
            this.btn_psnldetils.Click += new System.EventHandler(this.btn_psnldetils_Click);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(925, 553);
            this.Controls.Add(this.btn_cngepwd);
            this.Controls.Add(this.btn_psnldetils);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSettings";
            this.Text = "frmSettings";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_cngepwd;
        private System.Windows.Forms.Button btn_psnldetils;
    }
}