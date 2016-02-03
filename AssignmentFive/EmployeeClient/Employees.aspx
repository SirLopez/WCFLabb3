<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Employees.aspx.cs" Inherits="EmployeeClient.Employees" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style3 {
            width: 212px;
        }
        .auto-style4 {
            width: 213px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" style="background-color: #00FF00; border: medium solid #008000">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label8" runat="server" Text="FIND EMPLOYEE"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label9" runat="server" Text="Search by id"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBoxFindEmployee" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td>
                    <asp:Button ID="ButtonFind" runat="server" OnClick="ButtonFind_Click" Text="Find" />
                </td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label11" runat="server" Text="EDIT EMPLOYEE"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="LabelID" runat="server" Text="Employee id"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBoxShowEmployeeID" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="LabelFirstname" runat="server" Text="Firstname"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBoxShowFirstname" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="LabelLastname" runat="server" Text="Lastname"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBoxShowLastname" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="LabelTitel" runat="server" Text="Titel"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBoxShowTitle" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="LabelAddress" runat="server" Text="Address"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBoxShowAddress" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="LabelCity" runat="server" Text="City"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBoxShowCity" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>
                    <asp:Button ID="ButtonSave" runat="server" OnClick="ButtonSave_Click" Text="Edit" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
