
namespace ES04_LIST_FOREACH
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
            this.lbxCities = new System.Windows.Forms.ListBox();
            this.lbxSelectedCities = new System.Windows.Forms.ListBox();
            this.btnAddRightLeft = new System.Windows.Forms.Button();
            this.btnAddAllRight = new System.Windows.Forms.Button();
            this.btnAddLeft = new System.Windows.Forms.Button();
            this.btnAddRight = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxCities
            // 
            this.lbxCities.FormattingEnabled = true;
            this.lbxCities.ItemHeight = 16;
            this.lbxCities.Location = new System.Drawing.Point(25, 21);
            this.lbxCities.Name = "lbxCities";
            this.lbxCities.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbxCities.Size = new System.Drawing.Size(284, 196);
            this.lbxCities.TabIndex = 0;
            // 
            // lbxSelectedCities
            // 
            this.lbxSelectedCities.FormattingEnabled = true;
            this.lbxSelectedCities.ItemHeight = 16;
            this.lbxSelectedCities.Location = new System.Drawing.Point(439, 21);
            this.lbxSelectedCities.Name = "lbxSelectedCities";
            this.lbxSelectedCities.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbxSelectedCities.Size = new System.Drawing.Size(316, 196);
            this.lbxSelectedCities.TabIndex = 1;
            // 
            // btnAddRightLeft
            // 
            this.btnAddRightLeft.Location = new System.Drawing.Point(315, 76);
            this.btnAddRightLeft.Name = "btnAddRightLeft";
            this.btnAddRightLeft.Size = new System.Drawing.Size(108, 55);
            this.btnAddRightLeft.TabIndex = 2;
            this.btnAddRightLeft.Text = "<";
            this.btnAddRightLeft.UseVisualStyleBackColor = true;
            this.btnAddRightLeft.Click += new System.EventHandler(this.AddLeft_Click);
            // 
            // btnAddAllRight
            // 
            this.btnAddAllRight.Location = new System.Drawing.Point(315, 137);
            this.btnAddAllRight.Name = "btnAddAllRight";
            this.btnAddAllRight.Size = new System.Drawing.Size(108, 55);
            this.btnAddAllRight.TabIndex = 3;
            this.btnAddAllRight.Text = ">>";
            this.btnAddAllRight.UseVisualStyleBackColor = true;
            this.btnAddAllRight.Click += new System.EventHandler(this.AddAllRight_Click);
            // 
            // btnAddLeft
            // 
            this.btnAddLeft.Location = new System.Drawing.Point(315, 183);
            this.btnAddLeft.Name = "btnAddLeft";
            this.btnAddLeft.Size = new System.Drawing.Size(108, 55);
            this.btnAddLeft.TabIndex = 4;
            this.btnAddLeft.Text = "<<";
            this.btnAddLeft.UseVisualStyleBackColor = true;
            this.btnAddLeft.Click += new System.EventHandler(this.btnAddAllLeft_Click);
            // 
            // btnAddRight
            // 
            this.btnAddRight.Location = new System.Drawing.Point(315, 21);
            this.btnAddRight.Name = "btnAddRight";
            this.btnAddRight.Size = new System.Drawing.Size(108, 55);
            this.btnAddRight.TabIndex = 5;
            this.btnAddRight.Text = ">";
            this.btnAddRight.UseVisualStyleBackColor = true;
            this.btnAddRight.Click += new System.EventHandler(this.addRight_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddRight);
            this.Controls.Add(this.btnAddLeft);
            this.Controls.Add(this.btnAddAllRight);
            this.Controls.Add(this.btnAddRightLeft);
            this.Controls.Add(this.lbxSelectedCities);
            this.Controls.Add(this.lbxCities);
            this.Name = "Form1";
            this.Text = "ListForm";
            this.Load += new System.EventHandler(this.LoadList);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxCities;
        private System.Windows.Forms.ListBox lbxSelectedCities;
        private System.Windows.Forms.Button btnAddRightLeft;
        private System.Windows.Forms.Button btnAddAllRight;
        private System.Windows.Forms.Button btnAddLeft;
        private System.Windows.Forms.Button btnAddRight;
    }
}

