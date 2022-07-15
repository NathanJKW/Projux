namespace Projux.Backend.Brokers.Database;

using LiteDB;
using Projux.Backend.Database;
using Projux.Backend.Database.Entities;

public class DatabaseBroker : IDatabaseBroker
{
    private IDatabaseContext _databaseContext { get; }
    public DatabaseBroker(IDatabaseContext databaseContext)
    {
        _databaseContext = databaseContext;
    }

    public ILiteCollection<CustomerContactEntity> CustomerContactCollection =>
        _databaseContext.Database.GetCollection<CustomerContactEntity>("CustomerContact");
}
