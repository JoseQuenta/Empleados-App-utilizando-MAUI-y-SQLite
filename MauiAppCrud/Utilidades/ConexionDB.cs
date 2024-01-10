namespace MauiAppCrud.Utilidades
{
    //se crea una clase estatica para devolver la ruta de la base de datos, esta clase se llama ConexionDB y se coloca en la carpeta Utilidades
    public static class ConexionDB
    {
        public static string DevolverRuta(string nombreBaseDatos)
        {
            //se crea una variable de tipo string llamada rutaBaseDatos y se inicializa en vacio
            string rutaBaseDatos = string.Empty;
            //se crea una condicion para verificar si el dispositivo es android o ios
            if(DeviceInfo.Platform == DevicePlatform.Android)
            {
                //si es android se obtiene la ruta de la base de datos y se almacena en la variable rutaBaseDatos
                rutaBaseDatos = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                //se concatena la ruta de la base de datos con el nombre de la base de datos
                rutaBaseDatos = Path.Combine(rutaBaseDatos, nombreBaseDatos);
            }
            else if(DeviceInfo.Platform ==DevicePlatform.iOS)
            {
                rutaBaseDatos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                rutaBaseDatos = Path.Combine(rutaBaseDatos, "..", "Library", nombreBaseDatos);
            }
            return rutaBaseDatos;
        }
    }
}
