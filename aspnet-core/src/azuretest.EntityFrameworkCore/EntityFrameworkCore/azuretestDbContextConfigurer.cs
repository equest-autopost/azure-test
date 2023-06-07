using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace azuretest.EntityFrameworkCore
{
    public static class azuretestDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<azuretestDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<azuretestDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
