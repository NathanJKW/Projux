namespace Projux.Backend.Database;

using LiteDB;

public interface IDatabaseContext
{
    LiteDatabase Database { get; }
}