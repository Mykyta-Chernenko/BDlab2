using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salary
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "salaryDataSet1.Employee". При необходимости она может быть перемещена или удалена.
            this.employeeTableAdapter.Fill(this.salaryDataSet1.Employee);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "salaryDataSet1.Payoff". При необходимости она может быть перемещена или удалена.
            this.payoffTableAdapter.Fill(this.salaryDataSet1.Payoff);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "salaryDataSet1.Payoff". При необходимости она может быть перемещена или удалена.
            this.payoffTableAdapter.Fill(this.salaryDataSet1.Payoff);
            dataGridView1.AutoGenerateColumns = true;

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            employeeTableAdapter.Update(salaryDataSet1);
            payoffTableAdapter.Update(salaryDataSet1);
        }

        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = employeeBindingSource;
            dataGridView1.DataSource = employeeBindingSource;
            label.Text = "Employees";
        }

        private void payoffsToolStripMenuItem_Click(object sender, EventArgs e)
        {       
            bindingNavigator1.BindingSource = payoffBindingSource;
            dataGridView1.DataSource = payoffBindingSource;
            label.Text = "Payoffs";
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void salaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var salary = new AddSalaryForm();
            salary.ShowDialog();
            employeeTableAdapter.Fill(salaryDataSet1.Employee);
            payoffTableAdapter.Fill(salaryDataSet1.Payoff);
        }
    }
}
