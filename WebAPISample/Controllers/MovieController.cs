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
        public IEnumerable<Movie> Get ()
        {
            var thismovie = _context.Movies;
            return thismovie.ToList();
            
        }
        
        // GET api/movie/5
        [HttpGet("{id}")]
        public Movie Get(int id)
        {
           var thismovie =_context.Movies.Where(m => m.MovieId == id).FirstOrDefault();
           _context.Movies.Find(id);
           return thismovie;
        }

        // POST api/movie
        [HttpPost]
        public void Post([FromBody]Movie value)
        {

            // Create movie in db logic
        }

        // PUT api/movie/5
        [HttpPut]
        public Movie Put(int id, [FromBody]string value, Movie movie)
        {
             id = movie.MovieId;
            _context.Movies.Find(id);
            if (id != null)
            {
                var thismovie = movie;
                _context.Movies.Where(m => m.MovieId == thismovie.MovieId && m.Title == thismovie.Title && m.Genre == thismovie.Genre && m.Director == thismovie.Director).ToList();
                _context.SaveChanges();
                return thismovie;
            }
            return movie;
            
            // Update movie in db logic
        }

        // DELETE api/movie/5
        [HttpDelete]
        public void Delete(int id)
        {             
            // Delete movie from db logic
        }
    }
}