using Grpc.Core;
using GrpcService1.Protos;

namespace GrpcService1.Services
{
    public class CustomerService: Customer.CustomerBase
    {
        public override Task<FindCustomerReply> GetCustomer(FindCustomerRequest request, ServerCallContext context)
        {
            FindCustomerReply newCustomer = new FindCustomerReply();
            newCustomer.Id = request.Id;
            newCustomer.Name = "New Customer";
            return Task.FromResult(newCustomer);
        }
    }
}
