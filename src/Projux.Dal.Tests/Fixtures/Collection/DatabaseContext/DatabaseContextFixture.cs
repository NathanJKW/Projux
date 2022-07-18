using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projux.Dal.Tests.Fixtures.Collection.DatabaseContext;

public class DatabaseContextFixture : IDisposable
{
    public DatabaseContextFixture()
    {
        Db = new Database.LiteDbContext(new LiteDbOptions { DatabaseLocation = @"LiteDbTest.db" });
    }

    public void Dispose()
    {
        Db.Database.Dispose();
        File.Delete(@"LiteDbTest.db");
    }

    public ILiteDbContext Db { get; private set; }
}