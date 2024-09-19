using MemberPlatform.Domain;
using Microsoft.EntityFrameworkCore;

namespace MemberPlatform.DataAccess;

public class MemberDbContext : DbContext
{
    public DbSet<Member> Members { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=member.db");
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(MemberDbContext).Assembly);
        base.OnModelCreating(modelBuilder);
    }
}