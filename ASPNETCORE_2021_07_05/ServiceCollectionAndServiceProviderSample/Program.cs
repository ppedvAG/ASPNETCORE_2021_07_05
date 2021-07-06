using DependecyInjectionSample;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace ServiceCollectionAndServiceProviderSample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Definiton der Collection
            ServiceCollection serviceCollection = new ServiceCollection();
            
            //Hinzufügen von Objekten in den Container /Singleton / Scope / Transient
            serviceCollection.AddSingleton<ICar, MockCar>();
            serviceCollection.AddScoped<ICar, MockCar>();
            serviceCollection.AddTransient<ICar, MockCar>();

            //Am Ende wird die Reisetasche zugeschnürrt -> Ein ServiceProvider entseht 
            ServiceProvider provider = serviceCollection.BuildServiceProvider();

            ICar mockCar = provider.GetRequiredService<ICar>(); //Wird im Hintergrund aufgerufen, wenn eine Instanz der jeweiligen Controller-Klasse erstellt wird (via Factory)
            Console.ReadKey();

            //https://autofac.readthedocs.io/en/latest/integration/aspnetcore.html
            //Alternative Libraries -> AutoFac / Ninject / StructureMap -> bieten weitere alternativen zu ServiceProvider + andere Lebenszeiten bei Objecten an. 
        }
    }
}
