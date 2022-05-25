<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Deafult.aspx.cs" Inherits="WebAppCrudDay48.Pages.Departments.Deafult" %>

<%@ Import Namespace="WebApp.services" %>
<%@ Import Namespace="WebApp.services.Utilities" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Department View All Deatils</title>
    <link rel="stylesheet" href="/css/style.css" />
</head>
<body>
     <a href="Create.aspx">Add new department</a>
    <br />
    <br />
    <form class="DeafultForm" id="form1" runat="server">

        <div>


            <table border="3" cellpadding="10">
                <caption>Department View All Deatils</caption>
                <thead class="theading">
                    <tr>
                        <td>Department Id</td>
                        <td>Department Name</td>
                        <td>Department Description</td>
                        <td colspan="2">Operation</td>
                    </tr>
                </thead>
                <tbody>

                    <%
                        var departmentService = new DepartmentService();
                        var departments = departmentService.GetAll();

                        foreach (var department in departments)
                        {
                %>
                    <tr>
                        <td><%= department.Id %></td>
                        <td><%= department.Name %></td>
                        <td><%= department.Description.GetFormattedValue() %></td>
                        <td><a href="Update.aspx?id=<%= department.Id %>">Edit</a></td>
                        <td><a href="Delete.aspx?id=<%= department.Id %>">Delete</a></td>
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
