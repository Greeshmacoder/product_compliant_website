<%@ Page Title="" Language="C#" MasterPageFile="~/Guest/Guest.Master" AutoEventWireup="true" CodeBehind="userreg.aspx.cs" Inherits="product_compliant_website.Guest.userreg" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1><center>Registration page</center></h1>
    
  
        <div>
            <center>
            <table>
            <tr>
             <td> <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label></td>
              <td ><asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style1"></asp:TextBox></td></tr>
           
             <tr>
            
             <td> <asp:Label ID="Label2" runat="server" Text="Phone number"></asp:Label></td>
              <td> <asp:TextBox ID="TextBox3" runat="server" CssClass="auto-style1"></asp:TextBox></td></tr>
             <tr>
           
             <td> <asp:Label ID="Label4" runat="server" Text="Email"></asp:Label></td>
             <td> <asp:TextBox ID="TextBox2" runat="server" CssClass="auto-style1" Width="157px"></asp:TextBox></td></tr>
            
            
              <tr>
                  
              <td>
             <asp:Label ID="Label3" runat="server" Text="password"></asp:Label>
                  </td>
                    <td><asp:TextBox ID="TextBox4" runat="server" CssClass="auto-style2"></asp:TextBox></td></tr>
                <br />
                </table>
              <br />
              <br />
            <asp:Button ID="Button1" runat="server" Text="Register" OnClick="Button1_Click" /></center>
        </div>
    
</asp:Content>
