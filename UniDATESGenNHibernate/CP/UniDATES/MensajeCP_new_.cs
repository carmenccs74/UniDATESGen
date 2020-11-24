
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using System.Collections.Generic;
using UniDATESGenNHibernate.EN.UniDATES;
using UniDATESGenNHibernate.CAD.UniDATES;
using UniDATESGenNHibernate.CEN.UniDATES;



/*PROTECTED REGION ID(usingUniDATESGenNHibernate.CP.UniDATES_Mensaje_new_) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace UniDATESGenNHibernate.CP.UniDATES
{
public partial class MensajeCP : BasicCP
{
public UniDATESGenNHibernate.EN.UniDATES.MensajeEN New_ (string p_texto, string p_imagen, string p_video, int p_emisor, int p_receptor)
{
        /*PROTECTED REGION ID(UniDATESGenNHibernate.CP.UniDATES_Mensaje_new_) ENABLED START*/

        IMensajeCAD mensajeCAD = null;
        MensajeCEN mensajeCEN = null;
        CitaCAD citaCAD = null;
        CitaCEN citaCEN = null;

        UniDATESGenNHibernate.EN.UniDATES.MensajeEN result = null;


        try
        {
                SessionInitializeTransaction ();
                mensajeCAD = new MensajeCAD (session);
                mensajeCEN = new  MensajeCEN (mensajeCAD);


                citaCAD = new CitaCAD (session);
                citaCEN = new CitaCEN (citaCAD);



                int oid;
                //Initialized MensajeEN
                MensajeEN mensajeEN;
                mensajeEN = new MensajeEN ();
                mensajeEN.Texto = p_texto;

                mensajeEN.Imagen = p_imagen;

                mensajeEN.Video = p_video;


                if (p_emisor != -1) {
                        mensajeEN.Emisor = new UniDATESGenNHibernate.EN.UniDATES.UsuarioEN ();
                        mensajeEN.Emisor.IdUsuario = p_emisor;
                }


                if (p_receptor != -1) {
                        mensajeEN.Receptor = new UniDATESGenNHibernate.EN.UniDATES.UsuarioEN ();
                        mensajeEN.Receptor.IdUsuario = p_receptor;
                }

                //Call to MensajeCAD

                oid = mensajeCAD.New_ (mensajeEN);
                CitaEN citaEN = null;

                IList<CitaEN> citasSolicitadasE = citaCEN.DameChats (mensajeEN.Emisor.Nombre);
                IList<CitaEN> citasSolicitadasR = citaCEN.DameChats (mensajeEN.Receptor.Nombre);
                int idCita = -1;
                foreach (CitaEN cit in citasSolicitadasE) {
                        int idCitaEmisor = cit.IdCita;
                        //Console.WriteLine ("IDCita emisor: " + idCitaEmisor);
                        foreach (CitaEN cita in citasSolicitadasR) {
                                int idCitaReceptor = cita.IdCita;
                                // Console.WriteLine ("IdCitaReceptor: " + idCitaReceptor);
                                if (idCitaEmisor == idCitaReceptor) {
                                        idCita = idCitaEmisor;
                                }
                        }
                }

                if (idCita != -1) {
                        citaEN = citaCEN.ReadOID (idCita);
                }


                if (citaEN != null) {
                        result = mensajeCAD.ReadOIDDefault (oid);
                }



                SessionCommit ();
        }
        catch (Exception ex)
        {
                SessionRollBack ();
                throw ex;
        }
        finally
        {
                SessionClose ();
        }
        return result;


        /*PROTECTED REGION END*/
}
}
}
