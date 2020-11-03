
using System;
// Definición clase PlanesPremiumEN
namespace UniDATESGenNHibernate.EN.UniDATES
{
public partial class PlanesPremiumEN
{
/**
 *	Atributo idPlan
 */
private int idPlan;



/**
 *	Atributo precio
 */
private float precio;



/**
 *	Atributo descripcion
 */
private string descripcion;



/**
 *	Atributo nombre
 */
private string nombre;



/**
 *	Atributo usuarioPremium
 */
private System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.UsuarioPremiumEN> usuarioPremium;






public virtual int IdPlan {
        get { return idPlan; } set { idPlan = value;  }
}



public virtual float Precio {
        get { return precio; } set { precio = value;  }
}



public virtual string Descripcion {
        get { return descripcion; } set { descripcion = value;  }
}



public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}



public virtual System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.UsuarioPremiumEN> UsuarioPremium {
        get { return usuarioPremium; } set { usuarioPremium = value;  }
}





public PlanesPremiumEN()
{
        usuarioPremium = new System.Collections.Generic.List<UniDATESGenNHibernate.EN.UniDATES.UsuarioPremiumEN>();
}



public PlanesPremiumEN(int idPlan, float precio, string descripcion, string nombre, System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.UsuarioPremiumEN> usuarioPremium
                       )
{
        this.init (IdPlan, precio, descripcion, nombre, usuarioPremium);
}


public PlanesPremiumEN(PlanesPremiumEN planesPremium)
{
        this.init (IdPlan, planesPremium.Precio, planesPremium.Descripcion, planesPremium.Nombre, planesPremium.UsuarioPremium);
}

private void init (int idPlan
                   , float precio, string descripcion, string nombre, System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.UsuarioPremiumEN> usuarioPremium)
{
        this.IdPlan = idPlan;


        this.Precio = precio;

        this.Descripcion = descripcion;

        this.Nombre = nombre;

        this.UsuarioPremium = usuarioPremium;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        PlanesPremiumEN t = obj as PlanesPremiumEN;
        if (t == null)
                return false;
        if (IdPlan.Equals (t.IdPlan))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.IdPlan.GetHashCode ();
        return hash;
}
}
}
