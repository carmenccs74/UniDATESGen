
using System;
// Definición clase UsuarioPremiumEN
namespace UniDATESGenNHibernate.EN.UniDATES
{
public partial class UsuarioPremiumEN                                                                       : UniDATESGenNHibernate.EN.UniDATES.UsuarioEN


{
/**
 *	Atributo numeroTarjeta
 */
private int numeroTarjeta;



/**
 *	Atributo titular
 */
private string titular;



/**
 *	Atributo fechaCaducidad
 */
private Nullable<DateTime> fechaCaducidad;



/**
 *	Atributo cvv
 */
private int cvv;



/**
 *	Atributo planesPremium
 */
private UniDATESGenNHibernate.EN.UniDATES.PlanesPremiumEN planesPremium;






public virtual int NumeroTarjeta {
        get { return numeroTarjeta; } set { numeroTarjeta = value;  }
}



public virtual string Titular {
        get { return titular; } set { titular = value;  }
}



public virtual Nullable<DateTime> FechaCaducidad {
        get { return fechaCaducidad; } set { fechaCaducidad = value;  }
}



public virtual int Cvv {
        get { return cvv; } set { cvv = value;  }
}



public virtual UniDATESGenNHibernate.EN.UniDATES.PlanesPremiumEN PlanesPremium {
        get { return planesPremium; } set { planesPremium = value;  }
}





public UsuarioPremiumEN() : base ()
{
}



public UsuarioPremiumEN(int idUsuario, int numeroTarjeta, string titular, Nullable<DateTime> fechaCaducidad, int cvv, UniDATESGenNHibernate.EN.UniDATES.PlanesPremiumEN planesPremium
                        , string nombre, string apellidos, String contraseña, string email, int telefono, UniDATESGenNHibernate.Enumerated.UniDATES.SexoEnum sexo, string universidad, string facultad, string grado, int curso, UniDATESGenNHibernate.Enumerated.UniDATES.ObjetivoEnum objetivo, string descripcion, UniDATESGenNHibernate.Enumerated.UniDATES.GastronomiaEnum gustoGastronomico, UniDATESGenNHibernate.Enumerated.UniDATES.OcioEnum ocio, UniDATESGenNHibernate.Enumerated.UniDATES.GustosMusicalesEnum gustoMusical, UniDATESGenNHibernate.Enumerated.UniDATES.DeportesEnum deporte, string registroCitas, string registroDenuncias, bool bloqueado, Nullable<DateTime> fechaAlta, Nullable<DateTime> fechaBaja, UniDATESGenNHibernate.Enumerated.UniDATES.OrientacionSexualEnum orientaciónSexual, System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.BusquedaEN> busqueda, System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.PublicacionEN> publicacion, System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.SesionEN> sesion, System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.IncidenciaEN> incidenciasDenunciadas, System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.IncidenciaEN> incidenciasRecibidas, System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.CitaEN> citasSolicitadas, System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.CitaEN> citasPendientes, System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.MensajeEN> mensajesEnviados, System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.MensajeEN> mensajesRecibidos, bool denunciado, bool premium, string usuariosBloqueados
                        )
{
        this.init (IdUsuario, numeroTarjeta, titular, fechaCaducidad, cvv, planesPremium, nombre, apellidos, contraseña, email, telefono, sexo, universidad, facultad, grado, curso, objetivo, descripcion, gustoGastronomico, ocio, gustoMusical, deporte, registroCitas, registroDenuncias, bloqueado, fechaAlta, fechaBaja, orientaciónSexual, busqueda, publicacion, sesion, incidenciasDenunciadas, incidenciasRecibidas, citasSolicitadas, citasPendientes, mensajesEnviados, mensajesRecibidos, denunciado, premium, usuariosBloqueados);
}


public UsuarioPremiumEN(UsuarioPremiumEN usuarioPremium)
{
        this.init (IdUsuario, usuarioPremium.NumeroTarjeta, usuarioPremium.Titular, usuarioPremium.FechaCaducidad, usuarioPremium.Cvv, usuarioPremium.PlanesPremium, usuarioPremium.Nombre, usuarioPremium.Apellidos, usuarioPremium.Contraseña, usuarioPremium.Email, usuarioPremium.Telefono, usuarioPremium.Sexo, usuarioPremium.Universidad, usuarioPremium.Facultad, usuarioPremium.Grado, usuarioPremium.Curso, usuarioPremium.Objetivo, usuarioPremium.Descripcion, usuarioPremium.GustoGastronomico, usuarioPremium.Ocio, usuarioPremium.GustoMusical, usuarioPremium.Deporte, usuarioPremium.RegistroCitas, usuarioPremium.RegistroDenuncias, usuarioPremium.Bloqueado, usuarioPremium.FechaAlta, usuarioPremium.FechaBaja, usuarioPremium.OrientaciónSexual, usuarioPremium.Busqueda, usuarioPremium.Publicacion, usuarioPremium.Sesion, usuarioPremium.IncidenciasDenunciadas, usuarioPremium.IncidenciasRecibidas, usuarioPremium.CitasSolicitadas, usuarioPremium.CitasPendientes, usuarioPremium.MensajesEnviados, usuarioPremium.MensajesRecibidos, usuarioPremium.Denunciado, usuarioPremium.Premium, usuarioPremium.UsuariosBloqueados);
}

private void init (int idUsuario
                   , int numeroTarjeta, string titular, Nullable<DateTime> fechaCaducidad, int cvv, UniDATESGenNHibernate.EN.UniDATES.PlanesPremiumEN planesPremium, string nombre, string apellidos, String contraseña, string email, int telefono, UniDATESGenNHibernate.Enumerated.UniDATES.SexoEnum sexo, string universidad, string facultad, string grado, int curso, UniDATESGenNHibernate.Enumerated.UniDATES.ObjetivoEnum objetivo, string descripcion, UniDATESGenNHibernate.Enumerated.UniDATES.GastronomiaEnum gustoGastronomico, UniDATESGenNHibernate.Enumerated.UniDATES.OcioEnum ocio, UniDATESGenNHibernate.Enumerated.UniDATES.GustosMusicalesEnum gustoMusical, UniDATESGenNHibernate.Enumerated.UniDATES.DeportesEnum deporte, string registroCitas, string registroDenuncias, bool bloqueado, Nullable<DateTime> fechaAlta, Nullable<DateTime> fechaBaja, UniDATESGenNHibernate.Enumerated.UniDATES.OrientacionSexualEnum orientaciónSexual, System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.BusquedaEN> busqueda, System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.PublicacionEN> publicacion, System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.SesionEN> sesion, System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.IncidenciaEN> incidenciasDenunciadas, System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.IncidenciaEN> incidenciasRecibidas, System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.CitaEN> citasSolicitadas, System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.CitaEN> citasPendientes, System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.MensajeEN> mensajesEnviados, System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.MensajeEN> mensajesRecibidos, bool denunciado, bool premium, string usuariosBloqueados)
{
        this.IdUsuario = idUsuario;


        this.NumeroTarjeta = numeroTarjeta;

        this.Titular = titular;

        this.FechaCaducidad = fechaCaducidad;

        this.Cvv = cvv;

        this.PlanesPremium = planesPremium;

        this.Nombre = nombre;

        this.Apellidos = apellidos;

        this.Contraseña = contraseña;

        this.Email = email;

        this.Telefono = telefono;

        this.Sexo = sexo;

        this.Universidad = universidad;

        this.Facultad = facultad;

        this.Grado = grado;

        this.Curso = curso;

        this.Objetivo = objetivo;

        this.Descripcion = descripcion;

        this.GustoGastronomico = gustoGastronomico;

        this.Ocio = ocio;

        this.GustoMusical = gustoMusical;

        this.Deporte = deporte;

        this.RegistroCitas = registroCitas;

        this.RegistroDenuncias = registroDenuncias;

        this.Bloqueado = bloqueado;

        this.FechaAlta = fechaAlta;

        this.FechaBaja = fechaBaja;

        this.OrientaciónSexual = orientaciónSexual;

        this.Busqueda = busqueda;

        this.Publicacion = publicacion;

        this.Sesion = sesion;

        this.IncidenciasDenunciadas = incidenciasDenunciadas;

        this.IncidenciasRecibidas = incidenciasRecibidas;

        this.CitasSolicitadas = citasSolicitadas;

        this.CitasPendientes = citasPendientes;

        this.MensajesEnviados = mensajesEnviados;

        this.MensajesRecibidos = mensajesRecibidos;

        this.Denunciado = denunciado;

        this.Premium = premium;

        this.UsuariosBloqueados = usuariosBloqueados;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        UsuarioPremiumEN t = obj as UsuarioPremiumEN;
        if (t == null)
                return false;
        if (IdUsuario.Equals (t.IdUsuario))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.IdUsuario.GetHashCode ();
        return hash;
}
}
}
