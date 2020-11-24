
using System;
// Definición clase SesionEN
namespace UniDATESGenNHibernate.EN.UniDATES
{
public partial class SesionEN
{
/**
 *	Atributo idSesion
 */
private int idSesion;



/**
 *	Atributo fechaInicio
 */
private Nullable<DateTime> fechaInicio;



/**
 *	Atributo fechaFin
 */
private Nullable<DateTime> fechaFin;



/**
 *	Atributo usuario
 */
private UniDATESGenNHibernate.EN.UniDATES.UsuarioEN usuario;



/**
 *	Atributo administrador
 */
private UniDATESGenNHibernate.EN.UniDATES.AdministradorEN administrador;






public virtual int IdSesion {
        get { return idSesion; } set { idSesion = value;  }
}



public virtual Nullable<DateTime> FechaInicio {
        get { return fechaInicio; } set { fechaInicio = value;  }
}



public virtual Nullable<DateTime> FechaFin {
        get { return fechaFin; } set { fechaFin = value;  }
}



public virtual UniDATESGenNHibernate.EN.UniDATES.UsuarioEN Usuario {
        get { return usuario; } set { usuario = value;  }
}



public virtual UniDATESGenNHibernate.EN.UniDATES.AdministradorEN Administrador {
        get { return administrador; } set { administrador = value;  }
}





public SesionEN()
{
}



public SesionEN(int idSesion, Nullable<DateTime> fechaInicio, Nullable<DateTime> fechaFin, UniDATESGenNHibernate.EN.UniDATES.UsuarioEN usuario, UniDATESGenNHibernate.EN.UniDATES.AdministradorEN administrador
                )
{
        this.init (IdSesion, fechaInicio, fechaFin, usuario, administrador);
}


public SesionEN(SesionEN sesion)
{
        this.init (IdSesion, sesion.FechaInicio, sesion.FechaFin, sesion.Usuario, sesion.Administrador);
}

private void init (int idSesion
                   , Nullable<DateTime> fechaInicio, Nullable<DateTime> fechaFin, UniDATESGenNHibernate.EN.UniDATES.UsuarioEN usuario, UniDATESGenNHibernate.EN.UniDATES.AdministradorEN administrador)
{
        this.IdSesion = idSesion;


        this.FechaInicio = fechaInicio;

        this.FechaFin = fechaFin;

        this.Usuario = usuario;

        this.Administrador = administrador;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        SesionEN t = obj as SesionEN;
        if (t == null)
                return false;
        if (IdSesion.Equals (t.IdSesion))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.IdSesion.GetHashCode ();
        return hash;
}
}
}
