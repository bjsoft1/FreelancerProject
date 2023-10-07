using FreelancerProject.Models.Product;
using Microsoft.EntityFrameworkCore;


namespace FreelancerProject.Services.DbContexts
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
        {
        }

        public DbSet<ProductModel> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ProductModel>(b =>
            {
                b.ToTable(nameof(Products));
                b.HasKey(x => x.Id);
                b.Property(x => x.Name).HasMaxLength(500).IsRequired(true);
                b.Property(x => x.Image).HasColumnName(nameof(ProductModel.Image).ToLower()).HasMaxLength(2000).IsRequired(false);
                b.Property(x => x.Description).HasMaxLength(2000).IsRequired(false);
                b.Property(x => x.Price).IsRequired(true).HasDefaultValue(0.0f);
            });
        }
    }
}
