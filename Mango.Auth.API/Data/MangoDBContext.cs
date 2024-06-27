using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Mango.Auth.API.Data
{
    public class MangoDBContext : IdentityDbContext<IdentityUser>
    {
        public MangoDBContext(DbContextOptions<MangoDBContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
