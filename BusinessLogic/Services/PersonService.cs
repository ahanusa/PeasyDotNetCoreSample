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
  }
}