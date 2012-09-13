using System.Collections;
using System.Collections.Generic;
using app.web.app.catalogbrowsing;
using app.web.app.catalogbrowsing.stubs;

namespace app.web.core.stubs
{
  public class StubSetOfCommands : IEnumerable<IProcessARequest>
  {
    IEnumerator IEnumerable.GetEnumerator()
    {
      return GetEnumerator();
    }

    public void do_something()
    {
    }

    public class Person
    {
      public int age { get; set; }
    }

    public IEnumerator<IProcessARequest> GetEnumerator()
    {
      yield return new RequestCommand(x => true,
                                      new ViewAReport<IEnumerable<DepartmentItem>>(
                                        new GetTheMainDepartmentsInTheStore().fetch_using));
    }
  }

  public class GetTheMainDepartmentsInTheStore : IFetchData<IEnumerable<DepartmentItem>>
  {
    public IEnumerable<DepartmentItem> fetch_using(IEncapsulateRequestDetails request)
    {
      return new StubDepartmentRepository().get_main_departments();
    }
  }
}