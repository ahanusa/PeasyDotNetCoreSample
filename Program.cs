using System;
using System.Linq;
using PeasyDotNetCoreSample.BusinessLogic.DataProxies;
using PeasyDotNetCoreSample.BusinessLogic.DTO;
using PeasyDotNetCoreSample.BusinessLogic.Services;

namespace PeasyDotNetCoreSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new PersonService(new PersonMockDataProxy());
            var newPerson = new Person() { Name = "Freida Jones", City = "Madison" };
            var insertResult = service.InsertCommand(newPerson).Execute();
            if (insertResult.Success)
            {
                Console.WriteLine(insertResult.Value.ID.ToString()); // prints the id value assigned via PersonMockDataProxy.Insert
            }
            else
            {
                foreach (var error in insertResult.Errors)
                    Console.WriteLine(error);
            }
        }
    }
}
