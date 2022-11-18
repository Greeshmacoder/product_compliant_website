<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="query_reply.aspx.cs" Inherits="product_compliant_website.Admin.query_reply" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3> <center>
    <br />
    <br />
    Query Verification</center></h3>
    <br />
    <br />
    <style>
         body {
            margin: 0;
            padding: 0;
            background-image: url('../images/4.png');
            
        }
       
        
       h3 {
            color:black;
            font-family:Algerian;
        }
    </style>
    <form id="form1" runat="server">
   <center><asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="query_id">
       <Columns>
           <asp:BoundField DataField="query_id" HeaderText="query_id" />
           <asp:BoundField DataField="query" HeaderText="Query" />
           <asp:BoundField DataField="username" HeaderText="Username" />
           <asp:BoundField DataField="pid" HeaderText="Product_id" />
       </Columns>
    </asp:GridView></center>
    </form>

    
</asp:Content>
