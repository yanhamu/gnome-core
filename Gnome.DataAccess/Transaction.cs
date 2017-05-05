using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Gnome.DataAccess
{
    public class Transaction : IEntity<Transaction>
    {
        public Guid Id { get; set; }
        public Guid AccountId { get; set; }
        public Account Account { get; set; }

        public void Map(EntityTypeBuilder<Transaction> entity)
        {
            entity.HasKey(t => t.Id);
            entity.HasOne(t => t.Account).WithMany().HasForeignKey(t => t.AccountId);
        }
    }
}