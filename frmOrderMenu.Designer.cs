namespace Pizza_Make_Order_Project
{
    partial class frmOrderMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrderMenu));
            lblName = new Label();
            lblHeadLine = new Label();
            txtNameValue = new TextBox();
            lblPhone = new Label();
            txtPhoneValue = new TextBox();
            lblLocation = new Label();
            btnBack = new Button();
            btnOrder = new Button();
            grpSum = new GroupBox();
            lblLocationSumValue = new Label();
            lblLocationSum = new Label();
            lblPhoneSumValue = new Label();
            lblNameSumValue = new Label();
            lblPhoneSum = new Label();
            lblNameSum = new Label();
            txtLocationValue = new TextBox();
            grpSum.SuspendLayout();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.Transparent;
            lblName.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(12, 127);
            lblName.Name = "lblName";
            lblName.Size = new Size(219, 25);
            lblName.TabIndex = 0;
            lblName.Text = "Please Enter Your Name:";
            // 
            // lblHeadLine
            // 
            lblHeadLine.AutoSize = true;
            lblHeadLine.BackColor = Color.Transparent;
            lblHeadLine.Font = new Font("Permanent Marker", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeadLine.ForeColor = Color.Red;
            lblHeadLine.Location = new Point(308, 32);
            lblHeadLine.Name = "lblHeadLine";
            lblHeadLine.Size = new Size(558, 57);
            lblHeadLine.TabIndex = 1;
            lblHeadLine.Text = "Order Your Hunt Vampire!";
            // 
            // txtNameValue
            // 
            txtNameValue.BackColor = SystemColors.MenuBar;
            txtNameValue.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNameValue.Location = new Point(237, 126);
            txtNameValue.Name = "txtNameValue";
            txtNameValue.Size = new Size(293, 30);
            txtNameValue.TabIndex = 2;
            txtNameValue.Tag = "example: koko";
            txtNameValue.Enter += txtNameValueEnter;
            txtNameValue.Leave += txtNameValueLeave;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.BackColor = Color.Transparent;
            lblPhone.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPhone.Location = new Point(12, 173);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(298, 25);
            lblPhone.TabIndex = 3;
            lblPhone.Text = "Please Enter Your Phone Number:";
            // 
            // txtPhoneValue
            // 
            txtPhoneValue.BackColor = SystemColors.MenuBar;
            txtPhoneValue.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhoneValue.Location = new Point(318, 173);
            txtPhoneValue.MaxLength = 10;
            txtPhoneValue.Name = "txtPhoneValue";
            txtPhoneValue.Size = new Size(212, 30);
            txtPhoneValue.TabIndex = 4;
            txtPhoneValue.Tag = "example: 0900000000";
            txtPhoneValue.Enter += txtPhoneValueEnter;
            txtPhoneValue.Leave += txtPhoneValueLeave;
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.BackColor = Color.Transparent;
            lblLocation.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLocation.Location = new Point(12, 251);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(404, 25);
            lblLocation.TabIndex = 5;
            lblLocation.Text = "Please Describe Where Your Palace Is Located:";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Transparent;
            btnBack.FlatAppearance.BorderColor = Color.Black;
            btnBack.FlatAppearance.BorderSize = 2;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnBack.ForeColor = Color.Red;
            btnBack.Location = new Point(373, 416);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(157, 61);
            btnBack.TabIndex = 7;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnOrder
            // 
            btnOrder.BackColor = Color.Transparent;
            btnOrder.FlatAppearance.BorderColor = Color.Black;
            btnOrder.FlatAppearance.BorderSize = 2;
            btnOrder.FlatStyle = FlatStyle.Flat;
            btnOrder.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnOrder.ForeColor = Color.FromArgb(0, 192, 0);
            btnOrder.Location = new Point(669, 416);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(157, 61);
            btnOrder.TabIndex = 8;
            btnOrder.Text = "Order";
            btnOrder.UseVisualStyleBackColor = false;
            btnOrder.Click += btnOrder_Click;
            // 
            // grpSum
            // 
            grpSum.BackColor = Color.Transparent;
            grpSum.Controls.Add(lblLocationSumValue);
            grpSum.Controls.Add(lblLocationSum);
            grpSum.Controls.Add(lblPhoneSumValue);
            grpSum.Controls.Add(lblNameSumValue);
            grpSum.Controls.Add(lblPhoneSum);
            grpSum.Controls.Add(lblNameSum);
            grpSum.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpSum.Location = new Point(586, 126);
            grpSum.Name = "grpSum";
            grpSum.Size = new Size(554, 266);
            grpSum.TabIndex = 9;
            grpSum.TabStop = false;
            grpSum.Text = "Summary";
            // 
            // lblLocationSumValue
            // 
            lblLocationSumValue.Font = new Font("Segoe UI", 10.8F);
            lblLocationSumValue.Location = new Point(6, 156);
            lblLocationSumValue.Name = "lblLocationSumValue";
            lblLocationSumValue.Size = new Size(530, 110);
            lblLocationSumValue.TabIndex = 12;
            // 
            // lblLocationSum
            // 
            lblLocationSum.AutoSize = true;
            lblLocationSum.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLocationSum.Location = new Point(6, 125);
            lblLocationSum.Name = "lblLocationSum";
            lblLocationSum.Size = new Size(98, 28);
            lblLocationSum.TabIndex = 11;
            lblLocationSum.Text = "Location:";
            // 
            // lblPhoneSumValue
            // 
            lblPhoneSumValue.Font = new Font("Segoe UI", 10.8F);
            lblPhoneSumValue.Location = new Point(83, 87);
            lblPhoneSumValue.Name = "lblPhoneSumValue";
            lblPhoneSumValue.Size = new Size(212, 30);
            lblPhoneSumValue.TabIndex = 10;
            // 
            // lblNameSumValue
            // 
            lblNameSumValue.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNameSumValue.Location = new Point(83, 42);
            lblNameSumValue.Name = "lblNameSumValue";
            lblNameSumValue.Size = new Size(293, 30);
            lblNameSumValue.TabIndex = 5;
            // 
            // lblPhoneSum
            // 
            lblPhoneSum.AutoSize = true;
            lblPhoneSum.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPhoneSum.Location = new Point(6, 84);
            lblPhoneSum.Name = "lblPhoneSum";
            lblPhoneSum.Size = new Size(76, 28);
            lblPhoneSum.TabIndex = 3;
            lblPhoneSum.Text = "Phone:";
            // 
            // lblNameSum
            // 
            lblNameSum.AutoSize = true;
            lblNameSum.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNameSum.Location = new Point(6, 39);
            lblNameSum.Name = "lblNameSum";
            lblNameSum.Size = new Size(73, 28);
            lblNameSum.TabIndex = 1;
            lblNameSum.Text = "Name:";
            // 
            // txtLocationValue
            // 
            txtLocationValue.BackColor = SystemColors.MenuBar;
            txtLocationValue.BorderStyle = BorderStyle.FixedSingle;
            txtLocationValue.Font = new Font("Segoe UI", 10.2F);
            txtLocationValue.Location = new Point(12, 282);
            txtLocationValue.Multiline = true;
            txtLocationValue.Name = "txtLocationValue";
            txtLocationValue.Size = new Size(518, 110);
            txtLocationValue.TabIndex = 6;
            txtLocationValue.Tag = "example: In aleppo, halab Aljadida, Nafisa mosque, Building 60, Floor 1, left appartment";
            txtLocationValue.Enter += txtLocationValueEnter;
            txtLocationValue.Leave += txtLocationValueLeave;
            // 
            // frmOrderMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Pizza_Vampire_Logo_Transparenceid;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1152, 516);
            Controls.Add(txtLocationValue);
            Controls.Add(grpSum);
            Controls.Add(btnOrder);
            Controls.Add(btnBack);
            Controls.Add(lblLocation);
            Controls.Add(txtPhoneValue);
            Controls.Add(lblPhone);
            Controls.Add(txtNameValue);
            Controls.Add(lblHeadLine);
            Controls.Add(lblName);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmOrderMenu";
            Tag = "1";
            Text = "Pizza Vampires";
            grpSum.ResumeLayout(false);
            grpSum.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblHeadLine;
        private TextBox txtNameValue;
        private Label lblPhone;
        private TextBox txtPhoneValue;
        private Label lblLocation;
        private Button btnBack;
        private Button btnOrder;
        private GroupBox grpSum;
        private Label label6;
        private Label lblNameSum;
        private Label lblPhoneSumValue;
        private Label lblNameSumValue;
        private Label lblPhoneSum;
        private Label lblLocationSum;
        private Label lblLocationSumValue;
        private TextBox txtLocationValue;
    }
}