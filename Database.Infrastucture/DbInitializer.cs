using Database.Domain.Contacts;
using Microsoft.EntityFrameworkCore;

namespace Database.Infrastucture;

public static class DbInitializer
{
    public static void Initialize(DbContext context)
    {
        context.Database.EnsureDeleted();
        context.Database.EnsureCreated();

        context.Set<Contact>()
            .Add(new Contact
            {
                Email = "toto@tutu.be",
                Subject = "Ceci est un sujet",
                Message = "Ceci est un message"
            });


        context.SaveChanges();
    }
}