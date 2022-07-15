namespace Projux.Backend.Features.Basic.CustomerContact.DeleteById;

using LiteDB;

public interface ICustomerContactDeleteByIdFeature
{
    bool Delete(ObjectId id);
}
