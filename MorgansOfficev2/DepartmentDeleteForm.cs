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
    public partial class DepartmentDeleteForm : Form
    { // create global variables
        private DataController DC;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;
        public DepartmentDeleteForm( DataController dc, MainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
            BindControls();
        }
        public void BindControls()
        {// binding the controls to their equivalent value in the Department Table 
            txtDepartmentID.DataBindings.Add("Text", DC.dsMorgan, "Department.DepartmentID");
            txtDepartmentName.DataBindings.Add("Text", DC.dsMorgan, "Department.DepartmentName");
            txtLocation.DataBindings.Add("Text", DC.dsMorgan, "Department.Location");
            lstDepartments.DataSource = DC.dsMorgan;
            lstDepartments.DisplayMember = "Department.DepartmentName";
            lstDepartments.ValueMember = "Department.DepartmentName";
            currencyManager = (CurrencyManager)this.BindingContext[DC.dsMorgan, "Department"];
        }

        private void btnReturn_Click(object sender, EventArgs e)
        { // hide current form and return user to the main menu 
            this.Hide();
            frmMenu.Show();

        }

        private void btnDeletedDepartment_Click(object sender, EventArgs e)
        { // check whether a department has employees allocated to it
            DataRow deleteDepartmentRow = DC.dtDepartment.Rows[currencyManager.Position];
            DataRow[] drEmployees = deleteDepartmentRow.GetChildRows(DC.dtDepartment.ChildRelations["DEPARTMENT_EMPLOYEE"]);
            if (drEmployees.Length == 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this department?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                { // delete department row
                    deleteDepartmentRow.Delete();
                    DC.UpdateDepartment();
                    MessageBox.Show("Department deleted successfully", "Acknowledgement", MessageBoxButtons.OK);
                }
            }
            else
            {  // error message, deletion unsuccessful 
                MessageBox.Show("This department has employees allocated and cannot be deleted", "Error"); 
            }
        }
    }
}
