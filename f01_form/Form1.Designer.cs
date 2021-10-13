
namespace f01_form
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.txtVal2 = new System.Windows.Forms.TextBox();
            this.txtVal1 = new System.Windows.Forms.TextBox();
            this.operazioni = new System.Windows.Forms.GroupBox();
            this.rdbMul = new System.Windows.Forms.RadioButton();
            this.rdbSum = new System.Windows.Forms.RadioButton();
            this.rdbDiv = new System.Windows.Forms.RadioButton();
            this.rdbSub = new System.Windows.Forms.RadioButton();
            this.execute = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.operazioni.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtResult);
            this.groupBox1.Controls.Add(this.txtVal2);
            this.groupBox1.Controls.Add(this.txtVal1);
            this.groupBox1.Controls.Add(this.operazioni);
            this.groupBox1.Controls.Add(this.execute);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 407);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OPERAZIONI";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Operatore1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Operatore1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtResult
            // 
            this.txtResult.Enabled = false;
            this.txtResult.Location = new System.Drawing.Point(322, 115);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(107, 22);
            this.txtResult.TabIndex = 10;
            // 
            // txtVal2
            // 
            this.txtVal2.Location = new System.Drawing.Point(322, 76);
            this.txtVal2.Name = "txtVal2";
            this.txtVal2.Size = new System.Drawing.Size(107, 22);
            this.txtVal2.TabIndex = 9;
            // 
            // txtVal1
            // 
            this.txtVal1.Location = new System.Drawing.Point(322, 21);
            this.txtVal1.Name = "txtVal1";
            this.txtVal1.Size = new System.Drawing.Size(107, 22);
            this.txtVal1.TabIndex = 8;
            // 
            // operazioni
            // 
            this.operazioni.Controls.Add(this.rdbMul);
            this.operazioni.Controls.Add(this.rdbSum);
            this.operazioni.Controls.Add(this.rdbDiv);
            this.operazioni.Controls.Add(this.rdbSub);
            this.operazioni.Location = new System.Drawing.Point(19, 21);
            this.operazioni.Name = "operazioni";
            this.operazioni.Size = new System.Drawing.Size(200, 175);
            this.operazioni.TabIndex = 7;
            this.operazioni.TabStop = false;
            this.operazioni.Text = "operazioni";
            // 
            // rdbMul
            // 
            this.rdbMul.AutoSize = true;
            this.rdbMul.Location = new System.Drawing.Point(6, 94);
            this.rdbMul.Name = "rdbMul";
            this.rdbMul.Size = new System.Drawing.Size(34, 21);
            this.rdbMul.TabIndex = 2;
            this.rdbMul.TabStop = true;
            this.rdbMul.Text = "*";
            this.rdbMul.UseVisualStyleBackColor = true;
            this.rdbMul.Click += new System.EventHandler(this.ChooseOperation);
            // 
            // rdbSum
            // 
            this.rdbSum.AutoSize = true;
            this.rdbSum.Location = new System.Drawing.Point(6, 37);
            this.rdbSum.Name = "rdbSum";
            this.rdbSum.Size = new System.Drawing.Size(37, 21);
            this.rdbSum.TabIndex = 0;
            this.rdbSum.TabStop = true;
            this.rdbSum.Text = "+";
            this.rdbSum.UseVisualStyleBackColor = true;
            this.rdbSum.Click += new System.EventHandler(this.ChooseOperation);
            // 
            // rdbDiv
            // 
            this.rdbDiv.AutoSize = true;
            this.rdbDiv.Location = new System.Drawing.Point(6, 115);
            this.rdbDiv.Name = "rdbDiv";
            this.rdbDiv.Size = new System.Drawing.Size(33, 21);
            this.rdbDiv.TabIndex = 3;
            this.rdbDiv.TabStop = true;
            this.rdbDiv.Text = "/";
            this.rdbDiv.UseVisualStyleBackColor = true;
            this.rdbDiv.Click += new System.EventHandler(this.ChooseOperation);
            // 
            // rdbSub
            // 
            this.rdbSub.AutoSize = true;
            this.rdbSub.Location = new System.Drawing.Point(6, 64);
            this.rdbSub.Name = "rdbSub";
            this.rdbSub.Size = new System.Drawing.Size(34, 21);
            this.rdbSub.TabIndex = 1;
            this.rdbSub.TabStop = true;
            this.rdbSub.Text = "-";
            this.rdbSub.UseVisualStyleBackColor = true;
            this.rdbSub.Click += new System.EventHandler(this.ChooseOperation);
            // 
            // execute
            // 
            this.execute.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.execute.Location = new System.Drawing.Point(510, 8);
            this.execute.Name = "execute";
            this.execute.Size = new System.Drawing.Size(237, 175);
            this.execute.TabIndex = 6;
            this.execute.Text = "Calcola";
            this.execute.UseVisualStyleBackColor = false;
            this.execute.Click += new System.EventHandler(this.executeCalc);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "rec";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.operazioni.ResumeLayout(false);
            this.operazioni.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbMul;
        private System.Windows.Forms.RadioButton rdbSub;
        private System.Windows.Forms.RadioButton rdbSum;
        private System.Windows.Forms.RadioButton rdbDiv;
        private System.Windows.Forms.Button execute;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox txtVal2;
        private System.Windows.Forms.TextBox txtVal1;
        private System.Windows.Forms.GroupBox operazioni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

