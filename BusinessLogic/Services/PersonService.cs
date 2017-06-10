using System.Collections.Generic;
using Peasy;

public class PersonService : ServiceBase<Person, int>
{
    public PersonService(IDataProxy<Person, int> dataProxy) : base(dataProxy)
    {
    }
}