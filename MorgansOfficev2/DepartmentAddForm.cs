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
    public partial class DepartmentAddForm : Form
    {
        private DataController DC;
        private MainForm frmMenu;

        public DepartmentAddForm(DataController dc, MainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
        }
        public void DisplayDepartments()
        {
            string departmentText = "";
            txtDepartments.Text = ""; 
            foreach (DataRow drDepartment in DC.dtDepartment.Rows)
            {
                departmentText += "Department ID: " + drDepartment["DepartmentID"] + ", ";
                departmentText += drDepartment["DepartmentName"] + ", ";
                departmentText += drDepartment["Location"] + "\r\n";
                txtDepartments.Text += departmentText;
                departmentText = ""; 
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
        }

        private void DepartmentAddForm_Load(object sender, EventArgs e)
        {
            DisplayDepartments();
        }

        private void btnAddDepartment_Click(object sender, EventArgs e)
        {
            if (txtDepartmentName.Text == "" || txtLocation.Text == "")
            {
                MessageBox.Show("One or more fields is blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataRow newDepartmentRow = DC.dtDepartment.NewRow(); // create a new department row
                newDepartmentRow["DepartmentName"] = txtDepartmentName.Text; // set department name for the new row
                newDepartmentRow["Location"] = txtLocation.Text; // set location for the new row
                DC.dsMorgan.Tables["Department"].Rows.Add(newDepartmentRow); // add the new row to the table
                DC.UpdateDepartment();
                DisplayDepartments();
                MessageBox.Show("Department added successfully", "Acknowledgement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDepartmentName.Text = "";
                txtLocation.Text = "";

            }
        }
    }
}
