<%@ Page Title="Noticias" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="Noticias.aspx.cs" Inherits="ProyectoProgramacion.Noticias" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <main class="container">
        <div runat="server" class="ContenedorNoticias border" id="NoticiasContainer"></div>
    </main>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.1/dist/js/bootstrap.bundle.min.js" integrity="sha384-gtEjrD/SeCtmISkJkNUaaKMoLD0//ElJ19smozuHV6z3Iehds+3Ulb9Bn9Plx0x4" crossorigin="anonymous"></script>
</asp:Content>
