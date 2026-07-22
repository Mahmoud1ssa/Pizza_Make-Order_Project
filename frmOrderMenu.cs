using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Make_Order_Project
{
    public partial class frmOrderMenu : Form
    {
        public frmOrderMenu()
        {
            InitializeComponent();
        }

        private void txtNameValueLeave(object sender, EventArgs e)
        {
            lblNameSumValue.Text = txtNameValue.Text;
        }

        private void txtPhoneValueLeave(object sender, EventArgs e)
        {
            lblPhoneSumValue.Text = txtPhoneValue.Text;
        }

        private void txtLocationValueLeave(object sender, EventArgs e)
        {
            lblLocationSumValue.Text = txtLocationValue.Text;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want to Discard Changes And Go Back?", "Go Back", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                this.Tag = 0;
                this.Close();
            }
        }
    }
}
