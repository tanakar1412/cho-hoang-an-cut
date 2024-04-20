 using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace gui.Models;

public partial class Net1021FinalContext : DbContext
{
    public Net1021FinalContext()
    {
    }

    public Net1021FinalContext(DbContextOptions<Net1021FinalContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Sinhvien> Sinhviens { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=TANAKAR\\SQLEXPRESS;Database=NET1021_Final;Trusted_Connection=True;TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Sinhvien>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Sinhvien");

            entity.Property(e => e.Gioitinh).HasColumnName("gioitinh");
            entity.Property(e => e.Nganh)
                .HasMaxLength(50)
                .HasColumnName("nganh");
            entity.Property(e => e.Ten)
                .HasMaxLength(50)
                .HasColumnName("ten");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
