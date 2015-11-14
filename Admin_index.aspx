<%@ Page Title="" Language="C#" MasterPageFile="~/MasterAdmin.master" AutoEventWireup="true" CodeFile="Admin_index.aspx.cs" Inherits="Admin_index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  
    <div class="row">
        
            <h3>INICIO</h3>
        
        <div class="col-md-3 well">
           <h5><img src="imagenes/img/hombre.png" height="25" width="22"/><%=cantC+" "%>Cliente(s).</h5> 
            <h5><img src="imagenes/img/mujer.png" height="30" width="30"/><%=cantN+" " %>Niñera(s).</h5>
            <h5><img src="imagenes/img/personas.png" height="20" width="25" /><%=cantN+cantC+" " %>personas en total</h5>
        </div>
        <div class=" col-md-offset-1 col-md-7 well">
            
        </div>
    </div>
</asp:Content>

