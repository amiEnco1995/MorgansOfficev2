
namespace MorgansOfficev2
{
    partial class ProjectDeleteForm
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
            this.lblStatus = new System.Windows.Forms.Label();
            this.lstProjects = new System.Windows.Forms.ListBox();
            this.btnDeleteProject = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.txtProjectID = new System.Windows.Forms.TextBox();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblProjectID
            // 
            this.lblProjectID.AutoSize = true;
            this.lblProjectID.Location = new System.Drawing.Point(461, 51);
            this.lblProjectID.Name = "lblProjectID";
            this.lblProjectID.Size = new System.Drawing.Size(100, 24);
            this.lblProjectID.TabIndex = 0;
            this.lblProjectID.Text = "Project ID: ";
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.Location = new System.Drawing.Point(434, 133);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(127, 24);
            this.lblProjectName.TabIndex = 1;
            this.lblProjectName.Text = "Project Name:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(494, 230);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(67, 24);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Status:";
            // 
            // lstProjects
            // 
            this.lstProjects.FormattingEnabled = true;
            this.lstProjects.ItemHeight = 24;
            this.lstProjects.Location = new System.Drawing.Point(47, 43);
            this.lstProjects.Name = "lstProjects";
            this.lstProjects.Size = new System.Drawing.Size(305, 364);
            this.lstProjects.TabIndex = 3;
            // 
            // btnDeleteProject
            // 
            this.btnDeleteProject.Location = new System.Drawing.Point(420, 349);
            this.btnDeleteProject.Name = "btnDeleteProject";
            this.btnDeleteProject.Size = new System.Drawing.Size(154, 58);
            this.btnDeleteProject.TabIndex = 4;
            this.btnDeleteProject.Text = "Delete Project";
            this.btnDeleteProject.UseVisualStyleBackColor = true;
            this.btnDeleteProject.Click += new System.EventHandler(this.btnDeleteProject_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(705, 349);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(154, 58);
            this.btnReturn.TabIndex = 5;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // txtProjectID
            // 
            this.txtProjectID.Enabled = false;
            this.txtProjectID.Location = new System.Drawing.Point(575, 43);
            this.txtProjectID.MaxLength = 3;
            this.txtProjectID.Name = "txtProjectID";
            this.txtProjectID.Size = new System.Drawing.Size(52, 32);
            this.txtProjectID.TabIndex = 6;
            // 
            // txtProjectName
            // 
            this.txtProjectName.Enabled = false;
            this.txtProjectName.Location = new System.Drawing.Point(575, 125);
            this.txtProjectName.MaxLength = 50;
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(284, 32);
            this.txtProjectName.TabIndex = 7;
            // 
            // cboStatus
            // 
            this.cboStatus.Enabled = false;
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(574, 225);
            this.cboStatus.MaxLength = 9;
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(94, 32);
            this.cboStatus.TabIndex = 8;
            // 
            // ProjectDeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 432);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.txtProjectName);
            this.Controls.Add(this.txtProjectID);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDeleteProject);
            this.Controls.Add(this.lstProjects);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblProjectName);
            this.Controls.Add(this.lblProjectID);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProjectDeleteForm";
            this.Text = "Delete Projects";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProjectID;
        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ListBox lstProjects;
        private System.Windows.Forms.Button btnDeleteProject;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.TextBox txtProjectID;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.ComboBox cboStatus;
    }
}