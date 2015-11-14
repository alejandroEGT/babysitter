using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
public partial class Admin_Precio : System.Web.UI.Page
{
    public string valor;
    public SqlDataReader verPrecio;
    public sql sql = new sql();
    string idPr;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    public void mensajeAlerta(String texto)
    {
        String t = texto;
        Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('" + t + "');</script>");
    }
   
    protected void Button1_Click(object sender, EventArgs e)
    {
        try 
        {
            if(TxtPrecio.Text.Equals(""))
            {
                mensajeAlerta("Ingrese precio");
            }
            else
            {
                SqlDataReader dr = sql.consulta("select idPrecio from tPrecioNiniera");
                if(dr.Read())
                {
                    string idp = dr[0].ToString();
                    sql.consulta("exec updatePrecio "+idp+","+TxtPrecio.Text.Replace(".",""));
                }
                else
                {
                    SqlDataReader id = sql.consulta("select ISNULL(MAX(idprecio),0)+1 from tPrecioNiniera");
                    if(id.Read())
                    {
                        idPr = id[0].ToString();
                        sql.consulta("exec ingresarprecio "+idPr+","+TxtPrecio.Text+"");
                    }
                }

            }
        }
        catch(Exception){}
    }
}