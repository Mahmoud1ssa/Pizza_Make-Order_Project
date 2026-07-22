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
            label2 = new Label();
            txtNameValue = new TextBox();
            lblPhone = new Label();
            txtPhoneValue = new TextBox();
            lblLocation = new Label();
            txtLocationValue = new TextBox();
            btnBack = new Button();
            btnOrder = new Button();
            grpSum = new GroupBox();
            lblNameSum = new Label();
            label6 = new Label();
            lblPhoneSum = new Label();
            label8 = new Label();
            txtNameSumValue = new Label();
            txtPhoneSumValue = new Label();
            grpSum.SuspendLayout();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(66, 127);
            lblName.Name = "lblName";
            lblName.Size = new Size(219, 25);
            lblName.TabIndex = 0;
            lblName.Text = "Please Enter Your Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Permanent Marker", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(301, 33);
            label2.Name = "label2";
            label2.Size = new Size(558, 57);
            label2.TabIndex = 1;
            label2.Text = "Order Your Hunt Vampire!";
            // 
            // txtNameValue
            // 
            txtNameValue.BackColor = SystemColors.MenuBar;
            txtNameValue.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNameValue.Location = new Point(372, 126);
            txtNameValue.Name = "txtNameValue";
            txtNameValue.Size = new Size(212, 30);
            txtNameValue.TabIndex = 2;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPhone.Location = new Point(66, 173);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(298, 25);
            lblPhone.TabIndex = 3;
            lblPhone.Text = "Please Enter Your Phone Number:";
            // 
            // txtPhoneValue
            // 
            txtPhoneValue.BackColor = SystemColors.MenuBar;
            txtPhoneValue.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhoneValue.Location = new Point(372, 173);
            txtPhoneValue.Name = "txtPhoneValue";
            txtPhoneValue.Size = new Size(212, 30);
            txtPhoneValue.TabIndex = 4;
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLocation.Location = new Point(66, 251);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(404, 25);
            lblLocation.TabIndex = 5;
            lblLocation.Text = "Please Describe Where Your Palace Is Located:";
            // 
            // txtLocationValue
            // 
            txtLocationValue.BackColor = SystemColors.MenuBar;
            txtLocationValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLocationValue.Location = new Point(66, 279);
            txtLocationValue.Multiline = true;
            txtLocationValue.Name = "txtLocationValue";
            txtLocationValue.Size = new Size(518, 102);
            txtLocationValue.TabIndex = 6;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnBack.ForeColor = Color.Red;
            btnBack.Location = new Point(372, 416);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(157, 61);
            btnBack.TabIndex = 7;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // btnOrder
            // 
            btnOrder.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnOrder.ForeColor = Color.FromArgb(0, 192, 0);
            btnOrder.Location = new Point(667, 416);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(157, 61);
            btnOrder.TabIndex = 8;
            btnOrder.Text = "Order";
            btnOrder.UseVisualStyleBackColor = true;
            // 
            // grpSum
            // 
            grpSum.Controls.Add(txtPhoneSumValue);
            grpSum.Controls.Add(txtNameSumValue);
            grpSum.Controls.Add(label8);
            grpSum.Controls.Add(lblPhoneSum);
            grpSum.Controls.Add(label6);
            grpSum.Controls.Add(lblNameSum);
            grpSum.Location = new Point(835, 126);
            grpSum.Name = "grpSum";
            grpSum.Size = new Size(294, 238);
            grpSum.TabIndex = 9;
            grpSum.TabStop = false;
            grpSum.Text = "Summary";
            // 
            // lblNameSum
            // 
            lblNameSum.AutoSize = true;
            lblNameSum.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNameSum.Location = new Point(6, 47);
            lblNameSum.Name = "lblNameSum";
            lblNameSum.Size = new Size(67, 25);
            lblNameSum.TabIndex = 1;
            lblNameSum.Text = "Name:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(109, 48);
            label6.Name = "label6";
            label6.Size = new Size(0, 25);
            label6.TabIndex = 2;
            // 
            // lblPhoneSum
            // 
            lblPhoneSum.AutoSize = true;
            lblPhoneSum.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPhoneSum.Location = new Point(6, 142);
            lblPhoneSum.Name = "lblPhoneSum";
            lblPhoneSum.Size = new Size(71, 25);
            lblPhoneSum.TabIndex = 3;
            lblPhoneSum.Text = "Phone:";
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(21, 88);
            label8.Name = "label8";
            label8.Size = new Size(249, 45);
            label8.TabIndex = 4;
            // 
            // txtNameSumValue
            // 
            txtNameSumValue.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNameSumValue.Location = new Point(21, 88);
            txtNameSumValue.Name = "txtNameSumValue";
            txtNameSumValue.Size = new Size(249, 45);
            txtNameSumValue.TabIndex = 5;
            // 
            // txtPhoneSumValue
            // 
            txtPhoneSumValue.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPhoneSumValue.Location = new Point(23, 180);
            txtPhoneSumValue.Name = "txtPhoneSumValue";
            txtPhoneSumValue.Size = new Size(249, 45);
            txtPhoneSumValue.TabIndex = 10;
            // 
            // frmOrderMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1152, 516);
            Controls.Add(grpSum);
            Controls.Add(btnOrder);
            Controls.Add(btnBack);
            Controls.Add(txtLocationValue);
            Controls.Add(lblLocation);
            Controls.Add(txtPhoneValue);
            Controls.Add(lblPhone);
            Controls.Add(txtNameValue);
            Controls.Add(label2);
            Controls.Add(lblName);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmOrderMenu";
            Text = "Pizza Vampires";
            grpSum.ResumeLayout(false);
            grpSum.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label label2;
        private TextBox txtNameValue;
        private Label lblPhone;
        private TextBox txtPhoneValue;
        private Label lblLocation;
        private TextBox txtLocationValue;
        private Button btnBack;
        private Button btnOrder;
        private GroupBox grpSum;
        private Label label6;
        private Label lblNameSum;
        private Label txtPhoneSumValue;
        private Label txtNameSumValue;
        private Label label8;
        private Label lblPhoneSum;
    }
}