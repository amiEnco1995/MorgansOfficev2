
namespace MorgansOfficev2
{
    partial class DepartmentDeleteForm
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
            this.lblDepartmentID = new System.Windows.Forms.Label();
            this.lblDepartmentName = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lstDepartments = new System.Windows.Forms.ListBox();
            this.btnDeletedDepartment = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.txtDepartmentID = new System.Windows.Forms.TextBox();
            this.txtDepartmentName = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblDepartmentID
            // 
            this.lblDepartmentID.AutoSize = true;
            this.lblDepartmentID.Location = new System.Drawing.Point(427, 57);
            this.lblDepartmentID.Name = "lblDepartmentID";
            this.lblDepartmentID.Size = new System.Drawing.Size(138, 24);
            this.lblDepartmentID.TabIndex = 0;
            this.lblDepartmentID.Text = "Department ID:";
            // 
            // lblDepartmentName
            // 
            this.lblDepartmentName.AutoSize = true;
            this.lblDepartmentName.Location = new System.Drawing.Point(395, 138);
            this.lblDepartmentName.Name = "lblDepartmentName";
            this.lblDepartmentName.Size = new System.Drawing.Size(170, 24);
            this.lblDepartmentName.TabIndex = 1;
            this.lblDepartmentName.Text = "Department Name:";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(480, 230);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(85, 24);
            this.lblLocation.TabIndex = 2;
            this.lblLocation.Text = "Location:";
            // 
            // lstDepartments
            // 
            this.lstDepartments.FormattingEnabled = true;
            this.lstDepartments.ItemHeight = 24;
            this.lstDepartments.Location = new System.Drawing.Point(51, 49);
            this.lstDepartments.Name = "lstDepartments";
            this.lstDepartments.Size = new System.Drawing.Size(278, 340);
            this.lstDepartments.TabIndex = 3;
            // 
            // btnDeletedDepartment
            // 
            this.btnDeletedDepartment.Location = new System.Drawing.Point(412, 330);
            this.btnDeletedDepartment.Name = "btnDeletedDepartment";
            this.btnDeletedDepartment.Size = new System.Drawing.Size(188, 61);
            this.btnDeletedDepartment.TabIndex = 4;
            this.btnDeletedDepartment.Text = "Delete Department";
            this.btnDeletedDepartment.UseVisualStyleBackColor = true;
            this.btnDeletedDepartment.Click += new System.EventHandler(this.btnDeletedDepartment_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(745, 328);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(188, 61);
            this.btnReturn.TabIndex = 5;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // txtDepartmentID
            // 
            this.txtDepartmentID.Enabled = false;
            this.txtDepartmentID.Location = new System.Drawing.Point(578, 49);
            this.txtDepartmentID.MaxLength = 3;
            this.txtDepartmentID.Name = "txtDepartmentID";
            this.txtDepartmentID.Size = new System.Drawing.Size(63, 32);
            this.txtDepartmentID.TabIndex = 6;
            // 
            // txtDepartmentName
            // 
            this.txtDepartmentName.Enabled = false;
            this.txtDepartmentName.Location = new System.Drawing.Point(578, 135);
            this.txtDepartmentName.MaxLength = 30;
            this.txtDepartmentName.Name = "txtDepartmentName";
            this.txtDepartmentName.Size = new System.Drawing.Size(271, 32);
            this.txtDepartmentName.TabIndex = 7;
            // 
            // txtLocation
            // 
            this.txtLocation.Enabled = false;
            this.txtLocation.Location = new System.Drawing.Point(578, 230);
            this.txtLocation.MaxLength = 20;
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(208, 32);
            this.txtLocation.TabIndex = 8;
            // 
            // DepartmentDeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 424);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.txtDepartmentName);
            this.Controls.Add(this.txtDepartmentID);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDeletedDepartment);
            this.Controls.Add(this.lstDepartments);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblDepartmentName);
            this.Controls.Add(this.lblDepartmentID);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DepartmentDeleteForm";
            this.Text = "Delete Departments";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDepartmentID;
        private System.Windows.Forms.Label lblDepartmentName;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.ListBox lstDepartments;
        private System.Windows.Forms.Button btnDeletedDepartment;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.TextBox txtDepartmentID;
        private System.Windows.Forms.TextBox txtDepartmentName;
        private System.Windows.Forms.TextBox txtLocation;
    }
}