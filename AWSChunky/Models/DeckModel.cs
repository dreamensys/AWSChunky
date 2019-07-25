using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AWSChunky.Models
{
    public class DeckModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public int WordsCount { get { return Words.Count; } }

        public int UserId { get; set; }

        public List<WordModel> Words { get; set; }
    }
}
