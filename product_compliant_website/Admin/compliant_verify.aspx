<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="compliant_verify.aspx.cs" Inherits="product_compliant_website.Admin.compliant_verify" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            margin-left: 15px;
        }
        .auto-style2 {
            margin-left: 5px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>
        <form id="form1" runat="server">
    <center> <h3>Compliant View</h3></center>
    <br />
    <center><asp:Label ID="Label1" runat="server" Text="From"></asp:Label><asp:TextBox ID="TextBox1" runat="server" TextMode="Date" CssClass="auto-style1"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; To:<asp:TextBox ID="TextBox2" runat="server" TextMode="Date" CssClass="auto-style2"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="compliant View" OnClick="Button1_Click" />
        <br />
    </center>
    <br />
    <br />
    <br />
    
      
    <center><asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="cid" OnRowDeleting="GridView1_RowDeleting">
        <Columns>
            <asp:BoundField DataField="cid" HeaderText="Compliant_id" />
            <asp:BoundField DataField="username" HeaderText="username" />
            <asp:BoundField DataField="pid" HeaderText="Product_id" />
            <asp:BoundField DataField="date" DataFormatString="{0:dd/MM/YYYY}" HeaderText="Date" />
            <asp:BoundField DataField="complaint" HeaderText="Compliant" />
            <asp:BoundField DataField="status" HeaderText="Status" />
            <asp:CommandField DeleteText="view Compliant" HeaderText="Compliant Approve" ShowDeleteButton="True" />
        </Columns>
    </asp:GridView>
        <br />
        Processed Compliant<br />
    </center>

    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataKeyNames="cid" OnRowDeleting="GridView2_RowDeleting">
        <Columns>
            <asp:BoundField DataField="cid" HeaderText="Compliant_id" />
            <asp:BoundField DataField="username" HeaderText="username" />
            <asp:BoundField DataField="pid" HeaderText="Product_id" />
            <asp:BoundField DataField="date" HeaderText="Date" />
            <asp:BoundField DataField="complaint" HeaderText="Compliant" />
            <asp:BoundField DataField="status" HeaderText="Status" />
            <asp:CommandField DeleteText="closed" HeaderText="Compliant Approve" ShowDeleteButton="True" />
        </Columns>

    </asp:GridView>
   
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
      <center>  <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" style="height: 29px" Text="Processed compliant" />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    </center>
</form>
</asp:Content>
