
using System;
using System.Text;
using UniDATESGenNHibernate.CEN.UniDATES;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using UniDATESGenNHibernate.EN.UniDATES;
using UniDATESGenNHibernate.Exceptions;


/*
 * Clase Usuario:
 *
 */

namespace UniDATESGenNHibernate.CAD.UniDATES
{
public partial class UsuarioCAD : BasicCAD, IUsuarioCAD
{
public UsuarioCAD() : base ()
{
}

public UsuarioCAD(ISession sessionAux) : base (sessionAux)
{
}



public UsuarioEN ReadOIDDefault (int idUsuario
                                 )
{
        UsuarioEN usuarioEN = null;

        try
        {
                SessionInitializeTransaction ();
                usuarioEN = (UsuarioEN)session.Get (typeof(UsuarioEN), idUsuario);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UniDATESGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UniDATESGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return usuarioEN;
}

public System.Collections.Generic.IList<UsuarioEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<UsuarioEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(UsuarioEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<UsuarioEN>();
                        else
                                result = session.CreateCriteria (typeof(UsuarioEN)).List<UsuarioEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UniDATESGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UniDATESGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (UsuarioEN usuario)
{
        try
        {
                SessionInitializeTransaction ();
                UsuarioEN usuarioEN = (UsuarioEN)session.Load (typeof(UsuarioEN), usuario.IdUsuario);

                usuarioEN.Nombre = usuario.Nombre;


                usuarioEN.Apellidos = usuario.Apellidos;


                usuarioEN.Contraseña = usuario.Contraseña;


                usuarioEN.Email = usuario.Email;


                usuarioEN.Telefono = usuario.Telefono;


                usuarioEN.Sexo = usuario.Sexo;


                usuarioEN.Universidad = usuario.Universidad;


                usuarioEN.Facultad = usuario.Facultad;


                usuarioEN.Grado = usuario.Grado;


                usuarioEN.Curso = usuario.Curso;


                usuarioEN.Objetivo = usuario.Objetivo;


                usuarioEN.Descripcion = usuario.Descripcion;


                usuarioEN.GustoGastronomico = usuario.GustoGastronomico;


                usuarioEN.Ocio = usuario.Ocio;


                usuarioEN.GustoMusical = usuario.GustoMusical;


                usuarioEN.Deporte = usuario.Deporte;


                usuarioEN.RegistroCitas = usuario.RegistroCitas;


                usuarioEN.RegistroDenuncias = usuario.RegistroDenuncias;


                usuarioEN.Bloqueado = usuario.Bloqueado;


                usuarioEN.FechaAlta = usuario.FechaAlta;


                usuarioEN.FechaBaja = usuario.FechaBaja;


                usuarioEN.OrientaciónSexual = usuario.OrientaciónSexual;










                session.Update (usuarioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UniDATESGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UniDATESGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int Registrarse (UsuarioEN usuario)
{
        try
        {
                SessionInitializeTransaction ();
                if (usuario.Sesion != null) {
                        // Argumento OID y no colección.
                        usuario.Sesion = (UniDATESGenNHibernate.EN.UniDATES.SesionEN)session.Load (typeof(UniDATESGenNHibernate.EN.UniDATES.SesionEN), usuario.Sesion.IdSesion);

                        usuario.Sesion.Usuario
                        .Add (usuario);
                }

                session.Save (usuario);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UniDATESGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UniDATESGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return usuario.IdUsuario;
}

public void EditarPerfil (UsuarioEN usuario)
{
        try
        {
                SessionInitializeTransaction ();
                UsuarioEN usuarioEN = (UsuarioEN)session.Load (typeof(UsuarioEN), usuario.IdUsuario);

                usuarioEN.Nombre = usuario.Nombre;


                usuarioEN.Apellidos = usuario.Apellidos;


                usuarioEN.Contraseña = usuario.Contraseña;


                usuarioEN.Email = usuario.Email;


                usuarioEN.Telefono = usuario.Telefono;


                usuarioEN.Sexo = usuario.Sexo;


                usuarioEN.Universidad = usuario.Universidad;


                usuarioEN.Facultad = usuario.Facultad;


                usuarioEN.Grado = usuario.Grado;


                usuarioEN.Curso = usuario.Curso;


                usuarioEN.Objetivo = usuario.Objetivo;


                usuarioEN.Descripcion = usuario.Descripcion;


                usuarioEN.GustoGastronomico = usuario.GustoGastronomico;


                usuarioEN.Ocio = usuario.Ocio;


                usuarioEN.GustoMusical = usuario.GustoMusical;


                usuarioEN.Deporte = usuario.Deporte;


                usuarioEN.RegistroCitas = usuario.RegistroCitas;


                usuarioEN.RegistroDenuncias = usuario.RegistroDenuncias;


                usuarioEN.Bloqueado = usuario.Bloqueado;


                usuarioEN.FechaAlta = usuario.FechaAlta;


                usuarioEN.FechaBaja = usuario.FechaBaja;


                usuarioEN.OrientaciónSexual = usuario.OrientaciónSexual;

                session.Update (usuarioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UniDATESGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UniDATESGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void DarsedeBaja (int idUsuario
                         )
{
        try
        {
                SessionInitializeTransaction ();
                UsuarioEN usuarioEN = (UsuarioEN)session.Load (typeof(UsuarioEN), idUsuario);
                session.Delete (usuarioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UniDATESGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UniDATESGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
