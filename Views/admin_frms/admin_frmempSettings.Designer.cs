
namespace Coursework.admin_frms
{
    partial class admin_frmempSettings
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
            this.btn_emppsnldetils = new System.Windows.Forms.Button();
            this.btn_chngpass = new System.Windows.Forms.Button();
            this.btn_addemp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_emppsnldetils
            // 
            this.btn_emppsnldetils.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_emppsnldetils.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_emppsnldetils.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(249)))));
            this.btn_emppsnldetils.Location = new System.Drawing.Point(39, 37);
            this.btn_emppsnldetils.Margin = new System.Windows.Forms.Padding(4);
            this.btn_emppsnldetils.Name = "btn_emppsnldetils";
            this.btn_emppsnldetils.Size = new System.Drawing.Size(277, 41);
            this.btn_emppsnldetils.TabIndex = 3;
            this.btn_emppsnldetils.Text = "Employee Details";
            this.btn_emppsnldetils.UseVisualStyleBackColor = true;
            this.btn_emppsnldetils.Click += new System.EventHandler(this.btn_emppsnldetils_Click);
            // 
            // btn_chngpass
            // 
            this.btn_chngpass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_chngpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_chngpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(249)))));
            this.btn_chngpass.Location = new System.Drawing.Point(39, 110);
            this.btn_chngpass.Margin = new System.Windows.Forms.Padding(4);
            this.btn_chngpass.Name = "btn_chngpass";
            this.btn_chngpass.Size = new System.Drawing.Size(277, 41);
            this.btn_chngpass.TabIndex = 4;
            this.btn_chngpass.Text = "Change Password";
            this.btn_chngpass.UseVisualStyleBackColor = true;
            this.btn_chngpass.Click += new System.EventHandler(this.btn_chngpass_Click);
            // 
            // btn_addemp
            // 
            this.btn_addemp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_addemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(249)))));
            this.btn_addemp.Location = new System.Drawing.Point(39, 186);
            this.btn_addemp.Margin = new System.Windows.Forms.Padding(4);
            this.btn_addemp.Name = "btn_addemp";
            this.btn_addemp.Size = new System.Drawing.Size(277, 41);
            this.btn_addemp.TabIndex = 5;
            this.btn_addemp.Text = "Add Employee";
            this.btn_addemp.UseVisualStyleBackColor = true;
            this.btn_addemp.Click += new System.EventHandler(this.btn_addemp_Click);
            // 
            // admin_frmempSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(925, 553);
            this.Controls.Add(this.btn_addemp);
            this.Controls.Add(this.btn_chngpass);
            this.Controls.Add(this.btn_emppsnldetils);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "admin_frmempSettings";
            this.Text = "frmempSettings";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_emppsnldetils;
        private System.Windows.Forms.Button btn_chngpass;
        private System.Windows.Forms.Button btn_addemp;
    }
}