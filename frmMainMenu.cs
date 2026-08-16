using System.Diagnostics;

namespace Pizza_Make_Order_Project
{
    public partial class frmMainMenu : Form
    {
        public void InitializeMainMenuForm()
        {
            // Size Initialize
            rdSmallSize.Checked = true;
            // Size Sum Initialize
            lblSizeSumValue.Text = rdSmallSize.Text;


            // Toppings Initialize
            chkExtraCheese.Checked = false;
            chkOnion.Checked = false;
            chkMushrooms.Checked = false;
            chkOlives.Checked = false;
            chkTomatoes.Checked = false;
            chkGreenPeppers.Checked = false;
            // Toppings Sum Initialize
            lblToppingsSumValue.Text = "";


            // Crust Type Initialize
            rdThinCrust.Checked = true;
            // Crust Type Sum Initialize
            lblCrustTypeSumValue.Text = rdThinCrust.Text;


            // Where To Eat Initialize
            rdTakeOut.Checked = true;
            // Where To Eat Sum Initialize
            lblWhereToEatSumValue.Text = rdTakeOut.Text;


            // Total Price Sum Initialize
            lblTotalPriceSumValue.Text = Convert.ToString(Convert.ToDecimal(rdSmallSize.Tag) + Convert.ToDecimal(rdThinCrust.Tag) + Convert.ToDecimal(rdTakeOut.Tag));
        }

        public frmMainMenu()
        {
            InitializeComponent();

            InitializeMainMenuForm();
        }

        public void RecalculateTotalPrice()
        {
            Double TotalPrice = 0;

            short nudCurrentValue = (short)(nudHowManyPizzasValue.Value);

            //START grpToppings checkboxes
            foreach (Control ctrlTemp in grpToppings.Controls)
            {
                if (ctrlTemp is CheckBox chkTemp && chkTemp.Checked)
                {
                    switch (chkTemp.Name)
                    {
                        case "chkExtraCheese": TotalPrice += Convert.ToDouble(chkTemp.Tag) * nudCurrentValue; break;

                        case "chkMushrooms": TotalPrice += Convert.ToDouble(chkTemp.Tag) * nudCurrentValue; break;

                        case "chkTomatoes": TotalPrice += Convert.ToDouble(chkTemp.Tag) * nudCurrentValue; break;

                        case "chkOnion": TotalPrice += Convert.ToDouble(chkTemp.Tag) * nudCurrentValue; break;

                        case "chkOlives": TotalPrice += Convert.ToDouble(chkTemp.Tag) * nudCurrentValue; break;

                        case "chkGreenPeppers": TotalPrice += Convert.ToDouble(chkTemp.Tag) * nudCurrentValue; break;
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
                        case "rdSmallSize": TotalPrice += Convert.ToDouble(rdTemp.Tag) * nudCurrentValue; break;

                        case "rdMediumSize": TotalPrice += Convert.ToDouble(rdTemp.Tag) * nudCurrentValue; break;

                        case "rdLargeSize": TotalPrice += Convert.ToDouble(rdTemp.Tag) * nudCurrentValue; break;
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
                        case "rdThinCrust": TotalPrice += Convert.ToDouble(rdTemp.Tag) * nudCurrentValue; break;

                        case "rdThickCrust": TotalPrice += Convert.ToDouble(rdTemp.Tag) * nudCurrentValue; break;
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
                                switch (nudCurrentValue)
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

                        case "rdTakeOut": TotalPrice += Convert.ToDouble(rdTemp.Tag) * nudCurrentValue; break;
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
        List<string> grpToppings_chksTexts = new List<string>();

        //This method is for the Texts of the check boxes inside the group box "grpToppings"
        //Its job is to Update the Toppings summary every time a CheckBox value Change.
        public void UpdateToppingsSumValue(CheckBox chkTemp)
        {
            if (chkTemp.Checked)
                grpToppings_chksTexts.Add(chkTemp.Text);

            else
                grpToppings_chksTexts.Remove(chkTemp.Text);


            lblToppingsSumValue.Text = String.Join(" ,", grpToppings_chksTexts);
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
        //                  START nudHowManyPizzasValue work...
        //
        private void nudHowManyPizzasValue_ValueChanged(object sender, EventArgs e)
        {
            RecalculateTotalPrice();
        }

        //
        //                  START btn work...
        //
        private void btnReset_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want To Reset Your Order?",
                "Reset",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                InitializeMainMenuForm();
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

                if (Convert.ToInt32(objfrmOrderMenu.Tag) == 0)
                    this.Show();
                else
                    this.Close();
            }
        }

        //
        //                  START lnkLinkedIn work...
        //
        private void lnkLinkedIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //This Command makes the site that you have visited marke with visited color "Blue"...
            lnkLinkedIn.LinkVisited = true;

            //Process is a class... and its job is to open a program inside the computer or a Web Explorer or any thing.
            //Start is the function that does the job of opening a program or any thing.
            //this command sais: open this WebPage using the default WebExplorer on the current Cumputer.
            //UseShellExecute = true... You are using Shell to open the default explorer... and it must be "true" so the operation goes fine.
            //ProcessStartInfo... you are creating an object of class that has the options to open the comming thing.
            Process.Start(new ProcessStartInfo("https://www.linkedin.com/in/dev-mahmoud-issa-6a98b0390/") { UseShellExecute = true });
        }
    }
}