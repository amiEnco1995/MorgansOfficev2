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
    public partial class EmployeeDeleteForm : Form
    { // create global variables
        private DataController DC;
        private MainForm frmMenu;
        private CurrencyManager cmEmployee;
        public EmployeeDeleteForm(DataController dc, MainForm mnu)
        { // call these methods upon form initialization
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide(); // hides Main menu form 
            BindControls();
        }
        public void BindControls()
        { // bind the controls to their corresponding values in the Employee table 
            txtLastName.DataBindings.Add("Text", DC.dsMorgan, "Employee.LastName");
            txtFirstName.DataBindings.Add("Text", DC.dsMorgan, "Employee.FirstName");
            txtStreetAddress.DataBindings.Add("Text", DC.dsMorgan, "Employee.StreetAddress");
            txtSuburb.DataBindings.Add("Text", DC.dsMorgan, "Employee.Suburb");
            cmEmployee = (CurrencyManager)this.BindingContext[DC.dsMorgan, "Employee"];
            dgvEmployees.DataSource = DC.dsMorgan;
            dgvEmployees.DataMember = "Employee"; 
        }

        private void btnReturn_Click(object sender, EventArgs e)
        { // hide the current form and show the main menu form 
            this.Hide();
            frmMenu.Show();
        }

        private void btnDeletedEmployee_Click(object sender, EventArgs e)
        { // check whether an employee has assignments allocated to it
            DataRow deleteEmployeeRow = DC.dtEmployee.Rows[cmEmployee.Position];
            DataRow[] drAssignment = deleteEmployeeRow.GetChildRows(DC.dtEmployee.ChildRelations["EMPLOYEE_ASSIGNMENT"]);
            if(drAssignment.Length == 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this employee?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                { // delete employee row
                    deleteEmployeeRow.Delete();
                    DC.UpdateEmployee();
                    MessageBox.Show("Employee deleted successfully", "Acknowledgement", MessageBoxButtons.OK);
                }
            }
            else
            {  // error message, deletion unsuccessful 
                MessageBox.Show("This employee has projects assigned and cannot be deleted", "Error");
            }

        }

    }
    
}
