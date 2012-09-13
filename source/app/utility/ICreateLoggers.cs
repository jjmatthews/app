using System;

namespace app.utility
{
  public interface ICreateLoggers
  {
    IProvideAccessToLogging create_logger_bound_to(Type calling_type);
  }
}