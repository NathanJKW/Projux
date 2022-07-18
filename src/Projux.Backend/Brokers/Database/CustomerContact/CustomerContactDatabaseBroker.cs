using LiteDB;
using Projux.Backend.Database;
using Projux.Backend.Database.Entities;

namespace Projux.Backend.Brokers.Database.CustomerContact;

public class CustomerContactDatabaseBroker : ICustomerContactDatabaseBroker
{
    private IDatabaseContext _databaseContext;
    
    public CustomerContactDatabaseBroker(IDatabaseContext databaseContext)
    {
        _databaseContext = databaseContext;
    }

    public bool Delete(ObjectId customerContactId)
    {
        return _databaseContext.CustomerContactCollection.Delete(customerContactId);
    }

    public ObjectId Insert(CustomerContactEntity newCustomerContact)
    {
        return _databaseContext.CustomerContactCollection.Insert(newCustomerContact);
    }

    public IQueryable<CustomerContactEntity> Select()
    {
        return _databaseContext.CustomerContactCollection.Find(Query.All()).AsQueryable<CustomerContactEntity>();
    }

    public bool Update(CustomerContactEntity updatedCustomerContact)
    {
        return _databaseContext.CustomerContactCollection.Update(updatedCustomerContact);
    }
}