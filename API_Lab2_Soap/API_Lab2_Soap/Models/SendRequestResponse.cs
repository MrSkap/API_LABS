using System.Runtime.Serialization;
using System.ServiceModel;
using System.Xml.Serialization;

namespace API_Lab2_Soap.Models;

[DataContract(Name = "SendRequestResponse", Namespace = "https://localhost:7208")]
[MessageContract]
[XmlType(Namespace = "https://localhost:7208")]
public class SendRequestResponse
{
    [DataMember(Order = 0)]
    [MessageBodyMember(Namespace = "https://localhost:7208", Order = 0)]
    public string Message { get; set; } = "Default response message";
}