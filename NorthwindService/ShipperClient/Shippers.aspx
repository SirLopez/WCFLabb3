<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Shippers.aspx.cs" Inherits="ShipperClient.Shippers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" style="background-color: #00FFFF; padding: 100px; margin: 100px">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="EDIT SHIPPER INFORMATION"></asp:Label>
    
    </div>
        <p>
            <asp:Label ID="Label6" runat="server" Text="Enter Shipper Code:"></asp:Label>
        </p>
        <asp:TextBox ID="TextBoxInsertShipperID" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="ButtonGetShipper" runat="server" OnClick="ButtonGetShipper_Click" Text="Get Shipper" />
        </p>
        <asp:Label ID="Label3" runat="server" Text="EDIT SHIPPER DATA"></asp:Label>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Shipper Id:"></asp:Label>
        </p>
        <asp:TextBox ID="TextBoxShowShipperID" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="Label4" runat="server" Text="Compane name:"></asp:Label>
        </p>
        <asp:TextBox ID="TextBoxShowCompanyName" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="Label5" runat="server" Text="Phone"></asp:Label>
        </p>
        <asp:TextBox ID="TextBoxShowPhone" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="ButtonSave" runat="server" OnClick="ButtonSave_Click" Text="Save" />
        </p>
    </form>
</body>
</html>
