
namespace MorgansOfficev2
{
    partial class ProjectUpdateForm
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
            this.lblProjectID = new System.Windows.Forms.Label();
            this.lblProjectName = new System.Windows.Forms.Label();
            this.lblBudget = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtProjectID = new System.Windows.Forms.TextBox();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.nudBudget = new System.Windows.Forms.NumericUpDown();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.lstProjects = new System.Windows.Forms.ListBox();
            this.btnUpdateProject = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudBudget)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProjectID
            // 
            this.lblProjectID.AutoSize = true;
            this.lblProjectID.Location = new System.Drawing.Point(534, 52);
            this.lblProjectID.Name = "lblProjectID";
            this.lblProjectID.Size = new System.Drawing.Size(95, 24);
            this.lblProjectID.TabIndex = 0;
            this.lblProjectID.Text = "Project ID:";
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.Location = new System.Drawing.Point(502, 114);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(127, 24);
            this.lblProjectName.TabIndex = 1;
            this.lblProjectName.Text = "Project Name:";
            // 
            // lblBudget
            // 
            this.lblBudget.AutoSize = true;
            this.lblBudget.Location = new System.Drawing.Point(555, 171);
            this.lblBudget.Name = "lblBudget";
            this.lblBudget.Size = new System.Drawing.Size(74, 24);
            this.lblBudget.TabIndex = 2;
            this.lblBudget.Text = "Budget:";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(534, 233);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(99, 24);
            this.lblStartDate.TabIndex = 3;
            this.lblStartDate.Text = "Start Date:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(555, 285);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(67, 24);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Status:";
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(555, 340);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(64, 24);
            this.lblNotes.TabIndex = 5;
            this.lblNotes.Text = "Notes:";
            // 
            // txtProjectID
            // 
            this.txtProjectID.Enabled = false;
            this.txtProjectID.Location = new System.Drawing.Point(640, 44);
            this.txtProjectID.MaxLength = 3;
            this.txtProjectID.Name = "txtProjectID";
            this.txtProjectID.Size = new System.Drawing.Size(51, 32);
            this.txtProjectID.TabIndex = 6;
            // 
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(640, 106);
            this.txtProjectName.MaxLength = 30;
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(272, 32);
            this.txtProjectName.TabIndex = 7;
            // 
            // nudBudget
            // 
            this.nudBudget.DecimalPlaces = 2;
            this.nudBudget.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudBudget.Location = new System.Drawing.Point(640, 169);
            this.nudBudget.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.nudBudget.Minimum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudBudget.Name = "nudBudget";
            this.nudBudget.Size = new System.Drawing.Size(109, 32);
            this.nudBudget.TabIndex = 8;
            this.nudBudget.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(640, 227);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(331, 32);
            this.dtpStartDate.TabIndex = 9;
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "Approved",
            "Pending",
            "Complete"});
            this.cboStatus.Location = new System.Drawing.Point(640, 282);
            this.cboStatus.MaxLength = 8;
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(158, 32);
            this.cboStatus.TabIndex = 10;
            this.cboStatus.Text = "Approved";
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(634, 354);
            this.txtNotes.MaxLength = 100;
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(382, 128);
            this.txtNotes.TabIndex = 11;
            // 
            // lstProjects
            // 
            this.lstProjects.FormattingEnabled = true;
            this.lstProjects.ItemHeight = 24;
            this.lstProjects.Location = new System.Drawing.Point(40, 44);
            this.lstProjects.Name = "lstProjects";
            this.lstProjects.Size = new System.Drawing.Size(359, 532);
            this.lstProjects.TabIndex = 12;
            // 
            // btnUpdateProject
            // 
            this.btnUpdateProject.Location = new System.Drawing.Point(506, 527);
            this.btnUpdateProject.Name = "btnUpdateProject";
            this.btnUpdateProject.Size = new System.Drawing.Size(173, 48);
            this.btnUpdateProject.TabIndex = 13;
            this.btnUpdateProject.Text = "Update Project";
            this.btnUpdateProject.UseVisualStyleBackColor = true;
            this.btnUpdateProject.Click += new System.EventHandler(this.btnUpdateProject_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(843, 528);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(173, 48);
            this.btnReturn.TabIndex = 14;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // ProjectUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 621);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnUpdateProject);
            this.Controls.Add(this.lstProjects);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.nudBudget);
            this.Controls.Add(this.txtProjectName);
            this.Controls.Add(this.txtProjectID);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblBudget);
            this.Controls.Add(this.lblProjectName);
            this.Controls.Add(this.lblProjectID);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProjectUpdateForm";
            this.Text = "Update Projects";
            ((System.ComponentModel.ISupportInitialize)(this.nudBudget)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProjectID;
        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.Label lblBudget;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtProjectID;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.NumericUpDown nudBudget;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.ListBox lstProjects;
        private System.Windows.Forms.Button btnUpdateProject;
        private System.Windows.Forms.Button btnReturn;
    }
}