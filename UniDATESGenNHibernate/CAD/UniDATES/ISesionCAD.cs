
using System;
using UniDATESGenNHibernate.EN.UniDATES;

namespace UniDATESGenNHibernate.CAD.UniDATES
{
public partial interface ISesionCAD
{
SesionEN ReadOIDDefault (int idSesion
                         );

void ModifyDefault (SesionEN sesion);

System.Collections.Generic.IList<SesionEN> ReadAllDefault (int first, int size);



int IniciarSesion (SesionEN sesion);

int IniciarSesionconHuella (SesionEN sesion);

void FinalizarSesion (int idSesion
                      );




void Modify (SesionEN sesion);
}
}
