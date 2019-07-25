using AWSChunky.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AWSChunky.Data.Queries
{
    public interface IWordsQueryProcessor
    {
        IEnumerable<Word> Get(int deckId);

        Task<Word> Create(Word model);
        Task Delete(string id);
    }
}
