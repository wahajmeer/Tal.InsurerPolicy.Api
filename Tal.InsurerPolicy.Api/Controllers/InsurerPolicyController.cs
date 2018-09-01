using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Tal.InsurerPolicy.Domain;
using Tal.InsurerPolicy.Services.Queries;

namespace Tal.InsurerPolicy.Api.Controllers
{
    [Route("insurerpolicies")]
    [Produces("application/json")]
    public class InsurerPolicyController : Controller
    {
        private readonly IMediator _mediator;

        public InsurerPolicyController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("get")]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.OK, Type =  typeof(List<LifeClient>))]
        public async Task<IActionResult> GetInsurerPolicies()
        {
            var insurerPolicies = await _mediator.Send(new GetInsurerPolicies());

            if (insurerPolicies == null)
            {
                return NotFound();
            }

            return Ok(insurerPolicies);
        }
    }

    
}