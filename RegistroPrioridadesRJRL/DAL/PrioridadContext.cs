using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace RegistroPrioridadesRJRL.Models
{
    public class PrioridadContext : DbContext
    {
        public DbSet<Prioridad> prioridades { get; set; }

        public PrioridadContext(DbContextOptions<PrioridadContext> options) : base(options) { }
    }
}
