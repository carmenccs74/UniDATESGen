

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
 *      Definition of the class MensajeCEN
 *
 */
public partial class MensajeCEN
{
private IMensajeCAD _IMensajeCAD;

public MensajeCEN()
{
        this._IMensajeCAD = new MensajeCAD ();
}

public MensajeCEN(IMensajeCAD _IMensajeCAD)
{
        this._IMensajeCAD = _IMensajeCAD;
}

public IMensajeCAD get_IMensajeCAD ()
{
        return this._IMensajeCAD;
}

public int New_ (string p_texto, string p_imagen, string p_video, int p_emisor)
{
        MensajeEN mensajeEN = null;
        int oid;

        //Initialized MensajeEN
        mensajeEN = new MensajeEN ();
        mensajeEN.Texto = p_texto;

        mensajeEN.Imagen = p_imagen;

        mensajeEN.Video = p_video;


        if (p_emisor != -1) {
                // El argumento p_emisor -> Property emisor es oid = false
                // Lista de oids idMensaje
                mensajeEN.Emisor = new UniDATESGenNHibernate.EN.UniDATES.UsuarioEN ();
                mensajeEN.Emisor.IdUsuario = p_emisor;
        }

        //Call to MensajeCAD

        oid = _IMensajeCAD.New_ (mensajeEN);
        return oid;
}

public void Modify (int p_Mensaje_OID, string p_texto, string p_imagen, string p_video)
{
        MensajeEN mensajeEN = null;

        //Initialized MensajeEN
        mensajeEN = new MensajeEN ();
        mensajeEN.IdMensaje = p_Mensaje_OID;
        mensajeEN.Texto = p_texto;
        mensajeEN.Imagen = p_imagen;
        mensajeEN.Video = p_video;
        //Call to MensajeCAD

        _IMensajeCAD.Modify (mensajeEN);
}

public void Destroy (int idMensaje
                     )
{
        _IMensajeCAD.Destroy (idMensaje);
}
}
}
