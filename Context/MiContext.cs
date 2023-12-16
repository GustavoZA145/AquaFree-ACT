using Microsoft.EntityFrameworkCore;
using AquaFree.Models;

namespace AquaFree.Context
{
    public class MiContext : DbContext
    {
        public MiContext(DbContextOptions<MiContext> options) : base(options)
        {
        
        }

        public DbSet<Usuario> Usuarios { get; set; }
        
    }
}