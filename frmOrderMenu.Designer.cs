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
            lblLocationSumValue = new Label();
            label1 = new Label();
            lblPhoneSumValue = new Label();
            lblNameSumValue = new Label();
            lblPhoneSum = new Label();
            label6 = new Label();
            lblNameSum = new Label();
            grpSum.SuspendLayout();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(12, 127);
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
            label2.Location = new Point(287, 33);
            label2.Name = "label2";
            label2.Size = new Size(558, 57);
            label2.TabIndex = 1;
            label2.Text = "Order Your Hunt Vampire!";
            // 
            // txtNameValue
            // 
            txtNameValue.BackColor = SystemColors.MenuBar;
            txtNameValue.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNameValue.Location = new Point(318, 126);
            txtNameValue.Name = "txtNameValue";
            txtNameValue.Size = new Size(212, 30);
            txtNameValue.TabIndex = 2;
            txtNameValue.Leave += txtNameValueLeave;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
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
            txtPhoneValue.Name = "txtPhoneValue";
            txtPhoneValue.Size = new Size(212, 30);
            txtPhoneValue.TabIndex = 4;
            txtPhoneValue.Leave += txtPhoneValueLeave;
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLocation.Location = new Point(12, 251);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(404, 25);
            lblLocation.TabIndex = 5;
            lblLocation.Text = "Please Describe Where Your Palace Is Located:";
            // 
            // txtLocationValue
            // 
            txtLocationValue.BackColor = SystemColors.MenuBar;
            txtLocationValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLocationValue.Location = new Point(12, 279);
            txtLocationValue.Multiline = true;
            txtLocationValue.Name = "txtLocationValue";
            txtLocationValue.Size = new Size(518, 102);
            txtLocationValue.TabIndex = 6;
            txtLocationValue.Leave += txtLocationValueLeave;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnBack.ForeColor = Color.Red;
            btnBack.Location = new Point(373, 416);
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
            btnOrder.Location = new Point(669, 416);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(157, 61);
            btnOrder.TabIndex = 8;
            btnOrder.Text = "Order";
            btnOrder.UseVisualStyleBackColor = true;
            // 
            // grpSum
            // 
            grpSum.Controls.Add(lblLocationSumValue);
            grpSum.Controls.Add(label1);
            grpSum.Controls.Add(lblPhoneSumValue);
            grpSum.Controls.Add(lblNameSumValue);
            grpSum.Controls.Add(lblPhoneSum);
            grpSum.Controls.Add(label6);
            grpSum.Controls.Add(lblNameSum);
            grpSum.Location = new Point(586, 126);
            grpSum.Name = "grpSum";
            grpSum.Size = new Size(554, 255);
            grpSum.TabIndex = 9;
            grpSum.TabStop = false;
            grpSum.Text = "Summary";
            // 
            // lblLocationSumValue
            // 
            lblLocationSumValue.Font = new Font("Segoe UI", 10.2F);
            lblLocationSumValue.Location = new Point(6, 150);
            lblLocationSumValue.Name = "lblLocationSumValue";
            lblLocationSumValue.Size = new Size(518, 102);
            lblLocationSumValue.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 125);
            label1.Name = "label1";
            label1.Size = new Size(90, 25);
            label1.TabIndex = 11;
            label1.Text = "Location:";
            // 
            // lblPhoneSumValue
            // 
            lblPhoneSumValue.Font = new Font("Segoe UI", 10.2F);
            lblPhoneSumValue.Location = new Point(83, 86);
            lblPhoneSumValue.Name = "lblPhoneSumValue";
            lblPhoneSumValue.Size = new Size(441, 30);
            lblPhoneSumValue.TabIndex = 10;
            // 
            // lblNameSumValue
            // 
            lblNameSumValue.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNameSumValue.Location = new Point(83, 41);
            lblNameSumValue.Name = "lblNameSumValue";
            lblNameSumValue.Size = new Size(441, 30);
            lblNameSumValue.TabIndex = 5;
            // 
            // lblPhoneSum
            // 
            lblPhoneSum.AutoSize = true;
            lblPhoneSum.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPhoneSum.Location = new Point(6, 84);
            lblPhoneSum.Name = "lblPhoneSum";
            lblPhoneSum.Size = new Size(71, 25);
            lblPhoneSum.TabIndex = 3;
            lblPhoneSum.Text = "Phone:";
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
            // lblNameSum
            // 
            lblNameSum.AutoSize = true;
            lblNameSum.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNameSum.Location = new Point(6, 39);
            lblNameSum.Name = "lblNameSum";
            lblNameSum.Size = new Size(67, 25);
            lblNameSum.TabIndex = 1;
            lblNameSum.Text = "Name:";
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
        private Label lblPhoneSumValue;
        private Label lblNameSumValue;
        private Label lblPhoneSum;
        private Label label1;
        private Label lblLocationSumValue;
    }
}