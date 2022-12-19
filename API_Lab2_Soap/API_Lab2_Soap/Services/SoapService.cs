using API_Lab2_Soap.Models;

namespace API_Lab2_Soap.Services;

public class SoapService : ISoapService
{
    public SendRequestResponse SendRequest(SendRequest sendRequest)
    {
        return
            new SendRequestResponse
            {
                Message = $"I get this massage: {sendRequest.Message}"
            };
    }
}