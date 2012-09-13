using System;

namespace app
{
  public static class FuncExtensions
  {
    public static Func<T> memoize<T>(this Func<T> query)
    {
      var is_cached = false;
      T cached_value = default(T);
      return () =>
      {
        if (is_cached) return cached_value;
        cached_value = query();
        is_cached = true;
        return cached_value;
      };
    }
  }
}