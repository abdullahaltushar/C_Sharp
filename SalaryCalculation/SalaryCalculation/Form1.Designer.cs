
namespace SalaryCalculation
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
            this.BasicSalarytext = new System.Windows.Forms.TextBox();
            this.hoursrenttext = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.medicalallancetext = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Totaltext = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.calculateTotalBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BasicSalarytext
            // 
            this.BasicSalarytext.Location = new System.Drawing.Point(193, 33);
            this.BasicSalarytext.Margin = new System.Windows.Forms.Padding(2);
            this.BasicSalarytext.Name = "BasicSalarytext";
            this.BasicSalarytext.Size = new System.Drawing.Size(180, 20);
            this.BasicSalarytext.TabIndex = 0;
            // 
            // hoursrenttext
            // 
            this.hoursrenttext.Location = new System.Drawing.Point(193, 75);
            this.hoursrenttext.Margin = new System.Windows.Forms.Padding(2);
            this.hoursrenttext.Name = "hoursrenttext";
            this.hoursrenttext.Size = new System.Drawing.Size(180, 20);
            this.hoursrenttext.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hours Rent :";
            // 
            // medicalallancetext
            // 
            this.medicalallancetext.Location = new System.Drawing.Point(193, 120);
            this.medicalallancetext.Margin = new System.Windows.Forms.Padding(2);
            this.medicalallancetext.Name = "medicalallancetext";
            this.medicalallancetext.Size = new System.Drawing.Size(180, 20);
            this.medicalallancetext.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Medical Allowance";
            // 
            // Totaltext
            // 
            this.Totaltext.Location = new System.Drawing.Point(193, 224);
            this.Totaltext.Margin = new System.Windows.Forms.Padding(2);
            this.Totaltext.Name = "Totaltext";
            this.Totaltext.Size = new System.Drawing.Size(180, 20);
            this.Totaltext.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 231);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Total Salary ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(399, 123);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "% of Bacis";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(399, 75);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "label1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(399, 75);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "% of Bacis";
            // 
            // calculateTotalBtn
            // 
            this.calculateTotalBtn.Location = new System.Drawing.Point(193, 154);
            this.calculateTotalBtn.Margin = new System.Windows.Forms.Padding(2);
            this.calculateTotalBtn.Name = "calculateTotalBtn";
            this.calculateTotalBtn.Size = new System.Drawing.Size(179, 24);
            this.calculateTotalBtn.TabIndex = 3;
            this.calculateTotalBtn.Text = "Calculate Total salary";
            this.calculateTotalBtn.UseVisualStyleBackColor = true;
            this.calculateTotalBtn.Click += new System.EventHandler(this.calculateTotalBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Basic Salary :";
            // 
            // Form1
            // 
            this.AcceptButton = this.calculateTotalBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.calculateTotalBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Totaltext);
            this.Controls.Add(this.medicalallancetext);
            this.Controls.Add(this.hoursrenttext);
            this.Controls.Add(this.BasicSalarytext);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salary Calculation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BasicSalarytext;
        private System.Windows.Forms.TextBox hoursrenttext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox medicalallancetext;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Totaltext;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button calculateTotalBtn;
        private System.Windows.Forms.Label label1;
    }
}

