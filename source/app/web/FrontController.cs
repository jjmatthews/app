namespace app.web
{
    public class FrontController : IProcessWebRequests
    {
        readonly IFindCommandsForRequests command_registry;

        public FrontController(IFindCommandsForRequests command_registry)
        {
            this.command_registry = command_registry;
        }

        public void process(IEncapsulateRequestDetails a_new_request)
        {
            var command = command_registry.get_the_command_that_can_process_the_request();
            command.process(a_new_request);
        }
    }
}