
    using Microsoft.AspNetCore.Mvc;

    namespace Security.Api.Controllers
    {
        [ApiController]
        [Route("api/[controller]")]
        public class AddRoleMemberIfNonexistentController : ControllerBase
        {
            [HttpPost]
            public IActionResult Execute()
            {
                // Logic for executing AddRoleMemberIfNonexistent stored procedure
                return Ok("AddRoleMemberIfNonexistent executed successfully.");
            }
        }
    }
    