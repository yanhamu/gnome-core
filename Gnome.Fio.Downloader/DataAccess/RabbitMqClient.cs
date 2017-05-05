using Gnome.Fio.Downloader.Model;
using Gnome.Transactions.Common;
using Newtonsoft.Json;
using RabbitMQ.Client;
using System;
using System.Text;

namespace Gnome.Fio.Downloader.DataAccess
{
    public class RabbitMqClient : IMessaging
    {
        private readonly string hostName;

        public RabbitMqClient(string hostName)
        {
            this.hostName = hostName;
        }

        public void Send(DownloadStatus downloadStatus)
        {
            var message = Serialize(downloadStatus);
            Send(message, "fio-downloader-status", "status");
        }

        public void Send(FioTransaction transaction, Guid accountId)
        {
            var obj = new TransactionMessage<FioTransaction>(transaction, accountId);
            var message = Serialize(obj);
            var queueName = "new-transactions";
            var routingKey = "new-fio-transaction";

            Send(message, queueName, routingKey);
        }

        private byte[] Serialize<T>(T obj)
        {
            var jsonTransaction = JsonConvert.SerializeObject(obj);
            return Encoding.UTF8.GetBytes(jsonTransaction);
        }

        private void Send(byte[] body, string queueName, string routingKey)
        {
            var factory = new ConnectionFactory() { HostName = hostName };
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.QueueDeclare(
                    queue: queueName,
                    durable: false,
                    exclusive: false,
                    autoDelete: false,
                    arguments: null
                    );

                channel.BasicPublish(
                    exchange: "",
                    routingKey: routingKey,
                    basicProperties: null,
                    body: body);
            }
        }
    }
}
