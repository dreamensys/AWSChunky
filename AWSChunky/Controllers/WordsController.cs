using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AWSChunky.Data.Queries;
using AWSChunky.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AWSChunky.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WordsController : ControllerBase
    {
        private readonly IWordsQueryProcessor wordsQueryProc;

        public WordsController(IWordsQueryProcessor _wordsProc)
        {
            wordsQueryProc = _wordsProc;
        }
        // GET: api/words/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            var words = wordsQueryProc.Get(id);
            var wordsList = words.Select(q => new WordModel() {
                Id = q.Id,
                OriginalText = q.OriginalText,
                Translatedtext = q.Translatedtext,
                ExampleSentence = q.ExampleSentence,
                Definition = q.Definition,
                DeckId = q.DeckId
            });
            return Ok(wordsList);
        }

       

        // POST: api/Words
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Words/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
