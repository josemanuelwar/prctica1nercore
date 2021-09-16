using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace LeerData
{
    public class AppVentasCursosContext : DbContext
    {
        private  const string connectioString=@"Data Source=localhost;Initial Catalog=CursoOnline;User ID=sa;Password=Sasukescm912;Application Name=MyApp";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer(connectioString);

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            /*realcion de uno a uno*/
            modelBuilder.Entity<Cusrsos>()
                .HasOne(b => b.PrecioPromocion)
                .WithOne(i => i.cusrsos)
                .HasForeignKey<Precio>(b => b.CusrsoId);
            /*ralacion de uno a muchos*/        
            modelBuilder.Entity<Cometario>()
                .HasOne(p => p.cusrsos)
                .WithMany(b => b.CometarioLista)
                .HasForeignKey(p => p.CusrsoId);
            /* lave primaria compuesta */
            modelBuilder.Entity<CursoInstructor>().HasKey(ci => new {ci.InstruccionId,ci.CusrsoId} );
            /*muchos a muchos*/

            modelBuilder.Entity<CursoInstructor>()
                .HasOne(C => C.cursos)
                .WithMany(E => E.InstruccionLinck)
                .HasForeignKey(C =>C.CusrsoId);

            modelBuilder.Entity<CursoInstructor>()
                .HasOne(C => C.Instruccion)
                .WithMany(E => E.cursoLinck)
                .HasForeignKey(C =>C.InstruccionId);    
            
        }
        public DbSet<Cusrsos> Cusrsos {get; set;}
        public DbSet<Precio> Precio {get;set;}
        public DbSet<Cometario> Cometario {get;set;}
        public DbSet<Instruccion> Instruccion {get;set;}
        public DbSet<CursoInstructor> cursoInstructor {get;set;}
    }
}