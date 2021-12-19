using System.Threading.Tasks;
using MassTransit;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace MassTransit_test.Controllers
{
      
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly IPublishEndpoint _publishEndpoint;

        public OrderController(IPublishEndpoint publishEndpoint)
        {
            _publishEndpoint = publishEndpoint;
        }
        // POST
        public async Task<IActionResult> Post([FromBody] Order order)
        {
            await _publishEndpoint.Publish(order);
            
            return Ok();
        }
    }
}