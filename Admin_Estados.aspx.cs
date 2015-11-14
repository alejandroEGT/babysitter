using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Admin_Estados : System.Web.UI.Page
{
    sql sql = new sql();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Btn_ingresar_Click(object sender, EventArgs e)
    {
        try
        {

            if (TxtEstado.Text.Equals(""))
            {
                mensajeAlerta("Ingrese un Estado");
            }
            else {

                SqlDataReader verific = sql.consulta("select descripcionEstado from tEstado");
                if (verific.Read())
                {
                    if (TxtEstado.Text.Equals(verific[0].ToString()))
                    {
                        mensajeAlerta("Este estado ya existe");
                    }
                    else 
                    {

                        sql.consulta("exec ingresarEstado " + TxtEstado.Text);
                        GridEstados.DataBind();
                        TxtEstado.Text = "";
                    }
                }



            }

        }
        catch (Exception) { }

    }
    public void mensajeAlerta(String texto)
    {
        String t = texto;
        Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('" + t + "');</script>");
    }
    protected void GridEstados_SelectedIndexChanged(object sender, EventArgs e)
    {
        try 
        {

           string rut = GridEstados.SelectedRow.Cells[0].Text;

           sql.consulta("exec borrarEstado "+rut);
           GridEstados.DataBind();

        }
        catch(Exception){}
    }
    protected void GridEstados_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        e.Row.Cells[0].Visible = false;
    }
}