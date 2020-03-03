using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPISample.Data;
using WebAPISample.Models;

namespace WebAPISample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private ApplicationContext _context;
        public MovieController(ApplicationContext context)
        {
            _context = context;
        } 

        [HttpGet]

        public IEnumerable<Movie> Get()
        {

            return _context.Movies.ToList();
        }

        // GET api/movie/5
        [HttpGet("{id}")]
        public Movie Get(int id)
        {
           var thismovie =_context.Movies.Where(m => m.MovieId == id).FirstOrDefault();
           _context.Movies.Find(id);
           return thismovie;

        }
       
        [HttpPost]
        public IActionResult Post([FromBody]Movie value)
        {

            _context.Movies.Add(value);
            _context.SaveChanges();
            return Ok(value);
        }


        [HttpPut]
        public void Put(int id, [FromBody]Movie value)
        {
            _context.Movies.Where(m => m.MovieId == id);
            _context.Movies.Find(id);
            if (id != value.MovieId)
            {
                NotFound();
            }
            if (ModelState.IsValid)
            {
                
                _context.Movies.Update(value);
                _context.SaveChanges();
            }
            

        }


        [HttpDelete]
        public void Delete(int id)

        {
            var movie = _context.Movies
                .Where(m => m.MovieId == id)
                .FirstOrDefault();

            _context.Remove(movie);
            _context.SaveChanges();
        }
    }
}