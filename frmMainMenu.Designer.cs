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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            lblMainMenuHeading = new Label();
            grpSize = new GroupBox();
            rdLargeSize = new RadioButton();
            rdMediumSize = new RadioButton();
            rdSmallSize = new RadioButton();
            grpToppings = new GroupBox();
            chkGreenPeppers = new CheckBox();
            chkOlives = new CheckBox();
            chkOnion = new CheckBox();
            chkTomatoes = new CheckBox();
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
            lblMainMenuHeading.BackColor = Color.Transparent;
            lblMainMenuHeading.Font = new Font("Permanent Marker", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMainMenuHeading.ForeColor = Color.Red;
            lblMainMenuHeading.Location = new Point(308, 32);
            lblMainMenuHeading.Name = "lblMainMenuHeading";
            lblMainMenuHeading.Size = new Size(541, 57);
            lblMainMenuHeading.TabIndex = 0;
            lblMainMenuHeading.Text = "Make Your Pizza Vampire!";
            // 
            // grpSize
            // 
            grpSize.BackColor = Color.Transparent;
            grpSize.Controls.Add(rdLargeSize);
            grpSize.Controls.Add(rdMediumSize);
            grpSize.Controls.Add(rdSmallSize);
            grpSize.Font = new Font("Showcard Gothic", 10.2F);
            grpSize.Location = new Point(94, 107);
            grpSize.Name = "grpSize";
            grpSize.Size = new Size(186, 149);
            grpSize.TabIndex = 1;
            grpSize.TabStop = false;
            grpSize.Text = "Size";
            // 
            // rdLargeSize
            // 
            rdLargeSize.AutoSize = true;
            rdLargeSize.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            rdLargeSize.ForeColor = SystemColors.ControlText;
            rdLargeSize.Location = new Point(30, 99);
            rdLargeSize.Name = "rdLargeSize";
            rdLargeSize.Size = new Size(69, 24);
            rdLargeSize.TabIndex = 2;
            rdLargeSize.TabStop = true;
            rdLargeSize.Tag = "3";
            rdLargeSize.Text = "Large";
            rdLargeSize.UseVisualStyleBackColor = true;
            rdLargeSize.CheckedChanged += rdLargeSize_CheckedChanged;
            // 
            // rdMediumSize
            // 
            rdMediumSize.AutoSize = true;
            rdMediumSize.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            rdMediumSize.ForeColor = SystemColors.ControlText;
            rdMediumSize.Location = new Point(30, 64);
            rdMediumSize.Name = "rdMediumSize";
            rdMediumSize.Size = new Size(88, 24);
            rdMediumSize.TabIndex = 1;
            rdMediumSize.TabStop = true;
            rdMediumSize.Tag = "2";
            rdMediumSize.Text = "Medium";
            rdMediumSize.UseVisualStyleBackColor = true;
            rdMediumSize.CheckedChanged += rdMediumSize_CheckedChanged;
            // 
            // rdSmallSize
            // 
            rdSmallSize.AutoSize = true;
            rdSmallSize.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            rdSmallSize.ForeColor = SystemColors.ControlText;
            rdSmallSize.Location = new Point(30, 29);
            rdSmallSize.Name = "rdSmallSize";
            rdSmallSize.Size = new Size(68, 24);
            rdSmallSize.TabIndex = 0;
            rdSmallSize.TabStop = true;
            rdSmallSize.Tag = "1";
            rdSmallSize.Text = "Small";
            rdSmallSize.UseVisualStyleBackColor = true;
            rdSmallSize.CheckedChanged += rdSmallSize_CheckedChanged;
            // 
            // grpToppings
            // 
            grpToppings.BackColor = Color.Transparent;
            grpToppings.Controls.Add(chkGreenPeppers);
            grpToppings.Controls.Add(chkOlives);
            grpToppings.Controls.Add(chkOnion);
            grpToppings.Controls.Add(chkTomatoes);
            grpToppings.Controls.Add(chkMushrooms);
            grpToppings.Controls.Add(chkExtraCheese);
            grpToppings.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            chkGreenPeppers.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            chkGreenPeppers.Location = new Point(246, 103);
            chkGreenPeppers.Name = "chkGreenPeppers";
            chkGreenPeppers.Size = new Size(133, 24);
            chkGreenPeppers.TabIndex = 5;
            chkGreenPeppers.Tag = "0.2";
            chkGreenPeppers.Text = "Green Peppers";
            chkGreenPeppers.UseVisualStyleBackColor = true;
            chkGreenPeppers.CheckedChanged += chkGreenPeppers_CheckedChanged;
            // 
            // chkOlives
            // 
            chkOlives.AutoSize = true;
            chkOlives.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            chkOlives.ForeColor = SystemColors.ControlText;
            chkOlives.Location = new Point(246, 70);
            chkOlives.Name = "chkOlives";
            chkOlives.Size = new Size(73, 24);
            chkOlives.TabIndex = 3;
            chkOlives.Tag = "0.1";
            chkOlives.Text = "Olives";
            chkOlives.UseVisualStyleBackColor = true;
            chkOlives.CheckedChanged += chkOlives_CheckedChanged;
            // 
            // chkOnion
            // 
            chkOnion.AutoSize = true;
            chkOnion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            chkOnion.ForeColor = SystemColors.ControlText;
            chkOnion.Location = new Point(246, 32);
            chkOnion.Name = "chkOnion";
            chkOnion.Size = new Size(73, 24);
            chkOnion.TabIndex = 1;
            chkOnion.Tag = "0.2";
            chkOnion.Text = "Onion";
            chkOnion.UseVisualStyleBackColor = true;
            chkOnion.CheckedChanged += chkOnion_CheckedChanged;
            // 
            // chkTomatoes
            // 
            chkTomatoes.AutoSize = true;
            chkTomatoes.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            chkTomatoes.ForeColor = SystemColors.ControlText;
            chkTomatoes.Location = new Point(33, 103);
            chkTomatoes.Name = "chkTomatoes";
            chkTomatoes.Size = new Size(100, 24);
            chkTomatoes.TabIndex = 4;
            chkTomatoes.Tag = "0.2";
            chkTomatoes.Text = "Tomatoes";
            chkTomatoes.CheckedChanged += chkTomatoes_CheckedChanged;
            // 
            // chkMushrooms
            // 
            chkMushrooms.AutoSize = true;
            chkMushrooms.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            chkMushrooms.Location = new Point(33, 67);
            chkMushrooms.Name = "chkMushrooms";
            chkMushrooms.Size = new Size(115, 24);
            chkMushrooms.TabIndex = 2;
            chkMushrooms.Tag = "1";
            chkMushrooms.Text = "Mushrooms";
            chkMushrooms.UseVisualStyleBackColor = true;
            chkMushrooms.CheckedChanged += chkMushrooms_CheckedChanged;
            // 
            // chkExtraCheese
            // 
            chkExtraCheese.AutoSize = true;
            chkExtraCheese.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            chkExtraCheese.Location = new Point(33, 32);
            chkExtraCheese.Name = "chkExtraCheese";
            chkExtraCheese.Size = new Size(120, 24);
            chkExtraCheese.TabIndex = 0;
            chkExtraCheese.Tag = "0.5";
            chkExtraCheese.Text = "Extra Cheese";
            chkExtraCheese.UseVisualStyleBackColor = true;
            chkExtraCheese.CheckedChanged += chkExtraCheese_CheckedChanged;
            // 
            // grpCrust
            // 
            grpCrust.BackColor = Color.Transparent;
            grpCrust.Controls.Add(rdThickCrust);
            grpCrust.Controls.Add(rdThinCrust);
            grpCrust.Font = new Font("Showcard Gothic", 10.2F);
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
            rdThickCrust.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            rdThickCrust.ForeColor = SystemColors.ControlText;
            rdThickCrust.Location = new Point(30, 70);
            rdThickCrust.Name = "rdThickCrust";
            rdThickCrust.Size = new Size(108, 24);
            rdThickCrust.TabIndex = 3;
            rdThickCrust.TabStop = true;
            rdThickCrust.Tag = "0.6";
            rdThickCrust.Text = "Thick Crust";
            rdThickCrust.UseVisualStyleBackColor = true;
            rdThickCrust.CheckedChanged += rdThickCrust_CheckedChanged;
            // 
            // rdThinCrust
            // 
            rdThinCrust.AutoSize = true;
            rdThinCrust.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            rdThinCrust.ForeColor = SystemColors.ControlText;
            rdThinCrust.Location = new Point(30, 26);
            rdThinCrust.Name = "rdThinCrust";
            rdThinCrust.Size = new Size(102, 24);
            rdThinCrust.TabIndex = 2;
            rdThinCrust.TabStop = true;
            rdThinCrust.Tag = "0.3";
            rdThinCrust.Text = "Thin Crust";
            rdThinCrust.UseVisualStyleBackColor = true;
            rdThinCrust.CheckedChanged += rdThinCrust_CheckedChanged;
            // 
            // grpWhereToEat
            // 
            grpWhereToEat.BackColor = Color.Transparent;
            grpWhereToEat.Controls.Add(rdTakeOut);
            grpWhereToEat.Controls.Add(rdEatIn);
            grpWhereToEat.Font = new Font("Showcard Gothic", 10.2F);
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
            rdTakeOut.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            rdTakeOut.ForeColor = SystemColors.ControlText;
            rdTakeOut.Location = new Point(44, 70);
            rdTakeOut.Name = "rdTakeOut";
            rdTakeOut.Size = new Size(92, 24);
            rdTakeOut.TabIndex = 4;
            rdTakeOut.TabStop = true;
            rdTakeOut.Tag = "0";
            rdTakeOut.Text = "Take Out";
            rdTakeOut.UseVisualStyleBackColor = true;
            rdTakeOut.CheckedChanged += rdTakeOut_CheckedChanged;
            // 
            // rdEatIn
            // 
            rdEatIn.AutoSize = true;
            rdEatIn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            rdEatIn.ForeColor = SystemColors.ControlText;
            rdEatIn.Location = new Point(44, 26);
            rdEatIn.Name = "rdEatIn";
            rdEatIn.Size = new Size(70, 24);
            rdEatIn.TabIndex = 3;
            rdEatIn.TabStop = true;
            rdEatIn.Tag = "0.5";
            rdEatIn.Text = "Eat In";
            rdEatIn.UseVisualStyleBackColor = true;
            rdEatIn.CheckedChanged += rdEatIn_CheckedChanged;
            // 
            // grpOrderSummary
            // 
            grpOrderSummary.BackColor = Color.Transparent;
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
            grpOrderSummary.Font = new Font("Showcard Gothic", 10.2F);
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
            lblTotalPriceSumValue.ImageAlign = ContentAlignment.BottomLeft;
            lblTotalPriceSumValue.Location = new Point(83, 336);
            lblTotalPriceSumValue.Name = "lblTotalPriceSumValue";
            lblTotalPriceSumValue.Size = new Size(132, 58);
            lblTotalPriceSumValue.TabIndex = 15;
            lblTotalPriceSumValue.TextAlign = ContentAlignment.MiddleRight;
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
            lblWhereToEatSumValue.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWhereToEatSumValue.Location = new Point(137, 274);
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
            lblCrustTypeSumValue.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCrustTypeSumValue.ImageAlign = ContentAlignment.BottomCenter;
            lblCrustTypeSumValue.Location = new Point(137, 200);
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
            lblToppingsSumValue.Size = new Size(204, 99);
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
            cmbHowManyPizzasValue.DropDownHeight = 100;
            cmbHowManyPizzasValue.FormattingEnabled = true;
            cmbHowManyPizzasValue.IntegralHeight = false;
            cmbHowManyPizzasValue.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20" });
            cmbHowManyPizzasValue.Location = new Point(715, 331);
            cmbHowManyPizzasValue.Name = "cmbHowManyPizzasValue";
            cmbHowManyPizzasValue.Size = new Size(53, 28);
            cmbHowManyPizzasValue.TabIndex = 6;
            cmbHowManyPizzasValue.SelectedIndexChanged += cmbHowManyPizzasValue_SelectedIndexChanged;
            // 
            // lblHowManyPizzas
            // 
            lblHowManyPizzas.AutoSize = true;
            lblHowManyPizzas.BackColor = Color.Transparent;
            lblHowManyPizzas.Font = new Font("Showcard Gothic", 10.2F);
            lblHowManyPizzas.Location = new Point(527, 332);
            lblHowManyPizzas.Name = "lblHowManyPizzas";
            lblHowManyPizzas.Size = new Size(171, 21);
            lblHowManyPizzas.TabIndex = 11;
            lblHowManyPizzas.Text = "How Many Pizzas:";
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.Transparent;
            btnNext.FlatAppearance.BorderColor = Color.Black;
            btnNext.FlatAppearance.BorderSize = 2;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNext.ForeColor = Color.Black;
            btnNext.Location = new Point(516, 418);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(157, 61);
            btnNext.TabIndex = 12;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Transparent;
            btnReset.FlatAppearance.BorderColor = Color.Black;
            btnReset.FlatAppearance.BorderSize = 2;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReset.ForeColor = Color.Red;
            btnReset.Location = new Point(270, 418);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(157, 61);
            btnReset.TabIndex = 13;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // frmMainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Pizza_Vampire_Logo_Transparenceid;
            BackgroundImageLayout = ImageLayout.Zoom;
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
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
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
        private RadioButton rdLargeSize;
        private RadioButton rdMediumSize;
        private GroupBox grpToppings;
        private CheckBox chkGreenPeppers;
        private CheckBox chkOlives;
        private CheckBox chkOnion;
        private CheckBox chkTomatoes;
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
