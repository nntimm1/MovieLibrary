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
        public IEnumerable<string> Get()
        {

            return new string[] { "movie1 string", "movie2 string" };
        }


        [HttpGet("{id}")]
        public string Get(int id)
        {

            return "value";
        }


        [HttpPost]
        public void Post([FromBody]Movie value)
        {

        }


        [HttpPut]
        public void Put(int id, [FromBody]string value)
        {

        }


        [HttpDelete]
        public void Delete(int id)
        {

        }
    }
}