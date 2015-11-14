<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="PerfilNiñera.aspx.cs" Inherits="PerfilNiñera" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div class="borde">
        <h3>PERFIL DE NIÑERA</h3>
    </div>
    <div class="volver">
        <a href="index.aspx"><img src="imagenes/img/volver.png" alt="" height="40" /></a>
    </div>

    <div class="textoIndex">

    <%try { 
        
            System.Data.SqlClient.SqlDataReader niñera = sql.consulta("select p.run, n.fotoPerfil, p.nombres, p.apellidoPaterno, p.apellidoMaterno,p.fechaNacimiento,n.descripcion from tPersona p inner join tNiñera n on n.runNiñera = p.run where p.run="+Url_Decodificada(Request.QueryString["idN"].ToString()));

           if (niñera.Read())
           {%>
                  <div class="fotoN"><img src="<%=niñera[1].ToString()%>" /></div>
                    <div class="descripNiñera">
                        <p><strong><%=niñera[2].ToString()+" "+niñera[3].ToString()+" "+niñera[4].ToString() %></strong></p>
                        <hr />
                        <strong>Edad: </strong><%=niñera[5].ToString() %>
                        <p>
                            <%=niñera[6].ToString() %>
                        </p>
                    </div>
        
                  
                
               
           <%}
        
       }catch(Exception){
           Response.Redirect("index.aspx");
       }                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                
        %>

      
                
        
        
        <br /><br /><br /><br /><br /><br /><br /><br />
    </div>
</asp:Content>

