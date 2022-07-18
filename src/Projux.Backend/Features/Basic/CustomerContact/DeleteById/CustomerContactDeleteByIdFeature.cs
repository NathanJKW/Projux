namespace Projux.Backend.Features.Basic.CustomerContact.DeleteById;

using LiteDB;
using Projux.Backend.Brokers.Database;
using Projux.Backend.Brokers.Database.CustomerContact;

public class CustomerContactDeleteByIdFeature : ICustomerContactDeleteByIdFeature
{
    private readonly ICustomerContactDatabaseBroker _customerContactDatabaseBroker;
    public CustomerContactDeleteByIdFeature(ICustomerContactDatabaseBroker customerContactDatabaseBroker)
    {
        _customerContactDatabaseBroker = customerContactDatabaseBroker;
    }

    public bool Delete(ObjectId id)
    {
        //return _databaseBroker.GetAll().Where(c => c.Id == id).FirstOrDefault().
        throw new NotImplementedException();
    }
}
