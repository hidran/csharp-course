namespace ES_03_Alignment
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.csharp = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbLeft = new System.Windows.Forms.RadioButton();
            this.rdbMiddle = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // csharp
            // 
            this.csharp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.csharp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.csharp.Font = new System.Drawing.Font("Microsoft Sans Serif", 46F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.csharp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.csharp.Location = new System.Drawing.Point(3, 12);
            this.csharp.Name = "csharp";
            this.csharp.Size = new System.Drawing.Size(1308, 112);
            this.csharp.TabIndex = 0;
            this.csharp.Text = "C#";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.rdbMiddle);
            this.groupBox1.Controls.Add(this.rdbLeft);
            this.groupBox1.Location = new System.Drawing.Point(36, 245);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1275, 127);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ALIGNMENT";
            // 
            // rdbLeft
            // 
            this.rdbLeft.AutoSize = true;
            this.rdbLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbLeft.Location = new System.Drawing.Point(169, 65);
            this.rdbLeft.Name = "rdbLeft";
            this.rdbLeft.Size = new System.Drawing.Size(57, 21);
            this.rdbLeft.TabIndex = 0;
            this.rdbLeft.TabStop = true;
            this.rdbLeft.Text = "Left";
            this.rdbLeft.UseVisualStyleBackColor = true;
            this.rdbLeft.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            this.rdbLeft.Click += new System.EventHandler(this.SetAlignment);
            // 
            // rdbMiddle
            // 
            this.rdbMiddle.AutoSize = true;
            this.rdbMiddle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMiddle.Location = new System.Drawing.Point(620, 65);
            this.rdbMiddle.Name = "rdbMiddle";
            this.rdbMiddle.Size = new System.Drawing.Size(76, 21);
            this.rdbMiddle.TabIndex = 1;
            this.rdbMiddle.TabStop = true;
            this.rdbMiddle.Text = "Middle";
            this.rdbMiddle.UseVisualStyleBackColor = true;
            this.rdbMiddle.CheckedChanged += new System.EventHandler(this.rdbMiddle_CheckedChanged);
            this.rdbMiddle.Click += new System.EventHandler(this.SetAlignment);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(1022, 65);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(67, 21);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Right";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            this.radioButton3.Click += new System.EventHandler(this.SetAlignment);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.csharp);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1342, 610);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label csharp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton rdbMiddle;
        private System.Windows.Forms.RadioButton rdbLeft;
    }
}
