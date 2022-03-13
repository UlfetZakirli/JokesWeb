#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JokesWeb.Models;

namespace JokesWeb.Data.ApplicationDb
{
    public class Context : DbContext
    {
        public Context (DbContextOptions<Context> options)
            : base(options)
        {
        }

        public DbSet<JokesWeb.Models.Joke> Joke { get; set; }
    }
}
