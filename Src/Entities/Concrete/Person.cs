namespace Entities.Concrete;

public class Person
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public int BirthYear { get; set; }
    public long NId { get; set; }
}
