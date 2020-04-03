using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ShelterAPI.Models;

namespace ShelterAPI.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class AnimalsController : ControllerBase
  {
    private ShelterAPIContext _db;

    public AnimalsController(ShelterAPIContext db)
    {
      _db = db;
    }

    // GET api/animals
    [HttpGet]
    public ActionResult<IEnumerable<Animal>> Get()
    {
      return _db.Animals.ToList();
    }

    // GET api/Animals/5
    [HttpGet("{id}")]
    public ActionResult<Animal> Get(int id)
    {
      return _db.Animals.FirstOrDefault(entry => entry.AnimalId == id);
    }

    // POST api/Animals
    [HttpPost]
    public void Post([FromBody] Animal animal)
    {
      _db.Animals.Add(animal);
      _db.SaveChanges();
    }

    // PUT api/Animals/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
      
    }

    // DELETE api/Animals/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
  }
}
