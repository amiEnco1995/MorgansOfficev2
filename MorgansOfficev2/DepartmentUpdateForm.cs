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
    public partial class DepartmentUpdateForm : Form
    {
        private DataController DC;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;
        public DepartmentUpdateForm(DataController dc, MainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
            BindControls();
        }
        public void BindControls()
        {
            txtDepartmentID.DataBindings.Add("Text", DC.dsMorgan, "Department.DepartmentID");
            txtDepartmentName.DataBindings.Add("Text", DC.dsMorgan, "Department.DepartmentName");
            txtLocation.DataBindings.Add("Text", DC.dsMorgan, "Department.Location");
            lstDepartments.DataSource = DC.dsMorgan; // make sure to use a list box and not a text box
            lstDepartments.DisplayMember = "Department.DepartmentName";
            lstDepartments.ValueMember = "Department.DepartmentName";
            currencyManager = (CurrencyManager)this.BindingContext[DC.dsMorgan, "Department"]; 
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();

        }

        private void btnUpdateDepartment_Click(object sender, EventArgs e)
        {
            DataRow updateDepartmentRow = DC.dtDepartment.Rows[currencyManager.Position];
            if ((txtDepartmentName.Text == "") || (txtLocation.Text == ""))
            {
                MessageBox.Show("You must enter a value for each of the text fields", "Error");
                return;
            }
            else
            {
                updateDepartmentRow["DepartmentName"] = txtDepartmentName.Text;
                updateDepartmentRow["Location"] = txtLocation.Text;
                currencyManager.EndCurrentEdit();
                DC.UpdateDepartment();
                MessageBox.Show("Department updated successfully", "Success");
            }
        }
    }
}
