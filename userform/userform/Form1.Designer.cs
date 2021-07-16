
namespace userform
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
            this.firsttext = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lasttext = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mothertext = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fathertext = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Addresstext = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.Label();
            this.savebtn = new System.Windows.Forms.Button();
            this.saveallbtn = new System.Windows.Forms.Button();
            this.namebtn = new System.Windows.Forms.Button();
            this.prasent_nameBtn = new System.Windows.Forms.Button();
            this.Addressbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firsttext
            // 
            this.firsttext.Location = new System.Drawing.Point(235, 73);
            this.firsttext.Name = "firsttext";
            this.firsttext.Size = new System.Drawing.Size(327, 26);
            this.firsttext.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lasttext
            // 
            this.lasttext.Location = new System.Drawing.Point(235, 128);
            this.lasttext.Name = "lasttext";
            this.lasttext.Size = new System.Drawing.Size(327, 26);
            this.lasttext.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name :";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // mothertext
            // 
            this.mothertext.Location = new System.Drawing.Point(235, 181);
            this.mothertext.Name = "mothertext";
            this.mothertext.Size = new System.Drawing.Size(327, 26);
            this.mothertext.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mother\'s Name :";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // fathertext
            // 
            this.fathertext.Location = new System.Drawing.Point(235, 237);
            this.fathertext.Name = "fathertext";
            this.fathertext.Size = new System.Drawing.Size(327, 26);
            this.fathertext.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Father\'s Name :";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // Addresstext
            // 
            this.Addresstext.Location = new System.Drawing.Point(249, 294);
            this.Addresstext.Multiline = true;
            this.Addresstext.Name = "Addresstext";
            this.Addresstext.Size = new System.Drawing.Size(313, 101);
            this.Addresstext.TabIndex = 4;
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Location = new System.Drawing.Point(110, 330);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(80, 20);
            this.Address.TabIndex = 3;
            this.Address.Text = "Address : ";
            // 
            // savebtn
            // 
            this.savebtn.Location = new System.Drawing.Point(110, 412);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(150, 47);
            this.savebtn.TabIndex = 5;
            this.savebtn.Text = "Save";
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // saveallbtn
            // 
            this.saveallbtn.Location = new System.Drawing.Point(322, 412);
            this.saveallbtn.Name = "saveallbtn";
            this.saveallbtn.Size = new System.Drawing.Size(240, 47);
            this.saveallbtn.TabIndex = 6;
            this.saveallbtn.Text = "Save all Information";
            this.saveallbtn.UseVisualStyleBackColor = true;
            this.saveallbtn.Click += new System.EventHandler(this.saveallbtn_Click);
            // 
            // namebtn
            // 
            this.namebtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.namebtn.Location = new System.Drawing.Point(110, 490);
            this.namebtn.Name = "namebtn";
            this.namebtn.Size = new System.Drawing.Size(150, 47);
            this.namebtn.TabIndex = 7;
            this.namebtn.Text = "Name";
            this.namebtn.UseVisualStyleBackColor = true;
            this.namebtn.Click += new System.EventHandler(this.namebtn_Click);
            // 
            // prasent_nameBtn
            // 
            this.prasent_nameBtn.Location = new System.Drawing.Point(322, 490);
            this.prasent_nameBtn.Name = "prasent_nameBtn";
            this.prasent_nameBtn.Size = new System.Drawing.Size(212, 47);
            this.prasent_nameBtn.TabIndex = 8;
            this.prasent_nameBtn.Text = "Present\'s Name";
            this.prasent_nameBtn.UseVisualStyleBackColor = true;
            this.prasent_nameBtn.Click += new System.EventHandler(this.prasent_nameBtn_Click);
            // 
            // Addressbtn
            // 
            this.Addressbtn.Location = new System.Drawing.Point(568, 490);
            this.Addressbtn.Name = "Addressbtn";
            this.Addressbtn.Size = new System.Drawing.Size(150, 47);
            this.Addressbtn.TabIndex = 9;
            this.Addressbtn.Text = "Address";
            this.Addressbtn.UseVisualStyleBackColor = true;
            this.Addressbtn.Click += new System.EventHandler(this.Addressbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 549);
            this.Controls.Add(this.Addressbtn);
            this.Controls.Add(this.prasent_nameBtn);
            this.Controls.Add(this.namebtn);
            this.Controls.Add(this.saveallbtn);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.Addresstext);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fathertext);
            this.Controls.Add(this.mothertext);
            this.Controls.Add(this.lasttext);
            this.Controls.Add(this.firsttext);
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "personal Imformation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firsttext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lasttext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox mothertext;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fathertext;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Addresstext;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.Button saveallbtn;
        private System.Windows.Forms.Button namebtn;
        private System.Windows.Forms.Button prasent_nameBtn;
        private System.Windows.Forms.Button Addressbtn;
    }
}

