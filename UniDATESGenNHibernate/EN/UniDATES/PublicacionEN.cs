
using System;
// Definición clase PublicacionEN
namespace UniDATESGenNHibernate.EN.UniDATES
{
public partial class PublicacionEN
{
/**
 *	Atributo idPublicacion
 */
private int idPublicacion;



/**
 *	Atributo usuario
 */
private UniDATESGenNHibernate.EN.UniDATES.UsuarioEN usuario;



/**
 *	Atributo foto
 */
private string foto;






public virtual int IdPublicacion {
        get { return idPublicacion; } set { idPublicacion = value;  }
}



public virtual UniDATESGenNHibernate.EN.UniDATES.UsuarioEN Usuario {
        get { return usuario; } set { usuario = value;  }
}



public virtual string Foto {
        get { return foto; } set { foto = value;  }
}





public PublicacionEN()
{
}



public PublicacionEN(int idPublicacion, UniDATESGenNHibernate.EN.UniDATES.UsuarioEN usuario, string foto
                     )
{
        this.init (IdPublicacion, usuario, foto);
}


public PublicacionEN(PublicacionEN publicacion)
{
        this.init (IdPublicacion, publicacion.Usuario, publicacion.Foto);
}

private void init (int idPublicacion
                   , UniDATESGenNHibernate.EN.UniDATES.UsuarioEN usuario, string foto)
{
        this.IdPublicacion = idPublicacion;


        this.Usuario = usuario;

        this.Foto = foto;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        PublicacionEN t = obj as PublicacionEN;
        if (t == null)
                return false;
        if (IdPublicacion.Equals (t.IdPublicacion))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.IdPublicacion.GetHashCode ();
        return hash;
}
}
}
