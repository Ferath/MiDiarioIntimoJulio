<%@ Page Title="Administradores" Language="C#" MasterPageFile="~/AdminNav.Master" AutoEventWireup="true" CodeBehind="CrudAdmin.aspx.cs" Inherits="ProyectoProgramacion.CosasAdmin.CrudAdmin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%--Esto es para probar--%>
    <table class="table border-2">
        <tr>
            <td class="card-title" colspan="3"><strong><em>Agregar un Administrador</em></strong></td>
        </tr>
        <tr>
            <td class="auto-style3">Username</td>
            <td><asp:TextBox ID="TxtUsername" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td class="auto-style3">Contraseña</td>
            <td><asp:TextBox ID="TxtPassword" TextMode="Password" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td class="auto-style3">Persona: </td>
            <td class="auto-style6">
                <asp:DropDownList ID="DrpPersonas" runat="server"></asp:DropDownList>
            </td>
            <td class="auto-style5"></td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style6">&nbsp;
                <asp:Button ID="BtnAgregarAutor" CssClass="btn btn-success" runat="server" OnClick="BtnAgregarAdmin_click" Text="Crear Adminisitrador" />
                <asp:Label ID="LbMensaje" runat="server" Text=""></asp:Label>
            </td>
            <td class="auto-style5">&nbsp;</td>
        </tr>
    </table>
    <%--Fin de la prueba--%>
</asp:Content>
