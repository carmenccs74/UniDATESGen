

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
 *      Definition of the class AdministradorCEN
 *
 */
public partial class AdministradorCEN
{
private IAdministradorCAD _IAdministradorCAD;

public AdministradorCEN()
{
        this._IAdministradorCAD = new AdministradorCAD ();
}

public AdministradorCEN(IAdministradorCAD _IAdministradorCAD)
{
        this._IAdministradorCAD = _IAdministradorCAD;
}

public IAdministradorCAD get_IAdministradorCAD ()
{
        return this._IAdministradorCAD;
}

public int Registrarse (int p_sesion, String p_pass, string p_email)
{
        AdministradorEN administradorEN = null;
        int oid;

        //Initialized AdministradorEN
        administradorEN = new AdministradorEN ();

        if (p_sesion != -1) {
                // El argumento p_sesion -> Property sesion es oid = false
                // Lista de oids idAdministrador
                administradorEN.Sesion = new UniDATESGenNHibernate.EN.UniDATES.SesionEN ();
                administradorEN.Sesion.IdSesion = p_sesion;
        }

        administradorEN.Pass = Utils.Util.GetEncondeMD5 (p_pass);

        administradorEN.Email = p_email;

        //Call to AdministradorCAD

        oid = _IAdministradorCAD.Registrarse (administradorEN);
        return oid;
}

public void Modify (int p_Administrador_OID, String p_pass, string p_email)
{
        AdministradorEN administradorEN = null;

        //Initialized AdministradorEN
        administradorEN = new AdministradorEN ();
        administradorEN.IdAdministrador = p_Administrador_OID;
        administradorEN.Pass = Utils.Util.GetEncondeMD5 (p_pass);
        administradorEN.Email = p_email;
        //Call to AdministradorCAD

        _IAdministradorCAD.Modify (administradorEN);
}

public void Destroy (int idAdministrador
                     )
{
        _IAdministradorCAD.Destroy (idAdministrador);
}
}
}
