using System.Collections.Generic;
using System.Linq;
using Machine.Specifications;
using app.web;
using developwithpassion.specifications.rhinomocks;
using developwithpassion.specifications.extensions;

namespace app.specs
{
    [Subject(typeof(CommandRegistry))]
    public class CommandRegistrySpecs
    {
        public abstract class concern : Observes<IFindCommandsForRequests,
                                          CommandRegistry>
        {

        }


        public class when_getting_a_command_for_a_request_and_it_as_the_command : concern
        {
            Establish c = () =>
            {
                all_the_commands = Enumerable.Range(1, 100).Select(x => fake.an<IProcessARequest>()).ToList();

                the_command_that_can_handle_the_request = fake.an<IProcessARequest>();
                all_the_commands.Add(the_command_that_can_handle_the_request);

                request = fake.an<IEncapsulateRequestDetails>();
                the_command_that_can_handle_the_request.setup(x => x.can_process(request)).Return(true);

                depends.on<IEnumerable<IProcessARequest>>(all_the_commands);
            };

            Because b = () =>
              result = sut.get_the_command_that_can_process_the_request(request);

            It should_return_the_command_that_an_handle_it = () =>
              result.ShouldEqual(the_command_that_can_handle_the_request);


            static IProcessARequest result;
            static IProcessARequest the_command_that_can_handle_the_request;
            static IEncapsulateRequestDetails request;
            static IList<IProcessARequest> all_the_commands;
        }
    }
}
