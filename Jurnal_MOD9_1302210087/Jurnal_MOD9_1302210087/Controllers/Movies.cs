using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel;
using System.Reflection;


namespace Jurnal_MOD9_1302210087.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Movies : ControllerBase
    {
        public static List<Movie2> _data = new List<Movie2>
        {
            new Movie2( "The Shawshank Redemption ", "Frank Darabont", new List<string>{"Tim Robbins", "Morgan Freeman", "Bob Gunton", "William Sadler" }, "Over the course of several years, two convicts form a friendship, seeking consolation and, eventually, redemption through basic compassion"),
            new Movie2( "The Godfather", "Francis Ford Coppola", new List<string>{"Marlon Brando", "Al Pacino", "James Caan", "Diane Keaton" }, "The aging patriarch of an organized crime dynasty in postwar New York City transfers control of his clandestine empire to his reluctant youngest son."),
            new Movie2( "The Dark Knight", "Christopher Nolan", new List<string>{"Christian Bale", "Heath Ledger", "Aaron Eckhart", "Michael Caine" }, "The aging patriarch of an organized crime dynasty in postwar New York City transfers control of his clandestine empire to his reluctant youngest son."),

        };
       
        [HttpGet]
        public IEnumerable<Movie2> Get()
        {
            return _data;
        }

        
        [HttpGet("{id}")]
        public Movie2 Get(int id)
        {
            if (id < 0 || id >= _data.Count)
            {
                NotFound();
            }
            return _data[id];
        }

      
        [HttpPost]
        public void Post([FromBody] Movie2 value)
        {
            _data.Add(value);
        }
      
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            if (id < 0 || id >= _data.Count)
            {
                NotFound();
            }
            _data.RemoveAt(id);
        }
    }
}