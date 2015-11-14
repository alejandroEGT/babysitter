<%@ Page Language="C#" %>
    
 <%   
     
if (Session["rutN"]!= null || Session["passN"]!= null)
{
    Session.Clear();
   
Response.Redirect("index.aspx"); 
}        
    
if (Session["rutC"] != null || Session["passC"] != null)
{
    Session.Clear();
    Response.Redirect("index.aspx"); 
}
if (Session["rutA"] != null || Session["passA"] != null)
{
    Session.Clear();
    Response.Redirect("Admin_Login.aspx");
}        
    
    
    
    
    
    
    
    
    
    
    
%>

