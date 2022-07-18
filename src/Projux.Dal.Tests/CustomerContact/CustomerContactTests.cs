using LiteDB;
using Projux.Dal.CustomerContact;
using Projux.Dal.Database.Entities;
using Projux.Dal.Tests.Fixtures.Collections.DatabaseContext;

namespace Projux.Dal.Tests.CustomerContact;

[Collection("DatabaseContextCollection")]
public class CustomerContactTests
{
    private readonly DatabaseContextFixture _databaseContextFixture;
    private readonly ICustomerContactBroker _customerContactService;
    public CustomerContactTests(DatabaseContextFixture databaseContextFixture)
    {
        _databaseContextFixture = databaseContextFixture;
        _customerContactService = new CustomerContactBroker(_databaseContextFixture.Db);
    }

    [Fact]
    public void ShouldReturnIQueryable()
    {
        var randomId = ObjectId.NewObjectId();
        var result = _customerContactService.Select();
        Assert.IsType<EnumerableQuery<CustomerContactEntity>>(result);
    }
}