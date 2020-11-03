

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
 *      Definition of the class CitaCEN
 *
 */
public partial class CitaCEN
{
private ICitaCAD _ICitaCAD;

public CitaCEN()
{
        this._ICitaCAD = new CitaCAD ();
}

public CitaCEN(ICitaCAD _ICitaCAD)
{
        this._ICitaCAD = _ICitaCAD;
}

public ICitaCAD get_ICitaCAD ()
{
        return this._ICitaCAD;
}

public int Aceptar (UniDATESGenNHibernate.Enumerated.UniDATES.ObjetivoEnum p_objetivo, int p_usuarioSolicitante, int p_usuarioReceptor)
{
        CitaEN citaEN = null;
        int oid;

        //Initialized CitaEN
        citaEN = new CitaEN ();
        citaEN.Objetivo = p_objetivo;


        if (p_usuarioSolicitante != -1) {
                // El argumento p_usuarioSolicitante -> Property usuarioSolicitante es oid = false
                // Lista de oids idCita
                citaEN.UsuarioSolicitante = new UniDATESGenNHibernate.EN.UniDATES.UsuarioEN ();
                citaEN.UsuarioSolicitante.IdUsuario = p_usuarioSolicitante;
        }


        if (p_usuarioReceptor != -1) {
                // El argumento p_usuarioReceptor -> Property usuarioReceptor es oid = false
                // Lista de oids idCita
                citaEN.UsuarioReceptor = new UniDATESGenNHibernate.EN.UniDATES.UsuarioEN ();
                citaEN.UsuarioReceptor.IdUsuario = p_usuarioReceptor;
        }

        //Call to CitaCAD

        oid = _ICitaCAD.Aceptar (citaEN);
        return oid;
}

public void Rechazar (int idCita
                      )
{
        _ICitaCAD.Rechazar (idCita);
}
}
}
