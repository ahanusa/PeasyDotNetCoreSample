using Peasy;

public class Person : IDomainObject<int>
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string City { get; set; }
}