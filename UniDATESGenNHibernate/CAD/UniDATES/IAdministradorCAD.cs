
using System;
using UniDATESGenNHibernate.EN.UniDATES;

namespace UniDATESGenNHibernate.CAD.UniDATES
{
public partial interface IAdministradorCAD
{
AdministradorEN ReadOIDDefault (int idAdministrador
                                );

void ModifyDefault (AdministradorEN administrador);

System.Collections.Generic.IList<AdministradorEN> ReadAllDefault (int first, int size);



int Registrarse (AdministradorEN administrador);

void Modify (AdministradorEN administrador);


void Destroy (int idAdministrador
              );


AdministradorEN ReadOID (int idAdministrador
                         );


System.Collections.Generic.IList<AdministradorEN> ReadAll (int first, int size);
}
}
