<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="SQLInjectionvuln.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Styles.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />

            <asp:Label ID="LabelProductName" runat="server" Text="Name"></asp:Label>
            <asp:TextBox ID="ProductNameText" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="LabelProductPrice" runat="server" Text="Price"></asp:Label>
            
            <asp:TextBox ID="ProductPriceText" runat="server"></asp:TextBox>
            <asp:Button ID="Add_Product_Button" runat="server" Text="Add Product" OnClick="Add_Product_Button_Click" />

            <br />
            <br />
            <asp:Label ID="LabelSearch" runat="server" Text="Search"></asp:Label>
            <br />
            <asp:Button ID="Search_Product_Button" runat="server" Text="Search Product" />


            
        </div>
    </form>
</body>
</html>
