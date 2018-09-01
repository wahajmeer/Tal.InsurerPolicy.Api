using Microsoft.AspNetCore.Mvc;

namespace Tal.InsurerPolicy.Api.Controllers
{
    [Route("healthcheck")]
    public class HealthCheckController : Controller
    {
        [HttpGet]
        [Route("")]
        [Route("ping")]
        public string Ping()
        {
            return "Pong";
        }
    }
}