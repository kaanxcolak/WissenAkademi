﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AkbilYonetimiUI.Models;

public partial class AkbildbContext : DbContext
{
    public AkbildbContext()
    {
    }

    public AkbildbContext(DbContextOptions<AkbildbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Akbiller> Akbillers { get; set; }

    public virtual DbSet<Kullanicilar> Kullanicilars { get; set; }

    public virtual DbSet<KullanicininTalimatlari> KullanicininTalimatlaris { get; set; }

    public virtual DbSet<Talimatlar> Talimatlars { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-P4SDEGD;Database=AKBILDB;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Akbiller>(entity =>
        {
            entity.HasKey(e => e.AkbilNo).HasName("PK__Akbiller__ADBC6456A9ABDF5A");

            entity.ToTable("Akbiller");

            entity.Property(e => e.AkbilNo)
                .HasMaxLength(16)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.AkbilTipi).HasMaxLength(50);
            entity.Property(e => e.Bakiye).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.AkbilSahibi).WithMany(p => p.Akbillers)
                .HasForeignKey(d => d.AkbilSahibiId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Akbiller_Kullanicilar");
        });

        modelBuilder.Entity<Kullanicilar>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Kullanic__3214EC07CE51489E");

            entity.ToTable("Kullanicilar");

            entity.Property(e => e.Ad).HasMaxLength(50);
            entity.Property(e => e.DogumTarihi).HasColumnType("date");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Parola)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Soyad).HasMaxLength(50);
        });

        modelBuilder.Entity<KullanicininTalimatlari>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("KullanicininTalimatlari");

            entity.Property(e => e.Akbil).HasMaxLength(67);
            entity.Property(e => e.YuklenecekTutar).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<Talimatlar>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Talimatl__3214EC07F3DC82B5");

            entity.ToTable("Talimatlar");

            entity.Property(e => e.AkbilId)
                .HasMaxLength(16)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.YuklenecekTutar).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Akbil).WithMany(p => p.Talimatlars)
                .HasForeignKey(d => d.AkbilId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Talimatlar_Akbiller");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
