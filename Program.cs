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
            var newPerson = new Person() { Name = "Fred Jones", City = "Madison" };
            var insertResult = service.InsertCommand(newPerson).Execute();
            if (insertResult.Success)
            {
                Console.WriteLine(insertResult.Value.ID.ToString());
            }
            else
            {
                // This line will execute and print 'Name cannot be fred jones'
                // Note that insertResult.Value will be NULL as PersonMockDataProxy.Insert did not execute due to failed rule
                Console.WriteLine(insertResult.Errors.First());
            }
        }
    }
}
