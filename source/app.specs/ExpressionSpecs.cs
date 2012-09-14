using System;
using System.Linq.Expressions;
using Machine.Specifications;
using developwithpassion.specifications.rhinomocks;
using developwithpassion.specifications.extensions;

namespace app.specs
{
    public class ExpressionSpecs
    {
        public abstract class concern : Observes
        {
        }

        public class when_getting_the_name_of_an_property_from_an_expression_tree : concern
        {
            It should_get_the_name = () =>
            {
                var jp = new Person { first_name = "JP" };
                Expression<Func<Person, bool>> condition = x => x.first_name.StartsWith("blah") && x.age < 10 && x.age > 1;
                ((MemberExpression)condition.Body).Member.Name.ShouldEqual("first_name");
            };
        }

        public class when_building_up_code_using_an_expression_tree : concern
        {
            It should_be_able_To_builda__Method = () =>
            {
                Func<int, bool> is_even = x => x % 2 == 0;


                var twoConstant = Expression.Constant(2, typeof(int));

                var parameters = Expression.Parameter(typeof(int), "x");
                var modulus = Expression.Modulo(parameters, twoConstant);
                var zeroConstant = Expression.Constant(0, typeof(int));
                var method = Expression.Equal(modulus, zeroConstant);


                var expressions = Expression.Lambda<Func<int, bool>>(method, parameters);

                var result = expressions.Compile()(4);
            };
        }
        public class Person
        {
            public int age { get; set; }
            public string first_name { get; set; }
        }
    }
}