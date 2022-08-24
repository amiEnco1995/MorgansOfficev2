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
    public partial class MainForm : Form
    {
        private DataController DC;                          // the reference to the form that holds the data controls
        private DepartmentAddForm frmDepartmentAdd;         // the reference to the add department form
        private DepartmentUpdateForm frmDepartmentUpdate;   // the reference to update department form
        private DepartmentDeleteForm frmDepartmentDelete;   // the reference to delete department form
        private DepartmentReportForm frmDepartmentReport;   // the reference to departments' report form
      
        private EmployeeAddForm frmEmployeeAdd;             // the reference to add employee form
        private EmployeeUpdateForm frmEmployeeUpdate;       // the reference to update employee form
        private EmployeeDeleteForm frmEmployeeDelete;       // the reference to delete employee form
        private EmployeeReportForm frmEmployeeReport;       // the reference to employee report form
       
        private ProjectAddForm frmProjectAdd;               // the reference to add project form
        private ProjectUpdateForm frmProjectUpdate;         // the reference to project update form
        private ProjectDeleteForm frmProjectDelete;         // the reference to project delete form
        private ProjectsReportForm frmProjectReport;        // the reference to project report form
       
        private EmployeeAssignForm frmEmployeeAssign;       // the reference to assign employee form
        private AssignmentUpdateForm frmAssignmentUpdate;   // the reference to update assignment form
        private EmployeeRemoveForm frmEmployeeRemove;       // the reference to remove employee form

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DC = new DataController(); //create the data controller and load the dataset
        }

        private void btnDepartmentsReport_Click(object sender, EventArgs e)
        {
            if (frmDepartmentReport == null)
            {
                frmDepartmentReport = new DepartmentReportForm(DC, this);
            }
            frmDepartmentReport.ShowDialog();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEmployeesReport_Click(object sender, EventArgs e)
        {
            if (frmEmployeeReport == null)
            {
                frmEmployeeReport = new EmployeeReportForm(DC, this);
            }
            frmEmployeeReport.ShowDialog();

        }

        private void btnAddDepartments_Click(object sender, EventArgs e)
        {
            if (frmDepartmentAdd == null)
            {
                frmDepartmentAdd = new DepartmentAddForm(DC, this);
            }
            frmDepartmentAdd.ShowDialog();

        }

        private void btnAddProjects_Click(object sender, EventArgs e)
        {
            if (frmProjectAdd == null)
            {
                frmProjectAdd = new ProjectAddForm(DC, this);
            }
            frmProjectAdd.ShowDialog();

        }

        private void btnAddEmployees_Click(object sender, EventArgs e)
        {
            if (frmEmployeeAdd == null)
            {
                frmEmployeeAdd = new EmployeeAddForm(DC, this);
            }
            frmEmployeeAdd.ShowDialog();

        }

        private void btnUpdateDepartments_Click(object sender, EventArgs e)
        {
            if (frmDepartmentUpdate == null)
            {
                frmDepartmentUpdate = new DepartmentUpdateForm(DC, this);
            }
            frmDepartmentUpdate.ShowDialog();

        }

        private void btnUpdateProjects_Click(object sender, EventArgs e)
        {
            if (frmProjectUpdate == null)
            {
                frmProjectUpdate = new ProjectUpdateForm(DC, this);
            }
            frmProjectUpdate.ShowDialog();

        }

        private void btnUpdateEmployees_Click(object sender, EventArgs e)
        {
            if (frmEmployeeUpdate == null)
            {
                frmEmployeeUpdate = new EmployeeUpdateForm(DC, this);
            }
            frmEmployeeUpdate.ShowDialog();

        }

        private void btnDeleteDepartments_Click(object sender, EventArgs e)
        { // opens the Department Delete Form

            if (frmDepartmentDelete == null)
            {
                frmDepartmentDelete = new DepartmentDeleteForm(DC, this);
            }
            frmDepartmentDelete.ShowDialog();

        }

        private void btnDeleteProjects_Click(object sender, EventArgs e)
        { // opens the Delete Project form 
            if (frmProjectDelete == null)
            {
                frmProjectDelete = new ProjectDeleteForm(DC, this);
            }
            frmProjectDelete.ShowDialog();

        }

        private void btnDeleteEmployees_Click(object sender, EventArgs e)
        { // opens the Delete Employees form 
            if (frmEmployeeDelete == null)
            {
                frmEmployeeDelete = new EmployeeDeleteForm(DC, this);
            }
            frmEmployeeDelete.ShowDialog();

        }

        private void btnAssignEmployees_Click(object sender, EventArgs e)
        { // opens employee assign form
            if (frmEmployeeAssign == null)
            {
                frmEmployeeAssign = new EmployeeAssignForm(DC, this);
            }
            frmEmployeeAssign.ShowDialog();

        }

        private void btnRemoveEmployees_Click(object sender, EventArgs e)
        { // opens the employee remove form 
            if (frmEmployeeRemove == null)
            {
                frmEmployeeRemove = new EmployeeRemoveForm(DC, this);
            }
            frmEmployeeRemove.ShowDialog();

        }
    }
}
