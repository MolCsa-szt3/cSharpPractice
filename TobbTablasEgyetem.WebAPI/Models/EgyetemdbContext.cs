using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;

namespace TobbTablasEgyetem.WebAPI.Models;

public partial class EgyetemdbContext : DbContext
{
    public EgyetemdbContext()
    {
    }

    public EgyetemdbContext(DbContextOptions<EgyetemdbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Course> Courses { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<Teacher> Teachers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=localhost;database=egyetemdb;user=root", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.4.28-mariadb"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_general_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Course>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("courses")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Credits).HasColumnType("int(1)");
            entity.Property(e => e.DepartmentId)
                .HasColumnType("int(1)")
                .HasColumnName("DepartmentID");
            entity.Property(e => e.Id)
                .HasColumnType("int(2)")
                .HasColumnName("ID");
            entity.Property(e => e.Name).HasMaxLength(25);
            entity.Property(e => e.TeacherId)
                .HasColumnType("int(2)")
                .HasColumnName("TeacherID");
        });

        modelBuilder.Entity<Department>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("department")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(2)")
                .HasColumnName("ID");
            entity.Property(e => e.Name).HasMaxLength(29);
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("student")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Age).HasColumnType("int(2)");
            entity.Property(e => e.DepartmentId)
                .HasColumnType("int(1)")
                .HasColumnName("DepartmentID");
            entity.Property(e => e.Email).HasMaxLength(28);
            entity.Property(e => e.Enrolled).HasColumnType("int(1)");
            entity.Property(e => e.Id)
                .HasColumnType("int(2)")
                .HasColumnName("ID");
            entity.Property(e => e.Name).HasMaxLength(16);
        });

        modelBuilder.Entity<Teacher>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("teacher")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.DepartmentId)
                .HasColumnType("int(1)")
                .HasColumnName("DepartmentID");
            entity.Property(e => e.Email).HasMaxLength(26);
            entity.Property(e => e.Id)
                .HasColumnType("int(2)")
                .HasColumnName("ID");
            entity.Property(e => e.Name).HasMaxLength(18);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
