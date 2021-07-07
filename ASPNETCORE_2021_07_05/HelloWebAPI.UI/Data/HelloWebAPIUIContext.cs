using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HelloWebAPI.Shared.Entities;

namespace HelloWebAPI.UI.Data
{
    public class HelloWebAPIUIContext : DbContext
    {
        public HelloWebAPIUIContext (DbContextOptions<HelloWebAPIUIContext> options)
            : base(options)
        {
        }

        public DbSet<HelloWebAPI.Shared.Entities.Movie> Movie { get; set; }
    }
}
