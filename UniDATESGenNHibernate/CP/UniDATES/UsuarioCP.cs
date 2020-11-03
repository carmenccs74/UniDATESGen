
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
public partial class UsuarioCP : BasicCP
{
public UsuarioCP() : base ()
{
}

public UsuarioCP(ISession sessionAux)
        : base (sessionAux)
{
}
}
}
