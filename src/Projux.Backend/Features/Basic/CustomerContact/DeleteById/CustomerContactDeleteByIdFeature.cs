namespace Projux.Backend.Features.Basic.CustomerContact.DeleteById;

using LiteDB;
using Projux.Backend.Brokers.Database;

public class CustomerContactDeleteByIdFeature : ICustomerContactDeleteByIdFeature
{
    private readonly IDatabaseBroker _databaseBroker;
    public CustomerContactDeleteByIdFeature(IDatabaseBroker databaseBroker)
    {
        _databaseBroker = databaseBroker;
    }

    public bool Delete(ObjectId id)
    {
        return _databaseBroker.CustomerContactCollection.Delete(id);
    }
}
