using Microsoft.AspNetCore.SignalR;

namespace signalr_example;

public sealed class ChatHub : Hub {
    public override async Task OnConnectedAsync() {
        System.Console.WriteLine("New connection established");
        await Clients.All.SendAsync("ReceiveMessage", $"{Context.ConnectionId} has joined");
    }

    public async Task SendMessage(string message) {
        System.Console.WriteLine($"Received: {message}");
        await Clients.All.SendAsync("ReceiveMessage", $"Echo: {message}");
    }
}