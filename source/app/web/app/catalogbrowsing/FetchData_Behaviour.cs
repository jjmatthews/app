using app.web.core;

namespace app.web.app.catalogbrowsing
{
  public delegate ReportModel FetchData_Behaviour<ReportModel>(IEncapsulateRequestDetails request);
}