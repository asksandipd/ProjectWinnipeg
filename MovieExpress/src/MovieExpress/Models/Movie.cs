using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieExpress.Models
{
    public class Movie
    {
        public int MovieId { get; set; }

        public string MovieName { get; set; }

        public string Feedback { get; set; }

        public int Rating { get; set; }
    }
}
