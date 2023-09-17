using Microsoft.EntityFrameworkCore;
using Registro_de_Tickets.Models;

namespace Registro_de_Tickets.DAL 
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context>op) : base(op) { }
        public DbSet<Tickets> Tickets { get; set; }
    }
}
