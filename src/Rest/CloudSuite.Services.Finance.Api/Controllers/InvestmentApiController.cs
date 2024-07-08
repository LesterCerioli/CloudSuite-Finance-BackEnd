using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using CloudSuite.BackBonne.Application.Handlers.AdviceService;
using CloudSuite.BackBonne.Application.Handlers.AdviceService.Requests;

namespace CloudSuite.Services.Finance.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvestmentApiController : ControllerBase
    {
        private readonly ILogger<InvestmentApiController> _logger;
        private readonly IMediator _mediator;

        public InvestmentApiController(ILogger<InvestmentApiController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [Authorize]
        [HttpPost("create")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Post([FromBody] CreateInvestmentCommand commandCreate)
        {
            var result = await _mediator.Send(commandCreate);
            if (result.Errors.Any())
            {
                return BadRequest(result);
            }
            else
            {
                return Ok(result);
            }
        }

        [Authorize]
        [HttpGet]
        [Route("exists/investment/{taxPayerRegistry}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> taxPayerRegistryExists([FromRoute] string taxPayerRegistry)
        {
            var result = await _mediator.Send(new CheckExistsInvestmentByTaxPayerRegistryRequest(taxPayerRegistry));
            if (result.Errors.Any())
            {
                return BadRequest(result);
            }
            else
            {
                return Ok(result);
            }

        }

        [Authorize]
        [HttpGet]
        [Route("exists/investment/{name}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> nameExists([FromRoute] string name)
        {
            var result = await _mediator.Send(new CheckExistsInvestmentByNameRequest(name));
            if (result.Errors.Any())
            {
                return BadRequest(result);
            }
            else
            {
                return Ok(result);
            }

        }

        [Authorize]
        [HttpGet]
        [Route("exists/investment/{investmentProfile}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> investmentProfileExists([FromRoute] string investmentProfile)
        {
            var result = await _mediator.Send(new CheckExistsInvestmentByInvestmentProfileRequest(investmentProfile));
            if (result.Errors.Any())
            {
                return BadRequest(result);
            }
            else
            {
                return Ok(result);
            }

        }
    }
}
