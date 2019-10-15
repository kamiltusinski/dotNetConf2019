using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace NetConfApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JokesController : ControllerBase
    {
        private readonly ILogger<JokesController> _logger;
        private readonly IEnumerable<Joke> _jokes;

        public JokesController(ILogger<JokesController> logger)
        {
            _logger = logger;

            var json = System.IO.File.ReadAllText("jokes.json");
            _jokes = JsonSerializer.Deserialize<Joke[]>(json, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
        }

        [HttpGet("{type}/random")]
        public Joke Get(string type)
        {
            var rng = new Random();
            var jokes = _jokes.Where(x=>x.Type == type).ToArray();

            return jokes[rng.Next(0, jokes.Length)];
        }
    }
}
