using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace taskManager.EntityFrameworkCore
{
    public static class taskManagerDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<taskManagerDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<taskManagerDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
