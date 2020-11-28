

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

public System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.UsuarioEN> BuscarUsuario (string p_nombre)
{
        return _IUsuarioCAD.BuscarUsuario (p_nombre);
}
public void DarsedeBaja (int idUsuario
                         )
{
        _IUsuarioCAD.DarsedeBaja (idUsuario);
}

public System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.UsuarioEN> DameUsuarioPorFiltro (UniDATESGenNHibernate.Enumerated.UniDATES.SexoEnum? p_sexo, string p_universidad, string p_facultad, string p_grado, int? p_curso, UniDATESGenNHibernate.Enumerated.UniDATES.ObjetivoEnum? p_objetivo, UniDATESGenNHibernate.Enumerated.UniDATES.GastronomiaEnum? p_gustoGastronomico, UniDATESGenNHibernate.Enumerated.UniDATES.OcioEnum? p_ocio, UniDATESGenNHibernate.Enumerated.UniDATES.GustosMusicalesEnum? p_gustoMusical, UniDATESGenNHibernate.Enumerated.UniDATES.DeportesEnum ? p_deporte)
{
        return _IUsuarioCAD.DameUsuarioPorFiltro (p_sexo, p_universidad, p_facultad, p_grado, p_curso, p_objetivo, p_gustoGastronomico, p_ocio, p_gustoMusical, p_deporte);
}
public System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.UsuarioEN> DameUsuariosBloqueados ()
{
        return _IUsuarioCAD.DameUsuariosBloqueados ();
}
public System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.UsuarioEN> DameUsuariosDenunciados ()
{
        return _IUsuarioCAD.DameUsuariosDenunciados ();
}
public System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.UsuarioEN> DameUsuariosRegistrados ()
{
        return _IUsuarioCAD.DameUsuariosRegistrados ();
}
public System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.UsuarioEN> DameUsuariosEliminados ()
{
        return _IUsuarioCAD.DameUsuariosEliminados ();
}
public UsuarioEN ReadOID (int idUsuario
                          )
{
        UsuarioEN usuarioEN = null;

        usuarioEN = _IUsuarioCAD.ReadOID (idUsuario);
        return usuarioEN;
}

public System.Collections.Generic.IList<UsuarioEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<UsuarioEN> list = null;

        list = _IUsuarioCAD.ReadAll (first, size);
        return list;
}
public System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.UsuarioEN> DameUsuariosPremium ()
{
        return _IUsuarioCAD.DameUsuariosPremium ();
}
public System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.UsuarioEN> DameUsuariosDadosDeBaja ()
{
        return _IUsuarioCAD.DameUsuariosDadosDeBaja ();
}
}
}
