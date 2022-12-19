using System.Xml.Linq;
using Microsoft.AspNetCore.Mvc;
using SoapHttpClient;
using SoapHttpClient.Enums;

namespace API_Lab2_Soap.Controllers;
[ApiController]
[Route("without")]
public class SoapController:ControllerBase
{
    [HttpGet("soap")]
    public async Task<string?> GetSoapMessage(string clientMessage)
    {
        var client = new SoapClient();
        var res = await client.PostAsync(new Uri("https://localhost:7208"),SoapVersion.Soap11, new XElement(XName.Get("Message"), "message"));
        return res.Content.ToString();
    }
}