import { Client } from "soap/lib/client";
export class SoapService{
    readonly SoapUrl = "http://localhost:5000"
    constructor(private soapClient:Client){ }

    getMessageFromServer(message:string): string {
        this.soapClient.addBodyAttribute(message);
        this.soapClient.setEndpoint(this.SoapUrl);
        this.soapClient.MyFunction({name: 'value'}, function(err, result, rawResponse, soapHeader, rawRequest) {
            // result is a javascript object
            // rawResponse is the raw xml response string
            // soapHeader is the response soap header as a javascript object
            // rawRequest is the raw xml request string
        });
        this.soapClient.
        return message;
    }
}