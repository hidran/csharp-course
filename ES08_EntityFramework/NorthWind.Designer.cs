
namespace ES08_EntityFramework
{
    partial class NorthWind
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
            this.LoadCategories = new System.Windows.Forms.Button();
            this.dtgProducts = new System.Windows.Forms.DataGridView();
            this.cmbCats = new System.Windows.Forms.ComboBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadCategories
            // 
            this.LoadCategories.Location = new System.Drawing.Point(288, 24);
            this.LoadCategories.Name = "LoadCategories";
            this.LoadCategories.Size = new System.Drawing.Size(288, 43);
            this.LoadCategories.TabIndex = 0;
            this.LoadCategories.Text = "Filter";
            this.LoadCategories.UseVisualStyleBackColor = true;
            this.LoadCategories.Click += new System.EventHandler(this.LoadProducts_Click);
            // 
            // dtgProducts
            // 
            this.dtgProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProducts.Location = new System.Drawing.Point(12, 75);
            this.dtgProducts.Name = "dtgProducts";
            this.dtgProducts.RowHeadersWidth = 51;
            this.dtgProducts.RowTemplate.Height = 24;
            this.dtgProducts.Size = new System.Drawing.Size(801, 271);
            this.dtgProducts.TabIndex = 2;
            this.dtgProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UpdateProduct);
            this.dtgProducts.DoubleClick += new System.EventHandler(this.ShowFormDetail);
            // 
            // cmbCats
            // 
            this.cmbCats.FormattingEnabled = true;
            this.cmbCats.Location = new System.Drawing.Point(12, 43);
            this.cmbCats.Name = "cmbCats";
            this.cmbCats.Size = new System.Drawing.Size(270, 24);
            this.cmbCats.TabIndex = 3;
            this.cmbCats.SelectedIndexChanged += new System.EventHandler(this.LoadCategories_Clic);
            // 
            // NorthWind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 716);
            this.Controls.Add(this.cmbCats);
            this.Controls.Add(this.dtgProducts);
            this.Controls.Add(this.LoadCategories);
            this.Name = "NorthWind";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LoadCats);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LoadCategories;
        private System.Windows.Forms.DataGridView dtgProducts;
        private System.Windows.Forms.ComboBox cmbCats;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

