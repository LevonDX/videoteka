using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Videoteka.Data.Entities
{
    public class Cinema : EntityBase
    {
        public Cinema()
        {
            Name = "Unnamed";
        }
        
        public string Name { get; set; }

        public TimeSpan? Duration { get; set; }

        public Genre Genre { get; set; }

        public Quality? Quality { get; set; }
    }
}