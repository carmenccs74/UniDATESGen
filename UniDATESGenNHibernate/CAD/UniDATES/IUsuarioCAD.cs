
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




void DarsedeBaja (int idUsuario
                  );
}
}
