using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employ
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
			AddEmployee addEmployee = new AddEmployee
			{
				MdiParent = this,
				Parent = TabManager.TabPages[0]
			};
			addEmployee.Show();
            EmployeesData employeesData = new EmployeesData
            {
                MdiParent = this,
                Parent = TabManager.TabPages[1]
            };
            employeesData.Show();
            Start start = new Start
            {
                MdiParent = this,
                Parent = TabManager.TabPages[2]
            };
            start.Show();
            TabManager.SelectedIndex = 2;
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
			this.WindowState = FormWindowState.Minimized;
        }

        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            TabManager.SelectedIndex = 0;
        }

        private void EmployeesDataButton_Click(object sender, EventArgs e)
        {
            TabManager.SelectedIndex = 1;
        }
    }
}
