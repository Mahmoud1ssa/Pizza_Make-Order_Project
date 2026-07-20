namespace Pizza_Make_Order_Project
{
    partial class frmMainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblMainMenuHeading = new Label();
            grpSize = new GroupBox();
            rdLargSize = new RadioButton();
            rdMediumSize = new RadioButton();
            rdSmallSize = new RadioButton();
            grpToppings = new GroupBox();
            chkGreenPeppers = new CheckBox();
            chkOlives = new CheckBox();
            chkOnion = new CheckBox();
            Tomatoes = new CheckBox();
            chkMushrooms = new CheckBox();
            chkExtraCheese = new CheckBox();
            grpCrust = new GroupBox();
            rdThickCrust = new RadioButton();
            rdThinCrust = new RadioButton();
            grpWhereToEat = new GroupBox();
            rdTakeOut = new RadioButton();
            rdEatIn = new RadioButton();
            grpOrderSummary = new GroupBox();
            lblDollarsMark = new Label();
            lblTotalPriceSumValue = new Label();
            lblTotalPriceSum = new Label();
            lblWhereToEatSumValue = new Label();
            lblWhereToEatSum = new Label();
            lblCrustTypeSumValue = new Label();
            lblCrustTypeSum = new Label();
            lblToppingsSumValue = new Label();
            lblToppingsSum = new Label();
            lblSizeSumValue = new Label();
            lblSizeSum = new Label();
            cmbHowManyPizzasValue = new ComboBox();
            lblHowManyPizzas = new Label();
            btnNext = new Button();
            btnReset = new Button();
            grpSize.SuspendLayout();
            grpToppings.SuspendLayout();
            grpCrust.SuspendLayout();
            grpWhereToEat.SuspendLayout();
            grpOrderSummary.SuspendLayout();
            SuspendLayout();
            // 
            // lblMainMenuHeading
            // 
            lblMainMenuHeading.AutoSize = true;
            lblMainMenuHeading.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMainMenuHeading.ForeColor = Color.Red;
            lblMainMenuHeading.Location = new Point(308, 32);
            lblMainMenuHeading.Name = "lblMainMenuHeading";
            lblMainMenuHeading.Size = new Size(573, 50);
            lblMainMenuHeading.TabIndex = 0;
            lblMainMenuHeading.Text = "Make Your Pizza Vampire!";
            // 
            // grpSize
            // 
            grpSize.Controls.Add(rdLargSize);
            grpSize.Controls.Add(rdMediumSize);
            grpSize.Controls.Add(rdSmallSize);
            grpSize.FlatStyle = FlatStyle.System;
            grpSize.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpSize.Location = new Point(94, 107);
            grpSize.Name = "grpSize";
            grpSize.Size = new Size(186, 149);
            grpSize.TabIndex = 1;
            grpSize.TabStop = false;
            grpSize.Text = "Size";
            // 
            // rdLargSize
            // 
            rdLargSize.AutoSize = true;
            rdLargSize.Location = new Point(30, 99);
            rdLargSize.Name = "rdLargSize";
            rdLargSize.Size = new Size(64, 27);
            rdLargSize.TabIndex = 2;
            rdLargSize.TabStop = true;
            rdLargSize.Text = "Larg";
            rdLargSize.UseVisualStyleBackColor = true;
            // 
            // rdMediumSize
            // 
            rdMediumSize.AutoSize = true;
            rdMediumSize.Location = new Point(30, 64);
            rdMediumSize.Name = "rdMediumSize";
            rdMediumSize.Size = new Size(94, 27);
            rdMediumSize.TabIndex = 1;
            rdMediumSize.TabStop = true;
            rdMediumSize.Text = "Medium";
            rdMediumSize.UseVisualStyleBackColor = true;
            // 
            // rdSmallSize
            // 
            rdSmallSize.AutoSize = true;
            rdSmallSize.Location = new Point(30, 29);
            rdSmallSize.Name = "rdSmallSize";
            rdSmallSize.Size = new Size(72, 27);
            rdSmallSize.TabIndex = 0;
            rdSmallSize.TabStop = true;
            rdSmallSize.Text = "Small";
            rdSmallSize.UseVisualStyleBackColor = true;
            // 
            // grpToppings
            // 
            grpToppings.Controls.Add(chkGreenPeppers);
            grpToppings.Controls.Add(chkOlives);
            grpToppings.Controls.Add(chkOnion);
            grpToppings.Controls.Add(Tomatoes);
            grpToppings.Controls.Add(chkMushrooms);
            grpToppings.Controls.Add(chkExtraCheese);
            grpToppings.Location = new Point(316, 107);
            grpToppings.Name = "grpToppings";
            grpToppings.Size = new Size(452, 149);
            grpToppings.TabIndex = 2;
            grpToppings.TabStop = false;
            grpToppings.Text = "Toppings";
            // 
            // chkGreenPeppers
            // 
            chkGreenPeppers.AutoSize = true;
            chkGreenPeppers.Location = new Point(246, 103);
            chkGreenPeppers.Name = "chkGreenPeppers";
            chkGreenPeppers.Size = new Size(126, 24);
            chkGreenPeppers.TabIndex = 5;
            chkGreenPeppers.Text = "Green Peppers";
            chkGreenPeppers.UseVisualStyleBackColor = true;
            // 
            // chkOlives
            // 
            chkOlives.AutoSize = true;
            chkOlives.Location = new Point(246, 70);
            chkOlives.Name = "chkOlives";
            chkOlives.Size = new Size(71, 24);
            chkOlives.TabIndex = 4;
            chkOlives.Text = "Olives";
            chkOlives.UseVisualStyleBackColor = true;
            // 
            // chkOnion
            // 
            chkOnion.AutoSize = true;
            chkOnion.Location = new Point(246, 32);
            chkOnion.Name = "chkOnion";
            chkOnion.Size = new Size(71, 24);
            chkOnion.TabIndex = 3;
            chkOnion.Text = "Onion";
            chkOnion.UseVisualStyleBackColor = true;
            // 
            // Tomatoes
            // 
            Tomatoes.AutoSize = true;
            Tomatoes.Location = new Point(33, 103);
            Tomatoes.Name = "Tomatoes";
            Tomatoes.Size = new Size(96, 24);
            Tomatoes.TabIndex = 2;
            Tomatoes.Text = "Tomatoes";
            Tomatoes.UseVisualStyleBackColor = true;
            // 
            // chkMushrooms
            // 
            chkMushrooms.AutoSize = true;
            chkMushrooms.Location = new Point(33, 67);
            chkMushrooms.Name = "chkMushrooms";
            chkMushrooms.Size = new Size(108, 24);
            chkMushrooms.TabIndex = 1;
            chkMushrooms.Text = "Mushrooms";
            chkMushrooms.UseVisualStyleBackColor = true;
            // 
            // chkExtraCheese
            // 
            chkExtraCheese.AutoSize = true;
            chkExtraCheese.Location = new Point(33, 32);
            chkExtraCheese.Name = "chkExtraCheese";
            chkExtraCheese.Size = new Size(115, 24);
            chkExtraCheese.TabIndex = 0;
            chkExtraCheese.Text = "Extra Cheese";
            chkExtraCheese.UseVisualStyleBackColor = true;
            // 
            // grpCrust
            // 
            grpCrust.Controls.Add(rdThickCrust);
            grpCrust.Controls.Add(rdThinCrust);
            grpCrust.Location = new Point(94, 279);
            grpCrust.Name = "grpCrust";
            grpCrust.Size = new Size(186, 116);
            grpCrust.TabIndex = 3;
            grpCrust.TabStop = false;
            grpCrust.Text = "Crust";
            // 
            // rdThickCrust
            // 
            rdThickCrust.AutoSize = true;
            rdThickCrust.Location = new Point(30, 70);
            rdThickCrust.Name = "rdThickCrust";
            rdThickCrust.Size = new Size(101, 24);
            rdThickCrust.TabIndex = 3;
            rdThickCrust.TabStop = true;
            rdThickCrust.Text = "Thick Crust";
            rdThickCrust.UseVisualStyleBackColor = true;
            // 
            // rdThinCrust
            // 
            rdThinCrust.AutoSize = true;
            rdThinCrust.Location = new Point(30, 26);
            rdThinCrust.Name = "rdThinCrust";
            rdThinCrust.Size = new Size(95, 24);
            rdThinCrust.TabIndex = 2;
            rdThinCrust.TabStop = true;
            rdThinCrust.Text = "Thin Crust";
            rdThinCrust.UseVisualStyleBackColor = true;
            // 
            // grpWhereToEat
            // 
            grpWhereToEat.Controls.Add(rdTakeOut);
            grpWhereToEat.Controls.Add(rdEatIn);
            grpWhereToEat.Location = new Point(316, 279);
            grpWhereToEat.Name = "grpWhereToEat";
            grpWhereToEat.Size = new Size(185, 116);
            grpWhereToEat.TabIndex = 4;
            grpWhereToEat.TabStop = false;
            grpWhereToEat.Text = "Where To Eat";
            // 
            // rdTakeOut
            // 
            rdTakeOut.AutoSize = true;
            rdTakeOut.Location = new Point(44, 70);
            rdTakeOut.Name = "rdTakeOut";
            rdTakeOut.Size = new Size(87, 24);
            rdTakeOut.TabIndex = 4;
            rdTakeOut.TabStop = true;
            rdTakeOut.Text = "Take Out";
            rdTakeOut.UseVisualStyleBackColor = true;
            // 
            // rdEatIn
            // 
            rdEatIn.AutoSize = true;
            rdEatIn.Location = new Point(44, 26);
            rdEatIn.Name = "rdEatIn";
            rdEatIn.Size = new Size(67, 24);
            rdEatIn.TabIndex = 3;
            rdEatIn.TabStop = true;
            rdEatIn.Text = "Eat In";
            rdEatIn.UseVisualStyleBackColor = true;
            // 
            // grpOrderSummary
            // 
            grpOrderSummary.Controls.Add(lblDollarsMark);
            grpOrderSummary.Controls.Add(lblTotalPriceSumValue);
            grpOrderSummary.Controls.Add(lblTotalPriceSum);
            grpOrderSummary.Controls.Add(lblWhereToEatSumValue);
            grpOrderSummary.Controls.Add(lblWhereToEatSum);
            grpOrderSummary.Controls.Add(lblCrustTypeSumValue);
            grpOrderSummary.Controls.Add(lblCrustTypeSum);
            grpOrderSummary.Controls.Add(lblToppingsSumValue);
            grpOrderSummary.Controls.Add(lblToppingsSum);
            grpOrderSummary.Controls.Add(lblSizeSumValue);
            grpOrderSummary.Controls.Add(lblSizeSum);
            grpOrderSummary.Location = new Point(804, 107);
            grpOrderSummary.Name = "grpOrderSummary";
            grpOrderSummary.Size = new Size(250, 397);
            grpOrderSummary.TabIndex = 5;
            grpOrderSummary.TabStop = false;
            grpOrderSummary.Text = "Order Summary";
            // 
            // lblDollarsMark
            // 
            lblDollarsMark.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDollarsMark.ForeColor = Color.FromArgb(0, 192, 0);
            lblDollarsMark.Location = new Point(202, 336);
            lblDollarsMark.Name = "lblDollarsMark";
            lblDollarsMark.Size = new Size(42, 58);
            lblDollarsMark.TabIndex = 16;
            lblDollarsMark.Text = "$";
            // 
            // lblTotalPriceSumValue
            // 
            lblTotalPriceSumValue.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalPriceSumValue.ForeColor = Color.FromArgb(0, 192, 0);
            lblTotalPriceSumValue.Location = new Point(148, 336);
            lblTotalPriceSumValue.Name = "lblTotalPriceSumValue";
            lblTotalPriceSumValue.Size = new Size(67, 58);
            lblTotalPriceSumValue.TabIndex = 15;
            // 
            // lblTotalPriceSum
            // 
            lblTotalPriceSum.AutoSize = true;
            lblTotalPriceSum.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalPriceSum.Location = new Point(26, 311);
            lblTotalPriceSum.Name = "lblTotalPriceSum";
            lblTotalPriceSum.Size = new Size(106, 25);
            lblTotalPriceSum.TabIndex = 14;
            lblTotalPriceSum.Text = "Total Price:";
            // 
            // lblWhereToEatSumValue
            // 
            lblWhereToEatSumValue.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWhereToEatSumValue.Location = new Point(123, 276);
            lblWhereToEatSumValue.Name = "lblWhereToEatSumValue";
            lblWhereToEatSumValue.Size = new Size(107, 25);
            lblWhereToEatSumValue.TabIndex = 13;
            // 
            // lblWhereToEatSum
            // 
            lblWhereToEatSum.AutoSize = true;
            lblWhereToEatSum.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWhereToEatSum.Location = new Point(26, 240);
            lblWhereToEatSum.Name = "lblWhereToEatSum";
            lblWhereToEatSum.Size = new Size(135, 25);
            lblWhereToEatSum.TabIndex = 12;
            lblWhereToEatSum.Text = "Where To Eat: ";
            // 
            // lblCrustTypeSumValue
            // 
            lblCrustTypeSumValue.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCrustTypeSumValue.Location = new Point(137, 198);
            lblCrustTypeSumValue.Name = "lblCrustTypeSumValue";
            lblCrustTypeSumValue.Size = new Size(107, 25);
            lblCrustTypeSumValue.TabIndex = 11;
            // 
            // lblCrustTypeSum
            // 
            lblCrustTypeSum.AutoSize = true;
            lblCrustTypeSum.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCrustTypeSum.Location = new Point(26, 198);
            lblCrustTypeSum.Name = "lblCrustTypeSum";
            lblCrustTypeSum.Size = new Size(107, 25);
            lblCrustTypeSum.TabIndex = 10;
            lblCrustTypeSum.Text = "Crust Type:";
            // 
            // lblToppingsSumValue
            // 
            lblToppingsSumValue.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblToppingsSumValue.Location = new Point(26, 99);
            lblToppingsSumValue.Name = "lblToppingsSumValue";
            lblToppingsSumValue.Size = new Size(204, 87);
            lblToppingsSumValue.TabIndex = 9;
            // 
            // lblToppingsSum
            // 
            lblToppingsSum.AutoSize = true;
            lblToppingsSum.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblToppingsSum.Location = new Point(26, 64);
            lblToppingsSum.Name = "lblToppingsSum";
            lblToppingsSum.Size = new Size(94, 25);
            lblToppingsSum.TabIndex = 8;
            lblToppingsSum.Text = "Toppings:";
            // 
            // lblSizeSumValue
            // 
            lblSizeSumValue.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSizeSumValue.Location = new Point(83, 32);
            lblSizeSumValue.Name = "lblSizeSumValue";
            lblSizeSumValue.Size = new Size(147, 24);
            lblSizeSumValue.TabIndex = 7;
            // 
            // lblSizeSum
            // 
            lblSizeSum.AutoSize = true;
            lblSizeSum.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSizeSum.Location = new Point(26, 29);
            lblSizeSum.Name = "lblSizeSum";
            lblSizeSum.Size = new Size(51, 25);
            lblSizeSum.TabIndex = 6;
            lblSizeSum.Text = "Size:";
            // 
            // cmbHowManyPizzasValue
            // 
            cmbHowManyPizzasValue.DropDownHeight = 60;
            cmbHowManyPizzasValue.FormattingEnabled = true;
            cmbHowManyPizzasValue.IntegralHeight = false;
            cmbHowManyPizzasValue.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20" });
            cmbHowManyPizzasValue.Location = new Point(694, 333);
            cmbHowManyPizzasValue.Name = "cmbHowManyPizzasValue";
            cmbHowManyPizzasValue.Size = new Size(53, 28);
            cmbHowManyPizzasValue.TabIndex = 6;
            // 
            // lblHowManyPizzas
            // 
            lblHowManyPizzas.AutoSize = true;
            lblHowManyPizzas.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHowManyPizzas.Location = new Point(527, 332);
            lblHowManyPizzas.Name = "lblHowManyPizzas";
            lblHowManyPizzas.Size = new Size(166, 25);
            lblHowManyPizzas.TabIndex = 11;
            lblHowManyPizzas.Text = "How Many Pizzas:";
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.FromArgb(192, 255, 192);
            btnNext.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNext.Location = new Point(527, 418);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(157, 61);
            btnNext.TabIndex = 12;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Silver;
            btnReset.Location = new Point(221, 418);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(157, 61);
            btnReset.TabIndex = 13;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            // 
            // frmMainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1152, 516);
            Controls.Add(btnReset);
            Controls.Add(btnNext);
            Controls.Add(lblHowManyPizzas);
            Controls.Add(cmbHowManyPizzasValue);
            Controls.Add(grpOrderSummary);
            Controls.Add(grpWhereToEat);
            Controls.Add(grpCrust);
            Controls.Add(grpToppings);
            Controls.Add(grpSize);
            Controls.Add(lblMainMenuHeading);
            Name = "frmMainMenu";
            Text = "Pizza Vampires";
            grpSize.ResumeLayout(false);
            grpSize.PerformLayout();
            grpToppings.ResumeLayout(false);
            grpToppings.PerformLayout();
            grpCrust.ResumeLayout(false);
            grpCrust.PerformLayout();
            grpWhereToEat.ResumeLayout(false);
            grpWhereToEat.PerformLayout();
            grpOrderSummary.ResumeLayout(false);
            grpOrderSummary.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMainMenuHeading;
        private GroupBox grpSize;
        private RadioButton rdSmallSize;
        private RadioButton rdLargSize;
        private RadioButton rdMediumSize;
        private GroupBox grpToppings;
        private CheckBox chkGreenPeppers;
        private CheckBox chkOlives;
        private CheckBox chkOnion;
        private CheckBox Tomatoes;
        private CheckBox chkMushrooms;
        private CheckBox chkExtraCheese;
        private GroupBox grpCrust;
        private RadioButton rdThickCrust;
        private RadioButton rdThinCrust;
        private GroupBox grpWhereToEat;
        private RadioButton rdTakeOut;
        private RadioButton rdEatIn;
        private GroupBox grpOrderSummary;
        private Label lblSizeSum;
        private Label lblSizeSumValue;
        private Label lblToppingsSum;
        private Label lblToppingsSumValue;
        private Label lblCrustTypeSum;
        private Label lblTotalPriceSum;
        private Label lblWhereToEatSumValue;
        private Label lblWhereToEatSum;
        private Label lblCrustTypeSumValue;
        private Label lblDollarsMark;
        private Label lblTotalPriceSumValue;
        private ComboBox cmbHowManyPizzasValue;
        private Label lblHowManyPizzas;
        private Button btnNext;
        private Button btnReset;
    }
}
