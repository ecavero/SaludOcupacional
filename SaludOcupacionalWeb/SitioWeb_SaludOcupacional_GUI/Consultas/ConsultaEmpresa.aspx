<%@ Page Title="" Language="C#" MasterPageFile="~/SaludOcupacional.Master" AutoEventWireup="true" CodeBehind="ConsultaEmpresa.aspx.cs" Inherits="SitioWeb_SaludOcupacional_GUI.ConsultaEmpresa" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <style type="text/css">
        .auto-style2 {
            width: 557px;
        }
        .auto-style3 {
            width: 196px;
        }
    </style>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <p class="tituloForm">Buscar Empresas</p>

    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>

        <table class="auto-style2">

            <tr>
                <td class="auto-style3">
                    <p class="labelTitulo">Filtrar por RUC</p>
                </td>
                <td>
                    <asp:TextBox ID="txtFiltro" runat="server"></asp:TextBox>
                </td>
                <td>
                     <asp:Button ID="btnBuscar" runat="server" CssClass="boton-new" Text="Buscar" OnClick="btnBuscar_Click" />
                </td>
            </tr>

        </table>

        <br />



        <asp:GridView ID="grvEmpresas" runat="server" CellPadding="4" CssClass="GridView" ForeColor="#333333" GridLines="None" Width="805px" AllowPaging="True" OnPageIndexChanging="grvPacientes_PageIndexChanging" PageSize="4" AutoGenerateColumns="True">
            <AlternatingRowStyle BackColor="White" />

            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            <SortedAscendingCellStyle BackColor="#FDF5AC" />
            <SortedAscendingHeaderStyle BackColor="#4D0000" />
            <SortedDescendingCellStyle BackColor="#FCF6C0" />
            <SortedDescendingHeaderStyle BackColor="#820000" />
        </asp:GridView>

        <asp:Label ID="lblMensajeError" runat="server" CssClass="labelErrores"></asp:Label>

        </ContentTemplate>
    </asp:UpdatePanel>

</asp:Content>
