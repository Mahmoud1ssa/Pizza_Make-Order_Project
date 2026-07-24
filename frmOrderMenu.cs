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
            txtStartSetHolder(txtNameValue);
            txtStartSetHolder(txtPhoneValue);
            txtStartSetHolder(txtLocationValue);
        }
        //These functions are to set holder when leave or enter a textbox
        private void txtStopSetHolder(TextBox txt)
        {
            if (txt.Text == Convert.ToString(txt.Tag))
            {
                txt.ForeColor = Color.Black;
                txt.Text = "";
            }
        }
        private void txtStartSetHolder(TextBox txt)
        {
            if (String.IsNullOrWhiteSpace(txt.Text))
            {
                txt.ForeColor = Color.Gray;
                txt.Text = Convert.ToString(txt.Tag);
                return;
            }
        }

        //This function is to fill a summary value label with a value
        private bool lblSumValueSet(TextBox txt, Label lbl)
        {
            if (txt.Text == Convert.ToString(txt.Tag))
                return false;

            lbl.Text = txt.Text;
            return true;
        }
        //
        //                  txtNameValue WORK...
        //
        private void txtNameValueEnter(object sender, EventArgs e)
        {
            txtStopSetHolder(sender as TextBox);
        }
        private void txtNameValueLeave(object sender, EventArgs e)
        {
            txtStartSetHolder(sender as TextBox);

            lblSumValueSet(sender as TextBox, lblNameSumValue);
        }
        //
        //                  txtPhoneValue WORK...
        //
        private void txtPhoneValueEnter(object sender, EventArgs e)
        {
            txtStopSetHolder(sender as TextBox);
        }
        private void txtPhoneValueLeave(object sender, EventArgs e)
        {
            txtStartSetHolder(sender as TextBox);

            lblSumValueSet(sender as TextBox, lblPhoneSumValue);
        }
        //
        //                  txtLocationValue WORK...
        //
        private void txtLocationValueEnter(object sender, EventArgs e)
        {
            txtStopSetHolder(sender as TextBox);
        }
        private void txtLocationValueLeave(object sender, EventArgs e)
        {
            txtStartSetHolder(sender as TextBox);

            lblSumValueSet(sender as TextBox, lblLocationSumValue);
        }
        //
        //                  btnBack WORK...
        //
        private void btnBack_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want to Discard Changes And Go Back?", "Go Back", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Tag = 0;
                this.Close();
            }
        }
        //
        //                  btnOrder WORK...
        //
        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (txtNameValue.Text == String.Empty || txtNameValue.Text == Convert.ToString(txtNameValue.Tag))
            {
                MessageBox.Show("Please Enter A Name Vampire!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPhoneValue.Text == String.Empty || txtPhoneValue.Text.Substring(0, 2) != "09" || txtPhoneValue.Text == Convert.ToString(txtPhoneValue.Tag))
            {
                MessageBox.Show("Please Enter A Valid Phone Number Vampire!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtLocationValue.Text == String.Empty || txtLocationValue.Text == Convert.ToString(txtLocationValue.Tag))
            {
                MessageBox.Show("Please Enter Your Palace Location Vampire!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
