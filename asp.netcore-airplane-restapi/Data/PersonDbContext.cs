using asp.netcore_airplane_restapi.Models;
using Microsoft.EntityFrameworkCore;

namespace asp.netcore_airplane_restapi.Data
{
    public class PersonDbContext : DbContext
    {
        public PersonDbContext(DbContextOptions<PersonDbContext> options) : base(options)
        {

        }

        public DbSet<Person> people { get; set; }
        public DbSet<Airplane> airplanes { get; set; }
    }
}
