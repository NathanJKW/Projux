using LiteDB;
using Projux.Dal.Database;
using Projux.Dal.Database.Entities;

namespace Projux.Dal.CustomerContact;

public class CustomerContactBroker : ICustomerContactBroker
{
    private IDatabaseContext _databaseContext;
    
    public CustomerContactBroker(IDatabaseContext databaseContext)
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