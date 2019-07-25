using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AWSChunky.Models
{
    public class WordModel
    {
        public int Id { get; set; }
        public string OriginalText { get; set; }
        public string Translatedtext { get; set; }
        public string ExampleSentence { get; set; }
        public string Definition { get; set; }
        public int DeckId { get; set; }

    }
}
