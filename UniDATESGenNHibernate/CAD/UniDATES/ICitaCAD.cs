
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



int New_ (CitaEN cita);

void Rechazar (int idCita
               );


System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.CitaEN> DameChats (int ? usu_id);


System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.CitaEN> DamePendientes (int ? usu_id);


CitaEN ReadOID (int idCita
                );


System.Collections.Generic.IList<CitaEN> ReadAll (int first, int size);


void Aceptar (CitaEN cita);
}
}
