using app.web.core;
using app.web.core.aspnet;

namespace app.web.app.catalogbrowsing
{
  public class ViewAReport<ReportModel> : IImplementAFeature
  {
    IDisplayInformation display_engine;
    FetchData_Behaviour<ReportModel> report;

    public ViewAReport(IDisplayInformation display_engine, FetchData_Behaviour<ReportModel> report)
    {
      this.display_engine = display_engine;
      this.report = report;
    }

    public ViewAReport(FetchData_Behaviour<ReportModel> query):this(new WebFormDisplayEngine(),query)
    {
    }

    public void process(IEncapsulateRequestDetails request)
    {
      display_engine.display(report(request));
    }
  }
}