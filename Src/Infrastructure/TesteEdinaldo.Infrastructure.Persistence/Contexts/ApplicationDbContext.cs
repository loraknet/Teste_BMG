using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;
using TesteEdinaldo.Application.Interfaces;
using TesteEdinaldo.Domain.Products.Entities;
using TesteEdinaldo.Infrastructure.Persistence.Extensions;

namespace TesteEdinaldo.Infrastructure.Persistence.Contexts
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, IAuthenticatedUserService authenticatedUser) : DbContext(options)
    {
        public DbSet<Product> Products { get; set; }
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new())
        {
            ChangeTracker.ApplyAuditing(authenticatedUser);

            return base.SaveChangesAsync(cancellationToken);
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            this.ConfigureDecimalProperties(builder);

            base.OnModelCreating(builder);
        }
    }
}