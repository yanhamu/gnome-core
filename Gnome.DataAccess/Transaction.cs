﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Gnome.DataAccess
{
    public class Transaction : IEntity<Transaction>
    {
        public Guid Id { get; set; }
        public Guid AccountId { get; set; }
        public Account Account { get; set; }
        public DateTime MovementDate { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }
        public string ContraAccount { get; set; }
        public string ContraAccountName { get; set; }
        public string ContraAccountBankCode { get; set; }
        public string ContraAccountBankName { get; set; }
        public string ConstantSymbol { get; set; }
        public string VariableSymbol { get; set; }
        public string SpecificSymbol { get; set; }
        public string MessageForReceiver { get; set; }
        public string Comment { get; set; }
        public string MovementId { get; set; }

        public void Map(EntityTypeBuilder<Transaction> entity)
        {
            entity.HasKey(t => t.Id);
            entity.HasOne(t => t.Account).WithMany().HasForeignKey(t => t.AccountId);
        }
    }
}