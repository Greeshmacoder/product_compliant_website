<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Confirmuser.aspx.cs" Inherits="product_compliant_website.Admin.Confirmuser" %>

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
            color:black;
            font-family:Algerian;
        }

    </style>
</head>
<body style="background-color:forestgreen">
    <h1><center> User Verification</center></h1>
    <form id="form1" runat="server">
        <div>
           <center><asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="lid" OnRowDeleting="GridView1_RowDeleting1" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Font-Bold="True" Font-Size="25pt"  >
               <Columns>
                   <asp:BoundField DataField="lid" HeaderText="Login" />
                   <asp:BoundField DataField="username" HeaderText="Username" />
                   <asp:CommandField HeaderText="Status" DeleteText="confirm" ShowDeleteButton="True" />
               </Columns>
               </asp:GridView></center>

        </div>
    </form>
</body>
</html>
