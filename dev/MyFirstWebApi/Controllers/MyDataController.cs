using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MyFirstWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MyDataController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Silti","Normāli", "Auksti"
        };
        private static readonly string[] Cities = new[]
        {
            "Riga","Salaspils","Jekabpils","Liepaja","Ogre"
        };
        private readonly ILogger<MyData> _logger;

        public MyDataController(ILogger<MyData> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<MyData> Get()
        {
            string myCharsCaps = "BCDEFGHIJKLMNOPQRSTUVWXYZ";
            string myChars = "abcdefghijklmnopqrstuvwxyz";
            char symbol;
            var rng = new Random();
            return Enumerable.Range(1, 100).Select(index => new MyData
            {
                Name = myCharsCaps[rng.Next(0,myCharsCaps.Length-1)].ToString(),
                Surnname = myCharsCaps[rng.Next(0,myCharsCaps.Length-1)].ToString()
                
            })
            .ToArray();
        }
    }
}