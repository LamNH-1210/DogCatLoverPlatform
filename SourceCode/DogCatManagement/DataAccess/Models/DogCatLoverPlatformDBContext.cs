using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace DataAccess.Models
{
    public partial class DogCatLoverPlatformDBContext : DbContext
    {
        public DogCatLoverPlatformDBContext()
        {
        }

        public DogCatLoverPlatformDBContext(DbContextOptions<DogCatLoverPlatformDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Configuration> Configurations { get; set; } = null!;
        public virtual DbSet<Exchange> Exchanges { get; set; } = null!;
        public virtual DbSet<Item> Items { get; set; } = null!;
        public virtual DbSet<Post> Posts { get; set; } = null!;
        public virtual DbSet<Report> Reports { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(GetConnectionString());
            }
        }
        private string GetConnectionString()
        {
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();
            var strConn = config["ConnectionStrings:DBConnection"];
            return strConn;
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Configuration>(entity =>
            {
                entity.HasKey(e => e.ConfigId)
                    .HasName("PK__Configur__C3BC335CC0274229");

                entity.ToTable("Configuration");

                entity.HasIndex(e => e.SettingName, "UQ_SettingName")
                    .IsUnique();

                entity.Property(e => e.SettingName).HasMaxLength(100);

                entity.Property(e => e.SettingValue).HasMaxLength(100);
            });

            modelBuilder.Entity<Exchange>(entity =>
            {
                entity.HasIndex(e => e.UserId1, "IX_Exchanges_UserId1");

                entity.HasIndex(e => e.UserId2, "IX_Exchanges_UserId2");

                entity.Property(e => e.ExchangeDate).HasColumnType("datetime");

                entity.Property(e => e.ItemType).HasMaxLength(50);

                entity.HasOne(d => d.UserId1Navigation)
                    .WithMany(p => p.ExchangeUserId1Navigations)
                    .HasForeignKey(d => d.UserId1)
                    .HasConstraintName("FK__Exchanges__UserI__1CF15040");

                entity.HasOne(d => d.UserId2Navigation)
                    .WithMany(p => p.ExchangeUserId2Navigations)
                    .HasForeignKey(d => d.UserId2)
                    .HasConstraintName("FK__Exchanges__UserI__1DE57479");
            });

            modelBuilder.Entity<Item>(entity =>
            {
                entity.Property(e => e.Category).HasMaxLength(50);

                entity.Property(e => e.ItemName).HasMaxLength(100);

                entity.HasOne(d => d.Owner)
                    .WithMany(p => p.Items)
                    .HasForeignKey(d => d.OwnerId)
                    .HasConstraintName("FK__Items__OwnerId__1ED998B2");
            });

            modelBuilder.Entity<Post>(entity =>
            {
                entity.HasIndex(e => e.UserId, "IX_Posts_UserId");

                entity.Property(e => e.PostDate).HasColumnType("datetime");

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.Title).HasMaxLength(100);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Posts)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Posts__UserId__1FCDBCEB");
            });

            modelBuilder.Entity<Report>(entity =>
            {
                entity.Property(e => e.ReportDate).HasColumnType("datetime");

                entity.HasOne(d => d.Post)
                    .WithMany(p => p.Reports)
                    .HasForeignKey(d => d.PostId)
                    .HasConstraintName("FK__Reports__PostId__20C1E124");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Reports)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Reports__UserId__21B6055D");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(e => e.Email, "UQ_Email")
                    .IsUnique();

                entity.HasIndex(e => e.UserName, "UQ_UserName")
                    .IsUnique();

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Password).HasMaxLength(100);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
