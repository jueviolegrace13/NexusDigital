using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System.Data.Common;

namespace NexusDigital.EntityFrameworkCore;

public static class NexusDigitalDbContextConfigurer
{
    public static void Configure(DbContextOptionsBuilder<NexusDigitalDbContext> builder, string connectionString)
    {
        builder.ConfigureWarnings(w => w.Ignore(RelationalEventId.PendingModelChangesWarning));
        builder.UseSqlServer(connectionString);
    }

    public static void Configure(DbContextOptionsBuilder<NexusDigitalDbContext> builder, DbConnection connection)
    {
        builder.ConfigureWarnings(w => w.Ignore(RelationalEventId.PendingModelChangesWarning));
        builder.UseSqlServer(connection);
    }
}
