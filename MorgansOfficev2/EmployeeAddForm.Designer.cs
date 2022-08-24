
namespace MorgansOfficev2
{
    partial class EmployeeAddForm
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
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblStreetAddress = new System.Windows.Forms.Label();
            this.lblSuburb = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblHourlyRate = new System.Windows.Forms.Label();
            this.lblDepartmentID = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtStreetAddress = new System.Windows.Forms.TextBox();
            this.txtSuburb = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.nudHourlyRate = new System.Windows.Forms.NumericUpDown();
            this.txtEmployees = new System.Windows.Forms.TextBox();
            this.cboDepartmentID = new System.Windows.Forms.ComboBox();
            this.cboDepartmentName = new System.Windows.Forms.ComboBox();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudHourlyRate)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(614, 47);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(102, 24);
            this.lblLastName.TabIndex = 0;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(611, 93);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(105, 24);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblStreetAddress
            // 
            this.lblStreetAddress.AutoSize = true;
            this.lblStreetAddress.Location = new System.Drawing.Point(579, 139);
            this.lblStreetAddress.Name = "lblStreetAddress";
            this.lblStreetAddress.Size = new System.Drawing.Size(137, 24);
            this.lblStreetAddress.TabIndex = 2;
            this.lblStreetAddress.Text = "Street Address:";
            // 
            // lblSuburb
            // 
            this.lblSuburb.AutoSize = true;
            this.lblSuburb.Location = new System.Drawing.Point(641, 191);
            this.lblSuburb.Name = "lblSuburb";
            this.lblSuburb.Size = new System.Drawing.Size(75, 24);
            this.lblSuburb.TabIndex = 3;
            this.lblSuburb.Text = "Suburb:";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(575, 239);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(141, 24);
            this.lblPhoneNumber.TabIndex = 4;
            this.lblPhoneNumber.Text = "Phone Number:";
            // 
            // lblHourlyRate
            // 
            this.lblHourlyRate.AutoSize = true;
            this.lblHourlyRate.Location = new System.Drawing.Point(603, 287);
            this.lblHourlyRate.Name = "lblHourlyRate";
            this.lblHourlyRate.Size = new System.Drawing.Size(113, 24);
            this.lblHourlyRate.TabIndex = 5;
            this.lblHourlyRate.Text = "Hourly Rate:";
            // 
            // lblDepartmentID
            // 
            this.lblDepartmentID.AutoSize = true;
            this.lblDepartmentID.Location = new System.Drawing.Point(578, 343);
            this.lblDepartmentID.Name = "lblDepartmentID";
            this.lblDepartmentID.Size = new System.Drawing.Size(138, 24);
            this.lblDepartmentID.TabIndex = 6;
            this.lblDepartmentID.Text = "Department ID:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(728, 43);
            this.txtLastName.MaxLength = 25;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(248, 32);
            this.txtLastName.TabIndex = 7;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(728, 93);
            this.txtFirstName.MaxLength = 25;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(248, 32);
            this.txtFirstName.TabIndex = 8;
            // 
            // txtStreetAddress
            // 
            this.txtStreetAddress.Location = new System.Drawing.Point(728, 139);
            this.txtStreetAddress.MaxLength = 50;
            this.txtStreetAddress.Name = "txtStreetAddress";
            this.txtStreetAddress.Size = new System.Drawing.Size(518, 32);
            this.txtStreetAddress.TabIndex = 9;
            // 
            // txtSuburb
            // 
            this.txtSuburb.Location = new System.Drawing.Point(728, 191);
            this.txtSuburb.MaxLength = 25;
            this.txtSuburb.Name = "txtSuburb";
            this.txtSuburb.Size = new System.Drawing.Size(248, 32);
            this.txtSuburb.TabIndex = 10;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(728, 239);
            this.txtPhoneNumber.MaxLength = 15;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(142, 32);
            this.txtPhoneNumber.TabIndex = 11;
            // 
            // nudHourlyRate
            // 
            this.nudHourlyRate.DecimalPlaces = 2;
            this.nudHourlyRate.Location = new System.Drawing.Point(728, 287);
            this.nudHourlyRate.Maximum = new decimal(new int[] {
            75,
            0,
            0,
            0});
            this.nudHourlyRate.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudHourlyRate.Name = "nudHourlyRate";
            this.nudHourlyRate.Size = new System.Drawing.Size(90, 32);
            this.nudHourlyRate.TabIndex = 12;
            this.nudHourlyRate.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // txtEmployees
            // 
            this.txtEmployees.Location = new System.Drawing.Point(24, 43);
            this.txtEmployees.Multiline = true;
            this.txtEmployees.Name = "txtEmployees";
            this.txtEmployees.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEmployees.Size = new System.Drawing.Size(504, 453);
            this.txtEmployees.TabIndex = 13;
            // 
            // cboDepartmentID
            // 
            this.cboDepartmentID.FormattingEnabled = true;
            this.cboDepartmentID.Location = new System.Drawing.Point(728, 343);
            this.cboDepartmentID.Name = "cboDepartmentID";
            this.cboDepartmentID.Size = new System.Drawing.Size(72, 32);
            this.cboDepartmentID.TabIndex = 14;
            // 
            // cboDepartmentName
            // 
            this.cboDepartmentName.FormattingEnabled = true;
            this.cboDepartmentName.Location = new System.Drawing.Point(806, 343);
            this.cboDepartmentName.Name = "cboDepartmentName";
            this.cboDepartmentName.Size = new System.Drawing.Size(170, 32);
            this.cboDepartmentName.TabIndex = 15;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(582, 447);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(236, 49);
            this.btnAddEmployee.TabIndex = 16;
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(1010, 447);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(236, 49);
            this.btnReturn.TabIndex = 17;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // EmployeeAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 527);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.cboDepartmentName);
            this.Controls.Add(this.cboDepartmentID);
            this.Controls.Add(this.txtEmployees);
            this.Controls.Add(this.nudHourlyRate);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtSuburb);
            this.Controls.Add(this.txtStreetAddress);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblDepartmentID);
            this.Controls.Add(this.lblHourlyRate);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblSuburb);
            this.Controls.Add(this.lblStreetAddress);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblLastName);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EmployeeAddForm";
            this.Text = "Add Employees";
            this.Load += new System.EventHandler(this.EmployeeAddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudHourlyRate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblStreetAddress;
        private System.Windows.Forms.Label lblSuburb;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblHourlyRate;
        private System.Windows.Forms.Label lblDepartmentID;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtStreetAddress;
        private System.Windows.Forms.TextBox txtSuburb;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.NumericUpDown nudHourlyRate;
        private System.Windows.Forms.TextBox txtEmployees;
        private System.Windows.Forms.ComboBox cboDepartmentID;
        private System.Windows.Forms.ComboBox cboDepartmentName;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnReturn;
    }
}