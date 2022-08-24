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
    public partial class EmployeeReportForm : Form
    {
        private DataController DC;
        private MainForm frmMenu;


        public EmployeeReportForm(DataController dc, MainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();

        }

        private void btnDisplayReport_Click(object sender, EventArgs e)
        {
            string employeeText = "";
            txtEmployees.Text = "";
            CurrencyManager cmDepartment;
            cmDepartment = (CurrencyManager)this.BindingContext[DC.dsMorgan, "Department"];

            foreach(DataRow drEmployee in DC.dtEmployee.Rows)
            {
                int aDepartmentID = Convert.ToInt32(drEmployee["DepartmentID"].ToString());
                cmDepartment.Position = DC.departmentView.Find(aDepartmentID);
                DataRow drDepartment = DC.dtDepartment.Rows[cmDepartment.Position];

                employeeText += "EmployeeID: " + drEmployee["EmployeeID"] + ", Last Name: ";
                employeeText += drEmployee["LastName"] + ", First Name: ";
                employeeText += drEmployee["FirstName"] + " Address: " + drEmployee["StreetAddress"] + ", Department Name: ";
                employeeText += drDepartment["DepartmentName"] + "\r\n\r\n";
                txtEmployees.Text += employeeText;
                employeeText = "";
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
        }
    }
}
