

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
 *      Definition of the class UsuarioPremiumCEN
 *
 */
public partial class UsuarioPremiumCEN
{
private IUsuarioPremiumCAD _IUsuarioPremiumCAD;

public UsuarioPremiumCEN()
{
        this._IUsuarioPremiumCAD = new UsuarioPremiumCAD ();
}

public UsuarioPremiumCEN(IUsuarioPremiumCAD _IUsuarioPremiumCAD)
{
        this._IUsuarioPremiumCAD = _IUsuarioPremiumCAD;
}

public IUsuarioPremiumCAD get_IUsuarioPremiumCAD ()
{
        return this._IUsuarioPremiumCAD;
}

public int HacerPremium (string p_nombre, string p_apellidos, String p_contraseña, string p_email, int p_telefono, UniDATESGenNHibernate.Enumerated.UniDATES.SexoEnum p_sexo, string p_universidad, string p_facultad, string p_grado, int p_curso, UniDATESGenNHibernate.Enumerated.UniDATES.ObjetivoEnum p_objetivo, string p_descripcion, string p_gustoGastronomico, string p_ocio, UniDATESGenNHibernate.Enumerated.UniDATES.GustosMusicalesEnum p_gustoMusical, UniDATESGenNHibernate.Enumerated.UniDATES.DeportesEnum p_deporte, string p_registroCitas, string p_registroDenuncias, char p_bloqueado, Nullable<DateTime> p_fechaAlta, Nullable<DateTime> p_fechaBaja, UniDATESGenNHibernate.Enumerated.UniDATES.OrientacionSexualEnum p_orientaciónSexual, int p_sesion, int p_numeroTarjeta, string p_titular, Nullable<DateTime> p_fechaCaducidad, int p_cvv)
{
        UsuarioPremiumEN usuarioPremiumEN = null;
        int oid;

        //Initialized UsuarioPremiumEN
        usuarioPremiumEN = new UsuarioPremiumEN ();
        usuarioPremiumEN.Nombre = p_nombre;

        usuarioPremiumEN.Apellidos = p_apellidos;

        usuarioPremiumEN.Contraseña = Utils.Util.GetEncondeMD5 (p_contraseña);

        usuarioPremiumEN.Email = p_email;

        usuarioPremiumEN.Telefono = p_telefono;

        usuarioPremiumEN.Sexo = p_sexo;

        usuarioPremiumEN.Universidad = p_universidad;

        usuarioPremiumEN.Facultad = p_facultad;

        usuarioPremiumEN.Grado = p_grado;

        usuarioPremiumEN.Curso = p_curso;

        usuarioPremiumEN.Objetivo = p_objetivo;

        usuarioPremiumEN.Descripcion = p_descripcion;

        usuarioPremiumEN.GustoGastronomico = p_gustoGastronomico;

        usuarioPremiumEN.Ocio = p_ocio;

        usuarioPremiumEN.GustoMusical = p_gustoMusical;

        usuarioPremiumEN.Deporte = p_deporte;

        usuarioPremiumEN.RegistroCitas = p_registroCitas;

        usuarioPremiumEN.RegistroDenuncias = p_registroDenuncias;

        usuarioPremiumEN.Bloqueado = p_bloqueado;

        usuarioPremiumEN.FechaAlta = p_fechaAlta;

        usuarioPremiumEN.FechaBaja = p_fechaBaja;

        usuarioPremiumEN.OrientaciónSexual = p_orientaciónSexual;


        if (p_sesion != -1) {
                // El argumento p_sesion -> Property sesion es oid = false
                // Lista de oids idUsuario
                usuarioPremiumEN.Sesion = new UniDATESGenNHibernate.EN.UniDATES.SesionEN ();
                usuarioPremiumEN.Sesion.IdSesion = p_sesion;
        }

        usuarioPremiumEN.NumeroTarjeta = p_numeroTarjeta;

        usuarioPremiumEN.Titular = p_titular;

        usuarioPremiumEN.FechaCaducidad = p_fechaCaducidad;

        usuarioPremiumEN.Cvv = p_cvv;

        //Call to UsuarioPremiumCAD

        oid = _IUsuarioPremiumCAD.HacerPremium (usuarioPremiumEN);
        return oid;
}

public void Modify (int p_UsuarioPremium_OID, string p_nombre, string p_apellidos, String p_contraseña, string p_email, int p_telefono, UniDATESGenNHibernate.Enumerated.UniDATES.SexoEnum p_sexo, string p_universidad, string p_facultad, string p_grado, int p_curso, UniDATESGenNHibernate.Enumerated.UniDATES.ObjetivoEnum p_objetivo, string p_descripcion, string p_gustoGastronomico, string p_ocio, UniDATESGenNHibernate.Enumerated.UniDATES.GustosMusicalesEnum p_gustoMusical, UniDATESGenNHibernate.Enumerated.UniDATES.DeportesEnum p_deporte, string p_registroCitas, string p_registroDenuncias, char p_bloqueado, Nullable<DateTime> p_fechaAlta, Nullable<DateTime> p_fechaBaja, UniDATESGenNHibernate.Enumerated.UniDATES.OrientacionSexualEnum p_orientaciónSexual, int p_numeroTarjeta, string p_titular, Nullable<DateTime> p_fechaCaducidad, int p_cvv)
{
        UsuarioPremiumEN usuarioPremiumEN = null;

        //Initialized UsuarioPremiumEN
        usuarioPremiumEN = new UsuarioPremiumEN ();
        usuarioPremiumEN.IdUsuario = p_UsuarioPremium_OID;
        usuarioPremiumEN.Nombre = p_nombre;
        usuarioPremiumEN.Apellidos = p_apellidos;
        usuarioPremiumEN.Contraseña = Utils.Util.GetEncondeMD5 (p_contraseña);
        usuarioPremiumEN.Email = p_email;
        usuarioPremiumEN.Telefono = p_telefono;
        usuarioPremiumEN.Sexo = p_sexo;
        usuarioPremiumEN.Universidad = p_universidad;
        usuarioPremiumEN.Facultad = p_facultad;
        usuarioPremiumEN.Grado = p_grado;
        usuarioPremiumEN.Curso = p_curso;
        usuarioPremiumEN.Objetivo = p_objetivo;
        usuarioPremiumEN.Descripcion = p_descripcion;
        usuarioPremiumEN.GustoGastronomico = p_gustoGastronomico;
        usuarioPremiumEN.Ocio = p_ocio;
        usuarioPremiumEN.GustoMusical = p_gustoMusical;
        usuarioPremiumEN.Deporte = p_deporte;
        usuarioPremiumEN.RegistroCitas = p_registroCitas;
        usuarioPremiumEN.RegistroDenuncias = p_registroDenuncias;
        usuarioPremiumEN.Bloqueado = p_bloqueado;
        usuarioPremiumEN.FechaAlta = p_fechaAlta;
        usuarioPremiumEN.FechaBaja = p_fechaBaja;
        usuarioPremiumEN.OrientaciónSexual = p_orientaciónSexual;
        usuarioPremiumEN.NumeroTarjeta = p_numeroTarjeta;
        usuarioPremiumEN.Titular = p_titular;
        usuarioPremiumEN.FechaCaducidad = p_fechaCaducidad;
        usuarioPremiumEN.Cvv = p_cvv;
        //Call to UsuarioPremiumCAD

        _IUsuarioPremiumCAD.Modify (usuarioPremiumEN);
}

public void Destroy (int idUsuario
                     )
{
        _IUsuarioPremiumCAD.Destroy (idUsuario);
}

public void AsignarPlanes (int p_UsuarioPremium_OID, int p_planesPremium_OID)
{
        //Call to UsuarioPremiumCAD

        _IUsuarioPremiumCAD.AsignarPlanes (p_UsuarioPremium_OID, p_planesPremium_OID);
}
}
}
