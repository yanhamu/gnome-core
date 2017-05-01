using System;

namespace Gnome.Fio.Downloader.Model
{
    public class TransactionSyncCommand
    {
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public string Token { get; set; }
        public Guid AccountId { get; set; }
    }
}
