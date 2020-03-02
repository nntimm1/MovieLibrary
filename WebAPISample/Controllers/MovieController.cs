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
        public IEnumerable<string> Get()
        {
            // TODO Retrieve all movies from db logic
            return new string[] { "movie1 string", "movie2 string" };
        }

        // GET api/movie/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            // TODO Retrieve movie by id from db logic
            return "value";
        }

        // POST api/movie
        [HttpPost]
        public void Post([FromBody]Movie value)
        {
            // TODO Create movie in db logic
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
            // TODO Delete movie from db logic
        }
    }
}