<%@ Page Title="" Language="C#" MasterPageFile="~/SaludOcupacional.Master" AutoEventWireup="true" CodeBehind="ConsultaMedico.aspx.cs" Inherits="SitioWeb_SaludOcupacional_GUI.Consultas.ConsultaMedico" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <style type="text/css">
        .auto-style1 {
            width: 64px;
        }
        .auto-style2 {
            width: 446px;
        }
    </style>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

        <p class="tituloForm">Buscar Médicos </p>

          <asp:UpdatePanel ID ="UpdatePanel1" runat ="server">
            <ContentTemplate >
                <table class="auto-style2" >
                    <tr>
                        <td>
                            <p class="labelTitulo">Ingrese especialidad:</p> 
                        </td>
                        <td>
                            <asp:TextBox ID="txtFiltro" runat="server"></asp:TextBox>
                        </td>
                        <td class="auto-style1">
                            <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
                        </td>
                    </tr>
                </table>
                <br />

  
            <asp:GridView ID="grvMedicos" runat="server" CellPadding="4" CssClass="GridView" ForeColor="#333333" GridLines="None" Width="805px" AllowPaging="True" OnPageIndexChanging="grvMedicos_PageIndexChanging" PageSize="4" AutoGenerateColumns="False">
            <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="dni" HeaderText="DNI" />
                    <asp:BoundField DataField="apellidoPaterno" HeaderText="Ap. Paterno" />
                    <asp:BoundField DataField="apellidoMaterno" HeaderText="Ap. Materno" />
                    <asp:BoundField DataField="nombre" HeaderText="Nombre" />
                    <asp:BoundField DataField="especialidad" HeaderText="Especialidad" />
                    <asp:BoundField DataField="nroColegiatura" HeaderText="N° Colegiatura" />
                    <asp:BoundField DataField="departamento" HeaderText="Departamento" />
                    <asp:BoundField DataField="provincia" HeaderText="Provincia" />
                    <asp:BoundField DataField="distrito" HeaderText="Distrito" />
                </Columns>
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
  
        <asp:Label ID="lblMensaje" runat="server" CssClass="labelErrores"></asp:Label>
  
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
