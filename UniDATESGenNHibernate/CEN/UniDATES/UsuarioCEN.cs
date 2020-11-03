

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
 *      Definition of the class UsuarioCEN
 *
 */
public partial class UsuarioCEN
{
private IUsuarioCAD _IUsuarioCAD;

public UsuarioCEN()
{
        this._IUsuarioCAD = new UsuarioCAD ();
}

public UsuarioCEN(IUsuarioCAD _IUsuarioCAD)
{
        this._IUsuarioCAD = _IUsuarioCAD;
}

public IUsuarioCAD get_IUsuarioCAD ()
{
        return this._IUsuarioCAD;
}

public int Registrarse (string p_nombre, string p_apellidos, String p_contraseña, string p_email, int p_telefono, UniDATESGenNHibernate.Enumerated.UniDATES.SexoEnum p_sexo, string p_universidad, string p_facultad, string p_grado, int p_curso, UniDATESGenNHibernate.Enumerated.UniDATES.ObjetivoEnum p_objetivo, string p_descripcion, string p_gustoGastronomico, string p_ocio, UniDATESGenNHibernate.Enumerated.UniDATES.GustosMusicalesEnum p_gustoMusical, UniDATESGenNHibernate.Enumerated.UniDATES.DeportesEnum p_deporte, string p_registroCitas, string p_registroDenuncias, char p_bloqueado, Nullable<DateTime> p_fechaAlta, Nullable<DateTime> p_fechaBaja, UniDATESGenNHibernate.Enumerated.UniDATES.OrientacionSexualEnum p_orientaciónSexual, int p_sesion)
{
        UsuarioEN usuarioEN = null;
        int oid;

        //Initialized UsuarioEN
        usuarioEN = new UsuarioEN ();
        usuarioEN.Nombre = p_nombre;

        usuarioEN.Apellidos = p_apellidos;

        usuarioEN.Contraseña = Utils.Util.GetEncondeMD5 (p_contraseña);

        usuarioEN.Email = p_email;

        usuarioEN.Telefono = p_telefono;

        usuarioEN.Sexo = p_sexo;

        usuarioEN.Universidad = p_universidad;

        usuarioEN.Facultad = p_facultad;

        usuarioEN.Grado = p_grado;

        usuarioEN.Curso = p_curso;

        usuarioEN.Objetivo = p_objetivo;

        usuarioEN.Descripcion = p_descripcion;

        usuarioEN.GustoGastronomico = p_gustoGastronomico;

        usuarioEN.Ocio = p_ocio;

        usuarioEN.GustoMusical = p_gustoMusical;

        usuarioEN.Deporte = p_deporte;

        usuarioEN.RegistroCitas = p_registroCitas;

        usuarioEN.RegistroDenuncias = p_registroDenuncias;

        usuarioEN.Bloqueado = p_bloqueado;

        usuarioEN.FechaAlta = p_fechaAlta;

        usuarioEN.FechaBaja = p_fechaBaja;

        usuarioEN.OrientaciónSexual = p_orientaciónSexual;


        if (p_sesion != -1) {
                // El argumento p_sesion -> Property sesion es oid = false
                // Lista de oids idUsuario
                usuarioEN.Sesion = new UniDATESGenNHibernate.EN.UniDATES.SesionEN ();
                usuarioEN.Sesion.IdSesion = p_sesion;
        }

        //Call to UsuarioCAD

        oid = _IUsuarioCAD.Registrarse (usuarioEN);
        return oid;
}

public void EditarPerfil (int p_Usuario_OID, string p_nombre, string p_apellidos, String p_contraseña, string p_email, int p_telefono, UniDATESGenNHibernate.Enumerated.UniDATES.SexoEnum p_sexo, string p_universidad, string p_facultad, string p_grado, int p_curso, UniDATESGenNHibernate.Enumerated.UniDATES.ObjetivoEnum p_objetivo, string p_descripcion, string p_gustoGastronomico, string p_ocio, UniDATESGenNHibernate.Enumerated.UniDATES.GustosMusicalesEnum p_gustoMusical, UniDATESGenNHibernate.Enumerated.UniDATES.DeportesEnum p_deporte, string p_registroCitas, string p_registroDenuncias, char p_bloqueado, Nullable<DateTime> p_fechaAlta, Nullable<DateTime> p_fechaBaja, UniDATESGenNHibernate.Enumerated.UniDATES.OrientacionSexualEnum p_orientaciónSexual)
{
        UsuarioEN usuarioEN = null;

        //Initialized UsuarioEN
        usuarioEN = new UsuarioEN ();
        usuarioEN.IdUsuario = p_Usuario_OID;
        usuarioEN.Nombre = p_nombre;
        usuarioEN.Apellidos = p_apellidos;
        usuarioEN.Contraseña = Utils.Util.GetEncondeMD5 (p_contraseña);
        usuarioEN.Email = p_email;
        usuarioEN.Telefono = p_telefono;
        usuarioEN.Sexo = p_sexo;
        usuarioEN.Universidad = p_universidad;
        usuarioEN.Facultad = p_facultad;
        usuarioEN.Grado = p_grado;
        usuarioEN.Curso = p_curso;
        usuarioEN.Objetivo = p_objetivo;
        usuarioEN.Descripcion = p_descripcion;
        usuarioEN.GustoGastronomico = p_gustoGastronomico;
        usuarioEN.Ocio = p_ocio;
        usuarioEN.GustoMusical = p_gustoMusical;
        usuarioEN.Deporte = p_deporte;
        usuarioEN.RegistroCitas = p_registroCitas;
        usuarioEN.RegistroDenuncias = p_registroDenuncias;
        usuarioEN.Bloqueado = p_bloqueado;
        usuarioEN.FechaAlta = p_fechaAlta;
        usuarioEN.FechaBaja = p_fechaBaja;
        usuarioEN.OrientaciónSexual = p_orientaciónSexual;
        //Call to UsuarioCAD

        _IUsuarioCAD.EditarPerfil (usuarioEN);
}

public void DarsedeBaja (int idUsuario
                         )
{
        _IUsuarioCAD.DarsedeBaja (idUsuario);
}
}
}
