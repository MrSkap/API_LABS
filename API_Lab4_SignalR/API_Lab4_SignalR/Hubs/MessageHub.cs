using Microsoft.AspNetCore.SignalR;
using RestSharp;

namespace API_Lab4_SignalR.Hubs;

public class MessageHub:Hub
{
    public async Task NewMessage(long username, string message) =>
        await Clients.All.SendAsync("messageReceived", username, $"{message} : {DateTime.Now}");

    public async Task WeatherMessage()
    {
        using var client = new RestClient();
        var uri = new Uri("http://localhost:7208/GetWeatherForecast");
        var request = new RestRequest(uri);
        var result = await client.GetAsync<WeatherForecast>(request);
        await Clients.Caller.SendAsync("weatherReceived", result);
    }
}