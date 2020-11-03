
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
 * Clase Incidencia:
 *
 */

namespace UniDATESGenNHibernate.CAD.UniDATES
{
public partial class IncidenciaCAD : BasicCAD, IIncidenciaCAD
{
public IncidenciaCAD() : base ()
{
}

public IncidenciaCAD(ISession sessionAux) : base (sessionAux)
{
}



public IncidenciaEN ReadOIDDefault (int idIncidencia
                                    )
{
        IncidenciaEN incidenciaEN = null;

        try
        {
                SessionInitializeTransaction ();
                incidenciaEN = (IncidenciaEN)session.Get (typeof(IncidenciaEN), idIncidencia);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UniDATESGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UniDATESGenNHibernate.Exceptions.DataLayerException ("Error in IncidenciaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return incidenciaEN;
}

public System.Collections.Generic.IList<IncidenciaEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<IncidenciaEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(IncidenciaEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<IncidenciaEN>();
                        else
                                result = session.CreateCriteria (typeof(IncidenciaEN)).List<IncidenciaEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UniDATESGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UniDATESGenNHibernate.Exceptions.DataLayerException ("Error in IncidenciaCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (IncidenciaEN incidencia)
{
        try
        {
                SessionInitializeTransaction ();
                IncidenciaEN incidenciaEN = (IncidenciaEN)session.Load (typeof(IncidenciaEN), incidencia.IdIncidencia);

                incidenciaEN.Motivo = incidencia.Motivo;


                incidenciaEN.Fecha = incidencia.Fecha;


                incidenciaEN.Resolucion = incidencia.Resolucion;




                session.Update (incidenciaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UniDATESGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UniDATESGenNHibernate.Exceptions.DataLayerException ("Error in IncidenciaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (IncidenciaEN incidencia)
{
        try
        {
                SessionInitializeTransaction ();
                if (incidencia.UsuarioDenunciante != null) {
                        // Argumento OID y no colección.
                        incidencia.UsuarioDenunciante = (UniDATESGenNHibernate.EN.UniDATES.UsuarioEN)session.Load (typeof(UniDATESGenNHibernate.EN.UniDATES.UsuarioEN), incidencia.UsuarioDenunciante.IdUsuario);

                        incidencia.UsuarioDenunciante.IncidenciasDenunciadas
                        .Add (incidencia);
                }
                if (incidencia.UsuarioDenunciado != null) {
                        // Argumento OID y no colección.
                        incidencia.UsuarioDenunciado = (UniDATESGenNHibernate.EN.UniDATES.UsuarioEN)session.Load (typeof(UniDATESGenNHibernate.EN.UniDATES.UsuarioEN), incidencia.UsuarioDenunciado.IdUsuario);

                        incidencia.UsuarioDenunciado.IncidenciasRecibidas
                        .Add (incidencia);
                }
                if (incidencia.Administrador != null) {
                        // Argumento OID y no colección.
                        incidencia.Administrador = (UniDATESGenNHibernate.EN.UniDATES.AdministradorEN)session.Load (typeof(UniDATESGenNHibernate.EN.UniDATES.AdministradorEN), incidencia.Administrador.IdAdministrador);

                        incidencia.Administrador.Incidencia
                        .Add (incidencia);
                }

                session.Save (incidencia);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UniDATESGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UniDATESGenNHibernate.Exceptions.DataLayerException ("Error in IncidenciaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return incidencia.IdIncidencia;
}

public void Modify (IncidenciaEN incidencia)
{
        try
        {
                SessionInitializeTransaction ();
                IncidenciaEN incidenciaEN = (IncidenciaEN)session.Load (typeof(IncidenciaEN), incidencia.IdIncidencia);

                incidenciaEN.Motivo = incidencia.Motivo;


                incidenciaEN.Fecha = incidencia.Fecha;


                incidenciaEN.Resolucion = incidencia.Resolucion;

                session.Update (incidenciaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UniDATESGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UniDATESGenNHibernate.Exceptions.DataLayerException ("Error in IncidenciaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Destroy (int idIncidencia
                     )
{
        try
        {
                SessionInitializeTransaction ();
                IncidenciaEN incidenciaEN = (IncidenciaEN)session.Load (typeof(IncidenciaEN), idIncidencia);
                session.Delete (incidenciaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UniDATESGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UniDATESGenNHibernate.Exceptions.DataLayerException ("Error in IncidenciaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
