<%@ Page Title="" Language="C#" MasterPageFile="~/user/user_master.Master" AutoEventWireup="true" CodeBehind="closedQuery.aspx.cs" Inherits="product_compliant_website.user.closedQuery" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center><h1>Closed complanit List</h1></center>
   <center><asp:GridView runat="server" ID="GridView1" AutoGenerateColumns="False" DataKeyNames="cid">
        <Columns>
            <asp:BoundField DataField="cid" HeaderText="complaint _id" />
            <asp:BoundField DataField="complaint" HeaderText="Complaint" />
            <asp:BoundField DataField="pid" HeaderText="Product_id" />
            <asp:BoundField DataField="username" HeaderText="Username" />
            <asp:BoundField DataField="status" HeaderText="Status" />
        </Columns>

    </asp:GridView></center>
</asp:Content>
