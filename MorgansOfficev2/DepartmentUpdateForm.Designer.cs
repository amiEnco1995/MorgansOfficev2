
namespace MorgansOfficev2
{
    partial class DepartmentUpdateForm
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
            this.txtDepartmentID = new System.Windows.Forms.TextBox();
            this.txtDepartmentName = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.btnUpdateDepartment = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lstDepartments = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblDepartmentID
            // 
            this.lblDepartmentID.AutoSize = true;
            this.lblDepartmentID.Location = new System.Drawing.Point(589, 73);
            this.lblDepartmentID.Name = "lblDepartmentID";
            this.lblDepartmentID.Size = new System.Drawing.Size(138, 24);
            this.lblDepartmentID.TabIndex = 0;
            this.lblDepartmentID.Text = "Department ID:";
            // 
            // lblDepartmentName
            // 
            this.lblDepartmentName.AutoSize = true;
            this.lblDepartmentName.Location = new System.Drawing.Point(557, 159);
            this.lblDepartmentName.Name = "lblDepartmentName";
            this.lblDepartmentName.Size = new System.Drawing.Size(170, 24);
            this.lblDepartmentName.TabIndex = 1;
            this.lblDepartmentName.Text = "Department Name:";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(642, 240);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(85, 24);
            this.lblLocation.TabIndex = 2;
            this.lblLocation.Text = "Location:";
            // 
            // txtDepartmentID
            // 
            this.txtDepartmentID.Enabled = false;
            this.txtDepartmentID.Location = new System.Drawing.Point(733, 70);
            this.txtDepartmentID.MaxLength = 3;
            this.txtDepartmentID.Name = "txtDepartmentID";
            this.txtDepartmentID.Size = new System.Drawing.Size(62, 32);
            this.txtDepartmentID.TabIndex = 3;
            // 
            // txtDepartmentName
            // 
            this.txtDepartmentName.Location = new System.Drawing.Point(733, 151);
            this.txtDepartmentName.MaxLength = 30;
            this.txtDepartmentName.Name = "txtDepartmentName";
            this.txtDepartmentName.Size = new System.Drawing.Size(328, 32);
            this.txtDepartmentName.TabIndex = 4;
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(733, 232);
            this.txtLocation.MaxLength = 20;
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(230, 32);
            this.txtLocation.TabIndex = 5;
            // 
            // btnUpdateDepartment
            // 
            this.btnUpdateDepartment.Location = new System.Drawing.Point(561, 371);
            this.btnUpdateDepartment.Name = "btnUpdateDepartment";
            this.btnUpdateDepartment.Size = new System.Drawing.Size(193, 54);
            this.btnUpdateDepartment.TabIndex = 7;
            this.btnUpdateDepartment.Text = "Update Department";
            this.btnUpdateDepartment.UseVisualStyleBackColor = true;
            this.btnUpdateDepartment.Click += new System.EventHandler(this.btnUpdateDepartment_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(868, 371);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(193, 54);
            this.btnReturn.TabIndex = 8;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lstDepartments
            // 
            this.lstDepartments.FormattingEnabled = true;
            this.lstDepartments.ItemHeight = 24;
            this.lstDepartments.Location = new System.Drawing.Point(40, 54);
            this.lstDepartments.Name = "lstDepartments";
            this.lstDepartments.Size = new System.Drawing.Size(448, 364);
            this.lstDepartments.TabIndex = 9;
            // 
            // DepartmentUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 468);
            this.Controls.Add(this.lstDepartments);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnUpdateDepartment);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.txtDepartmentName);
            this.Controls.Add(this.txtDepartmentID);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblDepartmentName);
            this.Controls.Add(this.lblDepartmentID);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DepartmentUpdateForm";
            this.Text = "Update Departments";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDepartmentID;
        private System.Windows.Forms.Label lblDepartmentName;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtDepartmentID;
        private System.Windows.Forms.TextBox txtDepartmentName;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Button btnUpdateDepartment;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.ListBox lstDepartments;
    }
}