using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections; /// /// Descripción breve de sql /// 
using System.Data.SqlClient;
public class sql
{
    string conexion = "Data Source=localhost;Initial Catalog=BdBabysitters;Integrated Security=True;MultipleActiveResultSets=True";
    //workstation id=BdBabysitters.mssql.somee.com;packet size=4096;user id=alejandro29_SQLLogin_1;pwd=ooujw1vd7u;data source=BdBabysitters.mssql.somee.com;persist security info=False;initial catalog=BdBabysitters
    //workstation id=BdBabysitters.mssql.somee.com;packet size=4096;user id=alejandro29_SQLLogin_1;pwd=ooujw1vd7u;data source=BdBabysitters.mssql.somee.com;persist security info=False;initial catalog=BdBabysitters"
    //Data Source=localhost;Initial Catalog=BdBabysitters;Integrated Security=True;MultipleActiveResultSets=True//
    SqlConnection con;
    DataSet sqlDataset;
    public sql()
    {
        con = new SqlConnection(conexion);
    }
    public SqlConnection obtenerConexion()
    {
        return con;
    }
    public DataTable procedimientos(string consulta)
    {
        try
        {
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand(consulta, con);
            da.SelectCommand.CommandType = CommandType.Text;
            DataSet ds = new DataSet(); da.Fill(ds, "bla");
            DataTable dt = ds.Tables[0];
            return dt;
        }
        catch (Exception ex)
        {
            return null;
        }
    }

    public void EjecutarSql(string strSql)
    {
        SqlCommand myCommand = new SqlCommand(strSql, con);
        myCommand.CommandType = CommandType.Text;
        con.Open();
        try
        {
            myCommand.ExecuteNonQuery();
            myCommand.Connection.Close();
        }
        catch (Exception)
        {
            con.Close();
        }
    }



    public SqlDataReader consulta(String sentencia)
    {
        conectar();
        try
        {
            SqlCommand comando = new SqlCommand(sentencia, con);
            SqlDataReader reader;
            reader = comando.ExecuteReader();
            return reader;
        }
        catch (Exception e)
        {
            return null;
        }
    }
    public void conectar()
    {
        try
        {
            con.Open();
        }
        catch (Exception e)
        {
        }
    }
    public void desconectar()
    {
        con.Close();
    }
    public void ejecutar(string sentencia)
    {
        conectar();
        try
        {
            SqlCommand Command = new SqlCommand(sentencia, con);
            Command.ExecuteReader();
        }
        catch (Exception e)
        {
        }
        finally
        {
            desconectar();
        }
    }
    public bool comprobarUsuario(string sentencia)
    {
        conectar();
        try
        {
            SqlCommand comando = new SqlCommand(sentencia, con);
            SqlDataReader reader;
            reader = comando.ExecuteReader();
            if (reader.Read())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        catch (Exception e)
        {
            return false;
        }
        finally
        {
            desconectar();
        }
    }
    public void llenaDropDown(DropDownList dw, String sentencia, String nombre, String valor, String id)
    {
        conectar();
        DataSet Ds = new DataSet();
        SqlDataAdapter Adapter = new SqlDataAdapter(sentencia, con);
        Adapter.Fill(Ds, nombre);
        dw.DataSource = Ds.Tables[0].DefaultView;
        dw.DataTextField = valor;
        dw.DataValueField = id;
        dw.DataBind(); desconectar();
    }
    public void llenarLista(ListBox dw, String sentencia, String nombre, String valor, String id)
    {
        conectar();
        DataSet Ds = new DataSet();
        SqlDataAdapter Adapter = new SqlDataAdapter(sentencia, con);
        Adapter.Fill(Ds, nombre);
        dw.DataSource = Ds.Tables[0].DefaultView;
        dw.DataTextField = valor; dw.DataValueField = id; dw.DataBind();
        desconectar();
    }
    public String obtenerId(String sentencia)
    {
        conectar();
        try
        {
            String var = "";
            SqlCommand comando = new SqlCommand(sentencia, con);
            SqlDataReader reader;
            reader = comando.ExecuteReader();
            if (reader.Read())
            {
                var = reader.GetValue(0).ToString();
                return var;
            }
            else
            {
                return "error";
            }
        }
        catch (Exception e)
        {
            return "error";
        }
    }
    public void llenaCheckList(CheckBoxList dw, String sentencia, String nombre, String valor, String id)
    {
        conectar();
        DataSet Ds = new DataSet();
        SqlDataAdapter Adapter = new SqlDataAdapter(sentencia, con);
        Adapter.Fill(Ds, nombre);
        dw.DataSource = Ds.Tables[0].DefaultView;
        dw.DataTextField = valor;
        dw.DataValueField = id; dw.DataBind();
        desconectar();
    }
    public void llenaGrilla(GridView gv, String Consulta, String nombre)
    {
        try
        {
            SqlCommand objComand = new SqlCommand(Consulta, con);
            SqlDataAdapter objAdapter = new SqlDataAdapter();
            objAdapter.SelectCommand = objComand; 
            conectar();
            DataSet objDS = new DataSet();
            objAdapter.Fill(objDS, "usuarios");
            desconectar();
            gv.DataSource = objDS;
            gv.DataBind();
        }
        catch (Exception ef)
        {
        }
    }


    public void datagrilla(GridView grilla,string procedimiento,string nombreVariable,string valor)
    {
        
        DataTable dt = new DataTable();
        
        conectar();
        SqlDataAdapter da = new SqlDataAdapter(procedimiento, con);

        da.SelectCommand.CommandType = CommandType.StoredProcedure;

        da.SelectCommand.Parameters.Add(nombreVariable, SqlDbType.VarChar, 80);

        da.SelectCommand.Parameters[nombreVariable].Value = valor;

        da.Fill(dt);

        grilla.DataSource = dt;
        grilla.DataBind();
    }

}