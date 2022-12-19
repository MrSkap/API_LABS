using Grpc.Net.Client;
using GrpcService1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientRPC
{
    public static class HelloClient
    {
        public static async Task<string> HelloToServer(string whoAreYou)
        {
            var channal = GrpcChannel.ForAddress("http://localhost:5141");
            var client = new Greeter.GreeterClient(channal);

            var reply = await client.SayHelloAsync(new HelloRequest() { Name = "Client" });
            return reply.Message;
        }
    }
}
