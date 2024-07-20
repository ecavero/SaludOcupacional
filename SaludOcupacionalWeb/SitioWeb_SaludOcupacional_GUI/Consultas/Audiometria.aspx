<%@ Page Title="" Language="C#" MasterPageFile="~/SaludOcupacional.Master" AutoEventWireup="true" CodeBehind="Audiometria.aspx.cs" Inherits="SitioWeb_SaludOcupacional_GUI.Consultas.Audiometria" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Cabecera" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Audiometría</h1>

    <asp:UpdatePanel ID ="UpdatePanel1" runat ="server">
        <ContentTemplate>
    <asp:DropDownList ID="cboCitas" runat="server" OnSelectedIndexChanged="cboCitas_SelectedIndexChanged">
    </asp:DropDownList>
    <br/>
    <asp:Chart runat="server" ID="chtAudiograma">
        <series>
            <asp:Series Name="OD" ChartType="Line" MarkerStyle="Circle" MarkerSize="10" MarkerBorderColor="Red" Color="Red"></asp:Series>
            <asp:Series Name="OI" ChartType="Line" MarkerStyle="Cross" MarkerSize="10" MarkerBorderColor="Blue" Color="Blue"></asp:Series>
        </series>
        <chartareas>
            <asp:ChartArea Name="ChartArea1"></asp:ChartArea>
        </chartareas>
    </asp:Chart>


        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
