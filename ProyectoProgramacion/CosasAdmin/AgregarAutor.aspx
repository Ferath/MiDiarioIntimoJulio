<%@ Page Title="" Language="C#" MasterPageFile="~/AdminNav.Master" AutoEventWireup="true" CodeBehind="AgregarAutor.aspx.cs" Inherits="ProyectoProgramacion.CosasAdmin.AgregarAutor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="table border-2">
        <tr>
            <td class="card-title" colspan="3"><strong><em>Subir una noticia</em></strong></td>
        </tr>
        <tr>
            <td class="auto-style3">Nombre: </td>
            <td class="auto-style6">
                <asp:TextBox ID="TxtNombre" runat="server" class="form-control"></asp:TextBox>
            </td>
            <td class="auto-style5"></td>
        </tr>
        <tr>
            <td class="auto-style3">Apellido: </td>
            <td class="auto-style6">
                <asp:TextBox ID="TxtApellido" runat="server" class="form-control"></asp:TextBox>
            </td>
            <td class="auto-style5"></td>
        </tr>
        <tr>
            <td class="auto-style3">Rut: </td>
            <td class="auto-style6">
                <asp:TextBox ID="TxtRut" maxlength="10" Placeholder="Ingrese su rut en el formato xxxxxxxx-x" runat="server" class="form-control"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Formato invalido, use el siguiente 'xxxxxxxx-(0-9 o K)'" ForeColor="red" ControlToValidate="TxtRut" ValidationExpression="^[0-9]{8,9}[-|‐]{1}[0-9kK]{1}$"></asp:RegularExpressionValidator>
            </td>
            <td class="auto-style5"></td>
        </tr>

        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style6">&nbsp;
                        <asp:Button ID="BtnAgregarAutor" CssClass="btn btn-success" runat="server" OnClick="BtnBtnAgregarAutor_Click" Text="AgregarAutor" />
                <asp:Label ID="LbMensaje" runat="server" Text=""></asp:Label>
            </td>
            <td class="auto-style5">&nbsp;</td>
        </tr>
    </table>
</asp:Content>
