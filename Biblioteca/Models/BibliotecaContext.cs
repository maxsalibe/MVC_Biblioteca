using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Modelo
{
    public class BibliotecaContext : DbContext
    {
        public DbSet<Usuario> usuarios { get; set; }
        public DbSet<Lector> lectores { get; set; }
        public DbSet<Prestamo> prestamos { get; set; }
        public DbSet<Libro> libros { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Server=localhost;Database=BIBLIOTECA;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
        public BibliotecaContext(DbContextOptions<BibliotecaContext> options): base(options)
        { }

        public BibliotecaContext()
        {
        }
    }
}
