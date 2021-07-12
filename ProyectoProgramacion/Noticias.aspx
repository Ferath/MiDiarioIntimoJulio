<%@ Page Title="Noticias" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="Noticias.aspx.cs" Inherits="ProyectoProgramacion.Noticias" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="position-absolute top-50 start-50 translate-middle">
        <asp:GridView ID="GrdListadoNoticias" CssClass="table align-baseline" runat="server"></asp:GridView>
    </div>
</asp:Content>
