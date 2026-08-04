
using Database.Model;
using Microsoft.EntityFrameworkCore;

namespace Database
{
    public class SQLLiteContex : DbContext
    {
        public SQLLiteContex(DbContextOptions<SQLLiteContex> options) : base(options) { }
        public DbSet<PojectItem> Projects { get; set; }
        public DbSet<ImageItem> Images { get; set; }
        public DbSet<TypeItem> Types { get; set; }
    }
}