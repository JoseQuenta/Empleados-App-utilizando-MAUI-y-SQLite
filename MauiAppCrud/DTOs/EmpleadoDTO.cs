using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiAppCrud.DTOs
{
    //se crea una clase llamada EmpleadoDTO que hereda de ObservableObject, esta clase se coloca en la carpeta DTOs, esta clase se encarga de almacenar los datos de un empleado. ObservableObject es una clase de CommunityToolkit.Mvvm.ComponentModel que se encarga de notificar cuando una propiedad cambia. Esta clase se utiliza para enviar los datos de un empleado a la base de datos.
    //Esta clase es partial, porque se utiliza en dos proyectos, en el proyecto MauiAppCrud y en el proyecto MauiAppCrudApi, en el proyecto MauiAppCrud se utiliza para enviar los datos de un empleado a la base de datos, en el proyecto MauiAppCrudApi se utiliza para recibir los datos de un empleado de la base de datos
    public partial class EmpleadoDTO : ObservableObject
    {
        [ObservableProperty]
        public int idEmpleado;
        [ObservableProperty]
        public string nombreCompleto;
        [ObservableProperty]
        public string correo;
        [ObservableProperty] 
        public decimal sueldo;
        [ObservableProperty]
        public DateTime fechaContrato;
    }
}
