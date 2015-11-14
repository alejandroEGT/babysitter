<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="registro_Clente.aspx.cs" Inherits="registro_Clente" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="borde"><h3>Registro de Cliente</h3></div>

     <div class="volver">
        <a href="Registro_index.aspx"><img src="imagenes/img/volver.png" alt="" height="35" /></a>
    </div>

        <div id="formularioRegistro">
            <div class="row well">
                
                    <div class="col-md-4">
                        <strong><p>Rut:</p></strong> <asp:TextBox ID="TxtRut" class="Txt" runat="server" Width="90px" MaxLength="9" TextMode="Number"></asp:TextBox>-<asp:TextBox ID="TxtCV" class="Txt" runat="server" Width="30px" MaxLength="1"></asp:TextBox>
                    </div>
                    <div class="col-md-4">
                        <strong><p>Nombre:</p></strong> <asp:TextBox ID="TxtNombre" class="Txt" runat="server" MaxLength="50"></asp:TextBox>
                     </div>
                   <div class="col-md-4">
                        <strong><p>Apellido Paterno:</p></strong> <asp:TextBox ID="TxtAP" class="Txt" runat="server" MaxLength="50"></asp:TextBox>
                    </div>
               </div> 
               <div class="row well">
                     
                    <div class="col-md-4">
                        <strong><p>Apellido Materno:</p></strong> <asp:TextBox ID="TxtAM" class="Txt" runat="server" MaxLength="50"></asp:TextBox>
                    </div>
                    <div class="col-md-4">
                        <strong><p>Fecha de Nacimiento:</p></strong> <asp:TextBox ID="TxtFechaNac" class="Txt" runat="server" MaxLength="50" TextMode="Date"></asp:TextBox>
                        
                        <ajaxToolkit:CalendarExtender ID="TxtFechaNac_CalendarExtender" runat="server" TargetControlID="TxtFechaNac" />
                        
                    </div>
                    <div class="col-md-4">
                        <strong><p>N°Celular:</p></strong>
                        <asp:TextBox ID="TxtCelu" class="Txt" runat="server" TextMode="Number" MaxLength="8"></asp:TextBox>
                        
                    </div>
               </div>
                <div class="row well">
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
                <div class="row well">
                    <div class="col-md-4">
                        <strong><p>Region:</p></strong>
                        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                            <contentTemplate>
                                <asp:DropDownList ID="DropRegion" runat="server" AutoPostBack="True" OnDataBound="DropRegion_DataBound" OnSelectedIndexChanged="DropRegion_SelectedIndexChanged"></asp:DropDownList>
                            </contentTemplate>
                        </asp:UpdatePanel>
                    </div>
                    <div class="col-md-4">
                        <strong><p>Provincia:</p></strong>
                           <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                               <ContentTemplate>
                                   <asp:DropDownList ID="DropProvincia" runat="server" AutoPostBack="True" OnDataBound="DropProvincia_DataBound" OnSelectedIndexChanged="DropProvincia_SelectedIndexChanged"></asp:DropDownList>
                               </ContentTemplate>
                            </asp:UpdatePanel>
                    </div>
                    <div class="col-md-4">
                        <strong><p>Comuna:</p></strong>
                                <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                                    <ContentTemplate>
                                        <asp:DropDownList ID="DropComuna" runat="server" AutoPostBack="True" OnDataBound="DropComuna_DataBound"></asp:DropDownList>
                                    </ContentTemplate>
                                </asp:UpdatePanel>
                    </div>
                </div>
                <div class="row well">
                    <div class="col-md-4">
                        <strong><p>Estado:</p></strong>
                        <asp:DropDownList ID="DropEstado" runat="server" Enabled="False"></asp:DropDownList>
                    </div>
                    <div class="col-md-4">
                        <strong><p>Correo:</p></strong><asp:TextBox ID="TxtCorreo" class="Txt" runat="server" TextMode="Email" MaxLength="50"></asp:TextBox><br />
                    </div>
                    <div class="col-md-4">
                         <strong><p>Clave:</p></strong><asp:TextBox ID="TxtClave" class="Txt" runat="server" MaxLength="50" TextMode="Password"></asp:TextBox>
                    </div>
                </div>
              
            <div class="row">
                <div class="col-md-offset-7 col-md-4">
                     <div id="btn_ingresar">
                            <asp:Button class="boton" ID="Btn_Ingresar" runat="server" Text="Registrar" OnClientClick="return verifica()" onClick="Btn_Ingresar_Click"/>
                    </div>
               </div>
            </div>
            <br /><br />
        </div>

    <script>
        function verifica(){
            var rut = document.getElementById("<%=TxtRut.ClientID%>").value;
            var cv = document.getElementById("<%=TxtCV.ClientID%>").value;
            var nom = document.getElementById("<%=TxtNombre.ClientID%>").value;
            var ap = document.getElementById("<%=TxtAP.ClientID%>").value;
            var am = document.getElementById("<%=TxtAM.ClientID%>").value;
            var fnac = document.getElementById("<%=TxtFechaNac.ClientID%>").value;
            var celu = document.getElementById("<%=TxtCelu.ClientID%>").value;
            var calle = document.getElementById("<%=TxtCalle.ClientID%>").value;
            var num = document.getElementById("<%=TxtNum.ClientID%>").value;
            var villap = document.getElementById("<%=TxtVillaP.ClientID%>").value;
            var correo = document.getElementById("<%=TxtCorreo.ClientID%>").value;
            var clave = document.getElementById("<%=TxtClave.ClientID%>").value;

            if(rut==""||cv==""||nom==""||ap==""||am==""||fnac==""||celu==""||calle==""||num==""||villap==""||correo==""||clave=="")
            {
                alert("faltan campos por llenar");
            }
           
        }

    </script>

</asp:Content>

