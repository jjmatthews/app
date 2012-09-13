using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Machine.Specifications;
using app.web.core;
using developwithpassion.specifications.rhinomocks;

namespace app.specs
{
    [Subject(typeof(ViewEngine))]
    public class ViewEngineSpecs
    {
        public abstract class concern : Observes<IImplementAFeature,ViewEngine>
        {
            Establish context = () => { };
        }
    }

    public class ViewEngine : IImplementAFeature
    {
    }
}
