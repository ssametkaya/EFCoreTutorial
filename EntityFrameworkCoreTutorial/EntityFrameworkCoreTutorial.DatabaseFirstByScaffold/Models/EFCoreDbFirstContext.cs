﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EntityFrameworkCoreTutorial.DatabaseFirstByScaffold.Models
{
    public partial class EFCoreDbFirstContext : DbContext
    {
        public EFCoreDbFirstContext()
        {
        }

        public EFCoreDbFirstContext(DbContextOptions<EFCoreDbFirstContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Product> Products { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Data Source=DESKTOP-94U96R1;Initial Catalog=EFCoreDbFirst;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(20);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
