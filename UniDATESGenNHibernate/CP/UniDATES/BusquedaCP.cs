
using System;
using System.Text;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using UniDATESGenNHibernate.Exceptions;
using UniDATESGenNHibernate.EN.UniDATES;
using UniDATESGenNHibernate.CAD.UniDATES;
using UniDATESGenNHibernate.CEN.UniDATES;



namespace UniDATESGenNHibernate.CP.UniDATES
{
public partial class BusquedaCP : BasicCP
{
public BusquedaCP() : base ()
{
}

public BusquedaCP(ISession sessionAux)
        : base (sessionAux)
{
}
}
}
