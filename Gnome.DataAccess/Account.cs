using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Gnome.DataAccess
{
    public class Account : IEntity<Account>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string OwnerId { get; set; }
        public ApplicationUser Owner { get; set; }

        public void Map(EntityTypeBuilder<Account> entity)
        {
            entity.HasKey(p => p.Id);

            entity.Property(p => p.Name);

            entity
                .HasOne(c => c.Owner)
                .WithMany()
                .HasForeignKey(c => c.OwnerId)
                .IsRequired();
        }
    }
}