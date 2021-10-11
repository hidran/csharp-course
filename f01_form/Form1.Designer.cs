
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.value1 = new System.Windows.Forms.TextBox();
            this.value2 = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.calculate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.execute = new System.Windows.Forms.Button();
            this.rdbDiv = new System.Windows.Forms.RadioButton();
            this.rdbMul = new System.Windows.Forms.RadioButton();
            this.rdbSub = new System.Windows.Forms.RadioButton();
            this.rdbSum = new System.Windows.Forms.RadioButton();
            this.operazioni = new System.Windows.Forms.GroupBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.txtVal2 = new System.Windows.Forms.TextBox();
            this.txtVal1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.operazioni.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 60);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.sayHi);
            this.button1.MouseEnter += new System.EventHandler(this.changeColor);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 78);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(192, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // value1
            // 
            this.value1.Location = new System.Drawing.Point(210, 12);
            this.value1.Name = "value1";
            this.value1.Size = new System.Drawing.Size(335, 22);
            this.value1.TabIndex = 2;
            this.value1.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // value2
            // 
            this.value2.Location = new System.Drawing.Point(210, 50);
            this.value2.Name = "value2";
            this.value2.Size = new System.Drawing.Size(335, 22);
            this.value2.TabIndex = 3;
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(210, 78);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(335, 22);
            this.result.TabIndex = 4;
            // 
            // calculate
            // 
            this.calculate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.calculate.Location = new System.Drawing.Point(571, 12);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(192, 60);
            this.calculate.TabIndex = 5;
            this.calculate.Text = "Calcola";
            this.calculate.UseVisualStyleBackColor = false;
            this.calculate.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtResult);
            this.groupBox1.Controls.Add(this.txtVal2);
            this.groupBox1.Controls.Add(this.txtVal1);
            this.groupBox1.Controls.Add(this.operazioni);
            this.groupBox1.Controls.Add(this.execute);
            this.groupBox1.Location = new System.Drawing.Point(95, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(678, 241);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OPERAZIONI";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // execute
            // 
            this.execute.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.execute.Location = new System.Drawing.Point(356, 21);
            this.execute.Name = "execute";
            this.execute.Size = new System.Drawing.Size(237, 115);
            this.execute.TabIndex = 6;
            this.execute.Text = "Calcola";
            this.execute.UseVisualStyleBackColor = false;
            this.execute.Click += new System.EventHandler(this.executeCalc);
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
            // txtResult
            // 
            this.txtResult.Enabled = false;
            this.txtResult.Location = new System.Drawing.Point(225, 104);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(107, 22);
            this.txtResult.TabIndex = 10;
            // 
            // txtVal2
            // 
            this.txtVal2.Location = new System.Drawing.Point(225, 76);
            this.txtVal2.Name = "txtVal2";
            this.txtVal2.Size = new System.Drawing.Size(107, 22);
            this.txtVal2.TabIndex = 9;
            // 
            // txtVal1
            // 
            this.txtVal1.Location = new System.Drawing.Point(225, 48);
            this.txtVal1.Name = "txtVal1";
            this.txtVal1.Size = new System.Drawing.Size(107, 22);
            this.txtVal1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.result);
            this.Controls.Add(this.value2);
            this.Controls.Add(this.value1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "rec";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.operazioni.ResumeLayout(false);
            this.operazioni.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox value1;
        private System.Windows.Forms.TextBox value2;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Button calculate;
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
    }
}

