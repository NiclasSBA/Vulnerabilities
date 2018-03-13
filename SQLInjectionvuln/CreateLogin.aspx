<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateLogin.aspx.cs" Inherits="SQLInjectionvuln.CreateLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="LabelInfo" runat="server" Text="Info goes here"></asp:Label>
            <br />
            <br />
            <br />
            <asp:Label ID="LabelName" runat="server" Text="Name"></asp:Label>
            <asp:TextBox ID="UserTextName" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="LabelPass" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="UserTextPass" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button_Create_User" runat="server" Text="Create User" OnClick="Add_User_Click" />
        </div>
    </form>
</body>
</html>
