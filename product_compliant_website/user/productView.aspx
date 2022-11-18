<%@ Page Title="" Language="C#" MasterPageFile="~/user/user_master.Master" AutoEventWireup="true" CodeBehind="productView.aspx.cs" Inherits="product_compliant_website.user.productView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
     <h1><center> Product List </center></h1>
    <center>
        <asp:GridView  ID="GridView1" runat="server" CellSpacing="1" Font-Size="25pt">
            <RowStyle BorderWidth="5px" />
        </asp:GridView>
        <Columns>
            <asp:BoundField DataField="pid" HeaderText="Product_id" />
            <asp:BoundField DataField="productname" HeaderText="Product Name" />
            <asp:BoundField DataField="price" HeaderText="Price" />
        </Columns>
        </asp:GridView>
        </center>
    
    
</asp:Content>
