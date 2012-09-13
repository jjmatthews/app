using Machine.Specifications;
using app.web.app.catalogbrowsing;
using app.web.core;
using developwithpassion.specifications.extensions;
using developwithpassion.specifications.rhinomocks;

namespace app.specs
{
  [Subject(typeof(ViewAReport<>))]
  public class ViewAReportSpecs
  {
    public abstract class concern : Observes<IImplementAFeature, ViewAReport<SomeItem>>
    {
      Establish context = () =>
      {
      };
    }

    public class when_run : concern
    {
      Establish context = () =>
      {
        display_engine = depends.on<IDisplayInformation>();
        request = fake.an<IEncapsulateRequestDetails>();
        the_report = new SomeItem();
        depends.on<FetchData_Behaviour<SomeItem>>(x =>
        {
          x.ShouldEqual(request);
          return the_report;
        });
      };

      Because b = () => sut.process(request);

      It should_display_the_result_of_running_its_provided_query =
        () => display_engine.received(x => x.display(the_report));

      static IDisplayInformation display_engine;
      static IEncapsulateRequestDetails request;
      static SomeItem the_report;
    }

    public class SomeItem
    {
    }
  }
}