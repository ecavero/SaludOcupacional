
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="SitioWeb_SaludOcupacional_GUI.Consultas.WebForm1" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
<asp:Chart runat="server" ID="ctl00">
    <series>
        <asp:Series Name="Series1" ChartType="Line"></asp:Series>
    </series>
    <chartareas>
        <asp:ChartArea Name="ChartArea1"></asp:ChartArea>
    </chartareas>
</asp:Chart>

    <form id="form1" runat="server">
        <div>
        </div>
    </form>
</body>
</html>
