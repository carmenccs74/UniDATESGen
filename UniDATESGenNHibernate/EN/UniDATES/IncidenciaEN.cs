
using System;
// Definición clase IncidenciaEN
namespace UniDATESGenNHibernate.EN.UniDATES
{
public partial class IncidenciaEN
{
/**
 *	Atributo idIncidencia
 */
private int idIncidencia;



/**
 *	Atributo motivo
 */
private UniDATESGenNHibernate.Enumerated.UniDATES.MotivoIncidenciaEnum motivo;



/**
 *	Atributo fecha
 */
private Nullable<DateTime> fecha;



/**
 *	Atributo resolucion
 */
private string resolucion;



/**
 *	Atributo usuarioDenunciante
 */
private UniDATESGenNHibernate.EN.UniDATES.UsuarioEN usuarioDenunciante;



/**
 *	Atributo usuarioDenunciado
 */
private UniDATESGenNHibernate.EN.UniDATES.UsuarioEN usuarioDenunciado;



/**
 *	Atributo administrador
 */
private UniDATESGenNHibernate.EN.UniDATES.AdministradorEN administrador;






public virtual int IdIncidencia {
        get { return idIncidencia; } set { idIncidencia = value;  }
}



public virtual UniDATESGenNHibernate.Enumerated.UniDATES.MotivoIncidenciaEnum Motivo {
        get { return motivo; } set { motivo = value;  }
}



public virtual Nullable<DateTime> Fecha {
        get { return fecha; } set { fecha = value;  }
}



public virtual string Resolucion {
        get { return resolucion; } set { resolucion = value;  }
}



public virtual UniDATESGenNHibernate.EN.UniDATES.UsuarioEN UsuarioDenunciante {
        get { return usuarioDenunciante; } set { usuarioDenunciante = value;  }
}



public virtual UniDATESGenNHibernate.EN.UniDATES.UsuarioEN UsuarioDenunciado {
        get { return usuarioDenunciado; } set { usuarioDenunciado = value;  }
}



public virtual UniDATESGenNHibernate.EN.UniDATES.AdministradorEN Administrador {
        get { return administrador; } set { administrador = value;  }
}





public IncidenciaEN()
{
}



public IncidenciaEN(int idIncidencia, UniDATESGenNHibernate.Enumerated.UniDATES.MotivoIncidenciaEnum motivo, Nullable<DateTime> fecha, string resolucion, UniDATESGenNHibernate.EN.UniDATES.UsuarioEN usuarioDenunciante, UniDATESGenNHibernate.EN.UniDATES.UsuarioEN usuarioDenunciado, UniDATESGenNHibernate.EN.UniDATES.AdministradorEN administrador
                    )
{
        this.init (IdIncidencia, motivo, fecha, resolucion, usuarioDenunciante, usuarioDenunciado, administrador);
}


public IncidenciaEN(IncidenciaEN incidencia)
{
        this.init (IdIncidencia, incidencia.Motivo, incidencia.Fecha, incidencia.Resolucion, incidencia.UsuarioDenunciante, incidencia.UsuarioDenunciado, incidencia.Administrador);
}

private void init (int idIncidencia
                   , UniDATESGenNHibernate.Enumerated.UniDATES.MotivoIncidenciaEnum motivo, Nullable<DateTime> fecha, string resolucion, UniDATESGenNHibernate.EN.UniDATES.UsuarioEN usuarioDenunciante, UniDATESGenNHibernate.EN.UniDATES.UsuarioEN usuarioDenunciado, UniDATESGenNHibernate.EN.UniDATES.AdministradorEN administrador)
{
        this.IdIncidencia = idIncidencia;


        this.Motivo = motivo;

        this.Fecha = fecha;

        this.Resolucion = resolucion;

        this.UsuarioDenunciante = usuarioDenunciante;

        this.UsuarioDenunciado = usuarioDenunciado;

        this.Administrador = administrador;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        IncidenciaEN t = obj as IncidenciaEN;
        if (t == null)
                return false;
        if (IdIncidencia.Equals (t.IdIncidencia))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.IdIncidencia.GetHashCode ();
        return hash;
}
}
}
