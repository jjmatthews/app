using Machine.Specifications;
using app.utility;
using developwithpassion.specifications.rhinomocks;
using developwithpassion.specifications.extensions;

namespace app.specs.utility
{
  public class LogSpecs
  {
    public abstract class concern : Observes<Log>
    {
    }

    [Subject(typeof(Log))]
    public class when_accessing_logging_functionality : concern
    {
      Establish context = () =>
      {
        logger = fake.an<IProvideAccessToLogging>();
        log_factory = fake.an<ICreateLoggers>();

        log_factory.setup(x => x.create_logger_bound_to(typeof(when_accessing_logging_functionality))).Return(logger);
        GetLoggingFactory_Behaviour item = () => log_factory;
        spec.change(() => Log.logging_factory_resolution).to(item);
      };

      Because b = () =>
        result = Log.an;

      It should_return_a_logger_bound_to_the_calling_type = () => 
        result.ShouldEqual(logger);

      static IProvideAccessToLogging logger;
      static IProvideAccessToLogging result;
      static GetLoggingFactory_Behaviour logging_factory_behaviour;
      static ICreateLoggers log_factory;
    }
  }
}