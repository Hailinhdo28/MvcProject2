using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcProject2.Models;
using MvcProject2.Data;

    namespace MvcProject2.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext (DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<MvcProject2.Models.Movie> Movie { get; set; }
    }
}
