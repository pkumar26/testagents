
    using Microsoft.AspNetCore.Mvc;

    namespace Reporting.Api.Controllers
    {
        [ApiController]
        [Route("api/[controller]")]
        public class Configuration_ApplyAuditingController : ControllerBase
        {
            [HttpPost]
            public IActionResult Execute()
            {
                // Logic for executing Configuration_ApplyAuditing stored procedure
                return Ok("Configuration_ApplyAuditing executed successfully.");
            }
        }
    }
    