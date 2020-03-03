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


            // Retrieve all movies from db logic

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
        public void Post([FromBody]Movie value)
        {

            _context.Movies.Add(value);
            _context.SaveChanges();            
        }


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