namespace Pizza_Make_Order_Project
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();

            cmbHowManyPizzasValue.SelectedIndex = 0;
        }

        Double TotalPrice = 0;

        public void RecalculateTotalPrice()
        {
            TotalPrice = 0;

            short selecteditemincmb = (short)(cmbHowManyPizzasValue.SelectedIndex + 1);

            //START grpToppings checkboxes
            foreach (Control ctrlTemp in grpToppings.Controls)
            {
                if (ctrlTemp is CheckBox chkTemp && chkTemp.Checked)
                {
                    switch (chkTemp.Name)
                    {
                        case "chkExtraCheese": TotalPrice += Convert.ToDouble(chkTemp.Tag) * selecteditemincmb; break;

                        case "chkMushrooms": TotalPrice += Convert.ToDouble(chkTemp.Tag) * selecteditemincmb; break;

                        case "chkTomatoes": TotalPrice += Convert.ToDouble(chkTemp.Tag) * selecteditemincmb; break;

                        case "chkOnion": TotalPrice += Convert.ToDouble(chkTemp.Tag) * selecteditemincmb; break;

                        case "chkOlives": TotalPrice += Convert.ToDouble(chkTemp.Tag) * selecteditemincmb; break;

                        case "chkGreenPeppers": TotalPrice += Convert.ToDouble(chkTemp.Tag) * selecteditemincmb; break;
                    }
                }
            }
            //END grpToppings checkboxes

            //START grpSize radio Buttons
            foreach (Control ctrlTemp in grpSize.Controls)
            {
                if (ctrlTemp is RadioButton rdTemp && rdTemp.Checked)
                {
                    switch (rdTemp.Name)
                    {
                        case "rdSmallSize": TotalPrice += Convert.ToDouble(rdTemp.Tag) * selecteditemincmb; break;

                        case "rdMediumSize": TotalPrice += Convert.ToDouble(rdTemp.Tag) * selecteditemincmb; break;

                        case "rdLargeSize": TotalPrice += Convert.ToDouble(rdTemp.Tag) * selecteditemincmb; break;
                    }
                }
            }
            //END grpSize radio Buttons

            //START grpCrust radio Buttons
            foreach (Control ctrlTemp in grpCrust.Controls)
            {
                if (ctrlTemp is RadioButton rdTemp && rdTemp.Checked)
                {
                    switch (rdTemp.Name)
                    {
                        case "rdThinCrust": TotalPrice += Convert.ToDouble(rdTemp.Tag) * selecteditemincmb; break;

                        case "rdThickCrust": TotalPrice += Convert.ToDouble(rdTemp.Tag) * selecteditemincmb; break;
                    }
                }
            }
            //END grpCrust radio Buttons

            //START grpWhereToEat radio Buttons
            foreach (Control ctrlTemp in grpWhereToEat.Controls)
            {
                if (ctrlTemp is RadioButton rdTemp && rdTemp.Checked)
                {
                    switch (rdTemp.Name)
                    {
                        case "rdEatIn":
                            {
                                switch (selecteditemincmb)
                                {
                                    case >= 1 and <= 4:
                                        {
                                            TotalPrice += Convert.ToDouble(rdTemp.Tag) * 1;
                                            break;
                                        }
                                    case >= 5 and <= 8:
                                        {
                                            TotalPrice += Convert.ToDouble(rdTemp.Tag) * 2;
                                            break;
                                        }
                                    case >= 9 and <= 12:
                                        {
                                            TotalPrice += Convert.ToDouble(rdTemp.Tag) * 3;
                                            break;
                                        }
                                    case >= 13 and <= 16:
                                        {
                                            TotalPrice += Convert.ToDouble(rdTemp.Tag) * 4;
                                            break;
                                        }
                                    case >= 17 and <= 20:
                                        {
                                            TotalPrice += Convert.ToDouble(rdTemp.Tag) * 5;
                                            break;
                                        }
                                }

                                break;
                            }

                        case "rdTakeOut": TotalPrice += Convert.ToDouble(rdTemp.Tag) * selecteditemincmb; break;
                    }
                }
            }
            //END grpWhereToEat radio Buttons

            lblTotalPriceSumValue.Text = Math.Round(TotalPrice, 2).ToString();
        }

        //
        //                  START grpToppings work...
        //
        //This List is for the Texts of the check boxes inside the group box "grpToppings"
        List<string> grp_chksTexts = new List<string>();

        //This method is for the Texts of the check boxes inside the group box "grpToppings"
        //Its job is to Update the Toppings summary every time a CheckBox value Change.
        public void UpdateToppingsSumValue(CheckBox chkTemp)
        {
            if (chkTemp.Checked)
                grp_chksTexts.Add(chkTemp.Text);

            else
                grp_chksTexts.Remove(chkTemp.Text);


            lblToppingsSumValue.Text = String.Join(" ,", grp_chksTexts);
        }

        private void chkExtraCheese_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chkTemp = sender as CheckBox;
            UpdateToppingsSumValue(chkTemp);
            RecalculateTotalPrice();
        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chkTemp = sender as CheckBox;
            UpdateToppingsSumValue(chkTemp);
            RecalculateTotalPrice();
        }

        private void chkMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chkTemp = sender as CheckBox;
            UpdateToppingsSumValue(chkTemp);
            RecalculateTotalPrice();
        }

        private void chkTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chkTemp = sender as CheckBox;
            UpdateToppingsSumValue(chkTemp);
            RecalculateTotalPrice();
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chkTemp = sender as CheckBox;
            UpdateToppingsSumValue(chkTemp);
            RecalculateTotalPrice();
        }

        private void chkGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chkTemp = sender as CheckBox;
            UpdateToppingsSumValue(chkTemp);
            RecalculateTotalPrice();
        }

        //
        //                  START grpSize work...
        //
        private void rdSmallSize_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdTemp = sender as RadioButton;
            lblSizeSumValue.Text = rdTemp.Text;
            RecalculateTotalPrice();
        }

        private void rdMediumSize_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdTemp = sender as RadioButton;
            lblSizeSumValue.Text = rdTemp.Text;
            RecalculateTotalPrice();
        }

        private void rdLargeSize_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdTemp = sender as RadioButton;
            lblSizeSumValue.Text = rdTemp.Text;
            RecalculateTotalPrice();
        }

        //
        //                  START grpCrust work...
        //
        private void rdThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdTemp = sender as RadioButton;
            lblCrustTypeSumValue.Text = rdTemp.Text;
            RecalculateTotalPrice();
        }

        private void rdThickCrust_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdTemp = sender as RadioButton;
            lblCrustTypeSumValue.Text = rdTemp.Text;
            RecalculateTotalPrice();
        }

        //
        //                  START grpWhereToEat work...
        //
        private void rdEatIn_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdTemp = sender as RadioButton;
            lblWhereToEatSumValue.Text = rdTemp.Text;
            RecalculateTotalPrice();
        }

        private void rdTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdTemp = sender as RadioButton;
            lblWhereToEatSumValue.Text = rdTemp.Text;
            RecalculateTotalPrice();
        }

        //
        //                  START cmbHowManyPizzas work...
        //
        private void cmbHowManyPizzasValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            RecalculateTotalPrice();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want To Reset Your Order?",
                "Reset",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                frmMainMenu frm_New_MainMenu = new frmMainMenu();
                frm_New_MainMenu.Show();
                this.Hide();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want To Move To Next Step?",
    "Next Step",
    MessageBoxButtons.OKCancel,
    MessageBoxIcon.Warning,
    MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                frmOrderMenu objfrmOrderMenu = new frmOrderMenu();
                this.Hide();
                objfrmOrderMenu.ShowDialog();

                if(Convert.ToInt32(objfrmOrderMenu.Tag) == 0)
                    this.Show();
                else
                    this.Close();
            }
        }
    }
}