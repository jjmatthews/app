using System;

namespace app.utility
{
  public interface ICreateLoggers
  {
    ILog create_logger_bound_to(Type calling_type);
  }
}