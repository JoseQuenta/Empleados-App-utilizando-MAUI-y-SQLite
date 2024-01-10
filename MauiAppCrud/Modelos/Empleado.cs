using System.ComponentModel.DataAnnotations;

namespace MauiAppCrud.Modelos
{
    public class Empleado
    {
        //aqui se colocan las propiedades de la clase, por ejemplo:
        [Key]
        public int IdEmpleado { get; set; }
        public string NombreCompleto { get; set; }
        public string Correo { get; set; }
        public decimal Sueldo { get; set; }
        public DateTime FechaContrato { get; set; }
    }
}

//las caracterisiticas como llave primaria, identitiy se colocan con data annotations es decir con [], por ejemplo si es llave primaria se coloca [Key], si es identity se coloca [DatabaseGenerated(DatabaseGeneratedOption.Identity)], si es requerido se coloca [Required], si es unico se coloca [Index(IsUnique = true)], si es unico y requerido se coloca [Required, Index(IsUnique = true)], si es unico y requerido y tiene un tamaño maximo se coloca [Required, Index(IsUnique = true), MaxLength(50)], si es unico y requerido y tiene un tamaño maximo y un nombre de columna se coloca [Required, Index(IsUnique = true), MaxLength(50), Column("NombreColumna")], si es unico y requerido y tiene un tamaño maximo y un nombre de columna y es llave primaria se coloca [Key, Required, Index(IsUnique = true), MaxLength(50), Column("NombreColumna")], si es unico y requerido y tiene un tamaño maximo y un nombre de columna y es llave primaria y es identity se coloca [Key, Required, Index(IsUnique = true), MaxLength(50), Column("NombreColumna"), DatabaseGenerated(DatabaseGeneratedOption.Identity)]... en el caso se requiera colocar mas de uno, esta se debe colocar en la parte superior de la clase, por ejemplo [Key, Required, Index(IsUnique = true), MaxLength(50), Column("NombreColumna"), DatabaseGenerated(DatabaseGeneratedOption.Identity)] public class Empleado
