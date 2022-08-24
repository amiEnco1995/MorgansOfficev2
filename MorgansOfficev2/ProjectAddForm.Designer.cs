
namespace MorgansOfficev2
{
    partial class ProjectAddForm
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
            this.lblProjectName = new System.Windows.Forms.Label();
            this.lblBudget = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.nudBudget = new System.Windows.Forms.NumericUpDown();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.txtProjects = new System.Windows.Forms.TextBox();
            this.btnAddProject = new System.Windows.Forms.Button();
            this.Return = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudBudget)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.Location = new System.Drawing.Point(653, 79);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(100, 19);
            this.lblProjectName.TabIndex = 0;
            this.lblProjectName.Text = "Project Name:";
            // 
            // lblBudget
            // 
            this.lblBudget.AutoSize = true;
            this.lblBudget.Location = new System.Drawing.Point(694, 145);
            this.lblBudget.Name = "lblBudget";
            this.lblBudget.Size = new System.Drawing.Size(59, 19);
            this.lblBudget.TabIndex = 1;
            this.lblBudget.Text = "Budget:";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(675, 202);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(78, 19);
            this.lblStartDate.TabIndex = 2;
            this.lblStartDate.Text = "Start Date:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(700, 255);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(53, 19);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Status:";
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(702, 304);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(51, 19);
            this.lblNotes.TabIndex = 4;
            this.lblNotes.Text = "Notes:";
            // 
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(759, 76);
            this.txtProjectName.MaxLength = 30;
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(358, 27);
            this.txtProjectName.TabIndex = 5;
            // 
            // nudBudget
            // 
            this.nudBudget.DecimalPlaces = 2;
            this.nudBudget.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudBudget.Location = new System.Drawing.Point(759, 137);
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
            this.nudBudget.Size = new System.Drawing.Size(127, 27);
            this.nudBudget.TabIndex = 6;
            this.nudBudget.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(759, 196);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(271, 27);
            this.dtpStartDate.TabIndex = 7;
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "Pending",
            "Approved",
            "Complete"});
            this.cboStatus.Location = new System.Drawing.Point(759, 247);
            this.cboStatus.MaxLength = 8;
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(167, 27);
            this.cboStatus.TabIndex = 8;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(759, 304);
            this.txtNotes.MaxLength = 100;
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(458, 133);
            this.txtNotes.TabIndex = 9;
            // 
            // txtProjects
            // 
            this.txtProjects.Location = new System.Drawing.Point(34, 67);
            this.txtProjects.Multiline = true;
            this.txtProjects.Name = "txtProjects";
            this.txtProjects.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtProjects.Size = new System.Drawing.Size(506, 487);
            this.txtProjects.TabIndex = 10;
            // 
            // btnAddProject
            // 
            this.btnAddProject.Location = new System.Drawing.Point(615, 503);
            this.btnAddProject.Name = "btnAddProject";
            this.btnAddProject.Size = new System.Drawing.Size(189, 51);
            this.btnAddProject.TabIndex = 11;
            this.btnAddProject.Text = "Add Project";
            this.btnAddProject.UseVisualStyleBackColor = true;
            this.btnAddProject.Click += new System.EventHandler(this.btnAddProject_Click);
            // 
            // Return
            // 
            this.Return.Location = new System.Drawing.Point(1028, 503);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(189, 51);
            this.Return.TabIndex = 12;
            this.Return.Text = "Return";
            this.Return.UseVisualStyleBackColor = true;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // ProjectAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 599);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.btnAddProject);
            this.Controls.Add(this.txtProjects);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.nudBudget);
            this.Controls.Add(this.txtProjectName);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblBudget);
            this.Controls.Add(this.lblProjectName);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProjectAddForm";
            this.Text = "Add Projects";
            this.Load += new System.EventHandler(this.ProjectAddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudBudget)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.Label lblBudget;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.NumericUpDown nudBudget;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.TextBox txtProjects;
        private System.Windows.Forms.Button btnAddProject;
        private System.Windows.Forms.Button Return;
    }
}