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
    public partial class UpdateUser : System.Web.UI.Page
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
            var userServices = new UserServices();

            try
            {
                var idText = Request.QueryString["id"];

                var user = new User
                {
                    Id = int.Parse(idText),

                    //FirstName = TextBoxFirstName.Text,
                    // LastName = TextBoxLastName.Text,
                    // DateOfBirth = TextBoxDateOfBirth.Text,
                    // Pan = TextBoxPan.Text,
                    // Email = TextBoxEmail.Text,
                    // MobileNumber = TextBoxMobileNumber.Text,
                    // Email = TextBoxEmail.Text,
                    // Comments = TextBoxComments.Text,
                    // DepartmentRefId = TextDepartmentRefId.Text,


                };

                //userServices.Update(user);

                LabelStatus.ShowStatusMessage("user record successfully updated!");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                LabelStatus.ShowStatusMessage("Failed to update user record!");
            }
        }

        private void ShowDataToUpdate()
        {
            var idText = Request.QueryString["id"];
            try
            {
                var id = int.Parse(idText);

                var userService = new UserServices();

                var user = userService.GetById(id);

                if (user == null)
                {
                    LabelStatus.ShowStatusMessage("Specified Id not found in database!");
                    return;
                }


                TextBoxFirstName.Text = user.LastName;
                TextBoxLastName.Text = user.LastName;
                TextBoxDateOfBirth.Text = user.DateOfBirth.ToString();
                TextBoxPan.Text = user.Pan;
                TextBoxAddress.Text = user.Address;
                TextBoxEmail.Text = user.Email;
            }
            catch (Exception)
            {
                LabelStatus.ShowStatusMessage("Id parameter not found!");
            }
        }
    }
}