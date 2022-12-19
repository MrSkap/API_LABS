using Grpc.Net.Client;
using GrpcService1.Protos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientRPC
{
    public static class CustomerClient
    {
        public static async Task<string> GetCustomerName(int id)
        {
            var channal = GrpcChannel.ForAddress("http://localhost:5141");
            var client = new Customer.CustomerClient(channal);

            var reply = await client.GetCustomerAsync(new FindCustomerRequest() { Id = id});
            return reply.Name;
        }
    }
}
