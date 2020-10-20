using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employ
{
    public partial class EMPDetails : UserControl
    {
        public string employeeID = string.Empty;
        public string jobTitle = string.Empty;
        public string branchName = string.Empty;
        public string contractLength = string.Empty;
        public string hireDate = string.Empty;
        public string salary = string.Empty;
        public EMPDetails()
        {
            InitializeComponent();
        }

        private void EMPDetails_Load(object sender, EventArgs e)
        {
            EID.Text = employeeID;
            JTitle.Text = jobTitle;
            BName.Text = branchName;
            CLength.Text = contractLength;
            HDate.Text = hireDate;
            Slry.Text = salary;
        }
    }
}
