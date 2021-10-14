
namespace ES06_AdoNet
{
    partial class AdoNet
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
            this.CaricaProdotto = new System.Windows.Forms.Button();
            this.dataProductsGridView = new System.Windows.Forms.DataGridView();
            this.btnShowDetail = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataProductsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CaricaProdotto
            // 
            this.CaricaProdotto.Location = new System.Drawing.Point(31, 13);
            this.CaricaProdotto.Name = "CaricaProdotto";
            this.CaricaProdotto.Size = new System.Drawing.Size(152, 38);
            this.CaricaProdotto.TabIndex = 0;
            this.CaricaProdotto.Text = "Carica Prodotti";
            this.CaricaProdotto.UseVisualStyleBackColor = true;
            this.CaricaProdotto.Click += new System.EventHandler(this.CaricaProdotto_Click);
            // 
            // dataProductsGridView
            // 
            this.dataProductsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataProductsGridView.Location = new System.Drawing.Point(12, 57);
            this.dataProductsGridView.Name = "dataProductsGridView";
            this.dataProductsGridView.RowHeadersWidth = 51;
            this.dataProductsGridView.RowTemplate.Height = 24;
            this.dataProductsGridView.Size = new System.Drawing.Size(1207, 505);
            this.dataProductsGridView.TabIndex = 1;
            // 
            // btnShowDetail
            // 
            this.btnShowDetail.Location = new System.Drawing.Point(1063, 13);
            this.btnShowDetail.Name = "btnShowDetail";
            this.btnShowDetail.Size = new System.Drawing.Size(166, 38);
            this.btnShowDetail.TabIndex = 2;
            this.btnShowDetail.Text = "Show Form detail";
            this.btnShowDetail.UseVisualStyleBackColor = true;
            this.btnShowDetail.Click += new System.EventHandler(this.ShowDetail_Click);
            // 
            // AdoNet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 574);
            this.Controls.Add(this.btnShowDetail);
            this.Controls.Add(this.dataProductsGridView);
            this.Controls.Add(this.CaricaProdotto);
            this.Name = "AdoNet";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AdoNet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataProductsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CaricaProdotto;
        private System.Windows.Forms.DataGridView dataProductsGridView;
        private System.Windows.Forms.Button btnShowDetail;
    }
}

