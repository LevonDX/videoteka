using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Videoteka.Data.Abstract;
using Videoteka.Data.Context;
using Videoteka.Data.Entities;

namespace Videoteka.Data.Concrete
{
    public class CinemaRepository : ICinemaRepository
    {
        private readonly CinemaDBContext _context;

        public CinemaRepository(CinemaDBContext context)
        {
            _context = context;
        }

        public void Delete(int id)
        {
            var cinema = GetById(id);
            if (cinema != null)
            {
                _context.Cinemas.Remove(cinema);
            }
        }

        public IEnumerable<Cinema> GetAll()
        {
            return _context.Cinemas.ToList();
        }

        public Cinema? GetById(int id)
        {
            return _context.Cinemas.Find( id);
        }

        public void Insert(Cinema entity)
        {
            _context.Cinemas.Add(entity);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void Update(Cinema entity)
        {
            _context.Cinemas.Update(entity);
        }
    }
}
