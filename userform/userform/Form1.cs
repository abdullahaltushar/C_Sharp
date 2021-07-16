using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace userform
{
    public partial class Form1 : Form
    {
        persion apersion = new persion();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void savebtn_Click(object sender, EventArgs e)
        {
           
            apersion.fatherName = fathertext.Text;
            apersion.motherName = mothertext.Text;
            apersion.firstName = firsttext.Text;
            apersion.lastName = lasttext.Text;
            apersion.Address = Addresstext.Text;

            MessageBox.Show("your data upload succesfully");
            Clear();

            
        }

        private void Clear()
        {
            fathertext.Clear();
            mothertext.Clear();
            firsttext.Clear();
            lasttext.Clear();
            Addresstext.Clear();
        }

        private void namebtn_Click(object sender, EventArgs e)
        {
            Clear();
            firsttext.Text = apersion.firstName;
            lasttext.Text = apersion.lastName;
        }

        private void prasent_nameBtn_Click(object sender, EventArgs e)
        {
            Clear();
            fathertext.Text = apersion.fatherName;
            mothertext.Text = apersion.motherName;
        }

        private void Addressbtn_Click(object sender, EventArgs e)
        {
            Clear();
            Addresstext.Text = apersion.Address;
        }

        private void saveallbtn_Click(object sender, EventArgs e)
        {
            Clear();
            firsttext.Text = apersion.firstName;
            lasttext.Text = apersion.lastName;
            fathertext.Text = apersion.fatherName;
            mothertext.Text = apersion.motherName;
            Addresstext.Text = apersion.Address;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
