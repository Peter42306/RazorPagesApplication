using Microsoft.EntityFrameworkCore;

namespace RazorPagesApplication.Models
{
    public class FileModelContext : DbContext
    {
        public DbSet<FileModel> Files { get; set; }

        public FileModelContext(DbContextOptions<FileModelContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
