using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JorgeMoncayoL_EjercicioCF.Models;

namespace JorgeMoncayoL_EjercicioCF.Data
{
    public class JorgeMoncayoL_EjercicioCFContext : DbContext
    {
        public JorgeMoncayoL_EjercicioCFContext (DbContextOptions<JorgeMoncayoL_EjercicioCFContext> options)
            : base(options)
        {
        }

        public DbSet<JorgeMoncayoL_EjercicioCF.Models.Burguer> Burguer { get; set; } = default!;
    }
}
