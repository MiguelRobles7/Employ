using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Employ
{
    public partial class EmployeesData : Form
    {
        private string _order = "DESC";
        private int _previewCounter = 0;
        public EmployeesData()
        {
            InitializeComponent();
        }

        private void EmployeesData_Load(object sender, EventArgs e)
        {
            CreateTable("SELECT * FROM EmployeesData ORDER BY FamilyName DESC");
            PreviewMove();
        }

        private void PInfoBtn_Click(object sender, EventArgs e)
        {
            EmpDetHeader.Visible = EValuesFlowPanel.Visible = false;
            PreviewPanel.Visible = false;
        }

        private void EmpDetBtn_Click(object sender, EventArgs e)
        {
            EmpDetHeader.Visible = EValuesFlowPanel.Visible = true;
            PreviewPanel.Visible = false;
        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            string query = string.Empty;
            if (SearchComboBox.SelectedIndex == 1) query = string.Format("SELECT * FROM EmployeesData WHERE FamilyName LIKE '{0}%' ORDER BY FamilyName {1};", SearchTextBox.Text, _order);
            else query = string.Format("SELECT * FROM EmployeesData WHERE {0} LIKE '{1}%' ORDER BY {0} {2};", SearchComboBox.SelectedItem, SearchTextBox.Text, _order);
            CreateTable(query);
        }
        private void ResetBtn_Click(object sender, EventArgs e)
        {
            CreateTable("SELECT * FROM EmployeesData ORDER BY FamilyName DESC");
            SearchTextBox.Text = string.Empty;
            SearchComboBox.SelectedIndex = 0;
            _order = "DESC";
            OrderByButton.Image = Employ.Properties.Resources.down;
        }
        private void CreateTable(string query)
        {
            EValuesFlowPanel.Controls.Clear();
            PValuesFlowPanel.Controls.Clear();
            EmployeeDataGridView.Controls.Clear();
            string constring = "Data Source = (localdb)\\MSSQLLocalDB;Initial Catalog = Employ;Integrated Security = True;";
            SqlConnection con = new SqlConnection(constring);

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            using (DataTable dt = new DataTable())
            {
                sda.Fill(dt);
                EmployeeDataGridView.DataSource = dt;
            }
            string fullName = string.Empty;

            for (int i = 0; i < EmployeeDataGridView.RowCount; i++)
            {
                fullName = EmployeeDataGridView.Rows[i].Cells["FamilyName"].FormattedValue.ToString() + ", " +
                    EmployeeDataGridView.Rows[i].Cells["GivenName"].FormattedValue.ToString() + ", " +
                    EmployeeDataGridView.Rows[i].Cells["MiddleName"].FormattedValue.ToString();

                Panel p = new Panel
                {
                    Size = new Size(827, 2),
                    Dock = DockStyle.Top,
                    BackColor = Color.LightSlateGray
                };
                Panel t = new Panel
                {
                    Size = new Size(827, 2),
                    Dock = DockStyle.Top,
                    BackColor = Color.LightSlateGray
                };
                Entry newEntry = new Entry()
                {
                    name = fullName,
                    mobileNumber = EmployeeDataGridView.Rows[i].Cells["MobileNumber"].FormattedValue.ToString(),
                    bday = EmployeeDataGridView.Rows[i].Cells["BirthDate"].FormattedValue.ToString(),
                    pEmail = EmployeeDataGridView.Rows[i].Cells["PersonalEmailAddress"].FormattedValue.ToString(),
                    address = EmployeeDataGridView.Rows[i].Cells["Address"].FormattedValue.ToString(),
                    Size = new Size(827, 43),
                    Dock = DockStyle.Top
                };
                EMPDetails empDet = new EMPDetails()
                {
                    employeeID = EmployeeDataGridView.Rows[i].Cells["EmployeeID"].FormattedValue.ToString(),
                    jobTitle = EmployeeDataGridView.Rows[i].Cells["JobTitle"].FormattedValue.ToString(),
                    branchName = EmployeeDataGridView.Rows[i].Cells["BranchName"].FormattedValue.ToString(),
                    contractLength = EmployeeDataGridView.Rows[i].Cells["ContractLength"].FormattedValue.ToString(),
                    hireDate = EmployeeDataGridView.Rows[i].Cells["HireDate"].FormattedValue.ToString(),
                    salary = EmployeeDataGridView.Rows[i].Cells["Salary"].FormattedValue.ToString(),
                    Size = new Size(827, 43),
                    Dock = DockStyle.Top
                };

                PValuesFlowPanel.Controls.Add(p);
                PValuesFlowPanel.Controls.Add(newEntry);
                EValuesFlowPanel.Controls.Add(t);
                EValuesFlowPanel.Controls.Add(empDet);
            }
        }

        private void OrderByButton_Click(object sender, EventArgs e)
        {
            if(_order == "DESC")
            {
                _order = "ASC";
                OrderByButton.Image = Employ.Properties.Resources.upg;
            }
            else
            {
                _order = "DESC";
                OrderByButton.Image = Employ.Properties.Resources.down;
            }
        }

        private void PreviewNextBtn_Click(object sender, EventArgs e)
        {
            if (_previewCounter + 1 < EmployeeDataGridView.RowCount)
            {
                _previewCounter++;
                PreviewMove();
            }
        }

        private void PreviewBackBtn_Click(object sender, EventArgs e)
        {
            if (_previewCounter - 1 > -1)
            {
                _previewCounter--;
                PreviewMove();
            }
        }
        private void PreviewMove()
        { 
            string fullName = EmployeeDataGridView.Rows[_previewCounter].Cells["FamilyName"].FormattedValue.ToString() + ", " +
            EmployeeDataGridView.Rows[_previewCounter].Cells["GivenName"].FormattedValue.ToString() + ", " +
            EmployeeDataGridView.Rows[_previewCounter].Cells["MiddleName"].FormattedValue.ToString();
            PreviewName.Text = fullName;
            PreviewJobTitle.Text = EmployeeDataGridView.Rows[_previewCounter].Cells["JobTitle"].FormattedValue.ToString();
            PreviewID.Text = EmployeeDataGridView.Rows[_previewCounter].Cells["EmployeeID"].FormattedValue.ToString();
            Bitmap a = (Bitmap)EmployeeDataGridView.Rows[_previewCounter].Cells["IDPicture"].FormattedValue;
            PreviewPictureBox.Image = a;
        }

        private void PreviewButton_Click(object sender, EventArgs e)
        {
            PreviewPanel.Visible = true;
        }
    }
}

