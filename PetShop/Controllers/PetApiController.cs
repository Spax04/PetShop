using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using PetShop.Model;
using PetShop.Repositories;

namespace PetShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetApiController : ControllerBase
    {
        private IRepository _repository;
        private readonly IConfiguration _configuration;
        public PetApiController(IRepository repository, IConfiguration configuration)
        {
            _repository = repository;
            _configuration = configuration;
        }

        [HttpGet]
        public IEnumerable<Animal> Get()
        {
            return _repository.GetAllAnimals();
        }

        [HttpGet("{id}")]
        public ActionResult<Animal> Get(int id)
        {
            if(_repository.GetAnimalById(id) == null)
                return NotFound();
            else
                return Ok(_repository.GetAnimalById(id));
        }
    }
}
