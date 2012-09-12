namespace app.web
{
  public interface IFindCommandsForRequests
  {
      IProcessARequest get_the_command_that_can_process_the_request(IEncapsulateRequestDetails a_new_request);
  }
}