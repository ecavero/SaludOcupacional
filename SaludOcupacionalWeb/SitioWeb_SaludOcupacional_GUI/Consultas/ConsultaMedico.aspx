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
                        <td ><p class="labelTitulo">Ingrese especialidad:</p> </td>
                        <td >
                            <asp:TextBox ID="txtFiltro" runat="server"></asp:TextBox>
                        </td>
                        <td class="auto-style1">
                            <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
                        </td>
                    </tr>
                </table>
                <br />

  
            <asp:GridView ID="grvMedicos" runat="server" CellPadding="4" CssClass="GriedView" ForeColor="#333333" GridLines="None" Width="768px" AllowPaging="True" OnPageIndexChanging="grvVendedores_PageIndexChanging" PageSize="4" AutoGenerateColumns="False">
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
  
      <%--Este es el modal popup  que contiene los mensajes --%>
            <%--1. Control target (cualquier control)--%>
              <asp:LinkButton ID="lnkMensaje" runat="server" ></asp:LinkButton>
             <%--2. El panel que se mostrara en el popup--%>
              <asp:Panel ID="pnlMensaje" runat="server" CssClass="CajaDialogo" Style="display: normal;" Width="500"> 
                    <table border="0" width="500px" style="margin: 0px; padding: 0px; background-color:darkred ; 
                        color: #FFFFFF;"> 
                        <tr> 
                            <td align="center"> 
                                <asp:Label ID="lblTitulo" runat="server" Text="Mensaje" /> 
                            </td> 
                            <td width="12%" class="center"> 
                                <asp:ImageButton ID="btnCerrar" runat="server" ImageUrl="~/Images/Cancelar.png" Style="vertical-align: top;" 
                                    ImageAlign="Right" /> 
                            </td> 
                        </tr> 
                         
                    </table>
                  <div>
                      <br />
                  </div>
                    <div> 
                        <asp:Label ID="lblMensajePopup" runat="server" CssClass="labelTitulo"  /> 
                    </div> 
                  <div>
                       <br />
                  </div>
                    <div> 
                        <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" CausesValidation="False" CssClass="boton-new" /> 
                    </div> 
                   <div>
                       <br />
                  </div>
                </asp:Panel> 
         <%--3.El Modal popup que hace referencia al control target  (1) y al panel (2)--%>
                <ajaxToolkit:modalpopupextender ID="PopMensaje" runat="server" TargetControlID="lnkMensaje" 
                    PopupControlID="pnlMensaje" BackgroundCssClass="FondoAplicacion"  OkControlID="btnAceptar" />
        </ContentTemplate>
    </asp:UpdatePanel>
        <%--<ProgressTemplate>
              <div class="overlay">
                  <div class="overlayContent ">
                  <h2>Cargando</h2>  
                  <img src="../Images/loading.gif" alt ="Loading" border="0" />              
              </div>
              </div>
          </ProgressTemplate>--%>
      <asp:UpdateProgress ID="UpdateProgress1" runat="server" DisplayAfter="0"  AssociatedUpdatePanelID ="UpdatePanel1">
<%--          <ProgressTemplate>
              <div class="overlay">
                  <div class="overlayContent ">
                  <h2>Cargando</h2>  
                  <img src="../Images/loading.gif" alt ="Loading" border="0" />              
              </div>
              </div>
          </ProgressTemplate>--%>
    </asp:UpdateProgress>
</asp:Content>
