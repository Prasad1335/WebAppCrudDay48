<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeleteUser.aspx.cs" Inherits="WebAppCrudDay48.Pages.Users.DeleteUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="/css/style.css" />
</head>
<body>
    <form id="form1" class="Createform" runat="server">
        <div class="status-message">
            <asp:Label runat="server" ID="LabelStatus" Visible="false" />
        </div>
        <div>
            <table>
                <thead>
                    <tr>
                        <th></th>
                        <th>
                            <p>Delete User</p>
                            <hr />
                        </th>
                    </tr>
                </thead>
                <thead>
                    <tr>
                        <td>
                            <asp:Label runat="server" ID="LabelFirstName">FirstName : </asp:Label></td>
                        <td>
                            <asp:TextBox runat="server" ID="TextBoxFirstName" placeholder="Enter User First Name" MaxLength="50"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" ID="LabelLastName">LastName : </asp:Label></td>
                        <td>
                            <asp:TextBox runat="server" ID="TextBoxLastName" placeholder="Enter User Last Name" MaxLength="50"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" ID="LabelDateOfBirth">DateOfBirth : </asp:Label></td>
                        <td>
                            <asp:TextBox runat="server" Class="dob" TextMode="Date" ID="TextBoxDateOfBirth"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" ID="LabelPan">Pan Number : </asp:Label></td>
                        <td>
                            <asp:TextBox runat="server" ID="TextBoxPan" placeholder="Enter User Pan" MaxLength="10"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" ID="LabelAddress">Address : </asp:Label></td>
                        <td>
                            <asp:TextBox runat="server" ID="TextBoxAddress" placeholder="Enter User Address" MaxLength="200"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" ID="LabelGender">Gender : </asp:Label></td>

                        <td>
                            <asp:RadioButton ID="RadioButtonmale" runat="server" GroupName="gender" />
                            <asp:Label ID="Labelmale" runat="server" class="radio" Text="Male"></asp:Label>
                            <asp:RadioButton ID="RadioButtonFemale" runat="server" GroupName="gender" />
                            <asp:Label ID="LabelFemale" runat="server" class="radio" Text="Female"></asp:Label>
                            <asp:RadioButton ID="RadioButtonOther" runat="server" GroupName="gender" />
                            <asp:Label ID="LabelOther" runat="server" class="radio" Text="Other"></asp:Label>

                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" ID="LabelMobileNumber">MobileNumber : </asp:Label></td>
                        <td>
                            <asp:TextBox runat="server" ID="TextBoxMobileNumber" placeholder="Enter User MobileNumber" MaxLength="12"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" ID="LabelEmail">Email : </asp:Label></td>
                        <td>
                            <asp:TextBox runat="server" ID="TextBoxEmail" placeholder="Enter User Email" MaxLength="55"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" ID="LabelComments">Comments : </asp:Label></td>
                        <td>
                            <asp:TextBox runat="server" ID="TextBoxComments" placeholder="Enter user Comments"
                                TextMode="MultiLine" MaxLength="500"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" ID="LabelDepartmentId">DepartmentId : </asp:Label></td>
                        <td>
                            <asp:TextBox runat="server" ID="TextBoxDepartmentId" placeholder="Enter User DepartmentId" MaxLength="2"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td>
                            <asp:Button runat="server" ID="ButtonDelete" Text="Delete" OnClick="ButtonDelete_OnClick" />
                            <a style="float: right" href="DeafultUser.aspx">
                                <input type="button" value="Back to Listing" /></a>
                        </td>
                    </tr>

                </thead>
            </table>
        </div>

    </form>

</body>
</html>
