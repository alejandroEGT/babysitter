using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
public partial class MasterNiñera : System.Web.UI.MasterPage
{
    //masterpage
    public sql sql = new sql();
    public string nombre;
    public string cantSMS;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            cantidadSolic();
            niniera();
            borrarCache();
        }
        else{
            cantidadSolic();
            niniera();
            borrarCache();
        
        }
        
    }
    public void niniera() 
    {
        try
        {
            SqlDataReader n = sql.consulta("exec datoNiniera " + Session["rutN"].ToString() + ",'" + Session["passN"].ToString() + "'");
            if (n.Read())
            {
                nombre = n[2].ToString() + " " + n[3].ToString();
            }
        }
        catch (Exception) {
            Response.Redirect("index.aspx");
        }
       
    }
    public void cantidadSolic()
    {
        try
        {
            SqlDataReader count = sql.consulta("select count(idServicio) from tServicio where runNiñera=" + Session["rutN"].ToString() + " and idEstado = 4");
            if (count.Read())
            {
                cantSMS =count[0].ToString();
                if (cantSMS.Equals("0"))
                {
                    cantSMS =null;
                }else{

                cantSMS = "(" + count[0].ToString() + ")";
                }
            }
            
        }catch(Exception){}
    }
    public void borrarCache()
    {
        Response.Cache.SetExpires(DateTime.UtcNow.AddMinutes(-1));
        Response.Cache.SetCacheability(HttpCacheability.NoCache);
        Response.Cache.SetNoStore();
    }
}
