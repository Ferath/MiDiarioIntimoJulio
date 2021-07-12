<%@ Page Title="Lista Donaciones" Language="C#" MasterPageFile="~/AdminNav.Master" AutoEventWireup="true" CodeBehind="ListaDonacion.aspx.cs" Inherits="ProyectoProgramacion.Admin.ListaDonacion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="position-absolute top-50 start-50 translate-middle">

        <asp:GridView ID="GrdDonacionesTotal" CssClass="table" runat="server"></asp:GridView>

    </div>

</asp:Content>
