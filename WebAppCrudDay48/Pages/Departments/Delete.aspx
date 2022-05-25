<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Delete.aspx.cs" Inherits="WebAppCrudDay48.Pages.Departments.Delete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Delete Department</title>
     <link rel="stylesheet" href="/css/style.css" />
</head>
<body>
   <form id="form1" class="Createform" runat="server">
        <div class="status-message">
            <asp:Label runat="server" id="LabelStatus" Visible="false" />
        </div>
       
        <div>
            <table >
                 <thead><tr><th></th><th><p>Delete New Department</p><hr/></th></tr></thead>
                <tr>
                    <td>
                        <asp:Label runat="server" ID="LabelName">Name : </asp:Label></td>
                    <td>
                        <asp:TextBox runat="server" ID="TextBoxName" placeholder="Enter Department Name" 
                                     MaxLength="50"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="vertical-align: top;">
                        <asp:Label runat="server" ID="LabelDescription">Description : </asp:Label>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="TextBoxDescription" placeholder="Department Description" 
                                     TextMode="MultiLine" MaxLength="500"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button runat="server" ID="ButtonCreate" Text="Delete"  OnClick="ButtonDelete_OnClick"/>
                        <a style="float: right" href="Deafult.aspx"><input type="button" value="Back to Listing" /></a>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
