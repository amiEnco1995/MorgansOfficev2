using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MorgansOfficev2
{
    public partial class ProjectAddForm : Form
    {
        private DataController DC;
        private MainForm frmMenu;
        public ProjectAddForm(DataController dc, MainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide(); 
        }
        public void  DisplayProjects()
        {
            string projectText = "";
            txtProjects.Text = "";
            
            foreach (DataRow drProject in DC.dtProject.Rows)
            {
                projectText += "Project ID: " + drProject["projectID"] + ", ";
                projectText += drProject["ProjectName"] + ", ";
                projectText += drProject["Status"] + "\r\n";
                txtProjects.Text += projectText;
                projectText = "";
            }
        } 
        private void clearFields()
          {
            txtProjectName.Text = "";
            nudBudget.Value = 10000;
            dtpStartDate.Value = DateTime.Today;
            txtNotes.Text = "";
           }

        private void Return_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();

        }

        private void ProjectAddForm_Load(object sender, EventArgs e)
        {
            DisplayProjects();
        }

        private void btnAddProject_Click(object sender, EventArgs e)
        {
            if (txtProjectName.Text == "" || nudBudget.Text == "")
            {
                MessageBox.Show("One or more fields is blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataRow newProjectRow = DC.dtProject.NewRow();
                newProjectRow["ProjectName"] = txtProjectName.Text;
                newProjectRow["Budget"] = nudBudget.Value;
                newProjectRow["StartDate"] = dtpStartDate.Value;
                newProjectRow["Status"] = cboStatus.Text;
                newProjectRow["Notes"] = txtNotes.Text;
                DC.dsMorgan.Tables["Project"].Rows.Add(newProjectRow);
                DC.UpdateProject();
                DisplayProjects();
                MessageBox.Show("Project created successfully", "Acknowledgement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearFields();

            }
        }
    }
}
