using commenpatater_core.Models;
using Microsoft.EntityFrameworkCore;

namespace commenpatater_api.Data.Contexts
{
    public class CommentContext : DbContext
    {
        public CommentContext(DbContextOptions<CommentContext> options) : base(options) { }

        public DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
