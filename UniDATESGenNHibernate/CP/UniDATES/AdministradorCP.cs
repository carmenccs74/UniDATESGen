
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
public partial class AdministradorCP : BasicCP
{
public AdministradorCP() : base ()
{
}

public AdministradorCP(ISession sessionAux)
        : base (sessionAux)
{
}
}
}
