using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Show_Click(object sender, EventArgs e)
        {
            string firstName = firstnameText.Text;
            string secondName = secondNameText.Text;
            string fullname = firstName + " " + secondName;

            fullnametext.Text = fullname;
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void nameText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
