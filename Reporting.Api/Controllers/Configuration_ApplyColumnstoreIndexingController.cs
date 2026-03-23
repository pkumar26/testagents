
    using Microsoft.AspNetCore.Mvc;

    namespace Reporting.Api.Controllers
    {
        [ApiController]
        [Route("api/[controller]")]
        public class Configuration_ApplyColumnstoreIndexingController : ControllerBase
        {
            [HttpPost]
            public IActionResult Execute()
            {
                // Logic for executing Configuration_ApplyColumnstoreIndexing stored procedure
                return Ok("Configuration_ApplyColumnstoreIndexing executed successfully.");
            }
        }
    }
    