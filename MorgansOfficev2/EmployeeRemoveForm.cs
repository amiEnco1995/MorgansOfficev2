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
    public partial class EmployeeRemoveForm : Form
    {
        private DataController DC;
        private MainForm frmMenu;
        private CurrencyManager cmEmployee;
        private CurrencyManager cmProject;
        private CurrencyManager cmAssignment;
        private CurrencyManager cmEmployeeAssignment; 
        public EmployeeRemoveForm(DataController dc, MainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
            BindControls(); 
        }
        public void BindControls()
        {
            cmEmployee = (CurrencyManager)this.BindingContext[DC.dsMorgan, "Employee"];
            cmProject = (CurrencyManager)this.BindingContext[DC.dsMorgan, "Project"];
            cmAssignment = (CurrencyManager)this.BindingContext[DC.dsMorgan, "Assignment"];
            cmEmployeeAssignment = (CurrencyManager)this.BindingContext[DC.dsMorgan, "Employee.EMPLOYEE_ASSIGNMENT"];

            dgvEmployees.DataSource = DC.dsMorgan;
            dgvEmployees.DataMember = "Employee";

            dgvAssignments.DataSource = DC.dsMorgan;
            dgvAssignments.DataMember = "Employee.EMPLOYEE_ASSIGNMENT"; // make sure to spell your associations properly in the dataset view

        }

        private void btnReturn_Click(object sender, EventArgs e)
        { // Return user to main menu and hide current form 
            this.Hide();
            frmMenu.Show();

        }

        private void btnRemoveEmployee_Click(object sender, EventArgs e)
        {// Set all properties of the data grid view of 'AllowUsersToAddRows' = False, or else System.InvalidCastException will be thrown

           
                int aProjectID = Convert.ToInt32(dgvAssignments["ProjectID", cmEmployeeAssignment.Position].Value);
                int anEmployeeID = Convert.ToInt32(dgvAssignments["EmployeeID", cmEmployeeAssignment.Position].Value);
                object[] primaryKey = new object[2];
                primaryKey[0] = aProjectID;
                primaryKey[1] = anEmployeeID;
                cmAssignment.Position = DC.assignmentView.Find(primaryKey);
                DataRow deleteAssignmentRow = DC.dtAssignment.Rows[cmAssignment.Position];

               
               if (MessageBox.Show("Are you sure you want to remove the employee from this project", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {

                         deleteAssignmentRow.Delete();
                         DC.dtAssignment.AcceptChanges();
                         DC.UpdateAssignment();
                        MessageBox.Show("Employee removed from project", "Acknowledgement", MessageBoxButtons.OK);

                    }

               
           
        }

        private void dgvAssignments_Click(object sender, EventArgs e)
        {

           //  DataRow deleteAssignmentRow = DC.dtAssignment.Rows[cmAssignment.Position];
            if (cmEmployeeAssignment.Position != -1 )
            { // Set all properties of the data grid view of 'AllowUsersToAddRows' = False, or else System.InvalidCastException will be thrown
                    int aProjectID = Convert.ToInt32(dgvAssignments["ProjectID", cmEmployeeAssignment.Position].Value);
                    cmProject.Position = DC.projectView.Find(aProjectID);
                    DataRow drProject = DC.dtProject.Rows[cmProject.Position];
                    txtProjectName.Text = drProject["ProjectName"].ToString();
                    //txtProjectName.Text = cmEmployeeAssignment.Position.ToString(); 
                          
            } 
           
            
        }
    }
}
