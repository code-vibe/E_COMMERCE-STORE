using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public string GetProducts()
        {
            return "All Products";
        }

        [HttpGet ("{id}")]
        public string GetProduct(int id)
        {
            return "Single Products";
        }
    }
}
