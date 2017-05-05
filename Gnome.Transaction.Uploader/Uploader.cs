using Gnome.Transactions.Common;
using Gnome.Transactions.Uploader;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Text;

namespace Gnome.Transaction.Uploader
{
    public class Uploader
    {
        private readonly IGnomeClient gnomeClient;
        private readonly string hostName;
        private readonly string queue;

        public Uploader(IGnomeClient gnomeClient, string hostName, string queue)
        {
            this.gnomeClient = gnomeClient;
            this.hostName = hostName;
            this.queue = queue;
        }

        public static void Main()
        {
            var loggerFactory = new LoggerFactory();
            var logger = loggerFactory.CreateLogger<Uploader>();

            try
            {
                new Uploader(null, "localhost", "new-transactions").Run();
            }
            catch (Exception ex)
            {
                logger.LogError(500, ex, "Uploader error", null);
            }
        }

        private void Run()
        {
            var factory = new ConnectionFactory() { HostName = hostName };
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.QueueDeclare(
                    queue: queue,
                    durable: false,
                    exclusive: false,
                    autoDelete: false,
                    arguments: null);

                var consumer = new EventingBasicConsumer(channel);
                consumer.Received += MessageReceived;

                channel.BasicConsume(queue: queue,
                    noAck: true,
                    consumer: consumer);

                Console.WriteLine("Press [enter] to exit");
                Console.ReadLine();
            }
        }

        private async void MessageReceived(object sender, BasicDeliverEventArgs e)
        {
            var message = JsonConvert.DeserializeObject<TransactionMessage<FioTransaction>>(Encoding.UTF8.GetString(e.Body));

            var accountId = message.AccountId;
            var transaction = message.Data;

            await gnomeClient.SendAsync(transaction, accountId);
        }
    }
}