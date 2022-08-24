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
    public partial class EmployeeAssignForm : Form
    {
        private DataController DC;
        private MainForm frmMenu;
        private CurrencyManager cmEmployee;
        private CurrencyManager cmProject;
        
        private CurrencyManager cmEmployeeAssignment;
        public EmployeeAssignForm(DataController dc, MainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
            BindControls();

        }
        public void BindControls()
        { // binding the data grid views with the specified tables 
            cmEmployee = (CurrencyManager)this.BindingContext[DC.dsMorgan, "Employee"];
            cmProject = (CurrencyManager)this.BindingContext[DC.dsMorgan, "Project"];

            cmEmployeeAssignment = (CurrencyManager)this.BindingContext[DC.dsMorgan, "Employee.Employee_Assignment"];

            dgvEmployees.DataSource = DC.dsMorgan;
            dgvEmployees.DataMember = "Employee";

            dgvProjects.DataSource = DC.dsMorgan;
            dgvProjects.DataMember = "Project";

             dgvAssignments.DataSource = DC.dsMorgan;
             dgvAssignments.DataMember = "Employee.Employee_Assignment"; // make sure to spell your associations properly in the dataset view
            
            

        }

        private void btnReturn_Click(object sender, EventArgs e)
        { // hide current form and show main menu form 
            this.Hide();
            frmMenu.Show();

        }

        private void btnAssignEmployee_Click(object sender, EventArgs e)
        { // if it doesn't work and says for example ProjecID can't be found, try removing project ID from dgvProjects then add it again
            //remove and re-add column from data grid view if it can't be found initially 
            try
            {   if (cmProject.Position != -1)
                {

                    DataRow newAssignment = DC.dtAssignment.NewRow();
                    newAssignment["ProjectID"] = dgvProjects["ProjectID", cmProject.Position].Value;
                    newAssignment["EmployeeID"] = dgvEmployees["EmployeeID", cmEmployee.Position].Value;
                    newAssignment["Hours"] = nudHours.Value;
                    DC.dsMorgan.Tables["Assignment"].Rows.Add(newAssignment);
                    DC.UpdateAssignment();
                    MessageBox.Show("Project successfully assigned to the employee", "Acknowledgement", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                } else
                {
                    MessageBox.Show("Please select a project to assign to the employee", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            catch (System.Data.ConstraintException)
            {
                MessageBox.Show("Employee is already assigned to that project", "Error");
            }
        }
    }
}
