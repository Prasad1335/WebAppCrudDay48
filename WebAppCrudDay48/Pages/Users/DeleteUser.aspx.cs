using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApp.services;
using WebApp.services.Utilities;

namespace WebAppCrudDay48.Pages.Users
{
    public partial class DeleteUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ShowDataToDelete();
        }

        protected void ButtonDelete_OnClick(object sender, EventArgs e)
        {
            DeleteData();
        }

        private void ShowDataToDelete()
        {
            var idText = Request.QueryString["id"];
            try
            {
                var id = int.Parse(idText);

                var userService = new UserServices();

                var user = userService.GetById(id);

                if (user == null)
                {
                    Label labelStatus = LabelStatus;
                    labelStatus.ShowStatusMessage("Specified Id not found in database!");
                    return;
                }

               TextBoxFirstName.Text = user.LastName;
               TextBoxLastName.Text = user.LastName;
               TextBoxDateOfBirth.Text = user.DateOfBirth.ToString();
               TextBoxPan.Text = user.Pan;
               TextBoxAddress.Text = user.Address;
               TextBoxEmail.Text = user.Email;
               //TextBoxMobileNumber.Text = user.MobileNumber;
               TextBoxEmail.Text = user.Email;
               TextBoxComments.Text = user.Comments;
               // LabelDepartmentId.Text = user.DepartmentRefId.ToString();

            }
            catch (Exception)
            {
                LabelStatus.ShowStatusMessage("Id parameter not found!");
            }
        }

        private void DeleteData()
        {
            var idText = Request.QueryString["id"];
            var id = int.Parse(idText);

            var userService = new UserServices();

            try
            {
                userService.Delete(id);

                LabelStatus.ShowStatusMessage("User record successfully deleted!");
            }
            catch (SqlException sqlException)
            {
                Console.WriteLine(sqlException);
                LabelStatus.ShowStatusMessage("Failed to delete User record! Maybe a foreign key was found! Please contact database admin!");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                LabelStatus.ShowStatusMessage("Failed to delete User record!");
            }
        }
    }
}