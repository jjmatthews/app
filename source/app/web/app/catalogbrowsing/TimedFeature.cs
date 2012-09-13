using System.Diagnostics;
using app.web.core;

namespace app.web.app.catalogbrowsing
{
  public class TimedFeature : IImplementAFeature
  {
    IImplementAFeature feature;

    public TimedFeature(IImplementAFeature feature)
    {
      this.feature = feature;
    }

    public void process(IEncapsulateRequestDetails request)
    {
      var item = new Stopwatch();
      item.Start();
      feature.process(request);
      item.Stop();
      //log timing details
    }
  }
}