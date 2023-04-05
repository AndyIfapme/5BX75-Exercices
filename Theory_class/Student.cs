namespace Theory_class;

public class Student : Person
{
    public string ClassYear { get; set; }

    public override string FullName()
    {
        return $"{Firstname} {Lastname.ToUpper()}";
    }
}