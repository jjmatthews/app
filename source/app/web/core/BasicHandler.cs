﻿using System.Web;
using app.web.core.stubs;

namespace app.web.core
{
  public class BasicHandler : IHttpHandler
  {
    IProcessWebRequests front_controller;
    ICreateRequests request_factory;

    public BasicHandler(IProcessWebRequests front_controller, ICreateRequests request_factory)
    {
      this.front_controller = front_controller;
      this.request_factory = request_factory;
    }

    public BasicHandler():this(new FrontController(),new StubRequestFactory())
    {
    }

    public void ProcessRequest(HttpContext context)
    {
      front_controller.process(request_factory.create_request_from(context));
    }

    public bool IsReusable
    {
      get { return true; }
    }
  }
}