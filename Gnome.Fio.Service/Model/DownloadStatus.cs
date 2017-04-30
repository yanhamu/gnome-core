using System;

namespace Gnome.Fio.Service.Model
{
    public class DownloadStatus
    {
        public Status Status { get; private set; }
        public DateTime Date { get; private set; }

        public static DownloadStatus CreateOk(Guid accountId, Guid documentId)
        {
            var d = new DownloadStatus();
            d.Status = Status.Ok;
            d.Date = DateTime.UtcNow;
            return d;
        }
    }

    public enum Status
    {
        Ok = 1,
        Error = 2
    }
}
