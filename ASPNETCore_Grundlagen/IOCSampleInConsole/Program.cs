// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.DependencyInjection;

Console.WriteLine("Hello, World!");
//So wie wir es kennen -> Basis Interface und Implementierte Klasse
IShip shipMockObject = new ShipMockObjet();


//ASPNET Core ServiceCollection 
IServiceCollection services = new ServiceCollection();

//LifeCylces von Objekten (Singleton, Scoped, Transient) 
services.AddSingleton<IShip, ShipMockObjet>();

//ASP.NET Core 6 -> builder.Services.AddSingleton
//Nachdem ALLE Dienste oder Objekte hinzugefügt wurden, wird der ServiceProvider erstellt
IServiceProvider serviceProvider = services.BuildServiceProvider();


// -> Ab da an, können wir auf die Services (Dienste, Objekte) zugreifen

//Unterschied zwischen GetService und GetRequiredService


//GetService gibt NULL zurück, wenn der Dienst oder Objekt nicht gefunden wird
IShip shipMockObject1 = serviceProvider.GetService<IShip>();


//GetRequiredService wirft eine Exception, wenn der Dienst oder Objekt nicht gefunden wird
IShip shipMockObject2 = serviceProvider.GetRequiredService<IShip>();


//In ASPNETCORE wird das rauslesen auch unter dem Pattern Seperation of Concernce betitelt

