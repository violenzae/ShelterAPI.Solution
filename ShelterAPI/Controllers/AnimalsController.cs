using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ShelterAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;


namespace ShelterAPI.Controllers
{ 
  [ApiVersion("1.0")]
  [Route("api/animals")]
  [ApiController]
  public class AnimalsV1Controller : ControllerBase
  {
    private ShelterAPIContext _db;

    public AnimalsV1Controller(ShelterAPIContext db)
    {
      _db = db;
    }

    // GET api/animals
    [HttpGet]
    public ActionResult<IEnumerable<Animal>> Get(string species, string breed, string gender, string name, int? age, string sortColumn)
    {
      var query = _db.Animals.AsQueryable();
      

      if (species != null)
      {
        query = query.Where(entry => entry.Species == species);
      }
      if (breed != null)
      {
        query = query.Where(entry => entry.Breed == breed);
      }
      if (gender != null)
      {
        query = query.Where(entry => entry.Gender == gender);
      }
      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }
      if (age != null)
      {
        query = query.Where(entry => entry.Age == age);
      }

      if (sortColumn != null)
      {
        if (sortColumn == "species")
        {
          return query.OrderBy(entry => entry.Species).ToList();
        } 
        else if (sortColumn == "age")
        {
          return query.OrderBy(entry => entry.Age).ToList();
        } 
        else if (sortColumn == "gender")
        {
          return query.OrderBy(entry => entry.Gender).ToList();
        } 
        else if (sortColumn == "name")
        {
          return query.OrderBy(entry => entry.Name).ToList();
        } 
        else if (sortColumn == "breed")
        {
          return query.OrderBy(entry => entry.Breed).ToList();
        } 
        else
        {
          return query.ToList();
        }
      }
      else
      {
      return query.ToList();
      }
    }

    // GET api/Animals/5
    [HttpGet("{id}")]
    public ActionResult<Animal> Get(int id)
    {
      return _db.Animals.FirstOrDefault(entry => entry.AnimalId == id);
    }

    [HttpGet("random")]
    public ActionResult<Animal> Get()
    {
      int count = _db.Animals.Count();
      Random rnd = new Random();
      int randNum = rnd.Next(1, (count+1));
      return _db.Animals.FirstOrDefault(entry => entry.AnimalId == randNum);
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
    public void Put(int id, [FromBody] Animal animal)
    {
        animal.AnimalId = id;
        _db.Entry(animal).State = EntityState.Modified;
        _db.SaveChanges();
    }

    // DELETE api/Animals/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var animalToDelete = _db.Animals.FirstOrDefault(entry => entry.AnimalId == id);
      _db.Animals.Remove(animalToDelete);
      _db.SaveChanges();
    }
  }



  [ApiVersion("2.0")]
  [Route("api/{v:apiVersion}/animals")]
  [ApiController]
  public class AnimalsV2Controller : ControllerBase
  {
    private ShelterAPIContext _db;

    public AnimalsV2Controller(ShelterAPIContext db)
    {
      _db = db;
    }

    // GET api/animals
    [HttpGet]
    public ActionResult<IEnumerable<Animal>> Get(string species, string breed, string gender, string name, int? age)
    {
      var query = _db.Animals.AsQueryable();

      if (species != null)
      {
        query = query.Where(entry => entry.Species == species);
      }

      return query.ToList();
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
    public void Put(int id, [FromBody] Animal animal)
    {
        animal.AnimalId = id;
        _db.Entry(animal).State = EntityState.Modified;
        _db.SaveChanges();
    }

    // DELETE api/Animals/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var animalToDelete = _db.Animals.FirstOrDefault(entry => entry.AnimalId == id);
      _db.Animals.Remove(animalToDelete);
      _db.SaveChanges();
    }
  }
}
