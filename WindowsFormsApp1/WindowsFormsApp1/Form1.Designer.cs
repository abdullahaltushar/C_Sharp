
namespace WindowsFormsApp1
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
            this.Show = new System.Windows.Forms.Button();
            this.firstnameText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.secondNameText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fullnametext = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Show
            // 
            this.Show.Location = new System.Drawing.Point(366, 131);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(130, 30);
            this.Show.TabIndex = 2;
            this.Show.Text = "Show";
            this.Show.UseVisualStyleBackColor = false;
            this.Show.Click += new System.EventHandler(this.Show_Click);
            // 
            // firstnameText
            // 
            this.firstnameText.Location = new System.Drawing.Point(179, 46);
            this.firstnameText.Name = "firstnameText";
            this.firstnameText.Size = new System.Drawing.Size(317, 20);
            this.firstnameText.TabIndex = 0;
            this.firstnameText.TextChanged += new System.EventHandler(this.nameText_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "first Name";
            // 
            // secondNameText
            // 
            this.secondNameText.Location = new System.Drawing.Point(179, 88);
            this.secondNameText.Name = "secondNameText";
            this.secondNameText.Size = new System.Drawing.Size(317, 20);
            this.secondNameText.TabIndex = 1;
            this.secondNameText.TextChanged += new System.EventHandler(this.nameText_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "second Name";
            // 
            // fullnametext
            // 
            this.fullnametext.Location = new System.Drawing.Point(179, 180);
            this.fullnametext.Name = "fullnametext";
            this.fullnametext.Size = new System.Drawing.Size(317, 20);
            this.fullnametext.TabIndex = 3;
            this.fullnametext.TextChanged += new System.EventHandler(this.nameText_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "full name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fullnametext);
            this.Controls.Add(this.secondNameText);
            this.Controls.Add(this.firstnameText);
            this.Controls.Add(this.Show);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show hello word";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Show;
        private System.Windows.Forms.TextBox firstnameText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox secondNameText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fullnametext;
        private System.Windows.Forms.Label label4;
    }
}

