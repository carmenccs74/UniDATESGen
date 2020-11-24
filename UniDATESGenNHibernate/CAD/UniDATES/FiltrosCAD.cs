
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


public System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.UsuarioEN> Elegir (UniDATESGenNHibernate.Enumerated.UniDATES.ObjetivoEnum? p_objetivoCita, string p_universidad, int? p_curso, string p_grado, string p_facultad, UniDATESGenNHibernate.Enumerated.UniDATES.GastronomiaEnum? p_gastronomia, UniDATESGenNHibernate.Enumerated.UniDATES.DeportesEnum? p_deporte, UniDATESGenNHibernate.Enumerated.UniDATES.OcioEnum? p_ocio, UniDATESGenNHibernate.Enumerated.UniDATES.GustosMusicalesEnum ? p_gustosMusicales)
{
        System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.UsuarioEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM FiltrosEN self where select usuario FROM UsuarioEN as usuario inner join usuario.Filtros as filtro where (:p_objetivoCita is not null and filtro.ObjetivoCita = :p_objetivoCita)  or (:p_universidad is not null and filtro.Universidad = :p_universidad) or (:p_curso is not null and filtro.Curso = :p_curso) or (:p_grado is not null and filtro.Grado = :p_grado) or (:p_facultad is not null and filtro.Facultad = :p_facultad) or (:p_gastronomia is not null and filtro.Gastronomia = :p_gastronomia) or (:p_deporte is not null and filtro.Deporte = :p_deporte) or (:p_ocio is not null and filtro.Ocio = :p_ocio) or (:p_gustosMusicales is not null and filtro.GustosMusicales = :p_gustosMusicales)";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("FiltrosENElegirHQL");
                query.SetParameter ("p_objetivoCita", p_objetivoCita);
                query.SetParameter ("p_universidad", p_universidad);
                query.SetParameter ("p_curso", p_curso);
                query.SetParameter ("p_grado", p_grado);
                query.SetParameter ("p_facultad", p_facultad);
                query.SetParameter ("p_gastronomia", p_gastronomia);
                query.SetParameter ("p_deporte", p_deporte);
                query.SetParameter ("p_ocio", p_ocio);
                query.SetParameter ("p_gustosMusicales", p_gustosMusicales);

                result = query.List<UniDATESGenNHibernate.EN.UniDATES.UsuarioEN>();
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

        return result;
}
public int New_ (FiltrosEN filtros)
{
        try
        {
                SessionInitializeTransaction ();
                if (filtros.Usuario != null) {
                        // Argumento OID y no colección.
                        filtros.Usuario = (UniDATESGenNHibernate.EN.UniDATES.UsuarioEN)session.Load (typeof(UniDATESGenNHibernate.EN.UniDATES.UsuarioEN), filtros.Usuario.IdUsuario);

                        filtros.Usuario.Filtros
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
