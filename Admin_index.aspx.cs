using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Admin_index : System.Web.UI.Page
{
    public sql sql = new sql();
    public int cantC;
    public int cantN;
    public int cantP;
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!Page.IsPostBack)
        {
            numClientes();
            numNiñeras();
        }
    }
    public void numClientes() 
    {
       SqlDataReader clienteCantidad = sql.consulta("select count(runCliente)as clientes from tCliente");
        if(clienteCantidad.Read())
        {
            cantC = Int32.Parse(clienteCantidad[0].ToString());
        }
    }
    public void numNiñeras() 
    {
        try
        {
            SqlDataReader niñeraCantidad = sql.consulta("select count(runNiñera)as niñeras from tNiñera");
            if (niñeraCantidad.Read())
            {
                cantN = Int32.Parse(niñeraCantidad[0].ToString());
            }
        }catch(Exception){}
    }
}