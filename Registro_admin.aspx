<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Registro_admin.aspx.cs" Inherits="Registro_admin" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="css/bootstrap.css" rel="stylesheet" />
    <link href="css/estilos.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <br />
 <div class="container well">
      
        <a href="Admin_index.aspx"><img src="imagenes/img/volver.png" alt="" height="35" /></a>
    
     <div class="borde">
         <h3>REGISTRO DE ADMINISTRADOR</h3>
     </div>
    <form id="form1" runat="server">
         <asp:ScriptManager ID="ScriptManager1" runat="server" EnableScriptGlobalization="True">
        </asp:ScriptManager>
    <div id="formularioRegistro" class="well">
        <div class="row">
            <div class="col-md-4">
                <strong><p>Rut:</p></strong> <asp:TextBox ID="TxtRut" class="Txt" runat="server" Width="80px" MaxLength="9" TextMode="Number"></asp:TextBox>-<asp:TextBox ID="TxtCV" class="Txt" runat="server" Width="30px" MaxLength="1"></asp:TextBox>
            </div>
            <div class="col-md-4">
                 <strong>Nombre:</strong> <asp:TextBox ID="TxtNombre" class="Txt" runat="server" MaxLength="50"></asp:TextBox>
            </div>
            <div class="col-md-4">
                 <strong>Apellido Paterno:</strong> <asp:TextBox ID="TxtAP" class="Txt" runat="server" MaxLength="50"></asp:TextBox>
            </div>
        </div>
        <div class="row">
            <div class="col-md-4">
                <strong>Apellido Materno:</strong> <asp:TextBox ID="TxtAM" class="Txt" runat="server" MaxLength="50"></asp:TextBox>
            </div>
            <div class="col-md-4">
                <strong>Fecha de Nacimiento:</strong> <asp:TextBox ID="TxtFechaNac" class="Txt" runat="server" MaxLength="50" TextMode="Date"></asp:TextBox>
                <ajaxToolkit:CalendarExtender ID="TxtFechaNac_CalendarExtender" runat="server" TargetControlID="TxtFechaNac" />
            </div>
            <div class="col-md-4">
                 <strong>N°Celular:</strong>
                        <asp:TextBox ID="TxtCelu" class="Txt" runat="server" TextMode="Number" MaxLength="8"></asp:TextBox>
            </div>
        </div>
        <div class="row">
            <div class="col-md-4">
                        <strong><p>Calle:</p></strong><asp:TextBox ID="TxtCalle" class="Txt" runat="server" MaxLength="50"></asp:TextBox>
                  </div>
                    <div class="col-md-4">
                        <strong><p>Numero:</p></strong><asp:TextBox ID="TxtNum" class="Txt" runat="server" TextMode="Number" MaxLength="9"></asp:TextBox>
                    </div>
                   <div class="col-md-4">
                        <strong><p>Villa/Poblacion:</p></strong><asp:TextBox ID="TxtVillaP" class="Txt" runat="server" MaxLength="50"></asp:TextBox>
                    </div>
        </div>
         <div class="row">
                    <div class="col-md-4">
                        <strong><p>Region:</p></strong>
                        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                            <contentTemplate>
                                <asp:DropDownList ID="DropRegion" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropRegion_SelectedIndexChanged" OnDataBound="DropRegion_DataBound"></asp:DropDownList>
                            </contentTemplate>
                        </asp:UpdatePanel>
                    </div>
                    <div class="col-md-4">
                        <strong><p>Provincia:</p></strong>
                           <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                               <ContentTemplate>
                                   <asp:DropDownList ID="DropProvincia" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropProvincia_SelectedIndexChanged" OnDataBound="DropProvincia_DataBound"></asp:DropDownList>
                               </ContentTemplate>
                            </asp:UpdatePanel>
                    </div>
                    <div class="col-md-4">
                        <strong><p>Comuna:</p></strong>
                                <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                                    <ContentTemplate>
                                        <asp:DropDownList ID="DropComuna" runat="server" OnSelectedIndexChanged="DropComuna_SelectedIndexChanged" OnDataBound="DropComuna_DataBound"></asp:DropDownList>
                                    </ContentTemplate>
                                </asp:UpdatePanel>
                    </div>
             </div>
                    <div class="row">
                        <div class="col-md-4">
                             <strong>Correo:</strong><asp:TextBox ID="TxtCorreo" class="Txt" runat="server" TextMode="Email"></asp:TextBox>
                        </div>
                        <div class="col-md-4">
                            <strong>Clave:</strong><asp:TextBox ID="TxtClave" class="Txt" runat="server" TextMode="Password"></asp:TextBox>
                        </div>
                        <div class="col-md-4">
                            <p><strong>Estado:</strong></p>
                            <asp:DropDownList ID="DropEstado" runat="server" Enabled="False"></asp:DropDownList>
                        </div>
                    </div>
                    <div id="btn_ingresar">
                        <asp:Button class="boton" ID="Btn_Ingresar" runat="server" Text="Registrar" OnClick="Btn_Ingresar_Click" />
                    </div>
       </div>
    </form>
    
 </div>
</body>
</html>
