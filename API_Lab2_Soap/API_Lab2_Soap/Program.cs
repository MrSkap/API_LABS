using System.ServiceModel;
using API_Lab2_Soap.Services;using SoapCore;
using SoapCoreServer;
using Endpoint = SoapCoreServer.Endpoint;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<ISoapService, SoapService>();
var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseRouting();
app.UseHttpsRedirection();

app.UseEndpoints(endpoints =>
{
    endpoints.UseSoapEndpoint<ISoapService>(options =>
    {
        options.Path = "/Soap.asmx";
        options.Binding = new BasicHttpBinding();
        options.CaseInsensitivePath = true;

    });
    endpoints.MapControllers();
});


app.MapControllers();

app.Run();