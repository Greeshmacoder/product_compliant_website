<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="Query.aspx.cs" Inherits="product_compliant_website.Admin.Query" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center>
        <h2>Reply Query</h2>
         <form id="form1" runat="server">
        <table>
            <tr>
                <th>
                    Product
                </th>
                <td></td>
                <td>
                    <asp:TextBox ID="PRoductTextBox1" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <th>
                    Question
                </th>
                <td></td>
                <td>
                    <asp:TextBox ID="QuestionTextBox" runat="server" TextMode="MultiLine" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <th>
                    Reply
                </th>
                <td></td>
                <td>
                    <asp:TextBox ID="ReplyTextBox" runat="server" ReadOnly="False" TextMode="MultiLine"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <th colspan="3">
                    <asp:Button ID="Button1" runat="server" Text="Reply" OnClick="Button1_Click" />
                </th>
            </tr>
        </table>
             </form>
</asp:Content>
