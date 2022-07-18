using Projux.Dal.Database;

namespace Projux.Dal.Tests.Fixtures.Collections.DatabaseContext;

public class DatabaseContextFixture : IDisposable
{
    public IDatabaseContext Db { get; private set; }

    public DatabaseContextFixture()
    {
        Db = new Database.DatabaseContext(new DatabaseOptions { DatabaseLocation = @"LiteDbTest.db" });
    }

    public void Dispose()
    {
        Db.Database.Dispose();
        File.Delete(@"LiteDbTest.db");
    }
}
