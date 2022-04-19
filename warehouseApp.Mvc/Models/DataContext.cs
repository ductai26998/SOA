using Microsoft.EntityFrameworkCore;

namespace warehouseApp.Mvc.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Product> Product { get; set; }

        // public DbSet<Author> Author { get; set; }

        // protected override void OnModelCreating(ModelBuilder builder)
        // {
        //     builder.Entity<News>()
        //         .HasOne(news => news.Author)
        //         .WithMany(author => author.NewsList)
        //         .HasForeignKey(News => News.AuthorId);
        //     base.OnModelCreating(builder);
        // }
    }
}