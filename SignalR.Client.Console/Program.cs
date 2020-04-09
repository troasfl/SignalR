using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR.Client;

namespace SignalR.Client.Console
{
    class Program
    {
        static async Task Main(string[] args)
        {
            System.Console.WriteLine("Press a key to start listening...");
            System.Console.ReadKey();

            var connection = new HubConnectionBuilder()
                //.WithUrl("http://localhost:5000/chathub")
                .WithUrl("http://18.185.227.32:5000/chathub")
                .WithAutomaticReconnect()
                .Build();
            //connection.On<string>("NewOrder", message => { System.Console.WriteLine($"Message received from server: {message}"); });
            await connection.StartAsync();
            System.Console.WriteLine("Listening. Press a key to quit");

            System.Console.ReadKey();
        }
    }
}
