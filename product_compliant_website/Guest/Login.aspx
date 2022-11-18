<%@ Page Title="" Language="C#" MasterPageFile="~/Guest/Guest.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="product_compliant_website.Guest.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1><center> Login Page </center></h1>
    <center><asp:Label runat="server" Text="Username  :"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    <br />

    <asp:Label runat="server" Text="Password  : "></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br />
    <br />
   
        <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" /></center>

</asp:Content>

