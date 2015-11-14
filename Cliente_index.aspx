<%@ Page Title="" Language="C#" MasterPageFile="~/MasterCliente.master" AutoEventWireup="true" CodeFile="Cliente_index.aspx.cs" Inherits="indexCliente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="borde">
        <h3>BUSQUEDA</h3>
    </div>
    <div class="textoIndex">
        <h4>¿De que parte buscas?</h4><hr />
        <div class="row well">
            <div class="col-md-3">
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate> 
                       <strong>Region:</strong> <asp:DropDownList CssClass="ddl" ID="DropRegion" runat="server" AutoPostBack="True" OnDataBound="DropRegion_DataBound" OnSelectedIndexChanged="DropRegion_SelectedIndexChanged"></asp:DropDownList> 
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>
            <div class="col-md-3">
                <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                    <ContentTemplate>
                        <strong>Provincia:</strong> <asp:DropDownList ID="DropProvincia" CssClass="ddl" runat="server" AutoPostBack="True" OnDataBound="DropProvincia_DataBound" OnSelectedIndexChanged="DropProvincia_SelectedIndexChanged"></asp:DropDownList>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>
            <div class="col-md-3">
                <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                    <ContentTemplate>
                       <strong> Comuna:</strong> <asp:DropDownList  CssClass="ddl" ID="DropComuna" runat="server" AutoPostBack="True" OnDataBound="DropComuna_DataBound" OnSelectedIndexChanged="DropComuna_SelectedIndexChanged"></asp:DropDownList>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>
        </div>
        <asp:UpdatePanel ID="UpdatePanel4" runat="server">
            <ContentTemplate>
        <%
            try { 
            System.Data.SqlClient.SqlDataReader ninieras = sql.consulta(consulta);
                
            while(ninieras.Read()){
                
        %>
                <div class="c_niñera well">
                    <a href="#">
                        <img src="<%=ninieras[8].ToString() %>" alt="Alternate Text" height="145" width="140" class="img-thumbnail" />
                    </a>  
                        <h5><strong><%=ninieras[1].ToString()+" "+ninieras[2].ToString() %></strong></h5>
                        <h5><%=ninieras[4].ToString()+" " %>años</h5>
                        <h5><%=ninieras[5].ToString()+" "+ninieras[6].ToString() %> </h5>
                        
                       <a href="Cliente_perfilN.aspx?idN=<%=Url_Codificada(ninieras[0].ToString())%>"><input type="button" class="btnver" value="Ver Perfil" runat="server" /></a>
                </div>
           
        <%
            }
        }catch(Exception){
        
        }
        
        %>
               </ContentTemplate>
         </asp:UpdatePanel>
    </div>
</asp:Content>

