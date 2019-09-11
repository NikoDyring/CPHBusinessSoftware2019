using System;
using Grpc.Core;

namespace RPCAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            const int Port = 6789;
            var server = new Server
                {
                    Services = { StudentService.BindService(new ServerImplementation()) },
                    Ports = { new ServerPort("localhost", Port, ServerCredentials.Insecure) }
                };
                server.Start();

                Console.WriteLine("Server is now listening on port " + Port);
                Console.WriteLine("Press any key to stop the server...");
                Console.ReadKey();

                server.ShutdownAsync().Wait();
        }
    }
}
