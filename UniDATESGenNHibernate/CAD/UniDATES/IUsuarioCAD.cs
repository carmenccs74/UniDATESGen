
using System;
using UniDATESGenNHibernate.EN.UniDATES;

namespace UniDATESGenNHibernate.CAD.UniDATES
{
public partial interface IUsuarioCAD
{
UsuarioEN ReadOIDDefault (int idUsuario
                          );

void ModifyDefault (UsuarioEN usuario);

System.Collections.Generic.IList<UsuarioEN> ReadAllDefault (int first, int size);









int Registrarse (UsuarioEN usuario);

void EditarPerfil (UsuarioEN usuario);


System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.UsuarioEN> BuscarUsuario (string p_nombre);


void DarsedeBaja (int idUsuario
                  );


System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.UsuarioEN> DameUsuarioPorFiltro (UniDATESGenNHibernate.Enumerated.UniDATES.SexoEnum? p_sexo, string p_universidad, string p_facultad, string p_grado, int? p_curso, UniDATESGenNHibernate.Enumerated.UniDATES.ObjetivoEnum? p_objetivo, UniDATESGenNHibernate.Enumerated.UniDATES.GastronomiaEnum? p_gustoGastronomico, UniDATESGenNHibernate.Enumerated.UniDATES.OcioEnum? p_ocio, UniDATESGenNHibernate.Enumerated.UniDATES.GustosMusicalesEnum? p_gustoMusical, UniDATESGenNHibernate.Enumerated.UniDATES.DeportesEnum ? p_deporte);


System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.UsuarioEN> DameUsuariosBloqueados ();


System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.UsuarioEN> DameUsuariosDenunciados ();


System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.UsuarioEN> DameUsuariosRegistrados ();


System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.UsuarioEN> DameUsuariosEliminados ();


UsuarioEN ReadOID (int idUsuario
                   );


System.Collections.Generic.IList<UsuarioEN> ReadAll (int first, int size);


System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.UsuarioEN> DameUsuariosPremium ();
}
}
