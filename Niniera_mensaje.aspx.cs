using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.WebPages;
public partial class Niniera_mensaje : System.Web.UI.Page
{
    public sql sql = new sql();
    public string runCliente;
    protected void Page_Load(object sender, EventArgs e)
    {
        sql.datagrilla(GridView1, "mensajeContacto", "@runNiniera", Session["rutN"].ToString());
    }
   
  /* public void sms(){
        try
        {

            string rutdelwn = runCliente;

            SqlDataReader cliente = sql.consulta("select s.runCliente, concat(p.nombres,' ',p.apellidoPaterno)as nombre, " +
            "p.correoElectronico,p.telefono, s.fechaServicio, s.fechaServicioInicio, s.fechaServicioFin from tServicio s " +
            " inner join tPersona p on p.run = s.runCliente where runCliente = " + rutdelwn);

            if (cliente.Read())
            {
                lblNombreCliente.Text = cliente[1].ToString();
                lblcorreo.Text = cliente[2].ToString();
                lblfechas.Text = cliente[4].ToString() + " a las " + cliente[5].ToString() + " Hasta " + cliente[6].ToString() + ".";
            }

        }
        catch (Exception) { }
   * }
   * */
    
   protected void LinkButton1_Click(object sender, CommandEventArgs e)
   {
       //lblcorreo.Text = e.CommandArgument.ToString();
   }
   protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
   {
       e.Row.Cells[0].Visible = false;
       e.Row.Cells[1].Visible = false;
      
   }
}