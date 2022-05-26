using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApp.services;
using WebApp.services.Models;
using WebApp.services.Utilities;

namespace WebAppCrudDay48.Pages.Users
{
    public partial class CreateUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void ButtonCreate_OnClick(object sender, EventArgs e)
        {
            CreateData();
        }

        private void CreateData()
        {
            var userService = new UserServices();

            try
            {

                var user = new User
                {
                    FirstName = TextBoxFirstName.Text,
                    LastName = TextBoxLastName.Text,
                    DateOfBirth = DateTime.Parse(TextBoxDateOfBirth.Text),
                    Pan = TextBoxPan.Text,
                    Address = TextBoxAddress.Text,
                    Gender = TextBoxGender.Text,
                    MobileNumber = TextBoxMobileNumber.Text,
                    Email = TextBoxEmail.Text,
                    Comments = TextBoxComments.Text,
                    DepartmentRefId = int.Parse(TextBoxDepartmentRefId.Text)


                };

                userService.Add(user);

                LabelStatus.ShowStatusMessage("User record successfully added!");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                LabelStatus.ShowStatusMessage("Failed to add User record!");
            }
        }
    }
}