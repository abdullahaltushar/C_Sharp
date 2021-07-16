
namespace EmployeeInformation
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
            this.firstNametext = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SecondNametext = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LastNametext = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Savebutton = new System.Windows.Forms.Button();
            this.employeelistView = new System.Windows.Forms.ListView();
            this.fullName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.showBtn = new System.Windows.Forms.Button();
            this.firstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MiddleName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // firstNametext
            // 
            this.firstNametext.Location = new System.Drawing.Point(428, 55);
            this.firstNametext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.firstNametext.Name = "firstNametext";
            this.firstNametext.Size = new System.Drawing.Size(262, 26);
            this.firstNametext.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name :";
            // 
            // SecondNametext
            // 
            this.SecondNametext.Location = new System.Drawing.Point(428, 123);
            this.SecondNametext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SecondNametext.Name = "SecondNametext";
            this.SecondNametext.Size = new System.Drawing.Size(262, 26);
            this.SecondNametext.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Middle Name : ";
            // 
            // LastNametext
            // 
            this.LastNametext.Location = new System.Drawing.Point(428, 188);
            this.LastNametext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LastNametext.Name = "LastNametext";
            this.LastNametext.Size = new System.Drawing.Size(262, 26);
            this.LastNametext.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 197);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Last Name : ";
            // 
            // Savebutton
            // 
            this.Savebutton.Location = new System.Drawing.Point(288, 277);
            this.Savebutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(228, 35);
            this.Savebutton.TabIndex = 3;
            this.Savebutton.Text = "Save Information ";
            this.Savebutton.UseVisualStyleBackColor = true;
            this.Savebutton.Click += new System.EventHandler(this.Savebutton_Click);
            // 
            // employeelistView
            // 
            this.employeelistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.firstName,
            this.MiddleName,
            this.lastName,
            this.fullName});
            this.employeelistView.HideSelection = false;
            this.employeelistView.Location = new System.Drawing.Point(143, 322);
            this.employeelistView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.employeelistView.Name = "employeelistView";
            this.employeelistView.Size = new System.Drawing.Size(730, 191);
            this.employeelistView.TabIndex = 4;
            this.employeelistView.UseCompatibleStateImageBehavior = false;
            this.employeelistView.View = System.Windows.Forms.View.Details;
            // 
            // fullName
            // 
            this.fullName.DisplayIndex = 3;
            this.fullName.Text = "full Name";
            this.fullName.Width = 262;
            // 
            // showBtn
            // 
            this.showBtn.Location = new System.Drawing.Point(523, 277);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(179, 35);
            this.showBtn.TabIndex = 5;
            this.showBtn.Text = "Show";
            this.showBtn.UseVisualStyleBackColor = true;
            this.showBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // firstName
            // 
            this.firstName.DisplayIndex = 0;
            this.firstName.Text = "First Name";
            this.firstName.Width = 149;
            // 
            // MiddleName
            // 
            this.MiddleName.DisplayIndex = 1;
            this.MiddleName.Text = "Middle Name";
            this.MiddleName.Width = 161;
            // 
            // lastName
            // 
            this.lastName.DisplayIndex = 2;
            this.lastName.Text = "Last Name";
            this.lastName.Width = 163;
            // 
            // Form1
            // 
            this.AcceptButton = this.Savebutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.showBtn);
            this.Controls.Add(this.employeelistView);
            this.Controls.Add(this.Savebutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LastNametext);
            this.Controls.Add(this.SecondNametext);
            this.Controls.Add(this.firstNametext);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstNametext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SecondNametext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LastNametext;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Savebutton;
        private System.Windows.Forms.ListView employeelistView;
        private System.Windows.Forms.ColumnHeader fullName;
        private System.Windows.Forms.Button showBtn;
        private System.Windows.Forms.ColumnHeader firstName;
        private System.Windows.Forms.ColumnHeader MiddleName;
        private System.Windows.Forms.ColumnHeader lastName;
    }
}

