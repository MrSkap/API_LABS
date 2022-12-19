using System.Runtime.Serialization;
using System.ServiceModel;
using System.Xml.Serialization;

namespace API_Lab2_Soap.Models;

[DataContract(Name = "SendRequest", Namespace = "https://localhost:7208")]
[MessageContract(WrapperName = "SendRequest", WrapperNamespace = "https://localhost:7208", IsWrapped = true)]
[XmlType(Namespace = "https://localhost:7208")]
public class SendRequest
{
    [DataMember(Order = 0)]
    [MessageBodyMember(Namespace = "https://localhost:7208", Order = 0)]
    public string Message { get; set; } = "Default request message";
}