
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


                usuarioEN.Bloqueado = usuario.Bloqueado;


                usuarioEN.FechaAlta = usuario.FechaAlta;


                usuarioEN.FechaBaja = usuario.FechaBaja;


                usuarioEN.OrientaciónSexual = usuario.OrientaciónSexual;











                usuarioEN.Denunciado = usuario.Denunciado;


                usuarioEN.Premium = usuario.Premium;


                usuarioEN.UsuariosBloqueados = usuario.UsuariosBloqueados;



                usuarioEN.Foto = usuario.Foto;

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
public System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.UsuarioEN> BuscarUsuario (string p_nombre)
{
        System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.UsuarioEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM UsuarioEN self where select usu FROM UsuarioEN as usu where usu.Nombre = :p_nombre";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("UsuarioENBuscarUsuarioHQL");
                query.SetParameter ("p_nombre", p_nombre);

                result = query.List<UniDATESGenNHibernate.EN.UniDATES.UsuarioEN>();
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

        return result;
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

public System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.UsuarioEN> DameUsuarioPorFiltro (UniDATESGenNHibernate.Enumerated.UniDATES.SexoEnum? p_sexo, string p_universidad, string p_facultad, string p_grado, int? p_curso, UniDATESGenNHibernate.Enumerated.UniDATES.ObjetivoEnum? p_objetivo, UniDATESGenNHibernate.Enumerated.UniDATES.GastronomiaEnum? p_gustoGastronomico, UniDATESGenNHibernate.Enumerated.UniDATES.OcioEnum? p_ocio, UniDATESGenNHibernate.Enumerated.UniDATES.GustosMusicalesEnum? p_gustoMusical, UniDATESGenNHibernate.Enumerated.UniDATES.DeportesEnum ? p_deporte)
{
        System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.UsuarioEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM UsuarioEN self where select usu FROM UsuarioEN as usu where (:p_sexo is not null and usu.Sexo = :p_sexo) or (:p_universidad is not null and usu.Universidad = :p_universidad) or (:p_facultad is not null and usu.Facultad = :p_facultad) or (:p_grado is not null and usu.Grado = :p_grado) or (:p_curso is not null and usu.Curso = :p_curso) or (:p_objetivo is not null and usu.Objetivo = :p_objetivo) or (:p_gustoGastronomico is not null and usu.GustoGastronomico = :p_gustoGastronomico) or (:p_ocio is not null and usu.Ocio = :p_ocio) or (:p_gustoMusical is not null and usu.GustoMusical = :p_gustoMusical) or (:p_deporte is not null and usu.Deporte = :p_deporte)";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("UsuarioENDameUsuarioPorFiltroHQL");
                query.SetParameter ("p_sexo", p_sexo);
                query.SetParameter ("p_universidad", p_universidad);
                query.SetParameter ("p_facultad", p_facultad);
                query.SetParameter ("p_grado", p_grado);
                query.SetParameter ("p_curso", p_curso);
                query.SetParameter ("p_objetivo", p_objetivo);
                query.SetParameter ("p_gustoGastronomico", p_gustoGastronomico);
                query.SetParameter ("p_ocio", p_ocio);
                query.SetParameter ("p_gustoMusical", p_gustoMusical);
                query.SetParameter ("p_deporte", p_deporte);

                result = query.List<UniDATESGenNHibernate.EN.UniDATES.UsuarioEN>();
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

        return result;
}
public System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.UsuarioEN> DameUsuariosBloqueados ()
{
        System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.UsuarioEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM UsuarioEN self where select usu FROM UsuarioEN as usu where usu.Bloqueado = true";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("UsuarioENDameUsuariosBloqueadosHQL");

                result = query.List<UniDATESGenNHibernate.EN.UniDATES.UsuarioEN>();
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

        return result;
}
public System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.UsuarioEN> DameUsuariosDenunciados ()
{
        System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.UsuarioEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM UsuarioEN self where select usu FROM UsuarioEN as usu where usu.Denunciado = true";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("UsuarioENDameUsuariosDenunciadosHQL");

                result = query.List<UniDATESGenNHibernate.EN.UniDATES.UsuarioEN>();
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

        return result;
}
public System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.UsuarioEN> DameUsuariosRegistrados ()
{
        System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.UsuarioEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM UsuarioEN self where select usu FROM UsuarioEN as usu where (usu.FechaBaja is null)";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("UsuarioENDameUsuariosRegistradosHQL");

                result = query.List<UniDATESGenNHibernate.EN.UniDATES.UsuarioEN>();
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

        return result;
}
public System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.UsuarioEN> DameUsuariosEliminados ()
{
        System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.UsuarioEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM UsuarioEN self where select usu FROM UsuarioEN as usu where (usu.FechaBaja is not null)";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("UsuarioENDameUsuariosEliminadosHQL");

                result = query.List<UniDATESGenNHibernate.EN.UniDATES.UsuarioEN>();
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

        return result;
}
//Sin e: ReadOID
//Con e: UsuarioEN
public UsuarioEN ReadOID (int idUsuario
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

public System.Collections.Generic.IList<UsuarioEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<UsuarioEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(UsuarioEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<UsuarioEN>();
                else
                        result = session.CreateCriteria (typeof(UsuarioEN)).List<UsuarioEN>();
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

        return result;
}

public System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.UsuarioEN> DameUsuariosPremium ()
{
        System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.UsuarioEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM UsuarioEN self where select usu FROM UsuarioEN as usu where usu.Premium = true";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("UsuarioENDameUsuariosPremiumHQL");

                result = query.List<UniDATESGenNHibernate.EN.UniDATES.UsuarioEN>();
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

        return result;
}
public System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.UsuarioEN> DameUsuariosDadosDeBaja ()
{
        System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.UsuarioEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM UsuarioEN self where Select usu FROM UsuarioEN as usu where (usu.FechaBaja is not null)";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("UsuarioENDameUsuariosDadosDeBajaHQL");

                result = query.List<UniDATESGenNHibernate.EN.UniDATES.UsuarioEN>();
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

        return result;
}
}
}
