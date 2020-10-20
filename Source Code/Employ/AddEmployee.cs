using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employ
{
    public partial class AddEmployee : Form
    {
        public string imgLoc = string.Empty;
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {
            PersonalInfoPanel.Dock = DockStyle.Fill;
        }

        private void BDayButton_Click(object sender, EventArgs e)
        {
            BDayCalendar.Visible = true;
        }

        private void BDayCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            BDayTextBox.Text = BDayCalendar.SelectionRange.Start.ToShortDateString();
            BDayCalendar.Visible = false;
        }
        private void ClearAll()
        {
            HireDateTextBox.Text = ContractLengthTextBox.Text = SalaryTextBox.Text = EmployeeIDTextBox.Text = JobTitleTextBox.Text = BranchTextBox.Text = GivenNameTextBox.Text = FamilyNameTextBox.Text = MiddleNameTextBox.Text = BDayTextBox.Text = MobileNumberTextBox.Text = PersonalEmailAddressTextBox.Text = AddressTextBox.Text = string.Empty;
            IDPicButton.Visible = true;
        }
        private void IDPicButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Choose a File";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                imgLoc = dlg.FileName.ToString();
                IDPicture.ImageLocation = imgLoc;
                IDPicButton.Visible = false;
            }
        }

        private void IDPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Choose a File";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                imgLoc = dlg.FileName.ToString();
                IDPicture.ImageLocation = imgLoc;
                IDPicButton.Visible = false;
            }
        }

        private void PInfoNextBtn_Click(object sender, EventArgs e)
        {
            string pInfoErrors = string.Empty;
            if (MobileNumberTextBox.Text.Any(char.IsLetter)) pInfoErrors += "Mobile Number not Valid! Format: 0000 000 0000\n";
            if (BDayTextBox.Text.Any(char.IsLetter)) pInfoErrors += "Birthday must be in DD/MM/YY Format!\n";
            if (pInfoErrors != string.Empty) MessageBox.Show(pInfoErrors, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                PersonalInfoPanel.Dock = DockStyle.None;
                ProfessionalDetailsPanel.Dock = DockStyle.Fill;
            }
        }
        private void PInfoClearBtn_Click(object sender, EventArgs e)
        {
            GivenNameTextBox.Text = FamilyNameTextBox.Text = MiddleNameTextBox.Text = BDayTextBox.Text = MobileNumberTextBox.Text = PersonalEmailAddressTextBox.Text = AddressTextBox.Text = string.Empty;
            IDPicButton.Visible = true;
        }

        private void EmpDetAddBtn_Click(object sender, EventArgs e)
        {
            string eDetErrors = string.Empty;
            if (ContractLengthTextBox.Text.Any(char.IsLetter)) eDetErrors += "Contract Lenght must be in DD/MM/YY Format!\n";
            if (EmployeeIDTextBox.Text.Length != 10 || EmployeeIDTextBox.Text.Any(char.IsWhiteSpace)) eDetErrors += "Employee ID Invalid!\n";
            if (eDetErrors != string.Empty) MessageBox.Show(eDetErrors, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                byte[] IDPicture = null;
                FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                IDPicture = br.ReadBytes((int)fs.Length);
                SqlConnection connection = new SqlConnection("Data Source = (localdb)\\MSSQLLocalDB;Initial Catalog = Employ;Integrated Security = True;");
                connection.Open();
                string queryString = "INSERT INTO EmployeesData VALUES(@GivenName, @FamilyName, @MiddleName, @MobileNumber, @BirthDate, @PersonalEmailAddress, @Address, @IDPicture, @EmployeeID, @JobTitle, @BranchName, @ContractLength, @HireDate, @Salary)";

                SqlParameter param1 = new SqlParameter()
                {
                    ParameterName = "@GivenName",
                    Value = GivenNameTextBox.Text
                };
                SqlParameter param2 = new SqlParameter()
                {
                    ParameterName = "@FamilyName",
                    Value = FamilyNameTextBox.Text
                };
                SqlParameter param3 = new SqlParameter()
                {
                    ParameterName = "@MiddleName",
                    Value = MiddleNameTextBox.Text
                };
                SqlParameter param4 = new SqlParameter()
                {
                    ParameterName = "@MobileNumber",
                    Value = MobileNumberTextBox.Text
                };
                SqlParameter param5 = new SqlParameter()
                {
                    ParameterName = "@BirthDate",
                    Value = DateTime.Parse(BDayTextBox.Text)
                };;
                SqlParameter param6 = new SqlParameter()
                {
                    ParameterName = "@PersonalEmailAddress",
                    Value = PersonalEmailAddressTextBox.Text
                };
                SqlParameter param7 = new SqlParameter()
                {
                    ParameterName = "@Address",
                    Value = AddressTextBox.Text
                };
                SqlParameter param8 = new SqlParameter()
                {
                    ParameterName = "@IDPicture",
                    Value = IDPicture
                };
                SqlParameter param9 = new SqlParameter()
                {
                    ParameterName = "@EmployeeID",
                    Value = EmployeeIDTextBox.Text
                };
                SqlParameter param10 = new SqlParameter()
                {
                    ParameterName = "@JobTitle",
                    Value = JobTitleTextBox.Text
                };
                SqlParameter param11 = new SqlParameter()
                {
                    ParameterName = "@BranchName",
                    Value = BranchTextBox.Text
                };
                SqlParameter param12 = new SqlParameter()
                {
                    ParameterName = "@ContractLength",
                    Value = Convert.ToInt32(ContractLengthTextBox.Text)
                };
                SqlParameter param13 = new SqlParameter()
                {
                    ParameterName = "@HireDate",
                    Value = DateTime.Parse(HireDateTextBox.Text)
                };
                SqlParameter param14 = new SqlParameter()
                {
                    ParameterName = "@Salary",
                    Value = Convert.ToInt32(SalaryTextBox.Text)
                };

                SqlCommand cmd = new SqlCommand(queryString, connection);

                cmd.Parameters.Add(param1);
                cmd.Parameters.Add(param2);
                cmd.Parameters.Add(param3);
                cmd.Parameters.Add(param4);
                cmd.Parameters.Add(param5);
                cmd.Parameters.Add(param6);
                cmd.Parameters.Add(param7);
                cmd.Parameters.Add(param8);
                cmd.Parameters.Add(param9);
                cmd.Parameters.Add(param10);
                cmd.Parameters.Add(param11);
                cmd.Parameters.Add(param12);
                cmd.Parameters.Add(param13);
                cmd.Parameters.Add(param14);

                cmd.ExecuteNonQuery();
                
                connection.Close();

                MessageBox.Show("Employee Added to Database!", "Accepted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearAll();
                ProfessionalDetailsPanel.Dock = DockStyle.None;
                PersonalInfoPanel.Dock = DockStyle.Fill;
            }
        }

        private void EmpDetClearBtn_Click(object sender, EventArgs e)
        {
            HireDateTextBox.Text = ContractLengthTextBox.Text = SalaryTextBox.Text = EmployeeIDTextBox.Text = JobTitleTextBox.Text = BranchTextBox.Text = string.Empty;
        }

        private void EmpDetPrevBtn_Click(object sender, EventArgs e)
        {
            ProfessionalDetailsPanel.Dock = DockStyle.None;
            PersonalInfoPanel.Dock = DockStyle.Fill;
        }

        private void HireDateBtn_Click(object sender, EventArgs e)
        {
            HireDateCalendar.Visible = true;
        }

        private void HireDateCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            HireDateTextBox.Text = HireDateCalendar.SelectionRange.Start.ToShortDateString();
            HireDateCalendar.Visible = false;
        }
    }
}
