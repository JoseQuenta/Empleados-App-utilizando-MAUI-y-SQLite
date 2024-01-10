using MauiAppCrud.DataAccess;
using Microsoft.Extensions.Logging;

using MauiAppCrud.ViewModels;
using MauiAppCrud.Views;
using Microsoft.EntityFrameworkCore.Metadata.Conventions.Infrastructure;

namespace MauiAppCrud;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		//se crea una variable dbContex de tipo EmpleadoDbContext y se inicializa con un objeto de tipo EmpleadoDbContext y se llama al metodo Database.EnsureCreated() para crear la base de datos y las tablas de la base de datos y las columnas de las tablas de la base de datos y las relaciones entre las tablas de la base de datos
		var dbContex = new EmpleadoDbContext();
		dbContex.Database.EnsureCreated();
		dbContex.Dispose();

		builder.Services.AddDbContext<EmpleadoDbContext>();

		builder.Services.AddTransient<EmpleadoPage>();
		builder.Services.AddTransient<EmpleadoViewModel>();

        builder.Services.AddTransient<MainPage>();
        builder.Services.AddTransient<MainViewModel>();

		Routing.RegisterRoute(nameof(EmpleadoPage), typeof(EmpleadoPage));
        

#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
