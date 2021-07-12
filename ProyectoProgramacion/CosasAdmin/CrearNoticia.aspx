<%@ Page Title="Subiendo noticias" Language="C#" MasterPageFile="~/AdminNav.Master" AutoEventWireup="true" CodeBehind="CrearNoticia.aspx.cs" Inherits="ProyectoProgramacion.Admin.CrearNoticia" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="position-absolute top-50 start-50 translate-middle">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:UpdatePanel ID="PanelRegistrarNoticia" runat="server">
            <ContentTemplate>
                <table class="table border-2">
                    <tr>
                        <td class="card-title" colspan="3"><strong><em>Subir una noticia</em></strong></td>
                    </tr>
                    <tr>
                        <td class="auto-style3">Titulo: </td>
                        <td class="auto-style6">
                            <asp:TextBox ID="TxtTitulo" runat="server" class="form-control"></asp:TextBox>
                        </td>
                        <td class="auto-style5"></td>
                    </tr>
                    <tr>
                        <td class="auto-style8">Autor:</td>
                        <td class="auto-style9">
                            <asp:DropDownList ID="DrpAutor" class="btn btn-dark dropdown-toggle" runat="server"></asp:DropDownList>
                        </td>
                        <td class="auto-style10"></td>
                    </tr>
                    <tr>
                        <td class="auto-style3">Fecha noticia:</td>
                        <td class="auto-style6">
                            <asp:TextBox ID="TxtFechaMostrar" runat="server" ReadOnly="true" class="form-control" OnPreRender="TxtFechaMostrar_PreRender"></asp:TextBox>
                        </td>
                        <td class="auto-style5"></td>
                    </tr>

                    <tr>
                        <td scope="col">Descripcion de la Noticia: </td>
                        <td class="auto-style6">
                            <asp:TextBox ID="TxtDescripcion" TextMode="MultiLine" Rows="10" class="form-control" runat="server"></asp:TextBox>
                        </td>
                        <td class="auto-style5"></td>
                    </tr>
                    <tr>
                        <td class="auto-style3">&nbsp;</td>
                        <td class="auto-style6">&nbsp;
                        <asp:Button ID="BtnDonar" CssClass="btn btn-success" runat="server" OnClick="BtnSubirNoticia_Click" Text="Subir noticia" />
                            <asp:Label ID="LbMensaje" runat="server" Text=""></asp:Label>
                        </td>
                        <td class="auto-style5">&nbsp;</td>
                    </tr>
                </table>
            </ContentTemplate>
        </asp:UpdatePanel>
        <asp:UpdateProgress ID="UpdateProgress1" AssociatedUpdatePanelID="PanelRegistrarNoticia" runat="server">
            <ProgressTemplate>
                <asp:Label ID="Label1" runat="server" Text="Subiendo su noticia..."></asp:Label>
            </ProgressTemplate>
        </asp:UpdateProgress>
    </div>
</asp:Content>
