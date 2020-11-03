
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
 * Clase Resultado:
 *
 */

namespace UniDATESGenNHibernate.CAD.UniDATES
{
public partial class ResultadoCAD : BasicCAD, IResultadoCAD
{
public ResultadoCAD() : base ()
{
}

public ResultadoCAD(ISession sessionAux) : base (sessionAux)
{
}



public ResultadoEN ReadOIDDefault (int idResultado
                                   )
{
        ResultadoEN resultadoEN = null;

        try
        {
                SessionInitializeTransaction ();
                resultadoEN = (ResultadoEN)session.Get (typeof(ResultadoEN), idResultado);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UniDATESGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UniDATESGenNHibernate.Exceptions.DataLayerException ("Error in ResultadoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return resultadoEN;
}

public System.Collections.Generic.IList<ResultadoEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<ResultadoEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(ResultadoEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<ResultadoEN>();
                        else
                                result = session.CreateCriteria (typeof(ResultadoEN)).List<ResultadoEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UniDATESGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UniDATESGenNHibernate.Exceptions.DataLayerException ("Error in ResultadoCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (ResultadoEN resultado)
{
        try
        {
                SessionInitializeTransaction ();
                ResultadoEN resultadoEN = (ResultadoEN)session.Load (typeof(ResultadoEN), resultado.IdResultado);

                session.Update (resultadoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UniDATESGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UniDATESGenNHibernate.Exceptions.DataLayerException ("Error in ResultadoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int Mostrar (ResultadoEN resultado)
{
        try
        {
                SessionInitializeTransaction ();
                if (resultado.Busqueda != null) {
                        // Argumento OID y no colección.
                        resultado.Busqueda = (UniDATESGenNHibernate.EN.UniDATES.BusquedaEN)session.Load (typeof(UniDATESGenNHibernate.EN.UniDATES.BusquedaEN), resultado.Busqueda.IdBusqueda);

                        resultado.Busqueda.Resultado
                        .Add (resultado);
                }

                session.Save (resultado);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UniDATESGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UniDATESGenNHibernate.Exceptions.DataLayerException ("Error in ResultadoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return resultado.IdResultado;
}

public void Destroy (int idResultado
                     )
{
        try
        {
                SessionInitializeTransaction ();
                ResultadoEN resultadoEN = (ResultadoEN)session.Load (typeof(ResultadoEN), idResultado);
                session.Delete (resultadoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UniDATESGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UniDATESGenNHibernate.Exceptions.DataLayerException ("Error in ResultadoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
