
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
 * Clase Filtros:
 *
 */

namespace UniDATESGenNHibernate.CAD.UniDATES
{
public partial class FiltrosCAD : BasicCAD, IFiltrosCAD
{
public FiltrosCAD() : base ()
{
}

public FiltrosCAD(ISession sessionAux) : base (sessionAux)
{
}



public FiltrosEN ReadOIDDefault (int idFiltros
                                 )
{
        FiltrosEN filtrosEN = null;

        try
        {
                SessionInitializeTransaction ();
                filtrosEN = (FiltrosEN)session.Get (typeof(FiltrosEN), idFiltros);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UniDATESGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UniDATESGenNHibernate.Exceptions.DataLayerException ("Error in FiltrosCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return filtrosEN;
}

public System.Collections.Generic.IList<FiltrosEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<FiltrosEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(FiltrosEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<FiltrosEN>();
                        else
                                result = session.CreateCriteria (typeof(FiltrosEN)).List<FiltrosEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UniDATESGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UniDATESGenNHibernate.Exceptions.DataLayerException ("Error in FiltrosCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (FiltrosEN filtros)
{
        try
        {
                SessionInitializeTransaction ();
                FiltrosEN filtrosEN = (FiltrosEN)session.Load (typeof(FiltrosEN), filtros.IdFiltros);

                filtrosEN.ObjetivoCita = filtros.ObjetivoCita;


                filtrosEN.Universidad = filtros.Universidad;


                filtrosEN.Curso = filtros.Curso;


                filtrosEN.Grado = filtros.Grado;


                filtrosEN.Facultad = filtros.Facultad;


                filtrosEN.Gastronomia = filtros.Gastronomia;


                filtrosEN.Deporte = filtros.Deporte;


                filtrosEN.Ocio = filtros.Ocio;


                filtrosEN.GustosMusicales = filtros.GustosMusicales;


                session.Update (filtrosEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UniDATESGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UniDATESGenNHibernate.Exceptions.DataLayerException ("Error in FiltrosCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (FiltrosEN filtros)
{
        try
        {
                SessionInitializeTransaction ();
                if (filtros.Busqueda != null) {
                        // Argumento OID y no colección.
                        filtros.Busqueda = (UniDATESGenNHibernate.EN.UniDATES.BusquedaEN)session.Load (typeof(UniDATESGenNHibernate.EN.UniDATES.BusquedaEN), filtros.Busqueda.IdBusqueda);

                        filtros.Busqueda.Filtros
                        .Add (filtros);
                }

                session.Save (filtros);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UniDATESGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UniDATESGenNHibernate.Exceptions.DataLayerException ("Error in FiltrosCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return filtros.IdFiltros;
}

public void Modify (FiltrosEN filtros)
{
        try
        {
                SessionInitializeTransaction ();
                FiltrosEN filtrosEN = (FiltrosEN)session.Load (typeof(FiltrosEN), filtros.IdFiltros);

                filtrosEN.ObjetivoCita = filtros.ObjetivoCita;


                filtrosEN.Universidad = filtros.Universidad;


                filtrosEN.Curso = filtros.Curso;


                filtrosEN.Grado = filtros.Grado;


                filtrosEN.Facultad = filtros.Facultad;


                filtrosEN.Gastronomia = filtros.Gastronomia;


                filtrosEN.Deporte = filtros.Deporte;


                filtrosEN.Ocio = filtros.Ocio;


                filtrosEN.GustosMusicales = filtros.GustosMusicales;

                session.Update (filtrosEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UniDATESGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UniDATESGenNHibernate.Exceptions.DataLayerException ("Error in FiltrosCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Destroy (int idFiltros
                     )
{
        try
        {
                SessionInitializeTransaction ();
                FiltrosEN filtrosEN = (FiltrosEN)session.Load (typeof(FiltrosEN), idFiltros);
                session.Delete (filtrosEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UniDATESGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UniDATESGenNHibernate.Exceptions.DataLayerException ("Error in FiltrosCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
