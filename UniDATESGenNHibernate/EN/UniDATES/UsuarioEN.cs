
using System;
// Definición clase UsuarioEN
namespace UniDATESGenNHibernate.EN.UniDATES
{
public partial class UsuarioEN
{
/**
 *	Atributo idUsuario
 */
private int idUsuario;



/**
 *	Atributo nombre
 */
private string nombre;



/**
 *	Atributo apellidos
 */
private string apellidos;



/**
 *	Atributo contraseña
 */
private String contraseña;



/**
 *	Atributo email
 */
private string email;



/**
 *	Atributo telefono
 */
private int telefono;



/**
 *	Atributo sexo
 */
private UniDATESGenNHibernate.Enumerated.UniDATES.SexoEnum sexo;



/**
 *	Atributo universidad
 */
private string universidad;



/**
 *	Atributo facultad
 */
private string facultad;



/**
 *	Atributo grado
 */
private string grado;



/**
 *	Atributo curso
 */
private int curso;



/**
 *	Atributo objetivo
 */
private UniDATESGenNHibernate.Enumerated.UniDATES.ObjetivoEnum objetivo;



/**
 *	Atributo descripcion
 */
private string descripcion;



/**
 *	Atributo gustoGastronomico
 */
private string gustoGastronomico;



/**
 *	Atributo ocio
 */
private string ocio;



/**
 *	Atributo gustoMusical
 */
private UniDATESGenNHibernate.Enumerated.UniDATES.GustosMusicalesEnum gustoMusical;



/**
 *	Atributo deporte
 */
private UniDATESGenNHibernate.Enumerated.UniDATES.DeportesEnum deporte;



/**
 *	Atributo registroCitas
 */
private string registroCitas;



/**
 *	Atributo registroDenuncias
 */
private string registroDenuncias;



/**
 *	Atributo bloqueado
 */
private char bloqueado;



/**
 *	Atributo fechaAlta
 */
private Nullable<DateTime> fechaAlta;



/**
 *	Atributo fechaBaja
 */
private Nullable<DateTime> fechaBaja;



/**
 *	Atributo orientaciónSexual
 */
private UniDATESGenNHibernate.Enumerated.UniDATES.OrientacionSexualEnum orientaciónSexual;



/**
 *	Atributo busqueda
 */
private System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.BusquedaEN> busqueda;



/**
 *	Atributo publicacion
 */
private System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.PublicacionEN> publicacion;



/**
 *	Atributo sesion
 */
private UniDATESGenNHibernate.EN.UniDATES.SesionEN sesion;



/**
 *	Atributo incidenciasDenunciadas
 */
private System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.IncidenciaEN> incidenciasDenunciadas;



/**
 *	Atributo incidenciasRecibidas  f gfn
 */
private System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.IncidenciaEN> incidenciasRecibidas;



/**
 *	Atributo citasSolicitadas
 */
private System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.CitaEN> citasSolicitadas;



/**
 *	Atributo citasPendientes
 */
private System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.CitaEN> citasPendientes;



/**
 *	Atributo mensajesEnviados
 */
private System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.MensajeEN> mensajesEnviados;



/**
 *	Atributo mensajesRecibidos
 */
private System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.MensajeEN> mensajesRecibidos;






public virtual int IdUsuario {
        get { return idUsuario; } set { idUsuario = value;  }
}



public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}



public virtual string Apellidos {
        get { return apellidos; } set { apellidos = value;  }
}



public virtual String Contraseña {
        get { return contraseña; } set { contraseña = value;  }
}



public virtual string Email {
        get { return email; } set { email = value;  }
}



public virtual int Telefono {
        get { return telefono; } set { telefono = value;  }
}



public virtual UniDATESGenNHibernate.Enumerated.UniDATES.SexoEnum Sexo {
        get { return sexo; } set { sexo = value;  }
}



public virtual string Universidad {
        get { return universidad; } set { universidad = value;  }
}



public virtual string Facultad {
        get { return facultad; } set { facultad = value;  }
}



public virtual string Grado {
        get { return grado; } set { grado = value;  }
}



public virtual int Curso {
        get { return curso; } set { curso = value;  }
}



public virtual UniDATESGenNHibernate.Enumerated.UniDATES.ObjetivoEnum Objetivo {
        get { return objetivo; } set { objetivo = value;  }
}



public virtual string Descripcion {
        get { return descripcion; } set { descripcion = value;  }
}



public virtual string GustoGastronomico {
        get { return gustoGastronomico; } set { gustoGastronomico = value;  }
}



public virtual string Ocio {
        get { return ocio; } set { ocio = value;  }
}



public virtual UniDATESGenNHibernate.Enumerated.UniDATES.GustosMusicalesEnum GustoMusical {
        get { return gustoMusical; } set { gustoMusical = value;  }
}



public virtual UniDATESGenNHibernate.Enumerated.UniDATES.DeportesEnum Deporte {
        get { return deporte; } set { deporte = value;  }
}



public virtual string RegistroCitas {
        get { return registroCitas; } set { registroCitas = value;  }
}



public virtual string RegistroDenuncias {
        get { return registroDenuncias; } set { registroDenuncias = value;  }
}



public virtual char Bloqueado {
        get { return bloqueado; } set { bloqueado = value;  }
}



public virtual Nullable<DateTime> FechaAlta {
        get { return fechaAlta; } set { fechaAlta = value;  }
}



public virtual Nullable<DateTime> FechaBaja {
        get { return fechaBaja; } set { fechaBaja = value;  }
}



public virtual UniDATESGenNHibernate.Enumerated.UniDATES.OrientacionSexualEnum OrientaciónSexual {
        get { return orientaciónSexual; } set { orientaciónSexual = value;  }
}



public virtual System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.BusquedaEN> Busqueda {
        get { return busqueda; } set { busqueda = value;  }
}



public virtual System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.PublicacionEN> Publicacion {
        get { return publicacion; } set { publicacion = value;  }
}



public virtual UniDATESGenNHibernate.EN.UniDATES.SesionEN Sesion {
        get { return sesion; } set { sesion = value;  }
}



public virtual System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.IncidenciaEN> IncidenciasDenunciadas {
        get { return incidenciasDenunciadas; } set { incidenciasDenunciadas = value;  }
}



public virtual System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.IncidenciaEN> IncidenciasRecibidas {
        get { return incidenciasRecibidas; } set { incidenciasRecibidas = value;  }
}



public virtual System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.CitaEN> CitasSolicitadas {
        get { return citasSolicitadas; } set { citasSolicitadas = value;  }
}



public virtual System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.CitaEN> CitasPendientes {
        get { return citasPendientes; } set { citasPendientes = value;  }
}



public virtual System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.MensajeEN> MensajesEnviados {
        get { return mensajesEnviados; } set { mensajesEnviados = value;  }
}



public virtual System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.MensajeEN> MensajesRecibidos {
        get { return mensajesRecibidos; } set { mensajesRecibidos = value;  }
}





public UsuarioEN()
{
        busqueda = new System.Collections.Generic.List<UniDATESGenNHibernate.EN.UniDATES.BusquedaEN>();
        publicacion = new System.Collections.Generic.List<UniDATESGenNHibernate.EN.UniDATES.PublicacionEN>();
        incidenciasDenunciadas = new System.Collections.Generic.List<UniDATESGenNHibernate.EN.UniDATES.IncidenciaEN>();
        incidenciasRecibidas = new System.Collections.Generic.List<UniDATESGenNHibernate.EN.UniDATES.IncidenciaEN>();
        citasSolicitadas = new System.Collections.Generic.List<UniDATESGenNHibernate.EN.UniDATES.CitaEN>();
        citasPendientes = new System.Collections.Generic.List<UniDATESGenNHibernate.EN.UniDATES.CitaEN>();
        mensajesEnviados = new System.Collections.Generic.List<UniDATESGenNHibernate.EN.UniDATES.MensajeEN>();
        mensajesRecibidos = new System.Collections.Generic.List<UniDATESGenNHibernate.EN.UniDATES.MensajeEN>();
}



public UsuarioEN(int idUsuario, string nombre, string apellidos, String contraseña, string email, int telefono, UniDATESGenNHibernate.Enumerated.UniDATES.SexoEnum sexo, string universidad, string facultad, string grado, int curso, UniDATESGenNHibernate.Enumerated.UniDATES.ObjetivoEnum objetivo, string descripcion, string gustoGastronomico, string ocio, UniDATESGenNHibernate.Enumerated.UniDATES.GustosMusicalesEnum gustoMusical, UniDATESGenNHibernate.Enumerated.UniDATES.DeportesEnum deporte, string registroCitas, string registroDenuncias, char bloqueado, Nullable<DateTime> fechaAlta, Nullable<DateTime> fechaBaja, UniDATESGenNHibernate.Enumerated.UniDATES.OrientacionSexualEnum orientaciónSexual, System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.BusquedaEN> busqueda, System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.PublicacionEN> publicacion, UniDATESGenNHibernate.EN.UniDATES.SesionEN sesion, System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.IncidenciaEN> incidenciasDenunciadas, System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.IncidenciaEN> incidenciasRecibidas, System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.CitaEN> citasSolicitadas, System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.CitaEN> citasPendientes, System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.MensajeEN> mensajesEnviados, System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.MensajeEN> mensajesRecibidos
                 )
{
        this.init (IdUsuario, nombre, apellidos, contraseña, email, telefono, sexo, universidad, facultad, grado, curso, objetivo, descripcion, gustoGastronomico, ocio, gustoMusical, deporte, registroCitas, registroDenuncias, bloqueado, fechaAlta, fechaBaja, orientaciónSexual, busqueda, publicacion, sesion, incidenciasDenunciadas, incidenciasRecibidas, citasSolicitadas, citasPendientes, mensajesEnviados, mensajesRecibidos);
}


public UsuarioEN(UsuarioEN usuario)
{
        this.init (IdUsuario, usuario.Nombre, usuario.Apellidos, usuario.Contraseña, usuario.Email, usuario.Telefono, usuario.Sexo, usuario.Universidad, usuario.Facultad, usuario.Grado, usuario.Curso, usuario.Objetivo, usuario.Descripcion, usuario.GustoGastronomico, usuario.Ocio, usuario.GustoMusical, usuario.Deporte, usuario.RegistroCitas, usuario.RegistroDenuncias, usuario.Bloqueado, usuario.FechaAlta, usuario.FechaBaja, usuario.OrientaciónSexual, usuario.Busqueda, usuario.Publicacion, usuario.Sesion, usuario.IncidenciasDenunciadas, usuario.IncidenciasRecibidas, usuario.CitasSolicitadas, usuario.CitasPendientes, usuario.MensajesEnviados, usuario.MensajesRecibidos);
}

private void init (int idUsuario
                   , string nombre, string apellidos, String contraseña, string email, int telefono, UniDATESGenNHibernate.Enumerated.UniDATES.SexoEnum sexo, string universidad, string facultad, string grado, int curso, UniDATESGenNHibernate.Enumerated.UniDATES.ObjetivoEnum objetivo, string descripcion, string gustoGastronomico, string ocio, UniDATESGenNHibernate.Enumerated.UniDATES.GustosMusicalesEnum gustoMusical, UniDATESGenNHibernate.Enumerated.UniDATES.DeportesEnum deporte, string registroCitas, string registroDenuncias, char bloqueado, Nullable<DateTime> fechaAlta, Nullable<DateTime> fechaBaja, UniDATESGenNHibernate.Enumerated.UniDATES.OrientacionSexualEnum orientaciónSexual, System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.BusquedaEN> busqueda, System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.PublicacionEN> publicacion, UniDATESGenNHibernate.EN.UniDATES.SesionEN sesion, System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.IncidenciaEN> incidenciasDenunciadas, System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.IncidenciaEN> incidenciasRecibidas, System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.CitaEN> citasSolicitadas, System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.CitaEN> citasPendientes, System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.MensajeEN> mensajesEnviados, System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.MensajeEN> mensajesRecibidos)
{
        this.IdUsuario = idUsuario;


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
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        UsuarioEN t = obj as UsuarioEN;
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
