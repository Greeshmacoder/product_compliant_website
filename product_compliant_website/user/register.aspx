<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="product_compliant_website.user.register" %>

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

        .auto-style1 {
            height: 29px;
        }

    </style>


    
</head>
<body style="background-color:forestgreen">
    <h1>
    <p>
    </p>
    <p>
    </p>
    <center>Registration page</center></h1>
    
    <form id="form1" runat="server">
        <div>
            <center>
            <table>
            <tr>
             <td> 
                 <br />
                <asp:Label ID="Label1" runat="server" Text="Name" Font-Bold="True" Font-Size="Larger" ></asp:Label></td>
              <td ><asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style1"></asp:TextBox></td></tr>
           
             <tr>
            
             <td class="auto-style1"> <asp:Label ID="Label2" runat="server" Text="Phone number" Font-Bold="True" Font-Size="Larger"></asp:Label></td>
              <td class="auto-style1"> <asp:TextBox ID="TextBox3" runat="server" CssClass="auto-style1"></asp:TextBox></td></tr>
             <tr>
           
             <td> <asp:Label ID="Label4" runat="server" Text="Email" Font-Bold="True" Font-Size="Larger"></asp:Label></td>
             <td> <asp:TextBox ID="TextBox2" runat="server" CssClass="auto-style1" Width="157px"></asp:TextBox></td></tr>
            
            
              <tr>
                  
              <td>
             <asp:Label ID="Label3" runat="server" Text="password" Font-Bold="True" Font-Size="Larger"></asp:Label>
                  </td>
                    <td><asp:TextBox ID="TextBox4" runat="server" CssClass="auto-style2"></asp:TextBox></td></tr>
                <br />
                </table>
              <br />
              <br />
            <asp:Button ID="Button1" runat="server" Text="Register" OnClick="Button1_Click" /></center>
        </div>
    </form>
</body>
</html>
