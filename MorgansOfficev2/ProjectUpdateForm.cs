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
    public partial class ProjectUpdateForm : Form
    {
        private DataController DC;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;

        public ProjectUpdateForm(DataController dc, MainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            BindControls();
            frmMenu.Hide();
        }
        public void BindControls()
        {
            txtProjectID.DataBindings.Add("Text", DC.dsMorgan, "Project.ProjectID");
            txtProjectName.DataBindings.Add("Text", DC.dsMorgan, "Project.ProjectName");
            nudBudget.DataBindings.Add("Value", DC.dsMorgan, "Project.Budget");
            dtpStartDate.DataBindings.Add("Text", DC.dsMorgan, "Project.StartDate");
            cboStatus.DataBindings.Add("Text", DC.dsMorgan, "Project.Status");
            txtNotes.DataBindings.Add("Text", DC.dsMorgan, "Project.Notes");
            lstProjects.DataSource = DC.dsMorgan;
            lstProjects.DisplayMember = "Project.ProjectName";
            lstProjects.ValueMember = "Project.ProjectName";
            currencyManager = (CurrencyManager)this.BindingContext[DC.dsMorgan, "Project"]; 
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
        }

        private void btnUpdateProject_Click(object sender, EventArgs e)
        {
            DataRow updateProjectRow = DC.dtProject.Rows[currencyManager.Position];
            if((txtProjectName.Text == "") || (cboStatus.Text == "") || (nudBudget.Text == "")) // ensures that status combo box and budget are not empty fields
            {
                MessageBox.Show("You must enter a value for each of the text fields", "Error");
            }
            else
            {
                updateProjectRow["ProjectName"] = txtProjectName.Text;
                updateProjectRow["Budget"] = nudBudget.Value;
                updateProjectRow["StartDate"] = dtpStartDate.Value;
                updateProjectRow["Status"] = cboStatus.Text;
                updateProjectRow["Notes"] = txtNotes.Text;
                currencyManager.EndCurrentEdit();
                DC.UpdateProject();
                MessageBox.Show("Project updated successfully", "Success"); 
            }
        }
    }
}
