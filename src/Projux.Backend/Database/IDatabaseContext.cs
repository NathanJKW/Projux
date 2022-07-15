namespace Projux.Backend.Database;

using LiteDB;

public interface IDatabaseContext
{
    public LiteDatabase Database { get; }
}