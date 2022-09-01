using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Videoteka.Data.Entities;

namespace Videoteka.Data.Abstract
{
    public interface ICinemaRepository
    {
        IEnumerable<Cinema> GetAll();
        Cinema? GetById(int id);
        void Insert(Cinema entity);
        void Update(Cinema entity);
        void Delete(int id);
        void SaveChanges();
    }
}
