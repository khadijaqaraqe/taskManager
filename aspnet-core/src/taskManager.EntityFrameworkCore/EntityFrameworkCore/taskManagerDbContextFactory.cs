using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using taskManager.Configuration;
using taskManager.Web;

namespace taskManager.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class taskManagerDbContextFactory : IDesignTimeDbContextFactory<taskManagerDbContext>
    {
        public taskManagerDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<taskManagerDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            taskManagerDbContextConfigurer.Configure(builder, configuration.GetConnectionString(taskManagerConsts.ConnectionStringName));

            return new taskManagerDbContext(builder.Options);
        }
    }
}
