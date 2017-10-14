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
    public partial class AddSalaryForm : Form
    {
        public AddSalaryForm()
        {
            InitializeComponent();
        }

        private void payoffBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.payoffBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.salaryDataSet1);

        }

        private void AddSalaryForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "salaryDataSet1.Payoff". При необходимости она может быть перемещена или удалена.
            this.payoffTableAdapter.Fill(this.salaryDataSet1.Payoff);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "salaryDataSet1.Employee". При необходимости она может быть перемещена или удалена.
            this.employeeTableAdapter.Fill(this.salaryDataSet1.Employee);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "salaryDataSet1.Employee". При необходимости она может быть перемещена или удалена.
            this.employeeTableAdapter.Fill(this.salaryDataSet1.Employee);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "salaryDataSet1.Employee". При необходимости она может быть перемещена или удалена.
            this.employeeTableAdapter.Fill(this.salaryDataSet1.Employee);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "salaryDataSet1.Payoff". При необходимости она может быть перемещена или удалена.
            this.payoffTableAdapter.Fill(this.salaryDataSet1.Payoff);

        }

        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.salaryDataSet1);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите подтвердить изменения?", "Изменение дан ных", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                payoffBindingSource.EndEdit();
                payoffTableAdapter.Update(salaryDataSet1);
                employeeTableAdapter.Update(salaryDataSet1);
            }

        }
    }
}
