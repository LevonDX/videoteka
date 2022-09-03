using Videoteka.Data;

namespace Videoteka.UI.Models
{
    public class CinemaViewModel
    {
        public CinemaViewModel()
        {
            Name = "Unnamed";
        }
        
        public int? Id { get; set; }

        public string Name { get; set; }
        
        public Genre Genre { get; set; }
    }
}
