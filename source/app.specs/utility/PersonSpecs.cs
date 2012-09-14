using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Machine.Specifications;
using app.utility;
using developwithpassion.specifications.rhinomocks;

namespace app.specs.utility
{
    public class PersonSpecs
    {
        public abstract class concern : Observes
        {
            Establish context = () => { };
        }

        [Subject(typeof (Person))]
        public class when_validate_person_model : concern
        {
            Establish context = () =>
                                    {

                                        Validate.Where<Person>.FirstName.shoudlnotbeempty.and.LastName.
                                            shouldnotbeemptyand.FirstName.shouldnotequal.LastName.and.birthdate.
                                            shouldbegreaterthanorequalto(mindate).and.birthdate.
                                            shouldbelessthanorequalto(maxdate);

                                    };

            Because b = () =>
                            {
                                
                            };

            It should_validate = () =>
                                     {
                                         
                                     };

            static Person person_model;
            static bool result;
            static string person_rule;
        }
    }

    public class Person
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime BirthDate { get; set; }



    }
}
