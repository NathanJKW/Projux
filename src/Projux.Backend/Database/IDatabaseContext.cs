namespace Projux.Backend.Database;

using LiteDB;
using Projux.Backend.Database.Entities;

public interface IDatabaseContext
{
    public LiteDatabase Database { get; }
    public ILiteCollection<CustomerContactEntity> CustomerContactCollection { get; }
}