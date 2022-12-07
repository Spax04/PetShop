using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PetAPI.Data;
using PetAPI.Model;


namespace PetAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetsController : ControllerBase
    {

        private StoreContextApi _context;
        public PetsController( StoreContextApi context)
        {

            _context = context;
        }

        [HttpGet("AllAnimals")]
        public async Task<ActionResult<IEnumerable<Animal>>> GetAnimalsAsync()
        {
            return Ok(await _context.Animals!.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Animal>> GetOneAnimalAsync(int id)
        {
            Animal animal = await _context.Animals.FindAsync(id);

            if(animal == null)
            {
                return BadRequest();
            }
            else
            {
                return Ok(animal);
            }
            
        }
        
    }
}
