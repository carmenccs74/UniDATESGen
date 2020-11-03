
using System;
// Definición clase ResultadoEN
namespace UniDATESGenNHibernate.EN.UniDATES
{
public partial class ResultadoEN
{
/**
 *	Atributo busqueda
 */
private UniDATESGenNHibernate.EN.UniDATES.BusquedaEN busqueda;



/**
 *	Atributo idResultado
 */
private int idResultado;






public virtual UniDATESGenNHibernate.EN.UniDATES.BusquedaEN Busqueda {
        get { return busqueda; } set { busqueda = value;  }
}



public virtual int IdResultado {
        get { return idResultado; } set { idResultado = value;  }
}





public ResultadoEN()
{
}



public ResultadoEN(int idResultado, UniDATESGenNHibernate.EN.UniDATES.BusquedaEN busqueda
                   )
{
        this.init (IdResultado, busqueda);
}


public ResultadoEN(ResultadoEN resultado)
{
        this.init (IdResultado, resultado.Busqueda);
}

private void init (int idResultado
                   , UniDATESGenNHibernate.EN.UniDATES.BusquedaEN busqueda)
{
        this.IdResultado = idResultado;


        this.Busqueda = busqueda;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ResultadoEN t = obj as ResultadoEN;
        if (t == null)
                return false;
        if (IdResultado.Equals (t.IdResultado))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.IdResultado.GetHashCode ();
        return hash;
}
}
}
