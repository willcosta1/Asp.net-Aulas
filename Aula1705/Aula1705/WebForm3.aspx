<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="Aula1705.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:TextBox ID="txtValor1" runat="server"></asp:TextBox>
    <asp:TextBox ID="txtValor2" runat="server"></asp:TextBox>
    <asp:Button ID="btnSomar" runat="server" Text="+" OnClick="btnSomar_Click" />
    <asp:Button ID="btnIgual" runat="server" Text="=" OnClick="btnIgual_Click" />
    <br/><br/>
    <asp:TextBox ID="txtSoma" runat="server" ReadOnly="True"></asp:TextBox>
</asp:Content>
