<%@ Page Title="" Language="C#" MasterPageFile="~/user/user_master.Master" AutoEventWireup="true" CodeBehind="Complaint page.aspx.cs" Inherits="product_compliant_website.user.Complaint_page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 48px;
        }
        .auto-style2 {
            height: 97px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <br />
    <center>
        <asp:GridView  ID="GridView1" runat="server"></asp:GridView>
         </asp:GridView>
        </center>
    <h1><center> Compliant Registration</center></h1>
    <center> 
        <br />
        <br />
        <table>
            <tr>

           <td class="auto-style2">
         <asp:Label  ID="label1" runat="server" Text="Product name" Font-Bold="True" Font-Size="25pt"></asp:Label></td>
        <td class="auto-style2"><asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList></td>
       </tr>
        
       
           <tr>
           <td class="auto-style1"><asp:Label ID="label2" runat="server" Text="Compliant" Font-Bold="True" Font-Size="25pt"></asp:Label></td>
          
           <td class="auto-style1"> <textarea id="TextArea1" name="TextArea1" cols="20" rows="2"></textarea></td>
               </tr>
       
            </table>
     
           
         <center>  <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" Font-Bold="True" Font-Size="25pt" /></center>

</asp:Content>
