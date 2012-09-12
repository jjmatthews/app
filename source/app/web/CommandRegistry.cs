using System.Collections.Generic;

namespace app.web
{
    public class CommandRegistry : IFindCommandsForRequests
    {
        IEnumerable<IProcessARequest> all_commands;

        public CommandRegistry(IEnumerable<IProcessARequest> all_commands)
        {
            this.all_commands = all_commands;
        }

        public IProcessARequest get_the_command_that_can_process_the_request(IEncapsulateRequestDetails request)
        {
            foreach (var commands in all_commands)
            {
               if(commands.can_process(request))
                   return commands;
            }

            return new NullCommand();
        }
    }
}