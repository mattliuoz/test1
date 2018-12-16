using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Webapi.Domains;

namespace Webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PayslipsController : ControllerBase
    {
        public readonly IMediator _mediator;
        public PayslipsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET api/payslips/5
        [HttpGet("{id}")]
        public async Task<ActionResult<string>> Get(int id)
        {
            var a = await _mediator.Send(new GetPayslipCommand(id, PayMonth.January));

            return a;
        }
    }
}
