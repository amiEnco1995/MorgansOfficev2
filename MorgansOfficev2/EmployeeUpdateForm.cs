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
    public partial class EmployeeUpdateForm : Form
    {
        private DataController DC;
        private MainForm frmMenu;
        private CurrencyManager cmEmployee;
        private CurrencyManager cmDepartment;

        public EmployeeUpdateForm(DataController dc, MainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            BindControls();
          //  DC.employeeView.RowFilter = "Suburb = 'Mt Albert'"; // filter employee view to only where Suburb = Mt Albert
            frmMenu.Hide();
        }
        public void BindControls()
        {
            txtLastName.DataBindings.Add("Text", DC.dsMorgan, "Employee.LastName");
            txtFirstName.DataBindings.Add("Text", DC.dsMorgan, "Employee.FirstName");
            txtStreetAddress.DataBindings.Add("Text", DC.dsMorgan, "Employee.StreetAddress");
            txtSuburb.DataBindings.Add("Text", DC.dsMorgan, "Employee.Suburb");
            txtPhoneNumber.DataBindings.Add("Text", DC.dsMorgan, "Employee.PhoneNumber");
            nudHourlyRate.DataBindings.Add("Value", DC.dsMorgan, "Employee.HourlyRate");

            txtDepartmentID.DataBindings.Add("Text", DC.dsMorgan, "Employee.DepartmentID");



            cmDepartment = (CurrencyManager)this.BindingContext[DC.dsMorgan, "Department"];
            cmEmployee = (CurrencyManager)this.BindingContext[DC.dsMorgan, "Employee"];

            // dgvEmployees.DataSource = DC.employeeView; // data grid view uses data source that has been filtered where Suburb = Mt Alber 
            dgvEmployees.DataSource = DC.dsMorgan;
            dgvEmployees.DataMember = "Employee"; 

            

            
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            
            DataRow updateEmployeeRow = DC.dtEmployee.Rows[cmEmployee.Position];
            if ((txtFirstName.Text == "") || (txtLastName.Text == "") || (txtPhoneNumber.Text == "") || (txtStreetAddress.Text == "") || (txtSuburb.Text == "") || (nudHourlyRate.Text == ""))
            {
                MessageBox.Show("You must enter a value for each of the required fields", "Error");
             
            }
            else
            {
                    updateEmployeeRow["LastName"] = txtLastName.Text;
                    updateEmployeeRow["FirstName"] = txtFirstName.Text;
                    updateEmployeeRow["StreetAddress"] = txtStreetAddress.Text;
                    updateEmployeeRow["Suburb"] = txtSuburb.Text;
                    updateEmployeeRow["PhoneNumber"] = txtPhoneNumber.Text;
                    updateEmployeeRow["HourlyRate"] = nudHourlyRate.Value;
                    cmEmployee.EndCurrentEdit();
                    DC.UpdateEmployee();
                    MessageBox.Show("Employee updated successfully", "Success");
                
                
            }
        }

       

        private void dgvEmployees_Click(object sender, EventArgs e)
        {  // obtain the department name from clicking on an employee on the Employee data grid view table
            string departmentText = "";
            if (cmEmployee.Position != -1)
            {
                int departmentID = Convert.ToInt32(txtDepartmentID.Text); // alternative
                //int departmentID = Convert.ToInt32(dgvEmployees["DepartmentID", cmEmployee.Position].Value);
                cmDepartment.Position = DC.departmentView.Find(departmentID);
                DataRow drDepartment = DC.dtDepartment.Rows[cmDepartment.Position];
                departmentText = drDepartment["DepartmentName"].ToString();
                lstDepartment.Items.Clear(); // refresh the list 
                lstDepartment.Items.Add(departmentText);
            }
        }

       
    }
}
