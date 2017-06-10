using System;
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
            var getResult = service.GetAllCommand().Execute();
            if (getResult.Success)
            {
                foreach (var person in getResult.Value)
                    Console.WriteLine(person.Name);  // prints each person's name retrieved from PersonMockDataProxy.GetAll
            }

            var newPerson = new Person() { Name = "Freed Jones", City = "Madison" };
            var insertResult = service.InsertCommand(newPerson).Execute();
            if (insertResult.Success)
            {
                Console.WriteLine(insertResult.Value.ID.ToString()); // prints the id value assigned via PersonMockDataProxy.Insert
            }
        }
    }
}
