using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace mascalta.Data.Modules
{
    public partial class applicationDbContext : DbContext
    {
        public applicationDbContext()
        {
        }

        public applicationDbContext(DbContextOptions<applicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ArchiveTbl> ArchiveTbls { get; set; } = null!;
        public virtual DbSet<DealTypeTbl> DealTypeTbls { get; set; } = null!;
        public virtual DbSet<DocumentTbl> DocumentTbls { get; set; } = null!;
        public virtual DbSet<MassageTbl> MassageTbls { get; set; } = null!;
        public virtual DbSet<RequestStatusTbl> RequestStatusTbls { get; set; } = null!;
        public virtual DbSet<UserTbl> UserTbls { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=RIVKI-FARKASH;Database=Mascalta_DB ;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ArchiveTbl>(entity =>
            {
                entity.HasKey(e => e.IdUser)
                    .HasName("PK__archive___3717C982A9D5700D");

                entity.HasOne(d => d.DealTypeNavigation)
                    .WithMany(p => p.ArchiveTbls)
                    .HasForeignKey(d => d.DealType)
                    .HasConstraintName("fk_dealTypearchive");
            });

            modelBuilder.Entity<DealTypeTbl>(entity =>
            {
                entity.HasKey(e => e.IdDeal)
                    .HasName("PK__dealType__DFA01E43DBF06312");
            });

            modelBuilder.Entity<DocumentTbl>(entity =>
            {
                entity.HasKey(e => e.IdDocument)
                    .HasName("PK__document__E3A0F08EFE282F91");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.DocumentTbls)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_document_idUser");
            });

            modelBuilder.Entity<MassageTbl>(entity =>
            {
                entity.HasKey(e => e.Idmassage)
                    .HasName("PK__massage___00051787EAB7069F");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.MassageTbls)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_massage_idUser");
            });

            modelBuilder.Entity<RequestStatusTbl>(entity =>
            {
                entity.HasKey(e => e.IdStatus)
                    .HasName("PK__requestS__01936F742AA0F90F");
            });

            modelBuilder.Entity<UserTbl>(entity =>
            {
                entity.HasKey(e => e.IdUser)
                    .HasName("PK__user_tbl__3717C982C2C7BF65");

                entity.HasOne(d => d.DealTypeNavigation)
                    .WithMany(p => p.UserTbls)
                    .HasForeignKey(d => d.DealType)
                    .HasConstraintName("fk_dealType");

                entity.HasOne(d => d.RequestStatusNavigation)
                    .WithMany(p => p.UserTbls)
                    .HasForeignKey(d => d.RequestStatus)
                    .HasConstraintName("fk_requestStatus");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
