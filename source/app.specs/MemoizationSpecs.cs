using System;
using Machine.Specifications;
using developwithpassion.specifications.rhinomocks;

namespace app.specs
{
  public class MemoizationSpecs
  {
    public abstract class concern : Observes
    {
    }

    public class when_a_func_has_been_memoized : concern
    {
      Establish c = () =>
      {
        behaviour = Block.pointer_to(() =>
        {
          number_of_times_called ++;
          return 42;
        }).memoize();
      };

      Because b = () =>
      {
        result = behaviour();
        result = behaviour();
      };

      It should_not_call_the_original_behaviour_on_successive_attempts = () =>
      {
        number_of_times_called.ShouldEqual(1);
        result.ShouldEqual(42);
      };

      static int number_of_times_called;
      static Func<int> behaviour;
      static int result;
    }
  }
}