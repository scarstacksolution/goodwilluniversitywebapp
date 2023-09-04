using Aug31_Ver1_WebAp.Models;
using Microsoft.EntityFrameworkCore;

namespace Aug31_Ver1_WebAp.UnitOfWorkPattern
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Person> Person { get; set; }


    }
}

