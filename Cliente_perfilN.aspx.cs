using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Cliente_perfilN : System.Web.UI.Page
{
    public string runN;
    sql sql = new sql();
    public string fotoPerfil, nombre, apellidos, direccion, fechaN, descripcion, celular, edad, estudio, correo ;

    protected void Page_Load(object sender, EventArgs e)
    {
        runN = Url_Decodificada(Request.QueryString["idN"].ToString());

        if (!Page.IsPostBack)
        {
            verNiniera();
            verificaSolicitud();
        }
        else
        {
            verNiniera();
        }
       
    }
    public void verificaSolicitud()
    {
         
         try
         {
             SqlDataReader verSolicitud = sql.consulta("SELECT*FROM tServicio where runCliente =" + Session["rutC"].ToString() + " and runNiñera =" + runN + " and idEstado =4");
             if (verSolicitud.Read())
             {
                 label.Text = "'Niñera ya solicitada'";
             }
         }catch(Exception)
         {
             label.Text = "";
         }
    }
    public void verNiniera()
    {
        
        try
        {
            SqlDataReader vn = sql.consulta("exec datosNiniera " + runN);
            if(vn.Read())
            {
                fotoPerfil = vn[16].ToString();
                nombre = vn[1].ToString() + " " + vn[2].ToString() + " " + vn[3].ToString();
                direccion = vn[10].ToString() + ", " + vn[12].ToString();
                edad = vn[17].ToString();
                estudio = vn[13].ToString()+" en "+vn[14].ToString();
                descripcion = vn[15].ToString();
                celular = vn[6].ToString();
                correo = vn[4].ToString();
            }

        }catch(Exception)
        {
            Response.Redirect("Cliente_perfilN.aspx");
        }
    }
    public string Url_Codificada(string cadena)
    {
        byte[] cadenaByte = new byte[cadena.Length];
        cadenaByte = System.Text.Encoding.UTF8.GetBytes(cadena);
        string encodedCadena = Convert.ToBase64String(cadenaByte);
        return encodedCadena;
    }

    public string Url_Decodificada(string cadena)
    {
        var encoder = new System.Text.UTF8Encoding();
        var utf8Decode = encoder.GetDecoder();

        byte[] cadenaByte = Convert.FromBase64String(cadena);
        int charCount = utf8Decode.GetCharCount(cadenaByte, 0, cadenaByte.Length);
        char[] decodedChar = new char[charCount];
        utf8Decode.GetChars(cadenaByte, 0, cadenaByte.Length, decodedChar, 0);
        string result = new String(decodedChar);
        return result;
    }
    protected void Unnamed1_Click(object sender, EventArgs e)
    {
        runN = Url_Decodificada(Request.QueryString["idN"].ToString());
        try 
        {
            SqlDataReader verSolicitud= sql.consulta("SELECT*FROM tServicio where runCliente ="+Session["rutC"].ToString()+" and runNiñera ="+runN+" and idEstado =4");
            if (verSolicitud.Read())
            {
                mensajeAlerta("Niñera ya solicitada, Espera su respuesta o seleccione otra niñera para canselar la anterior.");
            }
            else
            {

                string rutN = Url_Decodificada(Request.QueryString["idN"].ToString());

                Response.Redirect("Cliente_SolicitarNiniera.aspx?idN=" + Url_Codificada(rutN));
            }
        }
        catch(Exception){}
    }
    public void mensajeAlerta(String texto)
    {
        String t = texto;
        Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('" + t + "');</script>");
    }
}