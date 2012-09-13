using app.web.core;

namespace app.web.app.catalogbrowsing
{
  public interface IFetchData<ReportModel>
  {
    ReportModel fetch_using(IEncapsulateRequestDetails request); 
  }
}