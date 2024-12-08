using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace NexusDigital.EntityFrameworkCore;

public static class NexusDigitalDbContextConfigurer
{
    public static void Configure(DbContextOptionsBuilder<NexusDigitalDbContext> builder, string connectionString)
    {
        builder.UseSqlServer(connectionString);
    }

    public static void Configure(DbContextOptionsBuilder<NexusDigitalDbContext> builder, DbConnection connection)
    {
        builder.UseSqlServer(connection);
    }
}
