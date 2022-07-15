namespace Projux.Backend.Database;

using LiteDB;

public class DatabaseContext : IDatabaseContext
{
    public LiteDatabase Database { get; }

    public DatabaseContext(DatabaseOptions options)
    {
        Database = new LiteDatabase(options.DatabaseLocation);
    }
}