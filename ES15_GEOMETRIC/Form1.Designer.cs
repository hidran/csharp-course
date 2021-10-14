
namespace ES15_GEOMETRIC
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
            this.lsbShapes = new System.Windows.Forms.ListBox();
            this.btnRect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsbShapes
            // 
            this.lsbShapes.FormattingEnabled = true;
            this.lsbShapes.ItemHeight = 16;
            this.lsbShapes.Location = new System.Drawing.Point(12, 235);
            this.lsbShapes.Name = "lsbShapes";
            this.lsbShapes.Size = new System.Drawing.Size(776, 84);
            this.lsbShapes.TabIndex = 0;
            // 
            // btnRect
            // 
            this.btnRect.Location = new System.Drawing.Point(130, 44);
            this.btnRect.Name = "btnRect";
            this.btnRect.Size = new System.Drawing.Size(199, 67);
            this.btnRect.TabIndex = 1;
            this.btnRect.Text = "Rectangle";
            this.btnRect.UseVisualStyleBackColor = true;
            this.btnRect.Click += new System.EventHandler(this.btnRect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRect);
            this.Controls.Add(this.lsbShapes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lsbShapes;
        private System.Windows.Forms.Button btnRect;
    }
}

