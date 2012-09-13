using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Machine.Specifications;
using Microsoft.Build.Framework;
using developwithpassion.specifications.rhinomocks;

namespace app.specs
{
    public class StaticLoggingSpecs
    {
        public abstract class concern : Observes<StaticLogging>
        {}

        [Subject(typeof (StaticLogging))]
        public class when_accessing_the_logging_entry_point : concern
        {
            Establish context = () =>
                                    {
                                        logger = fake.an<ILogger>();
                                    };

            Because b = () =>
                            {

                                result = StaticLogging.initialize_logger(logger); 
                            };

            It should_create_a_logger = () => result.ShouldBeOfType<ILogger>();
            static ILogger logger;
            static ILogger result;
        }
    }


    public class StaticLogging
    {
        static ILogger logger;
        
        public static ILogger initialize_logger(ILogger loggingType)
        {
            logger = loggingType;

            return logger;
        }
    }

}
