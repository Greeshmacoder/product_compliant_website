<%@ Page Title="" Language="C#" MasterPageFile="~/user/user_master.Master" AutoEventWireup="true" CodeBehind="Querypage.aspx.cs" Inherits="product_compliant_website.user.Querypage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1><center>Query Page</center></h1>
    <br />
   <center> <table>
        <tr>
            <td><h2>Product Name </h2></td>
            <td>
                <asp:DropDownList ID="Dd2" runat="server"></asp:DropDownList>
                
            </td>
        </tr>
        <tr>
            <td><h2>Query :</h2></td>
            <td>
                <textarea id="TextArea1" name="TextArea1" cols="20" rows="2"></textarea></td>
        </tr>
        <tr>
            <td colspan="2" align="center">
                <asp:Button runat="server" Text="Submit" OnClick="Unnamed2_Click"  />
            </td>
        </tr>
    </table></center>
    
   


</asp:Content>
