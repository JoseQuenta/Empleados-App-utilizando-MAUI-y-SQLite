using CommunityToolkit.Mvvm.Messaging.Messages;

namespace MauiAppCrud.Utilidades
{
    public class EmpleadoMensajeria : ValueChangedMessage<EmpleadoMensaje>
    {
        //se crea una clase llamada EmpleadoMensajeria que hereda de ValueChangedMessage, esta clase se coloca en la carpeta Utilidades, esta clase se encarga de enviar los datos de un empleado a la base de datos. ValueChangedMessage es una clase de CommunityToolkit.Mvvm.Messaging.Messages que se encarga de enviar un mensaje cuando una propiedad cambia. Esta clase se utiliza para enviar los datos de un empleado a la base de datos.
        public EmpleadoMensajeria(EmpleadoMensaje value) : base(value)
        {

        }
    }
}
