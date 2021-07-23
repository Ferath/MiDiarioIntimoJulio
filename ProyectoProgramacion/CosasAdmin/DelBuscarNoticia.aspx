<%@ Page Title="Buscando noticias" Language="C#" MasterPageFile="~/AdminNav.Master" AutoEventWireup="true" CodeBehind="DelBuscarNoticia.aspx.cs" Inherits="ProyectoProgramacion.Admin.DelBuscarNoticia" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="position-absolute top-50 start-50 translate-middle">
        <div>
            <asp:TextBox ID="TxtBuscarNoticia" Placeholder="Inserte el ID que desee eliminar..." CssClass="input-group input-group-lg" required runat="server"></asp:TextBox><br />
            <asp:Button ID="BtnEliminarNoticia" CssClass="btn-danger" runat="server" Text="Eliminar Noticia" OnClick="BtnEliminarNoticia_Click" />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="TxtBuscarNoticia" runat="server" ErrorMessage="El ID es requerido" ForeColor="Red"></asp:RequiredFieldValidator>
        </div>
        <asp:Label ID="LbBorrar" runat="server" ForeColor="Red" Text=""></asp:Label><br />
        <asp:GridView ID="GrdNoticias" CssClass="table m-2" runat="server"></asp:GridView>
    </div>
</asp:Content>
