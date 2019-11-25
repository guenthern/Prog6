<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="CreateUser.aspx.cs" Inherits="Prog3.CreateUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <table style="width: 100%">
    <tr>
        <td>
            <asp:Label ID="Label1" runat="server" Text="UserName: "></asp:Label>
            <asp:TextBox ID="txtUser" runat="server"></asp:TextBox>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label2" runat="server" Text="Password: "></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label3" runat="server" Text="Email: "></asp:Label>
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:Button ID="btnCreate" runat="server" OnClick="btnCreate_Click" Text="Craete Account" />
        </td>
    </tr>
</table>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
