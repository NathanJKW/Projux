using LiteDB;
using Projux.Dal.Database.Entities;

namespace Projux.Dal.CustomerContact;

public interface ICustomerContactBroker
{
    public IQueryable<CustomerContactEntity> Select();
    public ObjectId Insert(CustomerContactEntity newCustomerContact);
    public bool Update(CustomerContactEntity updatedCustomerContact);
    public bool Delete(ObjectId customerContactId);
}