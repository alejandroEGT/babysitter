<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Registro_index.aspx.cs" Inherits="Registro_index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="borde">
        <h3>REGISTRATE</h3>
    </div>
    <div id="formularioRegistro">
     <div class="row">
         <div class="col-md-offset-1 col-md-4">
            <div id="txtNana"><strong>Niñera</strong></div>
            <div id="img1">
            <a href="registroNiñera.aspx"><img src="imagenes/img/nanny.png" width="120" height="220"/></a>
            </div>
        </div>
         <div class=" col-md-offset-2  col-md-4">
            <div id="txtCliente"><strong>Cliente</strong></div>  
            <div id="img2">
            <a href="registro_Clente.aspx"><img src="imagenes/img/man.png" width="240" height="250"/></a>
            </div>
         </div>
     </div>
    <br />
    </div>
    
</asp:Content>

