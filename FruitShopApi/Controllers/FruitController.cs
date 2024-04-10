using FruitShopApi.Model;
using Microsoft.AspNetCore.Mvc;


namespace FruitShopApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FruitController : ControllerBase
    {

        private readonly ILogger<FruitController> _logger;

        public FruitController(ILogger<FruitController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetFruit")]
        public JsonResult GetFruit()
        {
            // Create mock data for fruits
            var fruits = new List<Fruit>
            {
                new Fruit { Id = 1, Name = "Apple", Image = "apple.jpg" },
                new Fruit { Id = 2, Name = "Banana", Image = "banana.jpg" },
                new Fruit { Id = 3, Name = "Orange", Image = "orange.jpg" }
            };
            return new JsonResult(fruits);
        }
    }
}
