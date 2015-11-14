<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin_Login.aspx.cs" Inherits="Admin_Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="css/bootstrap.css" rel="stylesheet" />
    <link href="css/estilos.css" rel="stylesheet" />
    <meta name="viewport" content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0" />
    <title></title>
</head>
<body>
    <br /><br />
    <div class="container well">
    <form id="form1" runat="server">
    <div class="borde">
        <h3>BienVenido Administrador</h3>
    </div>
        <div id="formularioRegistro">
                      <div class="row">
                        <div class=" col-md-offset-4 col-md-3">
                             <label for="ejemplo_email_1">Rut:</label>
                            <asp:TextBox class="form-control" ID="TxtRut" runat="server" placeholder="Rut" Width="226px"></asp:TextBox>
                        </div>
                     </div>
                      <div class="row">
                        <div class="col-md-offset-4 col-md-3">
                            <label for="ejemplo_password_1">Contraseña</label>
                            <asp:TextBox class="form-control" ID="TxtClave" runat="server" placeholder="Contraseña" Width="224px"></asp:TextBox>
                        </div>
                     </div>
                     <div class="row">                           
                          <div class="col-md-offset-5 col-md-3" >
                              <br />
                                <asp:Button class="btn btn-success" runat="server" Text="Entrar" OnClick="Unnamed1_Click" />
                                <br /><br />
                                <h5><a href="Registro_admin.aspx">Registrate aquí</a></h5>
                                <br /><br />
                            </div>
                    </div>
               
            </div>
    </form>
</div>
</body>
</html>
