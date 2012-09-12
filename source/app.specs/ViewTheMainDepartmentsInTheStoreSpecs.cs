﻿using System.Collections.Generic;
using Machine.Specifications;
using app.web.app.catalogbrowsing;
using app.web.core;
using developwithpassion.specifications.extensions;
using developwithpassion.specifications.rhinomocks;

namespace app.specs
{
  [Subject(typeof(ViewTheMainDepartmentsInTheStore))]
  public class ViewTheMainDepartmentsInTheStoreSpecs
  {
    public abstract class concern : Observes<IImplementAFeature,
                                      ViewTheMainDepartmentsInTheStore>
    {
    }

    public class when_run : concern
    {
      Establish c = () =>
      {
        department_repository = depends.on<IFindDepartments>();
        display_engine = depends.on<IDisplayInformation>();
        request = fake.an<IEncapsulateRequestDetails>();
        the_main_departments = new List<DepartmentItem>{new DepartmentItem()};

        department_repository.setup(x => x.get_main_departments()).Return(the_main_departments);
      };

      Because b = () =>
        sut.process(request);


      It should_display_the_main_departments = () =>
        display_engine.received(x => x.display(the_main_departments));

        

      static IEncapsulateRequestDetails request;
      static IFindDepartments department_repository;
      static IDisplayInformation display_engine;
      static IEnumerable<DepartmentItem> the_main_departments;
    }
  }
}