using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AWSChunky.Data.Models;

namespace AWSChunky.Data.Queries
{
    public class WordsQueryProcessor : IWordsQueryProcessor
    {
        private readonly List<Word> _wordsList = new List<Word>()
        {
           new Word() { Id=1, DeckId = 3, OriginalText = "get away", Translatedtext = "alejarse", ExampleSentence = "The teacher pointed out the mistake in the text", Definition = "" },
           new Word() { Id=2, DeckId = 3, OriginalText = "drop out", Translatedtext = "retirarse", ExampleSentence = "she'll have to drop out of the school", Definition = "" },
           new Word() { Id=3, DeckId = 1, OriginalText = "over-rated", Translatedtext = "sobrevalorado", ExampleSentence = "The car is over-rated by some people", Definition = "" },
        };
        public Task<Word> Create(Word model)
        {
            throw new NotImplementedException();
        }

        public Task Delete(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Word> Get(int deckId)
        {
            return _wordsList;
        }
    }
}
