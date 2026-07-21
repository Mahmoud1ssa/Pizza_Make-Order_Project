namespace Pizza_Make_Order_Project
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();

            cmbHowManyPizzasValue.SelectedIndex = 1;
        }

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
            UpdateToppingsSumValue(sender as CheckBox);
        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppingsSumValue(sender as CheckBox);
        }

        private void chkMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppingsSumValue(sender as CheckBox);
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppingsSumValue(sender as CheckBox);
        }

        private void Tomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppingsSumValue(sender as CheckBox);
        }

        private void chkGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppingsSumValue(sender as CheckBox);
        }
    }
}
