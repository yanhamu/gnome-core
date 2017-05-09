using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Gnome.DataAccess
{
    public class FioTransaction : IEntity<FioTransaction>
    {
        public Guid Id { get; set; }
        public Guid AccountId { get; set; }
        public Account Account { get; set; }
        public decimal Amount { get; set; }

        public DateTime MovementDate { get; set; }

        /// <summary>
        /// ID pohybu
        /// </summary>
        public string MovementId { get; set; }

        /// <summary>
        /// Měna
        /// </summary>
        public string Currency { get; set; }

        /// <summary>
        /// Protiúčet
        /// </summary>
        public string ContraAccount { get; set; }

        /// <summary>
        /// Název protiúčtu
        /// </summary>
        public string ContraAccountName { get; set; }

        /// <summary>
        /// Kód banky
        /// </summary>
        public string ContraAccountBankCode { get; set; }

        /// <summary>
        /// Název banky
        /// </summary>
        public string ContraAccountBankName { get; set; }

        /// <summary>
        /// KS
        /// </summary>
        public string ConstantSymbol { get; set; }

        /// <summary>
        /// VS
        /// </summary>
        public string VariableSymbol { get; set; }

        /// <summary>
        /// SS
        /// </summary>
        public string SpecificSymbol { get; set; }

        /// <summary>
        /// Uživatelská identifikace
        /// </summary>
        public string UserIdentification { get; set; }

        /// <summary>
        /// Zpráva pro příjemce
        /// </summary>
        public string MessageForReceiver { get; set; }

        /// <summary>
        /// Typ
        /// </summary>
        public string TransactionType { get; set; }

        /// <summary>
        /// Provedl
        /// </summary>
        public string TransactionExecutive { get; set; }

        /// <summary>
        /// Upřesnění
        /// </summary>
        public string Specification { get; set; }

        /// <summary>
        /// Komentář
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// BIC
        /// </summary>
        public string BankIndentifierCode { get; set; }

        /// <summary>
        /// ID Pokynu
        /// </summary>
        public long TransactionId { get; set; }


        public void Map(EntityTypeBuilder<FioTransaction> entity)
        {
            entity.HasKey(t => t.Id);
            entity.HasOne(t => t.Account).WithMany().HasForeignKey(t => t.AccountId);
        }
    }
}