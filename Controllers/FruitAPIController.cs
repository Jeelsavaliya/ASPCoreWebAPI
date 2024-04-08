using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASPCoreWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FruitAPIController : ControllerBase
    {

        public List<string> fruits = new List<string>()
        {
            "Apple","Mango","Banana","Watermellon","Ice-Apple"
        };

        [HttpGet]
        public List<string> Get()
        {
            return fruits;
        }

        [HttpGet("{id}")]
        public string GetFruitsById(int id)
        {
            return fruits.ElementAt(id);
        }
    }
}
