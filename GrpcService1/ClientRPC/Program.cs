// See https://aka.ms/new-console-template for more information
using ClientRPC;
using Grpc.Net.Client;
using GrpcService1;

Console.WriteLine(await HelloClient.HelloToServer("Bob"));
int id = 15;
Console.WriteLine( $"Customer id: {id}, customer name: { await CustomerClient.GetCustomerName(id)}");
Console.ReadLine();