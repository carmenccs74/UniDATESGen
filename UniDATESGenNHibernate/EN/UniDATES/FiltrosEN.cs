
using System;
// Definición clase FiltrosEN
namespace UniDATESGenNHibernate.EN.UniDATES
{
public partial class FiltrosEN
{
/**
 *	Atributo objetivoCita
 */
private UniDATESGenNHibernate.Enumerated.UniDATES.ObjetivoEnum objetivoCita;



/**
 *	Atributo universidad
 */
private string universidad;



/**
 *	Atributo curso
 */
private int curso;



/**
 *	Atributo grado
 */
private string grado;



/**
 *	Atributo facultad
 */
private string facultad;



/**
 *	Atributo gastronomia
 */
private UniDATESGenNHibernate.Enumerated.UniDATES.GastronomiaEnum gastronomia;



/**
 *	Atributo deporte
 */
private UniDATESGenNHibernate.Enumerated.UniDATES.DeportesEnum deporte;



/**
 *	Atributo ocio
 */
private UniDATESGenNHibernate.Enumerated.UniDATES.OcioEnum ocio;



/**
 *	Atributo gustosMusicales
 */
private UniDATESGenNHibernate.Enumerated.UniDATES.GustosMusicalesEnum gustosMusicales;



/**
 *	Atributo busqueda
 */
private UniDATESGenNHibernate.EN.UniDATES.BusquedaEN busqueda;



/**
 *	Atributo idFiltros
 */
private int idFiltros;






public virtual UniDATESGenNHibernate.Enumerated.UniDATES.ObjetivoEnum ObjetivoCita {
        get { return objetivoCita; } set { objetivoCita = value;  }
}



public virtual string Universidad {
        get { return universidad; } set { universidad = value;  }
}



public virtual int Curso {
        get { return curso; } set { curso = value;  }
}



public virtual string Grado {
        get { return grado; } set { grado = value;  }
}



public virtual string Facultad {
        get { return facultad; } set { facultad = value;  }
}



public virtual UniDATESGenNHibernate.Enumerated.UniDATES.GastronomiaEnum Gastronomia {
        get { return gastronomia; } set { gastronomia = value;  }
}



public virtual UniDATESGenNHibernate.Enumerated.UniDATES.DeportesEnum Deporte {
        get { return deporte; } set { deporte = value;  }
}



public virtual UniDATESGenNHibernate.Enumerated.UniDATES.OcioEnum Ocio {
        get { return ocio; } set { ocio = value;  }
}



public virtual UniDATESGenNHibernate.Enumerated.UniDATES.GustosMusicalesEnum GustosMusicales {
        get { return gustosMusicales; } set { gustosMusicales = value;  }
}



public virtual UniDATESGenNHibernate.EN.UniDATES.BusquedaEN Busqueda {
        get { return busqueda; } set { busqueda = value;  }
}



public virtual int IdFiltros {
        get { return idFiltros; } set { idFiltros = value;  }
}





public FiltrosEN()
{
}



public FiltrosEN(int idFiltros, UniDATESGenNHibernate.Enumerated.UniDATES.ObjetivoEnum objetivoCita, string universidad, int curso, string grado, string facultad, UniDATESGenNHibernate.Enumerated.UniDATES.GastronomiaEnum gastronomia, UniDATESGenNHibernate.Enumerated.UniDATES.DeportesEnum deporte, UniDATESGenNHibernate.Enumerated.UniDATES.OcioEnum ocio, UniDATESGenNHibernate.Enumerated.UniDATES.GustosMusicalesEnum gustosMusicales, UniDATESGenNHibernate.EN.UniDATES.BusquedaEN busqueda
                 )
{
        this.init (IdFiltros, objetivoCita, universidad, curso, grado, facultad, gastronomia, deporte, ocio, gustosMusicales, busqueda);
}


public FiltrosEN(FiltrosEN filtros)
{
        this.init (IdFiltros, filtros.ObjetivoCita, filtros.Universidad, filtros.Curso, filtros.Grado, filtros.Facultad, filtros.Gastronomia, filtros.Deporte, filtros.Ocio, filtros.GustosMusicales, filtros.Busqueda);
}

private void init (int idFiltros
                   , UniDATESGenNHibernate.Enumerated.UniDATES.ObjetivoEnum objetivoCita, string universidad, int curso, string grado, string facultad, UniDATESGenNHibernate.Enumerated.UniDATES.GastronomiaEnum gastronomia, UniDATESGenNHibernate.Enumerated.UniDATES.DeportesEnum deporte, UniDATESGenNHibernate.Enumerated.UniDATES.OcioEnum ocio, UniDATESGenNHibernate.Enumerated.UniDATES.GustosMusicalesEnum gustosMusicales, UniDATESGenNHibernate.EN.UniDATES.BusquedaEN busqueda)
{
        this.IdFiltros = idFiltros;


        this.ObjetivoCita = objetivoCita;

        this.Universidad = universidad;

        this.Curso = curso;

        this.Grado = grado;

        this.Facultad = facultad;

        this.Gastronomia = gastronomia;

        this.Deporte = deporte;

        this.Ocio = ocio;

        this.GustosMusicales = gustosMusicales;

        this.Busqueda = busqueda;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        FiltrosEN t = obj as FiltrosEN;
        if (t == null)
                return false;
        if (IdFiltros.Equals (t.IdFiltros))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.IdFiltros.GetHashCode ();
        return hash;
}
}
}
