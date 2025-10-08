using Categories.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Categories.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }
        public DbSet<Product> Products { get; set; } = default!;

        public DbSet<Category> Categories { get; set; } = default!;
    }
}
