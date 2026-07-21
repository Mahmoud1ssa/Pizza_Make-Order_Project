namespace Pizza_Make_Order_Project
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();

            cmbHowManyPizzasValue.SelectedIndex = 0;
        }

        Single TotalPrice = 0;

        //START grpToppings work...

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
        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chkTemp = sender as CheckBox;
            UpdateToppingsSumValue(chkTemp);
        }

        private void chkMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chkTemp = sender as CheckBox;
            UpdateToppingsSumValue(chkTemp);
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chkTemp = sender as CheckBox;
            UpdateToppingsSumValue(chkTemp);
        }

        private void Tomatoes_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chkTemp = sender as CheckBox;
            UpdateToppingsSumValue(chkTemp);
        }

        private void chkGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chkTemp = sender as CheckBox;
            UpdateToppingsSumValue(chkTemp);
        }

        //END grpToppings work...


        //START grpSize work...

        private void rdSmallSize_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdTemp = sender as RadioButton;
            lblSizeSumValue.Text = rdTemp.Text;
        }

        private void rdMediumSize_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdTemp = sender as RadioButton;
            lblSizeSumValue.Text = rdTemp.Text;
        }

        private void rdLargeSize_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdTemp = sender as RadioButton;
            lblSizeSumValue.Text = rdTemp.Text;
        }

        //END grpSize work...


        //START grpCrust work...

        private void rdThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdTemp = sender as RadioButton;
            lblCrustTypeSumValue.Text = rdTemp.Text;
        }

        private void rdThickCrust_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdTemp = sender as RadioButton;
            lblCrustTypeSumValue.Text = rdTemp.Text;
        }

        //END grpSize work...


        //START grpWhereToEat work...

        private void rdEatIn_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdTemp = sender as RadioButton;
            lblWhereToEatSumValue.Text = rdTemp.Text;
        }

        private void rdTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdTemp = sender as RadioButton;
            lblWhereToEatSumValue.Text = rdTemp.Text;
        }

        //END grpWhereToEat work...

    }
}
