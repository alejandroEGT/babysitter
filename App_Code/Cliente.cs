using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

/// <summary>
/// Descripción breve de Cliente
/// </summary>
public class Cliente
{
    public int rut, cv, celular, numero,idRegion, idProv, idCom, idEstado;
    public string nombre, apellidoP, apellidoM, calle, villaP, correo, clave, fechaNac ;
    
    
	public Cliente(int rut,int cv,int celular,int numero,int idR,int idPr,int idCo,int idE,string n,string ap,string am,string calle,string vp,string correo, string clave, string fnac)
	{
        this.rut = rut;
        this.cv = cv;
        this.celular = celular;
        this.numero = numero;
        this.idRegion = idR;
        this.idProv = idPr;
        this.idCom = idCo;
        this.idEstado = idE;
        this.nombre = n;
        this.apellidoP = ap;
        this.apellidoM = am;
        this.calle = calle;
        this.villaP = vp;
        this.correo = correo;
        this.clave = clave;
        this.fechaNac = fnac;


	}
    public void ingresaRut(int rut)
    {
        this.rut=rut;
    }
    public int muestraRut()
    {
        return rut;
    }
    public void ingresaCV(int cv) 
    {
        this.cv = cv;
    }
    public int muestraCV() 
    {
        return cv;
    }
    public void ingresaCelular(int celular) 
    {
        this.celular = celular;
    }
    public int muestraCelular()
    {
        return celular;
    }
    public void ingresaNumero(int numero)
    {
        this.numero = numero;
    }
    public int muestraNumero() 
    {
        return numero;
    }
    public void ingresarIdRegion(int idRegion) 
    {
        this.idRegion = idRegion;
    }
    public int muestraIdRegion() 
    {
        return idRegion;
    }
    public void ingresarIdProv(int idProv)
    {
        this.idProv = idProv;
    }
    public int muestraidProv()
    {
        return idProv;
    }

    public void ingresarIdCom(int idCom)
    {
        this.idCom = idCom;
    }
    public int muestraIdCom()
    {
        return idCom;
    }
    public void ingresarIdEstado(int idEstado)
    {
        this.idEstado = idEstado;
    }
    public int muestraIdEstado()
    {
        return idEstado;
    }
    public void ingresarNombre(string nombre)
    {
        this.nombre = nombre;
    }
    public string muestraNombre()
    {
        return nombre;
    }
    public void ingresarAP(string apellidoP)
    {
        this.apellidoP = apellidoP;
    }
    public string muestraAP()
    {
        return apellidoP;
    }
    public void ingresarAM(string apellidoM)
    {
        this.apellidoM = apellidoM;
    }
    public string muestraAM()
    {
        return apellidoM;
    }
    public void ingresarCalle(string calle)
    {
        this.calle = calle;
    }
    public string muestraCalle()
    {
        return calle;
    }
    public void ingresarVillaP(string villaP)
    {
        this.villaP=villaP;
    }
    public string muestraVillaP()
    {
        return villaP;
    }
    public void ingresarCorreo(string correo)
    {
        this.correo = correo;
    }
    public string muestraCorreo()
    {
        return correo;
    }
    public void ingresarClave(string clave)
    {
        this.clave = clave;
    }
    public string muestraClave()
    {
        return clave;
    }
    public void ingresarFechaNac(string fechaNac)
    {
        this.fechaNac = fechaNac;
    }
    public string muestraFechaNac()
    {
        return fechaNac;
    }
}