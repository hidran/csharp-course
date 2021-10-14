
namespace WFCustomers
{
    partial class Form1
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
            this.grvCustomers = new System.Windows.Forms.DataGridView();
            this.cbCountries = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grvCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // grvCustomers
            // 
            this.grvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvCustomers.Location = new System.Drawing.Point(12, 92);
            this.grvCustomers.Name = "grvCustomers";
            this.grvCustomers.RowHeadersWidth = 51;
            this.grvCustomers.RowTemplate.Height = 24;
            this.grvCustomers.Size = new System.Drawing.Size(1280, 600);
            this.grvCustomers.TabIndex = 0;
            // 
            // cbCountries
            // 
            this.cbCountries.FormattingEnabled = true;
            this.cbCountries.Location = new System.Drawing.Point(40, 32);
            this.cbCountries.Name = "cbCountries";
            this.cbCountries.Size = new System.Drawing.Size(224, 24);
            this.cbCountries.TabIndex = 1;
            this.cbCountries.SelectedIndexChanged += new System.EventHandler(this.ReloadGrid);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 611);
            this.Controls.Add(this.cbCountries);
            this.Controls.Add(this.grvCustomers);
            this.Name = "Form1";
            this.Text = "CUSTOMERS";
            this.Load += new System.EventHandler(this.LoadCustomers);
            ((System.ComponentModel.ISupportInitialize)(this.grvCustomers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grvCustomers;
        private System.Windows.Forms.ComboBox cbCountries;
    }
}

