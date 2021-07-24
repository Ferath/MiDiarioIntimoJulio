<%@ Page Title="" Language="C#" MasterPageFile="~/AdminNav.Master" AutoEventWireup="true" CodeBehind="AutoresVer.aspx.cs" Inherits="ProyectoProgramacion.CosasAdmin.AutoresVer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 27px;
        }
        .auto-style2 {
            height: 26px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:TextBox ID="TxtBuscar" placeholder="Ingrese código" runat="server"></asp:TextBox>
        <asp:Button ID="BtnBuscar" runat="server" Text="Buscar" OnClick="BtnBuscar_Click" />
        <br />
        <asp:LinkButton ID="LnkNuevo" runat="server" OnClick="LnkNuevo_Click">Agregar nuevo autor</asp:LinkButton>
        <br />
        <asp:Label ID="LbMensaje" runat="server" Text=""></asp:Label>
        <asp:Panel ID="Panel1" Visible="false" runat="server">
            <table class="table">
                <tr>
                    <td colspan="2" class="auto-style2">Detalles del Autor.</td>
                    <asp:HiddenField ID="Hdnid" runat="server" />
                </tr>
                <tr>
                    <td class="auto-style1">Rut:</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="TxtRut" Enabled="false" runat="server"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Formato invalido, use el siguiente 'xxxxxxxx-(0-9 o K)'" ForeColor="red" ControlToValidate="TxtRut" ValidationExpression="^[0-9]{8,9}[-|‐]{1}[0-9kK]{1}$"></asp:RegularExpressionValidator>
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
                        <td class="auto-style2">
                            <asp:LinkButton ID="LnkEditar" runat="server" OnClick="LnkEditar_Click">Modificar</asp:LinkButton>
                        </td>
                        <td>
                            <asp:Button ID="BtnModificar" CssClass="btn btn-light" Visible="false" runat="server" Text="Modificar" OnClick="BtnModificar_Click" />
                            <asp:Button ID="BtnEliminarPersona" CssClass="btn btn-danger" OnClick="DelPersona" runat="server" Text="Eliminar Autor" />
                            <br />
                            <asp:Label ID="LbMensaje2" runat="server" Text=""></asp:Label>
                        </td>
                    </tr>
            </table>
        </asp:Panel>
    </div>

</asp:Content>
