<%@ Page Title="" Language="C#" MasterPageFile="~/MasterCliente.master" AutoEventWireup="true" CodeFile="Cliente_SolicitarNiniera.aspx.cs" Inherits="Cliente_SolicitarNiniera" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />

    <div class="client">
         
        <a href="Cliente_perfilN.aspx?idN=<%= Url_Codificada(rutN)%>"><img src="imagenes/img/volver.png" alt="" height="35" /></a>
    
        <div class="row">

            <div class=" col-md-offset-1 col-md-12">
                <h3><p class="text-warning">vas a solicitar a <%=nombre %></p></h3>
            </div>

        </div>

        <hr />
        <br />
        <h3><strong>Indicale el horario y fecha </strong><small>(Campos obligatorios)</small>
        </h3>
        <div class="row well">
            <div class="col-md-4">
                <p><strong>Fecha del servicio:</strong></p>
                <asp:TextBox ID="TextFecha" runat="server" class="Txt"></asp:TextBox>
                <ajaxToolkit:CalendarExtender ID="TextFecha_CalendarExtender" runat="server" TargetControlID="TextFecha" />
            </div>
            <div class="col-md-4">
                <p><strong>Hora iniciada:</strong></p>
                <asp:TextBox ID="TxtHinicio" runat="server" TextMode="Time" Class="Txt" Height="20px" Width="133px"></asp:TextBox>
            </div>
            <div class="col-md-4">
                <p><strong>Hora finalizada:</strong></p>
                <asp:TextBox ID="TxtHfin" runat="server" TextMode="Time" Class="Txt" Height="20px" Width="133px"></asp:TextBox>
            </div>
        </div>
        <asp:Button Text="Enviar solicitud" class="btn btn-success" runat="server" OnClick="Unnamed1_Click" />
    </div>
</asp:Content>

