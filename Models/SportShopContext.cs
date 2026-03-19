using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace sport_shop_ver2.Models;

public partial class SportShopContext : DbContext
{
    public SportShopContext()
    {
    }

    public SportShopContext(DbContextOptions<SportShopContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<DeleveryPoint> DeleveryPoints { get; set; }

    public virtual DbSet<HistoryOrder> HistoryOrders { get; set; }

    public virtual DbSet<Manufacturer> Manufacturers { get; set; }

    public virtual DbSet<Measure> Measures { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<SportingProduct> SportingProducts { get; set; }

    public virtual DbSet<SportingProductsHistoryOrder> SportingProductsHistoryOrders { get; set; }

    public virtual DbSet<Status> Statuses { get; set; }

    public virtual DbSet<Supplier> Suppliers { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=sport_shop;Username=postgres;Password=1111");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("categories_pkey");

            entity.ToTable("categories");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CategoryName).HasColumnName("category_name");
        });

        modelBuilder.Entity<DeleveryPoint>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("delevery_points_pkey");

            entity.ToTable("delevery_points");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DeliveryAdress).HasColumnName("delivery_adress");
            entity.Property(e => e.Phone).HasColumnName("phone");
        });

        modelBuilder.Entity<HistoryOrder>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("history_orders_pkey");

            entity.ToTable("history_orders");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code).HasColumnName("code");
            entity.Property(e => e.DeliveryDate).HasColumnName("delivery_date");
            entity.Property(e => e.IdDeliveryPoint)
                .ValueGeneratedOnAdd()
                .HasColumnName("id_delivery_point");
            entity.Property(e => e.IdStatuses).HasColumnName("id_statuses");
            entity.Property(e => e.IdUser)
                .ValueGeneratedOnAdd()
                .HasColumnName("id_user");
            entity.Property(e => e.OrderDate).HasColumnName("order_date");

            entity.HasOne(d => d.IdDeliveryPointNavigation).WithMany(p => p.HistoryOrders)
                .HasForeignKey(d => d.IdDeliveryPoint)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("history_orders_id_delivery_point_fkey");

            entity.HasOne(d => d.IdStatusesNavigation).WithMany(p => p.HistoryOrders)
                .HasForeignKey(d => d.IdStatuses)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("history_orders_id_statuses_fkey");

            entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.HistoryOrders)
                .HasForeignKey(d => d.IdUser)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("history_orders_id_user_fkey");
        });

        modelBuilder.Entity<Manufacturer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("manufacturers_pkey");

            entity.ToTable("manufacturers");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ManufacturerName).HasColumnName("manufacturer_name");
        });

        modelBuilder.Entity<Measure>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("measures_pkey");

            entity.ToTable("measures");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.MeasureName).HasColumnName("measure_name");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("roles_pkey");

            entity.ToTable("roles");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.RoleName).HasColumnName("role_name");
        });

        modelBuilder.Entity<SportingProduct>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("sporting_products_pkey");

            entity.ToTable("sporting_products");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Art).HasColumnName("art");
            entity.Property(e => e.CointInStok).HasColumnName("coint_in_stok");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Discount).HasColumnName("discount");
            entity.Property(e => e.IdCategory).HasColumnName("id_category");
            entity.Property(e => e.IdManufacturer).HasColumnName("id_manufacturer");
            entity.Property(e => e.IdMeasure).HasColumnName("id_measure");
            entity.Property(e => e.IdSupplier).HasColumnName("id_supplier");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.ProductName).HasColumnName("product_name");

            entity.HasOne(d => d.IdCategoryNavigation).WithMany(p => p.SportingProducts)
                .HasForeignKey(d => d.IdCategory)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("sporting_products_d_category_fkey");

            entity.HasOne(d => d.IdManufacturerNavigation).WithMany(p => p.SportingProducts)
                .HasForeignKey(d => d.IdManufacturer)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("sporting_products_id_manufacturer_fkey");

            entity.HasOne(d => d.IdMeasureNavigation).WithMany(p => p.SportingProducts)
                .HasForeignKey(d => d.IdMeasure)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("sporting_products_id_measure_fkey");

            entity.HasOne(d => d.IdSupplierNavigation).WithMany(p => p.SportingProducts)
                .HasForeignKey(d => d.IdSupplier)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("sporting_products_id_supplier_fkey");
        });

        modelBuilder.Entity<SportingProductsHistoryOrder>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("sporting_products_history_orders_pkey");

            entity.ToTable("sporting_products_history_orders");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Count).HasColumnName("count");
            entity.Property(e => e.IdOrder).HasColumnName("id_order");
            entity.Property(e => e.IdProduct).HasColumnName("id_product");

            entity.HasOne(d => d.IdOrderNavigation).WithMany(p => p.SportingProductsHistoryOrders)
                .HasForeignKey(d => d.IdOrder)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("sporting_products_history_orders_id_order_fkey");

            entity.HasOne(d => d.IdProductNavigation).WithMany(p => p.SportingProductsHistoryOrders)
                .HasForeignKey(d => d.IdProduct)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("sporting_products_history_orders_id_product_fkey");
        });

        modelBuilder.Entity<Status>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("statuses_pkey");

            entity.ToTable("statuses");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.StatusName).HasColumnName("status_name");
        });

        modelBuilder.Entity<Supplier>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("suppliers_pkey");

            entity.ToTable("suppliers");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.SupplierName).HasColumnName("supplier_name");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("users_pkey");

            entity.ToTable("users");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.FirstName).HasColumnName("first_name");
            entity.Property(e => e.IdRole).HasColumnName("id_role");
            entity.Property(e => e.LastName).HasColumnName("last_name");
            entity.Property(e => e.Login).HasColumnName("login");
            entity.Property(e => e.MiddleName).HasColumnName("middle_name");
            entity.Property(e => e.Password).HasColumnName("password");

            entity.HasOne(d => d.IdRoleNavigation).WithMany(p => p.Users)
                .HasForeignKey(d => d.IdRole)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("users_id_role_fkey");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
