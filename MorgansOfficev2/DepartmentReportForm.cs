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
    public partial class DepartmentReportForm : Form
    {
        private DataController DC;
        private MainForm frmMenu;

        public DepartmentReportForm(DataController dc, MainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();

        }

        private void btnDisplayReport_Click(object sender, EventArgs e)
        {
            string departmentText = "";
            txtDepartments.Text = "";

           foreach (DataRow drDepartment in DC.dtDepartment.Rows)
            {
                departmentText += "Department ID: " + drDepartment["DepartmentID"] + ", Department Name: ";
                departmentText += drDepartment["DepartmentName"] + " Location ";
                departmentText += drDepartment["Location"] + "\r\n\r\n";
                DataRow[] drEmployees = drDepartment.GetChildRows(DC.dtDepartment.ChildRelations["DEPARTMENT_EMPLOYEE"]);
                if (drEmployees.Length == 0)
                {
                    departmentText += "This department has no employees allocated";
                }
                else
                {
                    departmentText += "Employees allocated:\r\n\r\n";
                    foreach (DataRow drEmployee in drEmployees)
                    {
                        departmentText += "Employee ID: " + drEmployee["EmployeeID"] + " Name: ";
                        departmentText += drEmployee["LastName"] + "," + drEmployee["FirstName"] + "\r\n";
                    }
                } departmentText += "\r\n\r\n-----------------------------------------------------------------------------\r\n\r\n";
            }txtDepartments.Text += departmentText;
            departmentText = "";
        }
    }
}
