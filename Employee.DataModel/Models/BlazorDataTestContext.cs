using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Employee.DataModel.Models;

public partial class BlazorDataTestContext : DbContext
{
    public BlazorDataTestContext()
    {
    }

    public BlazorDataTestContext(DbContextOptions<BlazorDataTestContext> options)
        : base(options)
    {
    }

    public virtual DbSet<EmployeeModel> EmployeeModels { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=.;Database=BlazorDataTest;Integrated Security=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<EmployeeModel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Employee__3214EC0766B50D64");

            entity.ToTable("EmployeeModel");

            entity.Property(e => e.InProject)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Skills)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(15)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
