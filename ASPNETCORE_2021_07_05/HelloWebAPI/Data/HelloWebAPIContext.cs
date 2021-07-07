using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloWebAPI.Shared.Entities;
using Microsoft.EntityFrameworkCore;


namespace HelloWebAPI.Data
{
    public class HelloWebAPIContext : DbContext
    {
        public HelloWebAPIContext (DbContextOptions<HelloWebAPIContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }
    }
}
