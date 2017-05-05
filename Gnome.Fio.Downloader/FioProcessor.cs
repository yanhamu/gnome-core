using Gnome.Fio.Downloader.DataAccess;
using Gnome.Fio.Downloader.Model;
using Gnome.Fio.Downloader.Services;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace Gnome.Fio.Service
{
    public class FioProcessor
    {
        private readonly FioDownloader fioDownloader;
        private readonly IMessaging messaging;
        private readonly IFioService fioService;
        private readonly ILogger logger;

        public FioProcessor(
            FioDownloader fioDownloader,
            IMessaging messaging,
            IFioService fioService,
            ILogger logger)
        {
            this.fioDownloader = fioDownloader;
            this.messaging = messaging;
            this.fioService = fioService;
            this.logger = logger;
        }

        public async Task Process(TransactionSyncCommand command)
        {
            try
            {
                var documentId = await fioDownloader.Download(command.Token, command.From, command.To);

                await this.fioService.Process(command.AccountId, documentId);

                messaging.Send(DownloadStatus.CreateOk(command.AccountId, documentId));
            }
            catch (Exception ex)
            {
                messaging.Send(DownloadStatus.CreateError(command.AccountId));
                logger.LogError(1, ex, "Processing error", null);
            }
        }
    }
}