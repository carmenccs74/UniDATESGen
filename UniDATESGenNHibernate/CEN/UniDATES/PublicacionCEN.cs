

using System;
using System.Text;
using System.Collections.Generic;
using Newtonsoft.Json;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using UniDATESGenNHibernate.Exceptions;

using UniDATESGenNHibernate.EN.UniDATES;
using UniDATESGenNHibernate.CAD.UniDATES;


namespace UniDATESGenNHibernate.CEN.UniDATES
{
/*
 *      Definition of the class PublicacionCEN
 *
 */
public partial class PublicacionCEN
{
private IPublicacionCAD _IPublicacionCAD;

public PublicacionCEN()
{
        this._IPublicacionCAD = new PublicacionCAD ();
}

public PublicacionCEN(IPublicacionCAD _IPublicacionCAD)
{
        this._IPublicacionCAD = _IPublicacionCAD;
}

public IPublicacionCAD get_IPublicacionCAD ()
{
        return this._IPublicacionCAD;
}

public int Añadir (int p_usuario, string p_foto)
{
        PublicacionEN publicacionEN = null;
        int oid;

        //Initialized PublicacionEN
        publicacionEN = new PublicacionEN ();

        if (p_usuario != -1) {
                // El argumento p_usuario -> Property usuario es oid = false
                // Lista de oids idPublicacion
                publicacionEN.Usuario = new UniDATESGenNHibernate.EN.UniDATES.UsuarioEN ();
                publicacionEN.Usuario.IdUsuario = p_usuario;
        }

        publicacionEN.Foto = p_foto;

        //Call to PublicacionCAD

        oid = _IPublicacionCAD.Añadir (publicacionEN);
        return oid;
}

public void Eliminar (int idPublicacion
                      )
{
        _IPublicacionCAD.Eliminar (idPublicacion);
}

public void Modify (int p_Publicacion_OID, string p_foto)
{
        PublicacionEN publicacionEN = null;

        //Initialized PublicacionEN
        publicacionEN = new PublicacionEN ();
        publicacionEN.IdPublicacion = p_Publicacion_OID;
        publicacionEN.Foto = p_foto;
        //Call to PublicacionCAD

        _IPublicacionCAD.Modify (publicacionEN);
}
}
}
