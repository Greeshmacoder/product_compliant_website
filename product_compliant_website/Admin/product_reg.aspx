<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="product_reg.aspx.cs" Inherits="product_compliant_website.Admin.product_reg" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
         body {
            margin: 0;
            padding: 0;
            background-image: url('../images/4.png');
            
        }
       
        
       h1 {
            color:Black;
            font-family:Algerian;
        }
    </style>
</head>
<body>
    <h1><center> 
    <br />
    <br />
    <br />
    <br />
    Product registration</center></h1>
    <form id="form1" runat="server">
        <div>
         <center><asp:Label ID="Label1" runat="server" Text="Product Name"></asp:Label><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Product Price"></asp:Label><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
             <asp:Button ID="Button1" runat="server" Text="Add Product" OnClick="Button1_Click" /></center>
        </div>
    </form>
</body>
</html>
