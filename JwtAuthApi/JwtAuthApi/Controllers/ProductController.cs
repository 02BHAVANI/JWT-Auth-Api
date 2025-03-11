using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JwtAuthApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize] // Protect this API with JWT
    public class ProductController : ControllerBase
    {
        [HttpGet("getproduct")]
        public IActionResult GetProduct()
        {
            return Ok(new { ProductId = 1, Name = "Laptop", Price = 1200 });
        }
    }
}
