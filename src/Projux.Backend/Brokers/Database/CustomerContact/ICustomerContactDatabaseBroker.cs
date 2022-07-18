using LiteDB;
using Projux.Backend.Database.Entities;

namespace Projux.Backend.Brokers.Database.CustomerContact;

public interface ICustomerContactDatabaseBroker
{
    public IQueryable<CustomerContactEntity> Select();
    public ObjectId Insert(CustomerContactEntity newCustomerContact);
    public bool Update(CustomerContactEntity updatedCustomerContact);
    public bool Delete(ObjectId customerContactId);
}