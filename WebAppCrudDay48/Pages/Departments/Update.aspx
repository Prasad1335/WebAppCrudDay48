<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Update.aspx.cs" Inherits="WebAppCrudDay48.Pages.Departments.Update" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Update Department</title>
     <link rel="stylesheet" href="/css/style.css" />
</head>
<body>
    <form id="form1" class="Createform" runat="server">
        <div class="status-message">
            <asp:Label runat="server" id="LabelStatus" Visible="false" />
        </div>
       
        <div>
            <table >
                 <thead><tr><th></th><th><p>Update New Department</p><hr/></th></tr></thead>
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
                        <asp:Button runat="server" ID="ButtonUpdate" Text="Update"  OnClick="ButtonUpdate_OnClick"/>
                        <a style="float: right" href="Deafult.aspx"><input type="button" value="Back to Listing" /></a>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
