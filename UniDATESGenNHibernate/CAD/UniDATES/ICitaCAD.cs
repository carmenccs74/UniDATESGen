
using System;
using UniDATESGenNHibernate.EN.UniDATES;

namespace UniDATESGenNHibernate.CAD.UniDATES
{
public partial interface ICitaCAD
{
CitaEN ReadOIDDefault (int idCita
                       );

void ModifyDefault (CitaEN cita);

System.Collections.Generic.IList<CitaEN> ReadAllDefault (int first, int size);



int Aceptar (CitaEN cita);

void Rechazar (int idCita
               );
}
}
