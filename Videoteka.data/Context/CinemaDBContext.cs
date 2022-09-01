using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Videoteka.Data.Entities;

namespace Videoteka.Data.Context
{
    public class CinemaDBContext : DbContext
    {

        public CinemaDBContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Cinema> Cinemas { get; set; } = null!;
    }
}
