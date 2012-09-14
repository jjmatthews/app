using System;
using Machine.Specifications;
using developwithpassion.specifications.rhinomocks;

namespace app.specs.utility
{
  public class PersonSpecs
  {
    public abstract class concern : Observes
    {
      Establish context = () =>
      {
      };
    }

    [Subject(typeof(Person))]
    public class when_validate_person_model : concern
    {
      It should_validate = () =>
      {
//        var rule_set = RuleBuilder.to_validate<Person>()
//          .check(x => x.FirstName, c =>
//          {
//            c.is_not_null();
//            c.constraint_error("First name is required on a person");
//          })
//          .check(x => x.LastName, c => c.is_not_null())
//          .check(x => x.FirstName, c => c.is_not_same_as(y => y.LastName))
//          .check(x => x.BirthDay, c => c.falls_after(new DateTime(1, 1, 1950)));
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