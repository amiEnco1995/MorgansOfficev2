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
    public partial class EmployeeAddForm : Form
    {
        private DataController DC;
        private MainForm frmMenu;

        public EmployeeAddForm(DataController dc, MainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
        }
        public void DisplayEmployees()
        {
            string employeeText = "";
            txtEmployees.Text = "";

            foreach(DataRow drEmployee in DC.dtEmployee.Rows)
            {
                employeeText += drEmployee["LastName"] + ", ";
                employeeText += drEmployee["FirstName"] + " - Address: ";
                employeeText += drEmployee["StreetAddress"] + ", ";
                employeeText += drEmployee["Suburb"] + "\r\n";
                txtEmployees.Text += employeeText;
                employeeText = ""; 
            }
        } private void LoadDepartments()
        {
            cboDepartmentName.DataSource = DC.dsMorgan;
            cboDepartmentName.DisplayMember = "Department.DepartmentName";
            cboDepartmentName.ValueMember = "Department.DepartmentName";
            cboDepartmentID.DataSource = DC.dsMorgan;
            cboDepartmentID.DisplayMember = "Department.DepartmentID";
            cboDepartmentID.ValueMember = "Department.DepartmentID";
        }
        private void ClearFields()
        {
            txtLastName.Text = "";
            txtFirstName.Text = "";
            txtStreetAddress.Text = "";
            txtSuburb.Text = "";
            txtPhoneNumber.Text = "";
            nudHourlyRate.Value = 30;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();

        }

        private void EmployeeAddForm_Load(object sender, EventArgs e)
        {
            LoadDepartments();
            DisplayEmployees();

        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            DataRow newEmployeeRow = DC.dtEmployee.NewRow();
            if ((txtFirstName.Text == "") || (txtFirstName.Text == "") || (txtStreetAddress.Text == "") || (txtSuburb.Text == "") || (txtPhoneNumber.Text == ""))
            {
                MessageBox.Show("You are missing one or more fields", "Error");
            }
            else
            {
              try
                {
                    newEmployeeRow["LastName"] = txtLastName.Text;
                    newEmployeeRow["FirstName"] = txtFirstName.Text;
                    newEmployeeRow["StreetAddress"] = txtStreetAddress.Text;
                    newEmployeeRow["Suburb"] = txtSuburb.Text;
                    newEmployeeRow["PhoneNumber"] = txtPhoneNumber.Text;
                    newEmployeeRow["HourlyRate"] = nudHourlyRate.Value;
                    newEmployeeRow["DepartmentID"] = cboDepartmentID.Text;
                    DC.dtEmployee.Rows.Add(newEmployeeRow);
                    MessageBox.Show("Employee added successfully", "Success");
                    DC.UpdateEmployee();
                    DisplayEmployees();
                    ClearFields();
                }
                catch
                {
                    MessageBox.Show("Please enter a number for hourly rate", "Error"); 
                }
            }
        }   
         
            

    }
}
