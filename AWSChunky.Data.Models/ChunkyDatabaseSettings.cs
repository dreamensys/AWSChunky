using System;
using System.Collections.Generic;
using System.Text;

namespace AWSChunky.Data.Models
{
    public class ChunkyDatabaseSettings : IChunkyDatabaseSettings
    {
        public string DecksCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface IChunkyDatabaseSettings
    {
        string DecksCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
