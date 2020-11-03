
using System;
using UniDATESGenNHibernate.EN.UniDATES;

namespace UniDATESGenNHibernate.CAD.UniDATES
{
public partial interface IUsuarioPremiumCAD
{
UsuarioPremiumEN ReadOIDDefault (int idUsuario
                                 );

void ModifyDefault (UsuarioPremiumEN usuarioPremium);

System.Collections.Generic.IList<UsuarioPremiumEN> ReadAllDefault (int first, int size);




int HacerPremium (UsuarioPremiumEN usuarioPremium);

void Modify (UsuarioPremiumEN usuarioPremium);


void Destroy (int idUsuario
              );


void AsignarPlanes (int p_UsuarioPremium_OID, int p_planesPremium_OID);
}
}
