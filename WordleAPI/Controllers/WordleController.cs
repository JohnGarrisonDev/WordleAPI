using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WordleAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WordleController : ControllerBase
    {

        string word = "SALET";
        // GET: api/<WordleController>
        [HttpGet]
        public string Get()
        {
            return word;
        }

        // GET api/<WordleController>/5
        [HttpGet("{guess}")]
        public Wordle Get(string guess)
        {
            return new Wordle(word, guess);
        }
    }
}
