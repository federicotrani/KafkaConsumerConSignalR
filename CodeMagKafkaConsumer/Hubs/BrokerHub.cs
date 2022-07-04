using CodeMagKafkaConsumer.Models;
using Microsoft.AspNetCore.SignalR;

namespace CodeMagKafkaConsumer.Hubs
{
    public class BrokerHub : Hub
    {
        public async Task SendMessage(BrokerMessage message)
        {
            await Clients.All.SendAsync("ReceiveMessage", message);
        }
    }
}
