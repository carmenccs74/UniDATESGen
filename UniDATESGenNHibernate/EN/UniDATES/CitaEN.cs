
using System;
// Definición clase CitaEN
namespace UniDATESGenNHibernate.EN.UniDATES
{
public partial class CitaEN
{
/**
 *	Atributo idCita
 */
private int idCita;



/**
 *	Atributo objetivo
 */
private UniDATESGenNHibernate.Enumerated.UniDATES.ObjetivoEnum objetivo;



/**
 *	Atributo usuarioSolicitante
 */
private UniDATESGenNHibernate.EN.UniDATES.UsuarioEN usuarioSolicitante;



/**
 *	Atributo usuarioReceptor
 */
private UniDATESGenNHibernate.EN.UniDATES.UsuarioEN usuarioReceptor;



/**
 *	Atributo aceptada
 */
private bool aceptada;






public virtual int IdCita {
        get { return idCita; } set { idCita = value;  }
}



public virtual UniDATESGenNHibernate.Enumerated.UniDATES.ObjetivoEnum Objetivo {
        get { return objetivo; } set { objetivo = value;  }
}



public virtual UniDATESGenNHibernate.EN.UniDATES.UsuarioEN UsuarioSolicitante {
        get { return usuarioSolicitante; } set { usuarioSolicitante = value;  }
}



public virtual UniDATESGenNHibernate.EN.UniDATES.UsuarioEN UsuarioReceptor {
        get { return usuarioReceptor; } set { usuarioReceptor = value;  }
}



public virtual bool Aceptada {
        get { return aceptada; } set { aceptada = value;  }
}





public CitaEN()
{
}



public CitaEN(int idCita, UniDATESGenNHibernate.Enumerated.UniDATES.ObjetivoEnum objetivo, UniDATESGenNHibernate.EN.UniDATES.UsuarioEN usuarioSolicitante, UniDATESGenNHibernate.EN.UniDATES.UsuarioEN usuarioReceptor, bool aceptada
              )
{
        this.init (IdCita, objetivo, usuarioSolicitante, usuarioReceptor, aceptada);
}


public CitaEN(CitaEN cita)
{
        this.init (IdCita, cita.Objetivo, cita.UsuarioSolicitante, cita.UsuarioReceptor, cita.Aceptada);
}

private void init (int idCita
                   , UniDATESGenNHibernate.Enumerated.UniDATES.ObjetivoEnum objetivo, UniDATESGenNHibernate.EN.UniDATES.UsuarioEN usuarioSolicitante, UniDATESGenNHibernate.EN.UniDATES.UsuarioEN usuarioReceptor, bool aceptada)
{
        this.IdCita = idCita;


        this.Objetivo = objetivo;

        this.UsuarioSolicitante = usuarioSolicitante;

        this.UsuarioReceptor = usuarioReceptor;

        this.Aceptada = aceptada;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        CitaEN t = obj as CitaEN;
        if (t == null)
                return false;
        if (IdCita.Equals (t.IdCita))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.IdCita.GetHashCode ();
        return hash;
}
}
}
