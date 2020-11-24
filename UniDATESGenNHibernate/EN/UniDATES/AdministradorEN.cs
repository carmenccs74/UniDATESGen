
using System;
// Definición clase AdministradorEN
namespace UniDATESGenNHibernate.EN.UniDATES
{
public partial class AdministradorEN
{
/**
 *	Atributo idAdministrador
 */
private int idAdministrador;



/**
 *	Atributo sesion
 */
private System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.SesionEN> sesion;



/**
 *	Atributo pass
 */
private String pass;



/**
 *	Atributo email
 */
private string email;



/**
 *	Atributo incidencia
 */
private System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.IncidenciaEN> incidencia;






public virtual int IdAdministrador {
        get { return idAdministrador; } set { idAdministrador = value;  }
}



public virtual System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.SesionEN> Sesion {
        get { return sesion; } set { sesion = value;  }
}



public virtual String Pass {
        get { return pass; } set { pass = value;  }
}



public virtual string Email {
        get { return email; } set { email = value;  }
}



public virtual System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.IncidenciaEN> Incidencia {
        get { return incidencia; } set { incidencia = value;  }
}





public AdministradorEN()
{
        sesion = new System.Collections.Generic.List<UniDATESGenNHibernate.EN.UniDATES.SesionEN>();
        incidencia = new System.Collections.Generic.List<UniDATESGenNHibernate.EN.UniDATES.IncidenciaEN>();
}



public AdministradorEN(int idAdministrador, System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.SesionEN> sesion, String pass, string email, System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.IncidenciaEN> incidencia
                       )
{
        this.init (IdAdministrador, sesion, pass, email, incidencia);
}


public AdministradorEN(AdministradorEN administrador)
{
        this.init (IdAdministrador, administrador.Sesion, administrador.Pass, administrador.Email, administrador.Incidencia);
}

private void init (int idAdministrador
                   , System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.SesionEN> sesion, String pass, string email, System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.IncidenciaEN> incidencia)
{
        this.IdAdministrador = idAdministrador;


        this.Sesion = sesion;

        this.Pass = pass;

        this.Email = email;

        this.Incidencia = incidencia;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        AdministradorEN t = obj as AdministradorEN;
        if (t == null)
                return false;
        if (IdAdministrador.Equals (t.IdAdministrador))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.IdAdministrador.GetHashCode ();
        return hash;
}
}
}
