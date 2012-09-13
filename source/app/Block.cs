using System;

namespace app
{
  public class Block
  {
    public static Func<T> pointer_to<T>(Func<T> action)
    {
      return action; 
    } 

    public static Action pointer_to(Action action)
    {
      return action; 
    } 
  }
}