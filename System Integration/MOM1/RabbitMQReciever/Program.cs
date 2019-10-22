using System;
using System.Collections.Generic;
using System.Text;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace RabbitMQReceiver
{
    class Program
    {
        public static event Action RaiseChoice;
        static void Main(string[] args)
        {
            List<string> interestList = new List<string>();

            var factory = new ConnectionFactory() { HostName = "localhost" };
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                RaiseChoice += Choice;
                channel.ExchangeDeclare(exchange: "Campaign", type: ExchangeType.Direct);
                Console.WriteLine("Welcome to Rent-A-Phat-Car! \n" +
                                  "___________________________ \n" +
                                  "Which class of car are you interested in renting?");
                string interest = Console.ReadLine();

                interestList.Add(interest);
                interestList.Add("");
                var queueName = channel.QueueDeclare().QueueName;

                foreach (var v in interestList)
                {
                    channel.QueueBind(queue: queueName,
                        exchange: "Campaign",
                        routingKey: $"{v}");
                }


                Console.WriteLine("[*] Waiting for offers.");
                while (true)
                {
                    var consumer = new EventingBasicConsumer(channel);
                    consumer.Received += (model, ea) =>
                    {
                        var body = ea.Body;
                        var message = Encoding.UTF8.GetString(body);
                        Console.WriteLine(message);
                            //new Task(Choice).Start();
                            //RaiseChoice?.Invoke();
                            Choice();

                    };
                    channel.BasicConsume(queue: queueName,
                        autoAck: true,
                        consumer: consumer);

                }
            }

        }

        private static void Choice()
        {
            Console.WriteLine("Would you like to confirm this booking? [C]onfirm or [P]ass");

            string answer = Console.ReadLine().ToUpper();
            if (answer == "C")
            {
                Console.WriteLine("Booking confirmed.");
            }
            else if (answer == "P")
            {
                Console.WriteLine("Booking has been passed.");
            }
        }
    }
}