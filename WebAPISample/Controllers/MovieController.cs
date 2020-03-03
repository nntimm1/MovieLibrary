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
        // GET api/movie
        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            // Retrieve all movies from db logic
            return _context.Movies.ToList();
        }

        // GET api/movie/5
        [HttpGet("{id}")]
        public Movie Get(int id)
        {

            // Retrieve movie by id from db logic
            var selectmovie = _context.Movies.Where(m => m.MovieId == id).FirstOrDefault();
            return selectmovie;
        }

        // POST api/movie
        [HttpPost]
        public void Post([FromBody]Movie value)
        {
            _context.Movies.Add(value);
            _context.SaveChanges();
            
       
            // Create movie in db logic
        }

        // PUT api/movie/5
        [HttpPut]
        public void Put(int id, [FromBody]string value)
        {
            // Update movie in db logic
        }

        // DELETE api/movie/5
        [HttpDelete]
        public void Delete(int id)
        {
           

            var movie = _context.Movies
                .Where(m => m.MovieId == id)
                .FirstOrDefault();

            _context.Remove(movie);
            _context.SaveChanges();


            // Delete movie from db logic
        }
    }
}