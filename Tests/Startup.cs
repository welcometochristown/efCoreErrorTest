using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ORM.Core.Contexts;
using ORM.Core.Contexts.Account;
using ORM.Core.Contexts.SmtrSimple;
using System;
using Tests.Fakes;

namespace Tests
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services, HostBuilderContext host = null)
        {
            ConfigureInMemoryDatabases(services);
        }

        public void ConfigureInMemoryDatabases(IServiceCollection services)
        {
            services.AddScoped(_ =>
            {
                var options = new DbContextOptionsBuilder<AccountContextBase>()
                    .UseInMemoryDatabase(databaseName: $"DATABASE_{Guid.NewGuid()}")
                    .EnableSensitiveDataLogging()
                    .Options;

                return new FakeAccountContext(options) as AccountDbContext;
            });

            services.AddScoped(_ =>
            {
                var options = new DbContextOptionsBuilder<SmtrSimpleContextBase>()
                    .UseInMemoryDatabase(databaseName: $"SMTRSIMPLE_{Guid.NewGuid()}")
                    .EnableSensitiveDataLogging()
                    .Options;

                return new FakeSmtrSimpleContext(options) as SmtrSimpleDbContext;
            });
        }
    }
}
