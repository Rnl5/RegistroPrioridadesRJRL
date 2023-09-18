using ClientesRJRL.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace RegistroPrioridadesRJRL.Models
{
    public class Context : DbContext
    {
        public DbSet<Prioridades> prioridades { get; set; }

        public DbSet<Clientes> Clientes {get; set;}

        public DbSet<Sistemas> Sistemas {get; set;}

        public DbSet<Tickets> Tickets {get; set;}
        
        public Context(DbContextOptions<Context> options) : base(options) { }
    }
}
