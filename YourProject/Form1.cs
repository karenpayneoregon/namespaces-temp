using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using CakeEaterLibrary.LanguageExtensions;
using YourProject.Classes;

using cake = CakeEaterLibrary;
using DataTable = System.Data.DataTable;

namespace YourProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Classes.DataTable table1 = new Classes.DataTable();
            table1.GetNameClass();

            cake.Classes.DataTable table2 = new cake.Classes.DataTable();
            table2.GetNameClass();

            DataTable table3 = new DataTable();
            table3.Columns.Add(new DataColumn("Id", typeof(int)));
        }

        private void EmployeeWhereNotButton_Click(object sender, EventArgs e)
        {
            var employeesList = Mocked.EmployeesList1.WhereNot(emp => emp.Id == null).ToList();

            foreach (var employee in employeesList)
            {
                Debug.WriteLine($"{employee.Id:D3} {employee.LastName}");

            }

            Debug.WriteLine("");
        }

        private void EmployeeWhereButton_Click(object sender, EventArgs e)
        {
            var employeesList = Mocked.EmployeesList1.Where(emp => emp.Id != null).ToList();

            foreach (var employee in employeesList)
            {
                Debug.WriteLine($"{employee.Id:D3} {employee.LastName}");

            }

            Debug.WriteLine("");
        }

        private void WhiteSpaceExtensionButton_Click(object sender, EventArgs e)
        {
            var employeesList = Mocked.EmployeesList1;

            for (int index = 0; index < employeesList.Count; index++)
            {
                if (index.IsEven())
                {
                    employeesList[index].FirstName = "";
                }
            }

            var emptyFirstName = employeesList.WhereNot(emp => string.IsNullOrWhiteSpace(emp.FirstName));

            foreach (var employee in emptyFirstName)
            {
                Debug.WriteLine($"{employee.LastName}");
            }

            Debug.WriteLine("");

        }

        private void WhiteSpaceButton_Click(object sender, EventArgs e)
        {
            var employeesList = Mocked.EmployeesList1;

            for (int index = 0; index < employeesList.Count; index++)
            {
                if (index.IsEven())
                {
                    employeesList[index].FirstName = "";
                }
            }

            var emptyFirstName = employeesList.Where(emp => !string.IsNullOrWhiteSpace(emp.FirstName));

            foreach (var employee in emptyFirstName)
            {
                Debug.WriteLine($"{employee.LastName}");
            }

            Debug.WriteLine("");

        }

        private void AllButton_Click(object sender, EventArgs e)
        {
            var employeesList = Mocked.EmployeesList1;

            var test1 = employeesList.All(emp => emp.Id is not null);
            Debug.WriteLine($"test 1: {test1}");

            var test2 = employeesList.NotAll(emp => emp.Id is null);
            Debug.WriteLine($"test 2: {test2}");
        }
    }
}
