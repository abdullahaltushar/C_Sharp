using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCalculation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateTotalBtn_Click(object sender, EventArgs e)
        {



            Salary salary = new Salary();
            salary.basicSalary = Convert.ToDouble(BasicSalarytext.Text);
            salary.houseRentPercentage = Convert.ToDouble(hoursrenttext.Text);
            salary.medicalAllownacePercentage= Convert.ToDouble(medicalallancetext.Text);

            double TotalSalary = salary.TotalCalculatesalary();
              Totaltext.Text = TotalSalary.ToString();

        }
    }
}
