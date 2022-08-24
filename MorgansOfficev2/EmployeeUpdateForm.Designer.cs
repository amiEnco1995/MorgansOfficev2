
namespace MorgansOfficev2
{
    partial class EmployeeUpdateForm
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
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblStreetAddress = new System.Windows.Forms.Label();
            this.lblSuburb = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblHourlyRate = new System.Windows.Forms.Label();
            this.btnUpdateEmployee = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtStreetAddress = new System.Windows.Forms.TextBox();
            this.txtSuburb = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.nudHourlyRate = new System.Windows.Forms.NumericUpDown();
            this.lstDepartment = new System.Windows.Forms.ListBox();
            this.lblDepartmentName = new System.Windows.Forms.Label();
            this.txtDepartmentID = new System.Windows.Forms.TextBox();
            this.lblDepartmentID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHourlyRate)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Location = new System.Drawing.Point(42, 41);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.ReadOnly = true;
            this.dgvEmployees.RowHeadersWidth = 51;
            this.dgvEmployees.RowTemplate.Height = 24;
            this.dgvEmployees.Size = new System.Drawing.Size(838, 345);
            this.dgvEmployees.TabIndex = 0;
            this.dgvEmployees.Click += new System.EventHandler(this.dgvEmployees_Click);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(77, 418);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(102, 24);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(74, 472);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(105, 24);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblStreetAddress
            // 
            this.lblStreetAddress.AutoSize = true;
            this.lblStreetAddress.Location = new System.Drawing.Point(42, 519);
            this.lblStreetAddress.Name = "lblStreetAddress";
            this.lblStreetAddress.Size = new System.Drawing.Size(137, 24);
            this.lblStreetAddress.TabIndex = 3;
            this.lblStreetAddress.Text = "Street Address:";
            // 
            // lblSuburb
            // 
            this.lblSuburb.AutoSize = true;
            this.lblSuburb.Location = new System.Drawing.Point(104, 571);
            this.lblSuburb.Name = "lblSuburb";
            this.lblSuburb.Size = new System.Drawing.Size(75, 24);
            this.lblSuburb.TabIndex = 4;
            this.lblSuburb.Text = "Suburb:";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(38, 618);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(141, 24);
            this.lblPhoneNumber.TabIndex = 5;
            this.lblPhoneNumber.Text = "Phone Number:";
            // 
            // lblHourlyRate
            // 
            this.lblHourlyRate.AutoSize = true;
            this.lblHourlyRate.Location = new System.Drawing.Point(57, 666);
            this.lblHourlyRate.Name = "lblHourlyRate";
            this.lblHourlyRate.Size = new System.Drawing.Size(113, 24);
            this.lblHourlyRate.TabIndex = 6;
            this.lblHourlyRate.Text = "Hourly Rate:";
            // 
            // btnUpdateEmployee
            // 
            this.btnUpdateEmployee.Location = new System.Drawing.Point(46, 731);
            this.btnUpdateEmployee.Name = "btnUpdateEmployee";
            this.btnUpdateEmployee.Size = new System.Drawing.Size(185, 55);
            this.btnUpdateEmployee.TabIndex = 7;
            this.btnUpdateEmployee.Text = "Update Employee";
            this.btnUpdateEmployee.UseVisualStyleBackColor = true;
            this.btnUpdateEmployee.Click += new System.EventHandler(this.btnUpdateEmployee_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(695, 731);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(185, 55);
            this.btnReturn.TabIndex = 8;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(209, 418);
            this.txtLastName.MaxLength = 25;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(263, 32);
            this.txtLastName.TabIndex = 9;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(209, 472);
            this.txtFirstName.MaxLength = 25;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(263, 32);
            this.txtFirstName.TabIndex = 10;
            // 
            // txtStreetAddress
            // 
            this.txtStreetAddress.Location = new System.Drawing.Point(209, 519);
            this.txtStreetAddress.MaxLength = 50;
            this.txtStreetAddress.Name = "txtStreetAddress";
            this.txtStreetAddress.Size = new System.Drawing.Size(493, 32);
            this.txtStreetAddress.TabIndex = 11;
            // 
            // txtSuburb
            // 
            this.txtSuburb.Location = new System.Drawing.Point(209, 571);
            this.txtSuburb.MaxLength = 25;
            this.txtSuburb.Name = "txtSuburb";
            this.txtSuburb.Size = new System.Drawing.Size(204, 32);
            this.txtSuburb.TabIndex = 12;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(209, 618);
            this.txtPhoneNumber.MaxLength = 15;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(147, 32);
            this.txtPhoneNumber.TabIndex = 13;
            // 
            // nudHourlyRate
            // 
            this.nudHourlyRate.DecimalPlaces = 2;
            this.nudHourlyRate.Location = new System.Drawing.Point(209, 666);
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
            this.nudHourlyRate.Size = new System.Drawing.Size(99, 32);
            this.nudHourlyRate.TabIndex = 14;
            this.nudHourlyRate.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // lstDepartment
            // 
            this.lstDepartment.Enabled = false;
            this.lstDepartment.FormattingEnabled = true;
            this.lstDepartment.ItemHeight = 24;
            this.lstDepartment.Location = new System.Drawing.Point(555, 670);
            this.lstDepartment.Name = "lstDepartment";
            this.lstDepartment.Size = new System.Drawing.Size(339, 28);
            this.lstDepartment.TabIndex = 15;
            // 
            // lblDepartmentName
            // 
            this.lblDepartmentName.AutoSize = true;
            this.lblDepartmentName.Location = new System.Drawing.Point(379, 674);
            this.lblDepartmentName.Name = "lblDepartmentName";
            this.lblDepartmentName.Size = new System.Drawing.Size(170, 24);
            this.lblDepartmentName.TabIndex = 16;
            this.lblDepartmentName.Text = "Department Name:";
            // 
            // txtDepartmentID
            // 
            this.txtDepartmentID.Enabled = false;
            this.txtDepartmentID.Location = new System.Drawing.Point(555, 627);
            this.txtDepartmentID.MaxLength = 15;
            this.txtDepartmentID.Name = "txtDepartmentID";
            this.txtDepartmentID.Size = new System.Drawing.Size(85, 32);
            this.txtDepartmentID.TabIndex = 17;
            // 
            // lblDepartmentID
            // 
            this.lblDepartmentID.AutoSize = true;
            this.lblDepartmentID.Location = new System.Drawing.Point(411, 635);
            this.lblDepartmentID.Name = "lblDepartmentID";
            this.lblDepartmentID.Size = new System.Drawing.Size(138, 24);
            this.lblDepartmentID.TabIndex = 18;
            this.lblDepartmentID.Text = "Department ID:";
            // 
            // EmployeeUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 798);
            this.Controls.Add(this.lblDepartmentID);
            this.Controls.Add(this.txtDepartmentID);
            this.Controls.Add(this.lblDepartmentName);
            this.Controls.Add(this.lstDepartment);
            this.Controls.Add(this.nudHourlyRate);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtSuburb);
            this.Controls.Add(this.txtStreetAddress);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnUpdateEmployee);
            this.Controls.Add(this.lblHourlyRate);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblSuburb);
            this.Controls.Add(this.lblStreetAddress);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.dgvEmployees);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EmployeeUpdateForm";
            this.Text = "Update Employees";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHourlyRate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblStreetAddress;
        private System.Windows.Forms.Label lblSuburb;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblHourlyRate;
        private System.Windows.Forms.Button btnUpdateEmployee;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtStreetAddress;
        private System.Windows.Forms.TextBox txtSuburb;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.NumericUpDown nudHourlyRate;
        private System.Windows.Forms.ListBox lstDepartment;
        private System.Windows.Forms.Label lblDepartmentName;
        private System.Windows.Forms.TextBox txtDepartmentID;
        private System.Windows.Forms.Label lblDepartmentID;
    }
}