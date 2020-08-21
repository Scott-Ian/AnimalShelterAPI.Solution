using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AnimalShelterAPI.Models;

namespace AnimalShelterAPI.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class DogsController : ControllerBase
  {
    private AnimalShelterAPIContext _db;

    public DogsController(AnimalShelterAPIContext db)
    {
      _db = db;
    }

    //GET api/Dogs
    //http://localhost:5000/api/Dogs?PageNumber=2
    //http://localhost:5000/api/Dogs?PageNumber=2&PageSize=1
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Dog>>> Get ([FromQuery] PaginationFilter pagination)
    {
      var dogs = await _db.Dogs
      .Skip((pagination.PageNumber -1) * pagination.PageSize)
      .Take(pagination.PageSize)
      .ToListAsync();

      return dogs;
    }

    //GET api/Dogs/3 - Get for specific Dog
    [HttpGet("DogId")]
    public async Task<ActionResult<Dog>> GetAction(int DogId)
    {
      Dog dog = await _db.Dogs.FirstOrDefaultAsync(d => d.DogId == DogId);
      return dog;
    }

    // POST api/Dogs
    [HttpPost]
    public void Post([FromBody] Dog dog)
    {
      _db.Dogs.Add(dog);
      _db.SaveChanges();
    }

    //PUT api/dogs/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Dog dog)
    {
      dog.DogId = id;
      _db.Entry(dog).State = EntityState.Modified;
      _db.SaveChanges();
    }

    //DELETE api/dogs/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var dogToDelete = _db.Dogs.FirstOrDefault(d => d.DogId == id);
      _db.Dogs.Remove(dogToDelete);
      _db.SaveChanges();
    }
  }
}