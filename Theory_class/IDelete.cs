namespace Theory_class;

public interface IDelete
{
    public DateTime? DeletedAt { get; set; }

    public void Delete();
}