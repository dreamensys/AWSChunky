using System;
using System.Collections.Generic;
using System.Text;

namespace AWSChunky.Data.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public DateTime Birthday { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }


    }
}
