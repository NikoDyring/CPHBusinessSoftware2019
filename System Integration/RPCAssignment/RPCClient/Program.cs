using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grpc.Core;

namespace RPCClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Channel channel = new Channel("127.0.0.1:6789", ChannelCredentials.Insecure);
            var client = new StudentService.StudentServiceClient(channel);

            var reply = client.GetStudents(new StudentRequest { });
            string[] replyArray = reply.Info.Split(',');
            int i = 1;
            foreach (var student in replyArray)
            {
                if (student == "")
                {
                    continue;
                }

                Console.WriteLine($"Student #{i}: " + student);
                i++;
            }



            channel.ShutdownAsync().Wait();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
