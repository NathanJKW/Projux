using LiteDB;
using Projux.Dal.CustomerContact;

namespace Projux.Backend.Features.Basic.CustomerContact.DeleteById;

public class CustomerContactDeleteByIdFeature : ICustomerContactDeleteByIdFeature
{
    private readonly ICustomerContactBroker _customerContactDatabaseBroker;
    public CustomerContactDeleteByIdFeature(ICustomerContactBroker customerContactDatabaseBroker)
    {
        _customerContactDatabaseBroker = customerContactDatabaseBroker;
    }

    public bool Delete(ObjectId id)
    {
        //return _databaseBroker.GetAll().Where(c => c.Id == id).FirstOrDefault().
        throw new NotImplementedException();
    }
}
