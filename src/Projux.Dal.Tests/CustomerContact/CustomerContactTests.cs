using LiteDB;
using Projux.Dal.CustomerContact;
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
    public void FindById_UsingRandomId_ShouldReturnNull()
    {
        var randomId = ObjectId.NewObjectId();
        var result = _customerContactService.Select().Where(x => x.Id == randomId).FirstOrDefault();
        Assert.Null(result);
    }
}