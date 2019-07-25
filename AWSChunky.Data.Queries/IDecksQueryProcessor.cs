using AWSChunky.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AWSChunky.Data.Queries
{
    public interface IDecksQueryProcessor
    {
        IEnumerable<Deck> Get();
        Deck Get(string id);
        Task Create(Deck model);
        //Task<Deck> Update(string id, UpdateDeckModel model);
        Task Delete(string id);
    }
}
