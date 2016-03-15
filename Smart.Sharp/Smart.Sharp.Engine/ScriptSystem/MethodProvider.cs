﻿namespace Smart.Sharp.Engine.ScriptSystem
{
  public abstract class MethodProvider
  {

    #region properties

    protected Session Session { get; private set; }

    #endregion

    #region constructor

    protected MethodProvider(Session session)
    {
      Session = session;
    }

    #endregion

  }
}
