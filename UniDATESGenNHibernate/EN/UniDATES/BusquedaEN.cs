
using System;
// Definición clase BusquedaEN
namespace UniDATESGenNHibernate.EN.UniDATES
{
public partial class BusquedaEN
{
/**
 *	Atributo idBusqueda
 */
private int idBusqueda;



/**
 *	Atributo usuario
 */
private UniDATESGenNHibernate.EN.UniDATES.UsuarioEN usuario;



/**
 *	Atributo filtros
 */
private System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.FiltrosEN> filtros;



/**
 *	Atributo resultado
 */
private System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.ResultadoEN> resultado;






public virtual int IdBusqueda {
        get { return idBusqueda; } set { idBusqueda = value;  }
}



public virtual UniDATESGenNHibernate.EN.UniDATES.UsuarioEN Usuario {
        get { return usuario; } set { usuario = value;  }
}



public virtual System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.FiltrosEN> Filtros {
        get { return filtros; } set { filtros = value;  }
}



public virtual System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.ResultadoEN> Resultado {
        get { return resultado; } set { resultado = value;  }
}





public BusquedaEN()
{
        filtros = new System.Collections.Generic.List<UniDATESGenNHibernate.EN.UniDATES.FiltrosEN>();
        resultado = new System.Collections.Generic.List<UniDATESGenNHibernate.EN.UniDATES.ResultadoEN>();
}



public BusquedaEN(int idBusqueda, UniDATESGenNHibernate.EN.UniDATES.UsuarioEN usuario, System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.FiltrosEN> filtros, System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.ResultadoEN> resultado
                  )
{
        this.init (IdBusqueda, usuario, filtros, resultado);
}


public BusquedaEN(BusquedaEN busqueda)
{
        this.init (IdBusqueda, busqueda.Usuario, busqueda.Filtros, busqueda.Resultado);
}

private void init (int idBusqueda
                   , UniDATESGenNHibernate.EN.UniDATES.UsuarioEN usuario, System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.FiltrosEN> filtros, System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.ResultadoEN> resultado)
{
        this.IdBusqueda = idBusqueda;


        this.Usuario = usuario;

        this.Filtros = filtros;

        this.Resultado = resultado;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        BusquedaEN t = obj as BusquedaEN;
        if (t == null)
                return false;
        if (IdBusqueda.Equals (t.IdBusqueda))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.IdBusqueda.GetHashCode ();
        return hash;
}
}
}
