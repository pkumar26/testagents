
    using Microsoft.AspNetCore.Mvc;

    namespace Performance.Api.Controllers
    {
        [ApiController]
        [Route("api/[controller]")]
        public class Configuration_ApplyFullTextIndexingController : ControllerBase
        {
            [HttpPost]
            public IActionResult Execute()
            {
                // Logic for executing Configuration_ApplyFullTextIndexing stored procedure
                return Ok("Configuration_ApplyFullTextIndexing executed successfully.");
            }
        }
    }
    