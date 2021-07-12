<%@ Page Title="Donaciones" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="Donaciones.aspx.cs" Inherits="ProyectoProgramacion.IndexTesteo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        #fondo{
            position: fixed;
            top: 0px;
            left: 0px;
            right: 0px;
            bottom: 0px;
            overflow: hidden;
            padding: 0px;
            background-color:gray;
            z-index: 1;
        }
        #imagen{
            position: fixed;
            top: 30%;
            left: 40%;
            height: 30%;
            width: 30%;
            z-index: 23;
            background-image: url('Assets/Icon/Loading.gif');
            background-repeat: no-repeat;
            background-position:center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdateDonar" runat="server">
        <ContentTemplate>
            <div class="position-absolute top-50 start-50 translate-middle">
                <table class="auto-style1">
                    <tr>
                        <td class="" colspan="3"><strong><em>Donar</em></strong></td>
                    </tr>
                    <tr>
                        <td class="">Monto de la donacion</td>
                        <td class="">
                            <asp:TextBox ID="TxtMonto" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="TxtMonto" runat="server" ErrorMessage="Monto requerido" ForeColor="Red"></asp:RequiredFieldValidator>
                        </td>
                        <td class=""></td>
                    </tr>
                    <tr>
                        <td class="">Metodo de pago:</td>
                        <td class="">
                            <asp:DropDownList ID="DrpMetodoPago" runat="server"></asp:DropDownList>
                        </td>
                        <td class=""></td>
                    </tr>
                    <tr>
                        <td class="">&nbsp;</td>
                        <td class="">&nbsp;
                        <asp:Button ID="BtnDonar" CssClass="btn btn-success" runat="server" OnClick="BtnDonar_Click" Text="Registrar" />
                        <asp:Label ID="LbMensaje" runat="server" Text="" ForeColor="Green"></asp:Label>
                        </td>
                        <td class="">&nbsp;</td>
                    </tr>
                </table>
                <br />
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
    <asp:UpdateProgress ID="UpdateProgress1" AssociatedUpdatePanelID="UpdateDonar" runat="server">
        <ProgressTemplate>
            <div id="fondo"></div>
            <div id="imagen"></div>
        </ProgressTemplate>
    </asp:UpdateProgress>
</asp:Content>
