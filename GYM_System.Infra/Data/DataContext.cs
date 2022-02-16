using GYM_System.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace GYM_System.Infra.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
          : base(options) { }

            public DbSet<Teacher> Teachers { get; set; }
            public DbSet<Student> Students { get; set; }
    }
}