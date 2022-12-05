using Microsoft.EntityFrameworkCore;
using guia_semana_16.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace guia_semana_16.Data
{
    public class guia_semana_16Context : DbContext
    {
        public guia_semana_16Context(DbContextOptions<guia_semana_16Context> options) : base(options)
        {

        }

        public DbSet<Movie> Movie { get; set; }
    }
}
