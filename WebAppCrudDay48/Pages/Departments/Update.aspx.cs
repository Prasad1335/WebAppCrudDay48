using System;
using WebApp.services;
using WebApp.services.Models;
using WebApp.services.Utilities;

namespace WebAppCrudDay48.Pages.Departments
{
    public partial class Update : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ShowDataToUpdate();
        }

        protected void ButtonUpdate_Click(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void UpdateData()
        {
            var departmentService = new DepartmentService();

            try
            {
                var idText = Request.QueryString["id"];

                var department = new Department
                {
                    Id = int.Parse(idText),
                    Name = TextBoxName.Text,
                    Description = TextBoxDescription.Text
                };

                departmentService.Update(department);

                LabelStatus.ShowStatusMessage("Department record successfully updated!");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                LabelStatus.ShowStatusMessage("Failed to update Department record!");
            }
        }

        private void ShowDataToUpdate()
        {
            var idText = Request.QueryString["id"];
            try
            {
                var id = int.Parse(idText);

                var departmentService = new DepartmentService();

                var department = departmentService.GetById(id);

                if (department == null)
                {
                    LabelStatus.ShowStatusMessage("Specified Id not found in database!");
                    return;
                }

                TextBoxName.Text = department.Name;
                TextBoxDescription.Text = department.Description;
            }
            catch (Exception e)
            {
                LabelStatus.ShowStatusMessage("Id parameter not found!");
            }
        }
    }
}