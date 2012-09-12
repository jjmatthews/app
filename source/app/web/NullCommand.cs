namespace app.web
{
    public class NullCommand : IProcessARequest
    {
        public void process(IEncapsulateRequestDetails the_request)
        {}

        public bool can_process(IEncapsulateRequestDetails request)
        {
            return false;
        }
    }
}