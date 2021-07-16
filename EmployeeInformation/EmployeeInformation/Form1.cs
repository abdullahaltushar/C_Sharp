using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeInformation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<employee> employees = new List<employee>();

        private void Savebutton_Click(object sender, EventArgs e)
        {
            employee employee = new employee();
            employee.firstName = firstNametext.Text;
            employee.middleName = SecondNametext.Text;
            employee.LastName = LastNametext.Text;
            employees.Add(employee);

            MessageBox.Show("imformation save succesful");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            employeelistView.Items.Clear();
            foreach (employee employee in employees)
            {

                ListViewItem item = new ListViewItem();
                item.Text = employee.firstName;
                item.SubItems.Add(employee.middleName);
                item.SubItems.Add(employee.LastName);
                item.SubItems.Add(employee.GetFullName());

                employeelistView.Items.Add(item);


            }
        }
    }
}
