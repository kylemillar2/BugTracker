using Microsoft.EntityFrameworkCore;

namespace BugTrackerApi.Models

{
    public class BugItemContext : DbContext
    {
        public BugItemContext(DbContextOptions<BugItemContext> options)
            : base(options) 
        {
        }

        public DbSet<BugItem> BugItems { get; set; } = null!;
    }
}
