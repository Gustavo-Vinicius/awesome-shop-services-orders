using Awesomeshop.Services.Orders.Application.Commands;
using Awesomeshop.Services.Orders.Application.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Awesomeshop.Services.Orders.Api.Controllers
{
    [Route("api/customers/{customerId}/orders")]
    //[Route("api/orders")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IMediator _mediator;
        public OrderController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByUId(Guid id)
        {
            var query = new GetOrderById(id);

            var result = await _mediator.Send(query);

            if(result == null) return NotFound();

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] AddOrder command)
        {
            var id = await _mediator.Send(command);

            return CreatedAtAction(nameof(GetByUId), new {id = id}, command );
        }


    }
}