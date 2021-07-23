﻿<%@ Page Title="Iniciar sesión" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ProyectoProgramacion.Modelo.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table align="center" class="table">
            <tr>
                <td class="auto-style3" colspan="2"><strong><em>Login</em></strong></td>
            </tr>
            <tr>
                <td class="auto-style2">Rut:</td>
                <td class="auto-style4">
                    <asp:TextBox ID="TxtRut" MaxLength="10" runat="server"></asp:TextBox>

                </td>
            </tr>
            <tr>
                <td class="auto-style2">Password:</td>
                <td class="auto-style4">
                    <asp:TextBox ID="TxtPassword"  runat="server" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="TxtPassword" runat="server" ErrorMessage="Debe ingresar un dato" ForeColor="Red"></asp:RequiredFieldValidator>                    
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style4">
                    <asp:Button ID="BrnLogin" runat="server" Text="Ingresar" OnClick="BrnLogin_Click" />
                    <br />
                    <asp:Label ID="LbMensaje" runat="server" Text=""></asp:Label>
                </td>
            </tr>
        </table>
</asp:Content>
