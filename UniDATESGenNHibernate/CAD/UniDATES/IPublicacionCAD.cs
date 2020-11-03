
using System;
using UniDATESGenNHibernate.EN.UniDATES;

namespace UniDATESGenNHibernate.CAD.UniDATES
{
public partial interface IPublicacionCAD
{
PublicacionEN ReadOIDDefault (int idPublicacion
                              );

void ModifyDefault (PublicacionEN publicacion);

System.Collections.Generic.IList<PublicacionEN> ReadAllDefault (int first, int size);



int Añadir (PublicacionEN publicacion);

void Eliminar (int idPublicacion
               );


void Modify (PublicacionEN publicacion);
}
}
