using System.ServiceModel;
using API_Lab2_Soap.Models;

namespace API_Lab2_Soap.Services;

[ServiceContract(Namespace = "https://localhost:7208")]
public interface ISoapService
{
    [OperationContract(
        Action = "https://localhost:7208" + "/SendMessage")]
    SendRequestResponse SendRequest(SendRequest sendRequest);
}