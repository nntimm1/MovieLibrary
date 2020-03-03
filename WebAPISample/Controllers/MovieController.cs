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
<<<<<<< HEAD
            // Retrieve all movies from db logic
            return _context.Movies.ToList();
=======
            // TODO Retrieve all movies from db logic
            return new string[] { "movie1 string", "movie2 string" };
>>>>>>> 53a0317e8b92cceb7e29dc30bbd1ddff067c656b
        }

        // GET api/movie/5
        [HttpGet("{id}")]
        public Movie Get(int id)
        {
<<<<<<< HEAD

            // Retrieve movie by id from db logic
            var selectmovie = _context.Movies.Where(m => m.MovieId == id).FirstOrDefault();
            return selectmovie;
=======
            // TODO Retrieve movie by id from db logic
            return "value";
>>>>>>> 53a0317e8b92cceb7e29dc30bbd1ddff067c656b
        }

        // POST api/movie
        [HttpPost]
        public void Post([FromBody]Movie value)
        {
<<<<<<< HEAD
            _context.Movies.Add(value);
            _context.SaveChanges();
            
       
            // Create movie in db logic
=======
            // TODO Create movie in db logic
>>>>>>> 53a0317e8b92cceb7e29dc30bbd1ddff067c656b
        }

        // PUT api/movie/5
        [HttpPut]
        public void Put(int id, [FromBody]string value)
        {
            // TODO Update movie in db logic
        }

        // TODO DELETE api/movie/5
        [HttpDelete]
        public void Delete(int id)
        {
<<<<<<< HEAD
           

            var movie = _context.Movies
                .Where(m => m.MovieId == id)
                .FirstOrDefault();

            _context.Remove(movie);
            _context.SaveChanges();


            // Delete movie from db logic
=======
            // TODO Delete movie from db logic
>>>>>>> 53a0317e8b92cceb7e29dc30bbd1ddff067c656b
        }
    }
}