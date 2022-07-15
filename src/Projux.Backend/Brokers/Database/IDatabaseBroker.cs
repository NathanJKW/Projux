namespace Projux.Backend.Brokers.Database;

using LiteDB;
using Projux.Backend.Database.Entities;

public interface IDatabaseBroker
{
    public ILiteCollection<CustomerContactEntity> CustomerContactCollection { get; }
}
