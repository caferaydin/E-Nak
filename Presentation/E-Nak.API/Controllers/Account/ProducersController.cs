using E_Nak.Application.Features.Commands.Account.CreateProducer;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace E_Nak.API.Controllers.Account
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProducersController : ControllerBase
    {
        readonly private IMediator _mediator;

        public ProducersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateProducer(CreateProducerCommandRequest request)
        {
            CreateProducerCommandResponse response = await _mediator.Send(request);
            return StatusCode((int)HttpStatusCode.Created);
        }
    }
}
