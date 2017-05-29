<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="cadastro.aspx.cs" Inherits="Aula2405_EF_MODELFIRST.Views.Categorias.cadastro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

   <!-- Primeira Aula
    <div id="mensagemSucesso" runat="server" class="alert alert-success" visible="false">
        <strong>Success!</strong> Indicates a successful or positive action.
    </div>

    <div id="mensagemErro" runat="server" class="alert alert-danger" visible="false">
        <strong>Danger!</strong> Indicates a dangerous or potentially negative action.
    </div>
    lado servidor -->

    <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
    <asp:TextBox ID="txtDesc" runat="server" TextMode="MultiLine"></asp:TextBox>
    <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click1"/> <!--OnClick="salvar_Click"-->
    <asp:Button ID="cancelar" runat="server" Text="Cancelar" />
</asp:Content>
