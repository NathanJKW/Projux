using Microsoft.Extensions.DependencyInjection;
using Projux.Dal.CustomerContact;
using Projux.Dal.Database;

namespace Projux.Dal;

public static class ProjuxDalInit
{
public static void AddProjuxDalLayer(this IServiceCollection serviceCollection, string dbLocation)
{
    // Services
    var databaseOptions = new DatabaseOptions { DatabaseLocation = dbLocation };

    serviceCollection.AddSingleton(databaseOptions);
    serviceCollection.AddSingleton<IDatabaseContext, DatabaseContext>();
    serviceCollection.AddTransient<ICustomerContactBroker, CustomerContactBroker>();
}
}