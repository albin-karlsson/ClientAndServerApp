using Microsoft.AspNetCore.Mvc;
using Shared;

namespace ServerApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalsController : ControllerBase
    {
        public static List<AnimalModel> Animals { get; set; } = new()
        {
            new AnimalModel()
            {
                Id = 1,
                Name = "Salmon",
                Type = "Fish"
            },
            new AnimalModel()
            {
                Id = 2,
                Name = "Lion",
                Type = "Mammal"
            },
            new AnimalModel()
            {
                Id = 3,
                Name = "Urangutang",
                Type = "Mammal"
            }
        };

        [HttpGet]
        public ActionResult<List<AnimalModel>> Get()
        {
            return Ok(Animals);
        }

        [HttpPost]
        public ActionResult Post(AnimalModel model)
        {
            if (model != null)
            {
                Animals.Add(model);

                return Ok();
            }

            return BadRequest();
        }
    }
}
