
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
 * Clase Busqueda:
 *
 */

namespace UniDATESGenNHibernate.CAD.UniDATES
{
public partial class BusquedaCAD : BasicCAD, IBusquedaCAD
{
public BusquedaCAD() : base ()
{
}

public BusquedaCAD(ISession sessionAux) : base (sessionAux)
{
}



public BusquedaEN ReadOIDDefault (int idBusqueda
                                  )
{
        BusquedaEN busquedaEN = null;

        try
        {
                SessionInitializeTransaction ();
                busquedaEN = (BusquedaEN)session.Get (typeof(BusquedaEN), idBusqueda);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UniDATESGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UniDATESGenNHibernate.Exceptions.DataLayerException ("Error in BusquedaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return busquedaEN;
}

public System.Collections.Generic.IList<BusquedaEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<BusquedaEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(BusquedaEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<BusquedaEN>();
                        else
                                result = session.CreateCriteria (typeof(BusquedaEN)).List<BusquedaEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UniDATESGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UniDATESGenNHibernate.Exceptions.DataLayerException ("Error in BusquedaCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (BusquedaEN busqueda)
{
        try
        {
                SessionInitializeTransaction ();
                BusquedaEN busquedaEN = (BusquedaEN)session.Load (typeof(BusquedaEN), busqueda.IdBusqueda);



                session.Update (busquedaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UniDATESGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UniDATESGenNHibernate.Exceptions.DataLayerException ("Error in BusquedaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int Buscar (BusquedaEN busqueda)
{
        try
        {
                SessionInitializeTransaction ();
                if (busqueda.Usuario != null) {
                        // Argumento OID y no colección.
                        busqueda.Usuario = (UniDATESGenNHibernate.EN.UniDATES.UsuarioEN)session.Load (typeof(UniDATESGenNHibernate.EN.UniDATES.UsuarioEN), busqueda.Usuario.IdUsuario);

                        busqueda.Usuario.Busqueda
                        .Add (busqueda);
                }

                session.Save (busqueda);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UniDATESGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UniDATESGenNHibernate.Exceptions.DataLayerException ("Error in BusquedaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return busqueda.IdBusqueda;
}
}
}
