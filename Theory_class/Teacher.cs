namespace Theory_class;

public class Teacher : Person
{
    public double Salary { get; set; }

    public override string FullName()
    {
        return $"{Lastname.ToUpper()} {Firstname}";
    }

    public override int GetAge()
    {
        return 30;
    }
}