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
  public class CatsController : ControllerBase
  {
    private AnimalShelterAPIContext _db;

    public CatsController(AnimalShelterAPIContext db)
    {
      _db = db;
    }

    // GET api/Cats
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Cat>>> Get ([FromQuery] PaginationFilter pagination)
    {
      var cats = await _db.Cats
      .Skip((pagination.PageNumber -1) * pagination.PageSize)
      .Take(pagination.PageSize)
      .ToListAsync();

      return cats;
    }

    //GET api/Cats/5 - Get for specific Cat
    [HttpGet("CatId")]
    public async Task<ActionResult<Cat>> GetAction(int CatId)
    {
      Cat cat = await _db.Cats.FirstOrDefaultAsync(c => c.CatId == CatId);
      return cat;
    }

    // POST api/Cats
    [HttpPost]
    public void Post([FromBody] Cat cat)
    {
      _db.Cats.Add(cat);
      _db.SaveChanges();
    }
  }
}