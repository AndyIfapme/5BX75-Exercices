using Database.Domain.Common;

namespace Database.Domain.Contacts;

public class Contact : Entity
{
    public string Email { get; set; } = default!;
    public string Subject { get; set; } = default!;
    public string Message { get; set; } = default!;
}