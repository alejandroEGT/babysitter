<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Cliente_Datos.aspx.cs" Inherits="Cliente_Datos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
      <link href="css/bootstrap.css" rel="stylesheet" />
    <link href="css/estilos.css" rel="stylesheet" />
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script>
    <script src="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/js/bootstrap.min.js"></script>
    <title></title>
</head>
<script>
    function centrar() { 
    iz=(screen.width-document.body.clientWidth) / 2; 
    de=(screen.height-document.body.clientHeight) / 5; 
    moveTo(iz,de); 
    }     
</script>

<body onload="centrar()">
    
 <div class="container well">
     <div class="borde">
         <h3>MIS DATOS</h3>
     </div>
    <form id="form2" runat="server">
         <asp:ScriptManager ID="ScriptManager1" runat="server" EnableScriptGlobalization="True">
        </asp:ScriptManager>
    <div id="formularioRegistro" class="well">
        <div class="row">
            <div class="col-md-4">
               <strong>Nombre:</strong> <asp:TextBox ID="TxtNombre" class="Txt" runat="server" MaxLength="50"></asp:TextBox>
            </div>
            <div class="col-md-4">
                <strong>Apellido Paterno:</strong> <asp:TextBox ID="Txtap" class="Txt" runat="server" MaxLength="50"></asp:TextBox>
            </div>
            <div class="col-md-4">
                 <strong>Apellido Materno:</strong> <asp:TextBox ID="TxtAm" class="Txt" runat="server" MaxLength="50"></asp:TextBox>
            </div>
        </div>

        <div class="row">
            <div class="col-md-4">
                <strong>N° Celular:</strong> <asp:TextBox ID="Txtcelu" class="Txt" runat="server" MaxLength="50"></asp:TextBox>
            </div>
            <div class="col-md-4">
                <strong>Calle:</strong> <asp:TextBox ID="Txtcalle" class="Txt" runat="server" MaxLength="50"></asp:TextBox>
            </div>
            <div class="col-md-4">
                <strong>Numero:</strong> <asp:TextBox ID="TxtNum" class="Txt" runat="server" MaxLength="50"></asp:TextBox>
            </div>
        </div>
        
        <div class="row">
            <div class="col-md-4">
                <strong>Villa/Poblacion:</strong> <asp:TextBox ID="Txtvp" class="Txt" runat="server" MaxLength="50"></asp:TextBox>
            </div>
            <div class="col-md-4">
               <p><strong>Region:</strong></p><asp:DropDownList ID="DropRegion" runat="server"></asp:DropDownList>
            </div>
            <div class="col-md-4">
                <p><strong>Provincia:</strong></p> <asp:DropDownList ID="DropProv" runat="server"></asp:DropDownList>
            </div>
        </div>

        <div class="row">
            <div class="col-md-4">
                 <p><strong>Comuna:</strong></p> <asp:DropDownList ID="DropComuna" runat="server"></asp:DropDownList>
            </div>
            <div class="col-md-4">
                 <strong>Correo:</strong> <asp:TextBox ID="TxtCorreo" Class="Txt" runat="server"></asp:TextBox>
            </div>
            <div class="col-md-4">
                <strong>Clave:</strong> <asp:TextBox ID="TxtPass" Class="Txt" runat="server" TextMode="Password"></asp:TextBox>
            </div>
        </div>

        <div class="row well">
            <div class="col-md-4">
                <asp:Button ID="btn_Actu" OnClientClick="javascript:window.close();" class="btn btn-info" runat="server" Text="Cerrar"  />
            </div>
            <div class="col-md-4">
                <asp:Button ID="Button2" class="btn btn-success" runat="server" Text="Guardar Datos" />
            </div>
        </div>
        </div>
    
    </form>
 </div>
</body>
</html>
