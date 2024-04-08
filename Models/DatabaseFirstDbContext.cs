using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ASPCoreWebAPI.Models;

public partial class DatabaseFirstDbContext : DbContext
{
    public DatabaseFirstDbContext()
    {
    }

    public DatabaseFirstDbContext(DbContextOptions<DatabaseFirstDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Student> Students { get; set; }

 
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Student>(entity =>
        {
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.School).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
