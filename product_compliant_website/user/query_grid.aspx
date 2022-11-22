
<%@ Page Title="" Language="C#" MasterPageFile="~/user/user_master.Master" AutoEventWireup="true" CodeBehind="query_grid.aspx.cs" Inherits="product_compliant_website.user.query_grid" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center><h1>Replyed Query</h1></center>
    <center><asp:GridView  ID="GridView1" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="query_id" HeaderText="Query ID" />
            <asp:BoundField DataField="pid" HeaderText="Product Id" />
            <asp:BoundField DataField="user_id" HeaderText="User Id" />
            <asp:BoundField DataField="username" HeaderText="Username" />
            <asp:BoundField DataField="query_reply" HeaderText="Query Reply" />
        </Columns>
        </asp:GridView>

        </center>

</asp:Content>
