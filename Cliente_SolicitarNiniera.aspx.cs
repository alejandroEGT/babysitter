using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
public partial class Cliente_SolicitarNiniera : System.Web.UI.Page
{
    public sql sql = new sql();
    public string nombre;
    public string rutN;
    protected void Page_Load(object sender, EventArgs e)
    {
        soliNiniera();
    }
    public void mensajeAlerta(String texto)
    {
        String t = texto;
        Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('" + t + "');</script>");
    }
    public void soliNiniera() 
    {
        try
        {
            rutN= Url_Decodificada(Request.QueryString["idN"].ToString());

             SqlDataReader dr = sql.consulta("exec seeNiniera " +rutN);
            if(dr.Read())
            {
                nombre = dr[1].ToString() + " " + dr[2].ToString() + " " + dr[3].ToString();
            }


        }catch(Exception){
            Response.Write("Cliente_perfilN.aspx");
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
        try 
        {
            if (TextFecha.Text.Equals("") || TxtHfin.Text.Equals("") || TxtHinicio.Text.Equals(""))
            {
                mensajeAlerta("Ingrese todos los campos");
            }
            else
            {

                if (DateTime.ParseExact(TextFecha.Text, "dd/MM/yyyy",null) < (DateTime.Now))
                {
                    mensajeAlerta("La Fecha ingresada ya ha pasado");
                }
                else
                {

                    SqlDataReader countSolicitud = sql.consulta("select * from tServicio where runCliente = " + Session["rutC"].ToString());
                    if (countSolicitud.Read())
                    {

                        sql.consulta("actualizarSolicitudNiniera '" + TextFecha.Text + "','" + TxtHinicio.Text + "','" + TxtHfin.Text + "'," + rutN + "");
                        mensajeAlerta("HAS CAMBIADO LA SOLICITUD A LA NIÑERA " + nombre.ToUpper() + "");
                    }
                    else
                    {

                        sql.consulta("exec solicitarNiniera '" + TextFecha.Text + "','" + TxtHinicio.Text + "','" + TxtHfin.Text + "'," + Session["rutC"].ToString() + "," + rutN + "");
                        mensajeAlerta("SOLISITASTE A " + nombre.ToUpper() + ". AHORA ESPERA SU RESPUESTA.");
                    }
                }
            }
            
        }catch(Exception){
            mensajeAlerta("error");
        }
    }
}