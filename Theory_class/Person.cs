namespace Theory_class;

public abstract class Person
{
    public required string Firstname { get; init; }
    public required string Lastname { get; init; }
    public required DateTime Birth { get; init; }

    public Address? Address { get; set; }

    public virtual int GetAge ()
    {
        var today = DateTime.Today;

        var a = (today.Year * 100 + today.Month) * 100 + today.Day;
        var b = (Birth.Year * 100 + Birth.Month) * 100 + Birth.Day;

        return (a - b) / 10000;
    }


    public abstract string FullName();
}