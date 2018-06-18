using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WithBangarRaju
{
    public partial class Form2 : Form
    {
        CompanyDBDataContext dc;
        List<Emp> Employees;
        int rowno = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dc = new CompanyDBDataContext();
            Employees = dc.Emps.ToList();
            ShowData();
             
        }
        private void ShowData()
        {
            EnoBox.Text = Employees[rowno].Empno.ToString();
            EnameBox.Text = Employees[rowno].Ename.ToString();
            SalaryBox.Text = Employees[rowno].Job.ToString();
            SalaryBox.Text = Employees[rowno].Sal.ToString();
            DepartmentBox.Text = Employees[rowno].Deptno.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rowno > 0)
            {

                rowno -= 1;
                ShowData();
            }
            else
                MessageBox.Show("First record of the table");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (rowno < Employees.Count - 1)
            {

                rowno += 1;
                ShowData();
            }
            else
                MessageBox.Show("Last record of the data");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
