using System;

namespace Gnome.Fio.Service.Model
{
    public class DownloadStatus
    {
        public Status Status { get; private set; }
        public DateTime Date { get; private set; }
        public Guid AccountId { get; private set; }
        public Guid? DocumentId { get; private set; }

        public static DownloadStatus CreateOk(Guid accountId, Guid documentId)
        {
            return new DownloadStatus(accountId)
            {
                Status = Status.Ok,
            };
        }

        public static DownloadStatus CreateError(Guid accountId, Guid documentId)
        {
            return new DownloadStatus(accountId)
            {
                Status = Status.Error,
                DocumentId = documentId
            };
        }

        public static DownloadStatus CreateError(Guid accountId)
        {
            return new DownloadStatus(accountId);
        }

        private DownloadStatus(Guid accountId)
        {
            AccountId = accountId;
            Date = DateTime.UtcNow;
        }
    }

    public enum Status
    {
        Ok = 1,
        Error = 2
    }
}
