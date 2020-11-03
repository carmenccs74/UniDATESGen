
using System;
// Definición clase MensajeEN
namespace UniDATESGenNHibernate.EN.UniDATES
{
public partial class MensajeEN
{
/**
 *	Atributo idMensaje
 */
private int idMensaje;



/**
 *	Atributo texto
 */
private string texto;



/**
 *	Atributo imagen
 */
private string imagen;



/**
 *	Atributo video
 */
private string video;



/**
 *	Atributo emisor
 */
private UniDATESGenNHibernate.EN.UniDATES.UsuarioEN emisor;



/**
 *	Atributo receptor
 */
private System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.UsuarioEN> receptor;






public virtual int IdMensaje {
        get { return idMensaje; } set { idMensaje = value;  }
}



public virtual string Texto {
        get { return texto; } set { texto = value;  }
}



public virtual string Imagen {
        get { return imagen; } set { imagen = value;  }
}



public virtual string Video {
        get { return video; } set { video = value;  }
}



public virtual UniDATESGenNHibernate.EN.UniDATES.UsuarioEN Emisor {
        get { return emisor; } set { emisor = value;  }
}



public virtual System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.UsuarioEN> Receptor {
        get { return receptor; } set { receptor = value;  }
}





public MensajeEN()
{
        receptor = new System.Collections.Generic.List<UniDATESGenNHibernate.EN.UniDATES.UsuarioEN>();
}



public MensajeEN(int idMensaje, string texto, string imagen, string video, UniDATESGenNHibernate.EN.UniDATES.UsuarioEN emisor, System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.UsuarioEN> receptor
                 )
{
        this.init (IdMensaje, texto, imagen, video, emisor, receptor);
}


public MensajeEN(MensajeEN mensaje)
{
        this.init (IdMensaje, mensaje.Texto, mensaje.Imagen, mensaje.Video, mensaje.Emisor, mensaje.Receptor);
}

private void init (int idMensaje
                   , string texto, string imagen, string video, UniDATESGenNHibernate.EN.UniDATES.UsuarioEN emisor, System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.UsuarioEN> receptor)
{
        this.IdMensaje = idMensaje;


        this.Texto = texto;

        this.Imagen = imagen;

        this.Video = video;

        this.Emisor = emisor;

        this.Receptor = receptor;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        MensajeEN t = obj as MensajeEN;
        if (t == null)
                return false;
        if (IdMensaje.Equals (t.IdMensaje))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.IdMensaje.GetHashCode ();
        return hash;
}
}
}
