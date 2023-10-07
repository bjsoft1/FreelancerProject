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

        #region Private Funtions
        private void Private_Seedingdata(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductModel>().HasData(Private_SampleProducts());
        }
        private List<ProductModel> Private_SampleProducts()
        {
            DateTime createTime = DateTime.Parse("2023-10-07 03:44:00 PM");
            var products = new List<ProductModel>();  
            for(int i = 0; i < 20; i++)
            {
                Guid id = Guid.Parse($"a9f06a70-8dfd-4e64-9c4c-42614ec{(50000 + i)}");

                products.Add(new ProductModel
                {
                    Id = id,
                    IsActive = true,
                    CreationTime = createTime,
                    Image = $"assets/images/products/{i}.png",
                    Description = null,
                    Name = $"My Product-{i}",
                    Price = 120.0f * i + 1500.0f,
                });
            }
            return products;
        }
        #endregion Private Funtions

    }
}
