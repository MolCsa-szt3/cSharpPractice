using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;

namespace DolgozoKezelo.Console.DbModels;

public partial class DolgozodbContext : DbContext
{
    public DolgozodbContext()
    {
    }

    public DolgozodbContext(DbContextOptions<DolgozodbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Worker> Workers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=localhost;database=dolgozodb;user=root", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.4.28-mariadb"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_general_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Worker>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("worker")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Email)
                .HasMaxLength(26)
                .HasColumnName("email");
            entity.Property(e => e.Name)
                .HasMaxLength(14)
                .HasColumnName("name");
            entity.Property(e => e.Salary)
                .HasColumnType("int(6)")
                .HasColumnName("salary");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
