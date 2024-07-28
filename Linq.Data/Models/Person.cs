namespace LINQ.Data.Models;

public record Person(string FirstName, string LastName)
{
    public override string ToString()
    {
        return $"{FirstName} {LastName}";
    }
}