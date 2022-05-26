<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeafultUser.aspx.cs" Inherits="WebAppCrudDay48.Pages.Users.DeafultUser" %>

<%@ Import Namespace="WebApp.services" %>
<%@ Import Namespace="WebApp.services.Utilities" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>User View All Deatils</title>
    <link rel="stylesheet" href="/css/style.css" />
</head>
<body>
    <form class="defUser" id="form1" runat="server">
        <a href="CreateUser.aspx">
            <button type="button">Add new user</button></a>

        <div>


            <table border="3" cellpadding="10">
                <caption>User View All Deatils</caption>
                <thead class="theading">
                    <tr>
                        <td>Id</td>
                        <td>FirstName</td>
                        <td>LastName</td>
                        <td>DateOfBirth</td>
                        <td>Pan</td>
                        <td>Address</td>
                        <td>Gender</td>
                        <td>Mobile</td>
                        <td>Email</td>
                        <td>Comment</td>
                        <td>Department ID</td>
                        <td colspan="2">Operation</td>
                    </tr>
                </thead>
                <tbody>

                    <%
                        var userService = new UserServices();
                        var users = userService.GetAll();

                        foreach (var user in users)
                        {
                    %>
                    <tr>
                        <td><%= user.Id %></td>
                        <td><%= user.FirstName %></td>
                        <td><%= user.LastName %></td>
                        <td><%= user.DateOfBirth %></td>
                        <td><%= user.Pan %></td>
                        <td><%= user.Address %></td>
                        <td><%= user.Gender %></td>
                        <td><%= user.MobileNumber %></td>
                        <td><%= user.Email %></td>
                        <td><%= user.Comments %></td>
                        <td><%= user.Id %></td>
                        <%--<td><%= user.Email.GetFormattedValue() %></td>--%>
                        <td><a href="UpdateUser.aspx?id=<%= user.Id %>">Edit</a></td>
                        <td><a href="DeleteUser.aspx?id=<%= user.Id %>">Delete</a></td>
                    </tr>
                    <%
                        }
                    %>
                </tbody>

            </table>
        </div>
    </form>
</body>
</html>
