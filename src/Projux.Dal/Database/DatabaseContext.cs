using LiteDB;
using Projux.Dal.Database.Entities;

namespace Projux.Dal.Database;

public class DatabaseContext : IDatabaseContext
{
    public LiteDatabase Database { get; }

    public ILiteCollection<CustomerContactEntity> CustomerContactCollection => 
        Database.GetCollection<CustomerContactEntity>("CustomerContact");

    public DatabaseContext(DatabaseOptions options)
    {
        Database = new LiteDatabase(options.DatabaseLocation);
    }
}