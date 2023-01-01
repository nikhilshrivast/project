using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace project.Models;

public partial class WorldContext : DbContext
{
    public WorldContext()
    {
    }

    public WorldContext(DbContextOptions<WorldContext> options)
        : base(options)
    {
    }

    public virtual DbSet<UserAccount> UserAccounts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-ENV7KR6 \\SQLEXPRESS;Initial Catalog=World;Integrated Security=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UserAccount>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__UserAcco__1788CC4C1532C016");

            entity.ToTable("UserAccount");

            entity.Property(e => e.Dateofbirth).HasColumnType("datetime");
            entity.Property(e => e.EmailId).HasMaxLength(250);
            entity.Property(e => e.FullName).HasMaxLength(250);
            entity.Property(e => e.Gender).HasMaxLength(250);
            entity.Property(e => e.Graduction).HasMaxLength(250);
            entity.Property(e => e.Hobbies).HasMaxLength(250);
            entity.Property(e => e.LastName).HasMaxLength(250);
            entity.Property(e => e.UploadDoc).HasMaxLength(250);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
