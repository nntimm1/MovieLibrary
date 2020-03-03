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


        [HttpGet("{id}")]
        public Movie Get(int id)
        {
            var selectmovie = _context.Movies.Where(m => m.MovieId == id).FirstOrDefault();
            return selectmovie;
        }


        [HttpPost]
        public void Post([FromBody]Movie value)
        {
            _context.Movies.Add(value);
            _context.SaveChanges();
        }


        [HttpPut]
        public void Put(int id, [FromBody]string value)
        {

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