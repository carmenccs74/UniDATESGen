
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
 * Clase UsuarioPremium:
 *
 */

namespace UniDATESGenNHibernate.CAD.UniDATES
{
public partial class UsuarioPremiumCAD : BasicCAD, IUsuarioPremiumCAD
{
public UsuarioPremiumCAD() : base ()
{
}

public UsuarioPremiumCAD(ISession sessionAux) : base (sessionAux)
{
}



public UsuarioPremiumEN ReadOIDDefault (int idUsuario
                                        )
{
        UsuarioPremiumEN usuarioPremiumEN = null;

        try
        {
                SessionInitializeTransaction ();
                usuarioPremiumEN = (UsuarioPremiumEN)session.Get (typeof(UsuarioPremiumEN), idUsuario);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UniDATESGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UniDATESGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioPremiumCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return usuarioPremiumEN;
}

public System.Collections.Generic.IList<UsuarioPremiumEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<UsuarioPremiumEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(UsuarioPremiumEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<UsuarioPremiumEN>();
                        else
                                result = session.CreateCriteria (typeof(UsuarioPremiumEN)).List<UsuarioPremiumEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UniDATESGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UniDATESGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioPremiumCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (UsuarioPremiumEN usuarioPremium)
{
        try
        {
                SessionInitializeTransaction ();
                UsuarioPremiumEN usuarioPremiumEN = (UsuarioPremiumEN)session.Load (typeof(UsuarioPremiumEN), usuarioPremium.IdUsuario);

                usuarioPremiumEN.NumeroTarjeta = usuarioPremium.NumeroTarjeta;


                usuarioPremiumEN.Titular = usuarioPremium.Titular;


                usuarioPremiumEN.FechaCaducidad = usuarioPremium.FechaCaducidad;


                usuarioPremiumEN.Cvv = usuarioPremium.Cvv;


                session.Update (usuarioPremiumEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UniDATESGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UniDATESGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioPremiumCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int HacerPremium (UsuarioPremiumEN usuarioPremium)
{
        try
        {
                SessionInitializeTransaction ();
                if (usuarioPremium.Sesion != null) {
                        // Argumento OID y no colección.
                        usuarioPremium.Sesion = (UniDATESGenNHibernate.EN.UniDATES.SesionEN)session.Load (typeof(UniDATESGenNHibernate.EN.UniDATES.SesionEN), usuarioPremium.Sesion.IdSesion);

                        usuarioPremium.Sesion.Usuario
                        .Add (usuarioPremium);
                }

                session.Save (usuarioPremium);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UniDATESGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UniDATESGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioPremiumCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return usuarioPremium.IdUsuario;
}

public void Modify (UsuarioPremiumEN usuarioPremium)
{
        try
        {
                SessionInitializeTransaction ();
                UsuarioPremiumEN usuarioPremiumEN = (UsuarioPremiumEN)session.Load (typeof(UsuarioPremiumEN), usuarioPremium.IdUsuario);

                usuarioPremiumEN.Nombre = usuarioPremium.Nombre;


                usuarioPremiumEN.Apellidos = usuarioPremium.Apellidos;


                usuarioPremiumEN.Contraseña = usuarioPremium.Contraseña;


                usuarioPremiumEN.Email = usuarioPremium.Email;


                usuarioPremiumEN.Telefono = usuarioPremium.Telefono;


                usuarioPremiumEN.Sexo = usuarioPremium.Sexo;


                usuarioPremiumEN.Universidad = usuarioPremium.Universidad;


                usuarioPremiumEN.Facultad = usuarioPremium.Facultad;


                usuarioPremiumEN.Grado = usuarioPremium.Grado;


                usuarioPremiumEN.Curso = usuarioPremium.Curso;


                usuarioPremiumEN.Objetivo = usuarioPremium.Objetivo;


                usuarioPremiumEN.Descripcion = usuarioPremium.Descripcion;


                usuarioPremiumEN.GustoGastronomico = usuarioPremium.GustoGastronomico;


                usuarioPremiumEN.Ocio = usuarioPremium.Ocio;


                usuarioPremiumEN.GustoMusical = usuarioPremium.GustoMusical;


                usuarioPremiumEN.Deporte = usuarioPremium.Deporte;


                usuarioPremiumEN.RegistroCitas = usuarioPremium.RegistroCitas;


                usuarioPremiumEN.RegistroDenuncias = usuarioPremium.RegistroDenuncias;


                usuarioPremiumEN.Bloqueado = usuarioPremium.Bloqueado;


                usuarioPremiumEN.FechaAlta = usuarioPremium.FechaAlta;


                usuarioPremiumEN.FechaBaja = usuarioPremium.FechaBaja;


                usuarioPremiumEN.OrientaciónSexual = usuarioPremium.OrientaciónSexual;


                usuarioPremiumEN.NumeroTarjeta = usuarioPremium.NumeroTarjeta;


                usuarioPremiumEN.Titular = usuarioPremium.Titular;


                usuarioPremiumEN.FechaCaducidad = usuarioPremium.FechaCaducidad;


                usuarioPremiumEN.Cvv = usuarioPremium.Cvv;

                session.Update (usuarioPremiumEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UniDATESGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UniDATESGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioPremiumCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Destroy (int idUsuario
                     )
{
        try
        {
                SessionInitializeTransaction ();
                UsuarioPremiumEN usuarioPremiumEN = (UsuarioPremiumEN)session.Load (typeof(UsuarioPremiumEN), idUsuario);
                session.Delete (usuarioPremiumEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UniDATESGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UniDATESGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioPremiumCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void AsignarPlanes (int p_UsuarioPremium_OID, int p_planesPremium_OID)
{
        UniDATESGenNHibernate.EN.UniDATES.UsuarioPremiumEN usuarioPremiumEN = null;
        try
        {
                SessionInitializeTransaction ();
                usuarioPremiumEN = (UsuarioPremiumEN)session.Load (typeof(UsuarioPremiumEN), p_UsuarioPremium_OID);
                usuarioPremiumEN.PlanesPremium = (UniDATESGenNHibernate.EN.UniDATES.PlanesPremiumEN)session.Load (typeof(UniDATESGenNHibernate.EN.UniDATES.PlanesPremiumEN), p_planesPremium_OID);

                usuarioPremiumEN.PlanesPremium.UsuarioPremium.Add (usuarioPremiumEN);



                session.Update (usuarioPremiumEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UniDATESGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UniDATESGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioPremiumCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
