namespace Architecture.Types.AgriculturalProductsMarketing
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Core;

    public partial class ProjectModel : ContextBase
    {
        public ProjectModel()
            : base("name=ProjectModel")
        {
           //Database.SetInitializer<ProjectModel>(new CreateDatabaseIfNotExists<ProjectModel>());
        }

        public virtual DbSet<CustomerContract> Customer { get; set; }
        public virtual DbSet<OrderContract> Order { get; set; }
        public virtual DbSet<Order_DetailContract> Order_Detail { get; set; }
        public virtual DbSet<ProductContract> Product { get; set; }
        public virtual DbSet<ShipperContract> Shipper { get; set; }
        public virtual DbSet<CategoryContract> Category { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<CustomerContract>()
                .Property(e => e.CustomerCode)
                .IsFixedLength();

            modelBuilder.Entity<OrderContract>()
                .Property(e => e.Freight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<OrderContract>()
                .HasMany(e => e.Order_Detail)
                .WithRequired(e => e.Order)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Order_DetailContract>()
                .Property(e => e.UnitPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ProductContract>()
                .Property(e => e.Unit_Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ProductContract>()
                .HasMany(e => e.Order_Detail)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ShipperContract>()
                .HasMany(e => e.Order)
                .WithOptional(e => e.Shipper)
                .HasForeignKey(e => e.ShipVia);

            modelBuilder.Entity<CategoryContract>()
                .Property(e => e.Name)
               .IsUnicode(false);
    
        }
    }
}
