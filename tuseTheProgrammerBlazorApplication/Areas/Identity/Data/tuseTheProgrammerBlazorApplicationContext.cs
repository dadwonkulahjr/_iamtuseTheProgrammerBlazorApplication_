using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace tuseTheProgrammerBlazorApplication.Data
{
    public class tuseTheProgrammerBlazorApplicationContext : IdentityDbContext<IdentityUser>
    {
        public tuseTheProgrammerBlazorApplicationContext(DbContextOptions<tuseTheProgrammerBlazorApplicationContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
