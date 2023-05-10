using Database.Domain.Contacts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.Infrastucture.Configurations;

public class ContactConfiguration : IEntityTypeConfiguration<Contact>
{
    // https://learn.microsoft.com/fr-fr/ef/core/modeling/entity-types?tabs=data-annotations
    public void Configure(EntityTypeBuilder<Contact> builder)
    {
        builder.HasKey(x => x.Id);
    }
}