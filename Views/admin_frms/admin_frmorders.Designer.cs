
namespace Coursework.admin_frms
{
    partial class admin_frmorders
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentmethodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliverymethodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pharmacyDataSet1 = new Coursework.PharmacyDataSet1();
            this.cmb_orderstatus = new System.Windows.Forms.ComboBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_qr = new System.Windows.Forms.Button();
            this.rbtn_nic = new System.Windows.Forms.RadioButton();
            this.rbtn_qr = new System.Windows.Forms.RadioButton();
            this.rbtn_orderId = new System.Windows.Forms.RadioButton();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ordersTableAdapter = new Coursework.PharmacyDataSet1TableAdapters.OrdersTableAdapter();
            this.txt_error = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn,
            this.orderdateDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.orderstatusDataGridViewTextBoxColumn,
            this.cIDDataGridViewTextBoxColumn,
            this.paymentmethodDataGridViewTextBoxColumn,
            this.deliverymethodDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ordersBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.Location = new System.Drawing.Point(12, 159);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(901, 320);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "Order_ID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "Order_ID";
            this.orderIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            this.orderIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderIDDataGridViewTextBoxColumn.Width = 50;
            // 
            // orderdateDataGridViewTextBoxColumn
            // 
            this.orderdateDataGridViewTextBoxColumn.DataPropertyName = "Order_date";
            this.orderdateDataGridViewTextBoxColumn.HeaderText = "Order_date";
            this.orderdateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderdateDataGridViewTextBoxColumn.Name = "orderdateDataGridViewTextBoxColumn";
            this.orderdateDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderdateDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 70;
            // 
            // orderstatusDataGridViewTextBoxColumn
            // 
            this.orderstatusDataGridViewTextBoxColumn.DataPropertyName = "Order_status";
            this.orderstatusDataGridViewTextBoxColumn.HeaderText = "Order_status";
            this.orderstatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderstatusDataGridViewTextBoxColumn.Name = "orderstatusDataGridViewTextBoxColumn";
            this.orderstatusDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderstatusDataGridViewTextBoxColumn.Width = 85;
            // 
            // cIDDataGridViewTextBoxColumn
            // 
            this.cIDDataGridViewTextBoxColumn.DataPropertyName = "CID";
            this.cIDDataGridViewTextBoxColumn.HeaderText = "CID";
            this.cIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cIDDataGridViewTextBoxColumn.Name = "cIDDataGridViewTextBoxColumn";
            this.cIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.cIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // paymentmethodDataGridViewTextBoxColumn
            // 
            this.paymentmethodDataGridViewTextBoxColumn.DataPropertyName = "Payment_method";
            this.paymentmethodDataGridViewTextBoxColumn.HeaderText = "Payment_method";
            this.paymentmethodDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.paymentmethodDataGridViewTextBoxColumn.Name = "paymentmethodDataGridViewTextBoxColumn";
            this.paymentmethodDataGridViewTextBoxColumn.ReadOnly = true;
            this.paymentmethodDataGridViewTextBoxColumn.Width = 125;
            // 
            // deliverymethodDataGridViewTextBoxColumn
            // 
            this.deliverymethodDataGridViewTextBoxColumn.DataPropertyName = "Delivery_method";
            this.deliverymethodDataGridViewTextBoxColumn.HeaderText = "Delivery_method";
            this.deliverymethodDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.deliverymethodDataGridViewTextBoxColumn.Name = "deliverymethodDataGridViewTextBoxColumn";
            this.deliverymethodDataGridViewTextBoxColumn.ReadOnly = true;
            this.deliverymethodDataGridViewTextBoxColumn.Width = 125;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.pharmacyDataSet1;
            // 
            // pharmacyDataSet1
            // 
            this.pharmacyDataSet1.DataSetName = "PharmacyDataSet1";
            this.pharmacyDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmb_orderstatus
            // 
            this.cmb_orderstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_orderstatus.FormattingEnabled = true;
            this.cmb_orderstatus.Items.AddRange(new object[] {
            "Pending",
            "Delivered",
            "Canceled"});
            this.cmb_orderstatus.Location = new System.Drawing.Point(708, 63);
            this.cmb_orderstatus.Name = "cmb_orderstatus";
            this.cmb_orderstatus.Size = new System.Drawing.Size(205, 24);
            this.cmb_orderstatus.TabIndex = 1;
            // 
            // btn_update
            // 
            this.btn_update.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_update.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_update.Location = new System.Drawing.Point(795, 505);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(110, 36);
            this.btn_update.TabIndex = 6;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_refresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_refresh.Location = new System.Drawing.Point(13, 505);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(110, 36);
            this.btn_refresh.TabIndex = 4;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_Search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_Search.Location = new System.Drawing.Point(657, 505);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(110, 36);
            this.btn_Search.TabIndex = 5;
            this.btn_Search.Text = "SEARCH";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label2.Location = new System.Drawing.Point(475, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Change Order Status";
            // 
            // btn_qr
            // 
            this.btn_qr.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_qr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_qr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_qr.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_qr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_qr.Location = new System.Drawing.Point(380, 62);
            this.btn_qr.Name = "btn_qr";
            this.btn_qr.Size = new System.Drawing.Size(70, 34);
            this.btn_qr.TabIndex = 23;
            this.btn_qr.Text = "SCAN";
            this.btn_qr.UseVisualStyleBackColor = true;
            this.btn_qr.Click += new System.EventHandler(this.btn_qr_Click);
            // 
            // rbtn_nic
            // 
            this.rbtn_nic.AutoSize = true;
            this.rbtn_nic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_nic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.rbtn_nic.Location = new System.Drawing.Point(13, 62);
            this.rbtn_nic.Name = "rbtn_nic";
            this.rbtn_nic.Size = new System.Drawing.Size(57, 22);
            this.rbtn_nic.TabIndex = 24;
            this.rbtn_nic.TabStop = true;
            this.rbtn_nic.Text = "NIC";
            this.rbtn_nic.UseVisualStyleBackColor = true;
            // 
            // rbtn_qr
            // 
            this.rbtn_qr.AutoSize = true;
            this.rbtn_qr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_qr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.rbtn_qr.Location = new System.Drawing.Point(13, 116);
            this.rbtn_qr.Name = "rbtn_qr";
            this.rbtn_qr.Size = new System.Drawing.Size(99, 22);
            this.rbtn_qr.TabIndex = 24;
            this.rbtn_qr.TabStop = true;
            this.rbtn_qr.Text = "QR Code";
            this.rbtn_qr.UseVisualStyleBackColor = true;
            // 
            // rbtn_orderId
            // 
            this.rbtn_orderId.AutoSize = true;
            this.rbtn_orderId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_orderId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.rbtn_orderId.Location = new System.Drawing.Point(13, 89);
            this.rbtn_orderId.Name = "rbtn_orderId";
            this.rbtn_orderId.Size = new System.Drawing.Size(87, 22);
            this.rbtn_orderId.TabIndex = 24;
            this.rbtn_orderId.TabStop = true;
            this.rbtn_orderId.Text = "Oder ID";
            this.rbtn_orderId.UseVisualStyleBackColor = true;
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(155, 62);
            this.txt_search.Multiline = true;
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(175, 34);
            this.txt_search.TabIndex = 25;
            this.txt_search.Click += new System.EventHandler(this.txt_search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Search By :";
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // txt_error
            // 
            this.txt_error.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txt_error.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_error.ForeColor = System.Drawing.Color.Red;
            this.txt_error.Location = new System.Drawing.Point(201, 11);
            this.txt_error.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_error.Multiline = true;
            this.txt_error.Name = "txt_error";
            this.txt_error.ReadOnly = true;
            this.txt_error.Size = new System.Drawing.Size(499, 31);
            this.txt_error.TabIndex = 35;
            // 
            // admin_frmorders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(925, 553);
            this.Controls.Add(this.txt_error);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.rbtn_orderId);
            this.Controls.Add(this.rbtn_qr);
            this.Controls.Add(this.rbtn_nic);
            this.Controls.Add(this.btn_qr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.cmb_orderstatus);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "admin_frmorders";
            this.Text = "admin_frmorders";
            this.Load += new System.EventHandler(this.admin_frmorders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmb_orderstatus;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_qr;
        private System.Windows.Forms.RadioButton rbtn_nic;
        private System.Windows.Forms.RadioButton rbtn_qr;
        private System.Windows.Forms.RadioButton rbtn_orderId;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label1;
        private PharmacyDataSet1 pharmacyDataSet1;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private PharmacyDataSet1TableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderstatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentmethodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliverymethodDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txt_error;
    }
}