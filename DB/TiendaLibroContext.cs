using Microsoft.EntityFrameworkCore;

namespace DB
{
    public class TiendaLibroContext: DbContext
    {
        public TiendaLibroContext(DbContextOptions<TiendaLibroContext> options): base(options) { 
        
            
        }
        
        public DbSet<Libro> Libros { get; set; }
        public DbSet<Autor> Autores { get; set; }

        
    }
}