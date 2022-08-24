
namespace MorgansOfficev2
{
    partial class EmployeeReportForm
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
            this.txtEmployees = new System.Windows.Forms.TextBox();
            this.btnDisplayReport = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEmployees
            // 
            this.txtEmployees.Location = new System.Drawing.Point(39, 37);
            this.txtEmployees.Multiline = true;
            this.txtEmployees.Name = "txtEmployees";
            this.txtEmployees.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEmployees.Size = new System.Drawing.Size(796, 442);
            this.txtEmployees.TabIndex = 0;
            // 
            // btnDisplayReport
            // 
            this.btnDisplayReport.Location = new System.Drawing.Point(39, 504);
            this.btnDisplayReport.Name = "btnDisplayReport";
            this.btnDisplayReport.Size = new System.Drawing.Size(207, 48);
            this.btnDisplayReport.TabIndex = 1;
            this.btnDisplayReport.Text = "Display Report";
            this.btnDisplayReport.UseVisualStyleBackColor = true;
            this.btnDisplayReport.Click += new System.EventHandler(this.btnDisplayReport_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(628, 504);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(207, 48);
            this.btnReturn.TabIndex = 2;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // EmployeeReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 567);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDisplayReport);
            this.Controls.Add(this.txtEmployees);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EmployeeReportForm";
            this.Text = "Employees Report";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmployees;
        private System.Windows.Forms.Button btnDisplayReport;
        private System.Windows.Forms.Button btnReturn;
    }
}