using MauiAppCrud.Modelos;
using Microsoft.EntityFrameworkCore;
using MauiAppCrud.Utilidades;

namespace MauiAppCrud.DataAccess
{
    //se crea una clase llamada EmpleadoDbContext que hereda de DbContext, esta clase se coloca en la carpeta DataAccess, esta clase se encarga de crear la base de datos y las tablas de la base de datos y las columnas de las tablas de la base de datos y las relaciones entre las tablas de la base de datos. DbContext es una clase de EntityFrameworkCore que se encarga de crear la base de datos y las tablas de la base de datos y las columnas de las tablas de la base de datos y las relaciones entre las tablas de la base de datos
    public class EmpleadoDbContext : DbContext
    {
        //se crea un constructor de la clase EmpleadoDbContext
        public DbSet<Empleado> Empleados { get; set; }

        //se crea un metodo llamado OnConfiguring que recibe como parametro un objeto de tipo DbContextOptionsBuilder llamado optionsBuilder, este metodo se encarga de configurar la base de datos, por ejemplo se le indica que se va a utilizar Sqlite y se le indica la ruta de la base de datos
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //se crea una variable de tipo string llamada conexionDB y se inicializa con la ruta de la base de datos
            string conexionDB = $"Filename={ConexionDB.DevolverRuta("empleados.db")}";
            //se le indica que se va a utilizar Sqlite y se le indica la ruta de la base de datos
            optionsBuilder.UseSqlite(conexionDB);
        }

        //se crea un metodo llamado OnModelCreating que recibe como parametro un objeto de tipo ModelBuilder llamado modelBuilder, este metodo se encarga de crear las tablas de la base de datos y las columnas de las tablas de la base de datos y las relaciones entre las tablas de la base de datos, por ejemplo se le indica que la tabla Empleado tiene una columna llamada IdEmpleado que es llave primaria y es identity y es requerida y tiene un tipo de dato int, se le indica que la tabla Empleado tiene una columna llamada NombreCompleto que es requerida y tiene un tipo de dato string, se le indica que la tabla Empleado tiene una columna llamada Correo que es requerida y tiene un tipo de dato string, se le indica que la tabla Empleado tiene una columna llamada Sueldo que es requerida y tiene un tipo de dato decimal, se le indica que la tabla Empleado tiene una columna llamada FechaContrato que es requerida y tiene un tipo de dato DateTime
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Empleado>(entity =>
            {
                entity.HasKey(col => col.IdEmpleado);
                entity.Property(col => col.IdEmpleado).IsRequired().ValueGeneratedOnAdd();
                entity.Property(col => col.NombreCompleto).IsRequired();
                entity.Property(col => col.Correo).IsRequired();
                entity.Property(col => col.Sueldo).IsRequired();
                entity.Property(col => col.FechaContrato).IsRequired();
            });
        }
    }
}
