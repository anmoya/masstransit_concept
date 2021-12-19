using System;
using System.Threading.Tasks;
using MassTransit;
using MassTransit.Saga;
using Microsoft.Extensions.Logging;
using Model;

namespace InventoryService
{
    public class OrderConsumer : IConsumer<Order>
    {
        private readonly ILogger<OrderConsumer> _logger;

        public OrderConsumer(ILogger<OrderConsumer> logger)
        {
            _logger = logger;
        }
        public async Task Consume(ConsumeContext<Order> context)
        {
            await Console.Out.WriteLineAsync(context.Message.Name);
            _logger.LogInformation($"Got new message: {context.Message.Name}");
        }
    }
}