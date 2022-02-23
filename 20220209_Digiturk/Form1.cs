using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20220209_Digiturk
{
    public partial class Form1 : Form
    {
        List<Employee> employees = new List<Employee>();

        public Form1()
        {
            InitializeComponent();
            CreateEmployees();
            FillCombobox();
        }

        void CreateEmployees()
        {
            Employee employee1 = new Employee("Ali","Demir", 12345678900, new DateTime(1980, 10, 1), new DateTime(2015, 01, 15), Employee.Department.HR);
            employees.Add(employee1);

            Employee employee2 = new Employee("Ahmet","Çelik", 12345678900, new DateTime(1985, 11, 15), new DateTime(2019, 11, 05), Employee.Department.Sales);
            employee2.SalesMade = 23;
            employees.Add(employee2);

            Employee employee3 = new Employee("Mustafa","Aslan", 12345678900, new DateTime(1960, 7, 4), new DateTime(2000, 05, 23), Employee.Department.Sales);
            employee3.FiredDate = new DateTime(2022,02,09);
            employees.Add(employee3);

            Employee employee4 = new Employee("Ayşe", "Öztürk", 12345678900, new DateTime(1989, 12, 1), new DateTime(2019, 11, 05), Employee.Department.Accounting);
            employees.Add(employee4);

            Employee employee5 = new Employee("Mehmet","Demir", 12345678900, new DateTime(1985, 12, 1), new DateTime(2005, 01, 25), Employee.Department.Accounting);
            employees.Add(employee5);
        }

        void FillCombobox()
        {
            float total_salary=0;

            foreach(Employee employee in employees)
            {
                employees_combobox.Items.Add(employee.FirstName+" "+employee.LastName);
                total_salary += employee.GetTotalSalary();
            }

            total_salary_label.Text = total_salary.ToString();
        }

        private void employees_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChooseEmployee();
        }

        void ChooseEmployee()
        {
            Employee employee = employees[employees_combobox.SelectedIndex];
            info_listbox.Items.Clear();
            info_listbox.Items.Add(employee.IDNumber);
            info_listbox.Items.Add(employee.GetAge());
            info_listbox.Items.Add(employee.GetSeniority());
            info_listbox.Items.Add(employee.GetTotalSalary());
            info_listbox.Items.Add(employee.StillWorking);
            info_listbox.Items.Add(employee.Department_);
        }
    }
}
