using LiteDB;
using Projux.Dal.Database.Entities;

namespace Projux.Dal.Database;

public interface IDatabaseContext
{
    public LiteDatabase Database { get; }
    public ILiteCollection<CustomerContactEntity> CustomerContactCollection { get; }
}