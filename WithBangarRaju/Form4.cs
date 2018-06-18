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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CompanyDBDataContext dc = new CompanyDBDataContext();
            Emp obj = new Emp();
            obj.Empno = int.Parse(EnoBox.Text);
            obj.Ename = EnameBox.Text;
            obj.Job = JobBox.Text;
            obj.Sal = decimal.Parse(Salary.Text);
            obj.Ename = EnameBox.Text;
            dc.Emps .InsertAllOnSubmit(obj);
           
        }
    }
}
