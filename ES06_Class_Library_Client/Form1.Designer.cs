
namespace ES06_Class_Library_Client
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
            this.CreatePerson = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.dtgPersons = new System.Windows.Forms.DataGridView();
            this.LoadEmployee = new System.Windows.Forms.Button();
            this.orderBySalary = new System.Windows.Forms.Button();
            this.txtYear = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPersons)).BeginInit();
            this.SuspendLayout();
            // 
            // CreatePerson
            // 
            this.CreatePerson.Location = new System.Drawing.Point(289, 26);
            this.CreatePerson.Name = "CreatePerson";
            this.CreatePerson.Size = new System.Drawing.Size(616, 70);
            this.CreatePerson.TabIndex = 0;
            this.CreatePerson.Text = "Create person";
            this.CreatePerson.UseVisualStyleBackColor = true;
            this.CreatePerson.Click += new System.EventHandler(this.CreatePerson_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(163, 141);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(502, 22);
            this.txtOutput.TabIndex = 1;
            // 
            // dtgPersons
            // 
            this.dtgPersons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPersons.Location = new System.Drawing.Point(0, 191);
            this.dtgPersons.Name = "dtgPersons";
            this.dtgPersons.RowHeadersWidth = 51;
            this.dtgPersons.RowTemplate.Height = 24;
            this.dtgPersons.Size = new System.Drawing.Size(1174, 203);
            this.dtgPersons.TabIndex = 2;
            // 
            // LoadEmployee
            // 
            this.LoadEmployee.Location = new System.Drawing.Point(289, 418);
            this.LoadEmployee.Name = "LoadEmployee";
            this.LoadEmployee.Size = new System.Drawing.Size(256, 74);
            this.LoadEmployee.TabIndex = 3;
            this.LoadEmployee.Text = "Filter by year";
            this.LoadEmployee.UseVisualStyleBackColor = true;
            this.LoadEmployee.Click += new System.EventHandler(this.FilterByYear_click);
            // 
            // orderBySalary
            // 
            this.orderBySalary.Location = new System.Drawing.Point(607, 418);
            this.orderBySalary.Name = "orderBySalary";
            this.orderBySalary.Size = new System.Drawing.Size(215, 74);
            this.orderBySalary.TabIndex = 4;
            this.orderBySalary.Text = "Order by Salary";
            this.orderBySalary.UseVisualStyleBackColor = true;
            this.orderBySalary.Click += new System.EventHandler(this.OrderBySalary_Click);
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(116, 444);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(147, 22);
            this.txtYear.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 544);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.orderBySalary);
            this.Controls.Add(this.LoadEmployee);
            this.Controls.Add(this.dtgPersons);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.CreatePerson);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPersons)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreatePerson;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.DataGridView dtgPersons;
        private System.Windows.Forms.Button LoadEmployee;
        private System.Windows.Forms.Button orderBySalary;
        private System.Windows.Forms.TextBox txtYear;
    }
}

