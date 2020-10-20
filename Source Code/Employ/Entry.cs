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
    public partial class Entry : UserControl
    {
        public Entry()
        {
            InitializeComponent();
        }
        public string name = "Name";
        public string mobileNumber = "Mobile Number";
        public string bday = "Birth Date";
        public string pEmail = "Personal Email";
        public string address = "Address";
        private void Entry_Load(object sender, EventArgs e)
        {
            aName.Text = name;
            Number.Text = mobileNumber;
            BDate.Text = bday;
            PerEmail.Text = pEmail;
            Addr.Text = address;
        }
    }
}
