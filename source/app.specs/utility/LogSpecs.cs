using Machine.Specifications;
using app.utility;
using developwithpassion.specifications.extensions;
using developwithpassion.specifications.rhinomocks;

namespace app.specs.utility
{
    public class LogSpecs
    {
        public abstract class concern : Observes<Log>
        {}

        [Subject(typeof (Log))]
        public class when_create_a_logger : concern
        {
            Establish context = () =>
                                    {
                                        logger = fake.an<ILog>();
                                        GetCurrentLoggingBehaviour item = ofLogger => logger;

                                        spec.change(() => Log.logging_behaviour).to(item);


                               };

            Because b = () => { result = Log.an<when_create_a_logger>(); };

            It should_return_the_same_logging_behaviour = () => result.ShouldEqual(logger);
            static ILog logger;
            static ILog result;
            static GetCurrentLoggingBehaviour logging_behaviour;
        }
    }
}
