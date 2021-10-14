
namespace ES13_ASYNC_AWAIT
{
    partial class AsyncAwait
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtIni = new System.Windows.Forms.TextBox();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.txtLengthBuild = new System.Windows.Forms.TextBox();
            this.txtIniBuild = new System.Windows.Forms.TextBox();
            this.txtAsyncEnd = new System.Windows.Forms.TextBox();
            this.txtAsyncIni = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtResultBuild = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.txtAsyncResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtIni
            // 
            this.txtIni.Location = new System.Drawing.Point(33, 61);
            this.txtIni.Name = "txtIni";
            this.txtIni.Size = new System.Drawing.Size(177, 22);
            this.txtIni.TabIndex = 0;
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(33, 113);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(177, 22);
            this.txtEnd.TabIndex = 1;
            // 
            // txtLengthBuild
            // 
            this.txtLengthBuild.Location = new System.Drawing.Point(283, 113);
            this.txtLengthBuild.Name = "txtLengthBuild";
            this.txtLengthBuild.Size = new System.Drawing.Size(177, 22);
            this.txtLengthBuild.TabIndex = 3;
            // 
            // txtIniBuild
            // 
            this.txtIniBuild.Location = new System.Drawing.Point(283, 61);
            this.txtIniBuild.Name = "txtIniBuild";
            this.txtIniBuild.Size = new System.Drawing.Size(177, 22);
            this.txtIniBuild.TabIndex = 2;
            // 
            // txtAsyncEnd
            // 
            this.txtAsyncEnd.Location = new System.Drawing.Point(538, 113);
            this.txtAsyncEnd.Name = "txtAsyncEnd";
            this.txtAsyncEnd.Size = new System.Drawing.Size(177, 22);
            this.txtAsyncEnd.TabIndex = 5;
            // 
            // txtAsyncIni
            // 
            this.txtAsyncIni.Location = new System.Drawing.Point(538, 61);
            this.txtAsyncIni.Name = "txtAsyncIni";
            this.txtAsyncIni.Size = new System.Drawing.Size(177, 22);
            this.txtAsyncIni.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 49);
            this.button1.TabIndex = 6;
            this.button1.Text = "String";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(33, 275);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(177, 22);
            this.txtTotal.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(283, 203);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 49);
            this.button2.TabIndex = 8;
            this.button2.Text = "String Builder";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtResultBuild
            // 
            this.txtResultBuild.Location = new System.Drawing.Point(283, 275);
            this.txtResultBuild.Name = "txtResultBuild";
            this.txtResultBuild.Size = new System.Drawing.Size(177, 22);
            this.txtResultBuild.TabIndex = 9;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(538, 203);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(177, 49);
            this.button3.TabIndex = 10;
            this.button3.Text = "String Builder";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtAsyncResult
            // 
            this.txtAsyncResult.Location = new System.Drawing.Point(538, 275);
            this.txtAsyncResult.Name = "txtAsyncResult";
            this.txtAsyncResult.Size = new System.Drawing.Size(177, 22);
            this.txtAsyncResult.TabIndex = 11;
            // 
            // AsyncAwait
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAsyncResult);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtResultBuild);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtAsyncEnd);
            this.Controls.Add(this.txtAsyncIni);
            this.Controls.Add(this.txtLengthBuild);
            this.Controls.Add(this.txtIniBuild);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.txtIni);
            this.Name = "AsyncAwait";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AsyncAwait_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIni;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.TextBox txtLengthBuild;
        private System.Windows.Forms.TextBox txtIniBuild;
        private System.Windows.Forms.TextBox txtAsyncEnd;
        private System.Windows.Forms.TextBox txtAsyncIni;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtResultBuild;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtAsyncResult;
    }
}

