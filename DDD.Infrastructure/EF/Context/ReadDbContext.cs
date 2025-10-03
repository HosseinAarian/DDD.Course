using Microsoft.EntityFrameworkCore;

namespace DDD.Infrastructure.EF.Context;

internal sealed class ReadDbContext : DbContext
{
    public ReadDbContext(DbContextOptions<ReadDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

    }
}
