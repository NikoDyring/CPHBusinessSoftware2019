using System;
using System.Text;
using RabbitMQ.Client;

namespace RabbitMQPublisher
{
    class Program
    {
        public static void Main(string[] args)
        {


            var factory = new ConnectionFactory() { HostName = "localhost" };
            using var connection = factory.CreateConnection();
            using var channel = connection.CreateModel();
            channel.ExchangeDeclare(exchange: "Campaign", type: ExchangeType.Direct);
            var campaign = "";
            while (campaign != "break")
            {
                Console.WriteLine("Select a car class to promote. \n" +
                                  "A, B or C");
                campaign = Console.ReadLine().ToLower();
                var message = GetAdvertisement(campaign);
                var body = Encoding.UTF8.GetBytes(message);

                channel.BasicPublish(exchange: "Campaign",
                    routingKey: $"{campaign}",
                    basicProperties: null,
                    body: body);
                Console.WriteLine($"[x] Sent {message} to customers wanting the {campaign}-campaign.");
            }
        }

        private static string GetAdvertisement(string campaign)
        {
            switch (campaign)
            {
                default:
                    {
                        return "Dreams come true this autumn, rent a Fiat 500 to go places. Only 30$ a day!";
                    }

                case "a":
                    {
                        return "(A)lpha week has started! Get our Tesla Model S for only 299.000,99$ a year!";
                    }
                case "b":
                    {
                        return "We're currently rolling out our (B)ig Campaign! Rent a Ford Fiesta for only 129.99$ a day!";
                    }
                case "c":
                    {
                        return "We've got an excellent offer on a Citroën C1, only 99.99$ a day!";
                    }
            }
        }
    }
}
