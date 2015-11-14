using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_verClientes : System.Web.UI.Page
{
    sql sql = new sql();
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!Page.IsPostBack)
        {
        }

    }
    public void grilla() 
    {
        BabySitters.Mantenedores.Comuna comuna = new BabySitters.Mantenedores.Comuna();
    }
}