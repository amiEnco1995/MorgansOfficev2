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
    public partial class ProjectDeleteForm : Form
    { // create global variables
        private DataController DC;
        private MainForm frmMenu;
        private CurrencyManager cmProject;
        public ProjectDeleteForm(DataController dc, MainForm mnu)
        { // call these methods upon form initialization 
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide(); // hide main menu form
            BindControls();
        }
        public void BindControls()
        { // bind controls to their equivalent values in the Project table 
            txtProjectID.DataBindings.Add("Text", DC.dsMorgan, "Project.ProjectID");
            txtProjectName.DataBindings.Add("Text", DC.dsMorgan, "Project.ProjectName");
            cboStatus.DataBindings.Add("Text", DC.dsMorgan, "Project.Status");
            lstProjects.DataSource = DC.dsMorgan;
            lstProjects.DisplayMember = "Project.ProjectName";
            lstProjects.ValueMember = "Project.ProjectName";
            cmProject = (CurrencyManager)this.BindingContext[DC.dsMorgan, "Project"]; 
        }

        private void btnReturn_Click(object sender, EventArgs e)
        { // hide current form and display Main menu form 
            this.Hide();
            frmMenu.Show();
        }

        private void btnDeleteProject_Click(object sender, EventArgs e)
        {// check whether a project has assignments allocated to it
            DataRow deleteProjectRow = DC.dtProject.Rows[cmProject.Position];
            DataRow[] drAssignments = deleteProjectRow.GetChildRows(DC.dtDepartment.ChildRelations["PROJECT_ASSIGNMENT"]);
            if (drAssignments.Length == 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this project?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                { // delete project row
                    deleteProjectRow.Delete();
                    DC.UpdateProject();
                    MessageBox.Show("Project deleted successfully", "Acknowledgement", MessageBoxButtons.OK);
                }
            }
            else
            {  // error message, deletion unsuccessful 
                MessageBox.Show("This project has employees allocated and cannot be deleted", "Error");
            }

        }
    }   
    

    
}
