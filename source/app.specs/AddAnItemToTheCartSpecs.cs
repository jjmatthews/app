using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Machine.Specifications;
using app.web.app.shopping;
using app.web.core;
using developwithpassion.specifications.extensions;
using developwithpassion.specifications.rhinomocks;

namespace app.specs
{
    [Subject(typeof(AddAnItemToTheCart))]
    public class AddAnItemToTheCartSpecs
    {
        public abstract class concern : Observes<IImplementAFeature, AddAnItemToTheCart>
        {}

        
       /* public class when_run : concern
        {
            Establish context = () =>
                                    {
                                        the_request = fake.an<IEncapsulateRequestDetails>();
                                        the_request.setup(x => x.map<OrderBasket>()).Return(new OrderBasket());

                                        display_engine = depends.on<IDisplayInformation>();
                                        order_engine = depends.on<IOrderEngine>();
                                    };

            Because b = () => sut.process(the_request);

            It should_process_the_basket = () => order_engine.received( x => x.process_the_basket(the_request.map<OrderBasket>()));

            It should_call_back_to_the_view_with_the_results = () => display_engine.received(x => x.display(order_engine.process_the_basket(the_request.map<OrderBasket>())));

            static IDisplayInformation display_engine;
            static IOrderEngine order_engine;
            static IEncapsulateRequestDetails the_request;
        }*/

    }
}
