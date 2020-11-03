
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
 * Clase Cita:
 *
 */

namespace UniDATESGenNHibernate.CAD.UniDATES
{
public partial class CitaCAD : BasicCAD, ICitaCAD
{
public CitaCAD() : base ()
{
}

public CitaCAD(ISession sessionAux) : base (sessionAux)
{
}



public CitaEN ReadOIDDefault (int idCita
                              )
{
        CitaEN citaEN = null;

        try
        {
                SessionInitializeTransaction ();
                citaEN = (CitaEN)session.Get (typeof(CitaEN), idCita);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UniDATESGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UniDATESGenNHibernate.Exceptions.DataLayerException ("Error in CitaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return citaEN;
}

public System.Collections.Generic.IList<CitaEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<CitaEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(CitaEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<CitaEN>();
                        else
                                result = session.CreateCriteria (typeof(CitaEN)).List<CitaEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UniDATESGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UniDATESGenNHibernate.Exceptions.DataLayerException ("Error in CitaCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (CitaEN cita)
{
        try
        {
                SessionInitializeTransaction ();
                CitaEN citaEN = (CitaEN)session.Load (typeof(CitaEN), cita.IdCita);

                citaEN.Objetivo = cita.Objetivo;



                session.Update (citaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UniDATESGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UniDATESGenNHibernate.Exceptions.DataLayerException ("Error in CitaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int Aceptar (CitaEN cita)
{
        try
        {
                SessionInitializeTransaction ();
                if (cita.UsuarioSolicitante != null) {
                        // Argumento OID y no colección.
                        cita.UsuarioSolicitante = (UniDATESGenNHibernate.EN.UniDATES.UsuarioEN)session.Load (typeof(UniDATESGenNHibernate.EN.UniDATES.UsuarioEN), cita.UsuarioSolicitante.IdUsuario);

                        cita.UsuarioSolicitante.CitasSolicitadas
                        .Add (cita);
                }
                if (cita.UsuarioReceptor != null) {
                        // Argumento OID y no colección.
                        cita.UsuarioReceptor = (UniDATESGenNHibernate.EN.UniDATES.UsuarioEN)session.Load (typeof(UniDATESGenNHibernate.EN.UniDATES.UsuarioEN), cita.UsuarioReceptor.IdUsuario);

                        cita.UsuarioReceptor.CitasPendientes
                        .Add (cita);
                }

                session.Save (cita);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UniDATESGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UniDATESGenNHibernate.Exceptions.DataLayerException ("Error in CitaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return cita.IdCita;
}

public void Rechazar (int idCita
                      )
{
        try
        {
                SessionInitializeTransaction ();
                CitaEN citaEN = (CitaEN)session.Load (typeof(CitaEN), idCita);
                session.Delete (citaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UniDATESGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UniDATESGenNHibernate.Exceptions.DataLayerException ("Error in CitaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
