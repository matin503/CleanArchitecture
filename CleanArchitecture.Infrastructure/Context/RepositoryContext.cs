using CleanArchitecture.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Infrastructure.Context;

public class RepositoryContext:DbContext
{
    public RepositoryContext(DbContextOptions options)
        :base(options)
    {
        
    }
    public DbSet<Entity> entities { get; set; }

}
