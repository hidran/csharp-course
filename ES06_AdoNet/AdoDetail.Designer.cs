
namespace ES06_AdoNet
{
    partial class AdoDetail
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
            this.cmbCountries = new System.Windows.Forms.ComboBox();
            this.dtgProducts = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCustomers = new System.Windows.Forms.ComboBox();
            this.dtgOrders = new System.Windows.Forms.DataGridView();
            this.cmbCities = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCountries
            // 
            this.cmbCountries.FormattingEnabled = true;
            this.cmbCountries.Location = new System.Drawing.Point(255, 65);
            this.cmbCountries.Name = "cmbCountries";
            this.cmbCountries.Size = new System.Drawing.Size(147, 24);
            this.cmbCountries.TabIndex = 0;
            this.cmbCountries.SelectedValueChanged += new System.EventHandler(this.LoadCustomers);
            // 
            // dtgProducts
            // 
            this.dtgProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProducts.Location = new System.Drawing.Point(4, 105);
            this.dtgProducts.Name = "dtgProducts";
            this.dtgProducts.RowHeadersWidth = 51;
            this.dtgProducts.RowTemplate.Height = 24;
            this.dtgProducts.Size = new System.Drawing.Size(689, 325);
            this.dtgProducts.TabIndex = 1;
            this.dtgProducts.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.RowSelected_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filter by country";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(792, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Choose Customer";
            // 
            // cmbCustomers
            // 
            this.cmbCustomers.FormattingEnabled = true;
            this.cmbCustomers.Location = new System.Drawing.Point(996, 72);
            this.cmbCustomers.Name = "cmbCustomers";
            this.cmbCustomers.Size = new System.Drawing.Size(250, 24);
            this.cmbCustomers.TabIndex = 4;
            this.cmbCustomers.SelectedIndexChanged += new System.EventHandler(this.LoadOrders);
            // 
            // dtgOrders
            // 
            this.dtgOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgOrders.Location = new System.Drawing.Point(774, 106);
            this.dtgOrders.Name = "dtgOrders";
            this.dtgOrders.RowHeadersWidth = 51;
            this.dtgOrders.RowTemplate.Height = 24;
            this.dtgOrders.Size = new System.Drawing.Size(781, 332);
            this.dtgOrders.TabIndex = 5;
            this.dtgOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgOrders_CellContentClick);
            // 
            // cmbCities
            // 
            this.cmbCities.FormattingEnabled = true;
            this.cmbCities.Location = new System.Drawing.Point(429, 63);
            this.cmbCities.Name = "cmbCities";
            this.cmbCities.Size = new System.Drawing.Size(176, 24);
            this.cmbCities.TabIndex = 6;
            this.cmbCities.SelectedIndexChanged += new System.EventHandler(this.LoadAllCustomers);
            // 
            // AdoDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1654, 590);
            this.Controls.Add(this.cmbCities);
            this.Controls.Add(this.dtgOrders);
            this.Controls.Add(this.cmbCustomers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgProducts);
            this.Controls.Add(this.cmbCountries);
            this.Name = "AdoDetail";
            this.Text = "Product detqil";
            this.Load += new System.EventHandler(this.AdoDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCountries;
        private System.Windows.Forms.DataGridView dtgProducts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCustomers;
        private System.Windows.Forms.DataGridView dtgOrders;
        private System.Windows.Forms.ComboBox cmbCities;
    }
}