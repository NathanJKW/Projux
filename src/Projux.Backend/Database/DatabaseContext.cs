namespace Projux.Backend.Database;

using LiteDB;
using Projux.Backend.Database.Entities;

public class DatabaseContext : IDatabaseContext
{
    public LiteDatabase Database { get; }

    public ILiteCollection<CustomerContactEntity> CustomerContactCollection => Database.GetCollection<CustomerContactEntity>("CustomerContact");

    public DatabaseContext(DatabaseOptions options)
    {
        Database = new LiteDatabase(options.DatabaseLocation);
    }
}