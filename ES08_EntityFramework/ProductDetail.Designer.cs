
namespace ES08_EntityFramework
{
    partial class ProductDetail
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
            this.ProductName = new System.Windows.Forms.TextBox();
            this.ProductID = new System.Windows.Forms.TextBox();
            this.cmbCats = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ProductName
            // 
            this.ProductName.Location = new System.Drawing.Point(124, 47);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(397, 22);
            this.ProductName.TabIndex = 0;
            // 
            // ProductID
            // 
            this.ProductID.Location = new System.Drawing.Point(124, 12);
            this.ProductID.Name = "ProductID";
            this.ProductID.Size = new System.Drawing.Size(397, 22);
            this.ProductID.TabIndex = 1;
            // 
            // cmbCats
            // 
            this.cmbCats.FormattingEnabled = true;
            this.cmbCats.Location = new System.Drawing.Point(124, 89);
            this.cmbCats.Name = "cmbCats";
            this.cmbCats.Size = new System.Drawing.Size(397, 24);
            this.cmbCats.TabIndex = 2;
            // 
            // ProductDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbCats);
            this.Controls.Add(this.ProductID);
            this.Controls.Add(this.ProductName);
            this.Name = "ProductDetail";
            this.Text = "Update product";
            this.Load += new System.EventHandler(this.InitFields);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ProductName;
        private System.Windows.Forms.TextBox ProductID;
        private System.Windows.Forms.ComboBox cmbCats;
    }
}