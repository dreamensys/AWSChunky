using AWSChunky.Data.Models;
using AWSChunky.Data.Queries;
using AWSChunky.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AWSChunky.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DecksController : ControllerBase
    {
        private readonly IDecksQueryProcessor _decksProc;

        public DecksController(IDecksQueryProcessor decksProc)
        {
            _decksProc = decksProc;
        }

        // GET: api/decks
        [HttpGet]
        public IActionResult Get()
        {
            var decks = _decksProc.Get();
            //var decksList = decks.Select(w => new DeckModel()
            //{
            //    Id = w.Id,
            //    Title = w.Title,
            //    Date = w.DateCreated,
            //    Words = new List<WordModel>() {
            //        new WordModel() { Id=1, DeckId = 3, OriginalText = "get away", Translatedtext = "alejarse", ExampleSentence = "The teacher pointed out the mistake in the text", Definition = "" },
            //        new WordModel() { Id=2, DeckId = 3, OriginalText = "drop out", Translatedtext = "retirarse", ExampleSentence = "she'll have to drop out of the school", Definition = "" },
            //        new WordModel() { Id=3, DeckId = 1, OriginalText = "over-rated", Translatedtext = "sobrevalorado", ExampleSentence = "The car is over-rated by some people", Definition = "" },
            //    }
            //}); ;
            return Ok(decks);
        }
        
        // POST: api/Decks
        [HttpPost]
        public IActionResult Post([FromBody] Deck value)
        {
            var newDeck = _decksProc.Create(value);
            return Ok(newDeck);
        }

        // PUT: api/Decks/5
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
