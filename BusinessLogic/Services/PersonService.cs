using System.Collections.Generic;
using Peasy;
using PeasyDotNetCoreSample.BusinessLogic.DTO;

namespace PeasyDotNetCoreSample.BusinessLogic.Services
{
  public class PersonService : ServiceBase<Person, int>
  {
      public PersonService(IDataProxy<Person, int> dataProxy) : base(dataProxy)
      {
      }
      
      protected override IEnumerable<IRule> GetBusinessRulesForInsert(Person entity, ExecutionContext<Person> context)
      {
          yield return new PersonNameRule(entity.Name);
          yield return new ValidCityRule(entity.City);
      }
  }
}
