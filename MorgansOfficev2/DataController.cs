using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace MorgansOfficev2
{
    public partial class DataController : Form
    {
        public DataTable dtEmployee;
        public DataTable dtAssignment;
        public DataTable dtDepartment;
        public DataTable dtProject;

        public DataView employeeView;
        public DataView assignmentView;
        public DataView departmentView;
        public DataView projectView; 
        public DataController()
        {
            InitializeComponent();
            dsMorgan.EnforceConstraints = false;
            daEmployee.Fill(dsMorgan);
            daAssignment.Fill(dsMorgan);
            daDepartment.Fill(dsMorgan);
            daProject.Fill(dsMorgan);
            dtEmployee = dsMorgan.Tables["Employee"];
            dtAssignment = dsMorgan.Tables["Assignment"];
            dtDepartment = dsMorgan.Tables["Department"];
            dtProject = dsMorgan.Tables["Project"];
          
            employeeView = new DataView(dtEmployee);
            employeeView.Sort = "EmployeeID";
            assignmentView = new DataView(dtAssignment);
            assignmentView.Sort = "EmployeeID,ProjectID";
            departmentView = new DataView(dtDepartment);
            departmentView.Sort = "DepartmentID";
            projectView = new DataView(dtProject);
            projectView.Sort = "ProjectID";
            dsMorgan.EnforceConstraints = true;
        }
        public void UpdateDepartment()
        {
            daDepartment.Update(dsMorgan, "Department");
        }

        private void daDepartment_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            // Include a variable and a command to retrieve 
            // the identity value from the Access Database
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnMorgan);
            if (e.StatementType == StatementType.Insert)
            {
                // Retrieve the identity value and
                // store it in the DepartmentID column
                newID = (int)idCMD.ExecuteScalar();
                e.Row["DepartmentID"] = newID;
            }
            

            
        }
        public void UpdateProject()
        {
            daProject.Update(dsMorgan, "Project");
        }

        private void daProject_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            // Include a variable and a command to retrieve 
            // the identity value from the Access Database
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnMorgan);
            if (e.StatementType == StatementType.Insert)
            {
                // Retrieve the identity value and
                // store it in the DepartmentID column
                newID = (int)idCMD.ExecuteScalar();
                e.Row["ProjectID"] = newID;
            }
        }
        public void UpdateEmployee()
        {
            daEmployee.Update(dsMorgan, "Employee");
        }

        private void daEmployee_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            // Include a variable and a command to retrieve 
            // the identity value from the Access Database
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnMorgan);
            if (e.StatementType == StatementType.Insert)
            {
                // Retrieve the identity value and
                // store it in the DepartmentID column
                newID = (int)idCMD.ExecuteScalar();
                e.Row["EmployeeID"] = newID;
            }
        }

        public void UpdateAssignment()
        {
            daAssignment.Update(dsMorgan, "Assignment");
        }


    }




}
