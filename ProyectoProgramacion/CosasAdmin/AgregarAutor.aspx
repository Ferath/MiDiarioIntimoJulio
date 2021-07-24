<%@ Page Title="Agregando Autor" Language="C#" MasterPageFile="~/AdminNav.Master" AutoEventWireup="true" CodeBehind="AgregarAutor.aspx.cs" Inherits="ProyectoProgramacion.CosasAdmin.AgregarAutor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="table border-2">
        <tr>
            <td class="card-title" colspan="3"><strong><em>Agregar un autor</em></strong></td>
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
                <asp:Button ID="BtnAgregarAutor" CssClass="btn btn-success" runat="server" OnClick="BtnBtnAgregarAutor_Click" Text="Hacer autor" />
                <asp:Button ID="BtnEliminarPersona" CssClass="btn btn-danger" OnClick="DelPersona" runat="server" Text="Eliminar Persona" />
                <asp:Label ID="LbMensaje" runat="server" Text=""></asp:Label>
            </td>
            <td class="auto-style5">&nbsp;</td>
        </tr>
    </table>
    <div>
        <asp:LinkButton ID="LnkVer" runat="server" OnClick="LnkNuevo_Click">Agregar nueva persona</asp:LinkButton>
        <br />
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        <asp:Panel ID="PanelPersona" Visible="false" runat="server">
            <table class="table">
                <tr>
                    <td colspan="2" class="auto-style2">Crear persona.</td>
                    <asp:HiddenField ID="Hdnid" runat="server" />
                </tr>
                <tr>
                    <td class="auto-style1">Rut:</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="TxtRut" runat="server"></asp:TextBox>
                        <asp:Label ID="LbId" Hidden="true" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Nombre:</td>
                    <td>
                        <asp:TextBox ID="TxtNombre" Enabled="false" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Apellido:</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TxtApellido" Enabled="false" runat="server"></asp:TextBox>
                    </td>
                    <tr>
                        <td class="auto-style2"></td>
                        <td>
                            <asp:Button ID="BtnCrearPersona" Visible="false" runat="server" CssClass="btn btn-success" Text="CrearPersona" OnClick="BtnCrearPersona_Click" />
                            <br />
                            <asp:Label ID="LbMensaje2" runat="server" Text=""></asp:Label>
                        </td>
                    </tr>
            </table>
        </asp:Panel>
    </div>

</asp:Content>
