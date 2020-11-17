using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Back_End.Models
{
    public partial class sitebdContext : DbContext
    {
        public sitebdContext()
        {
        }

        public sitebdContext(DbContextOptions<sitebdContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TbAnime> TbAnime { get; set; }
        public virtual DbSet<TbCliente> TbCliente { get; set; }
        public virtual DbSet<TbCompra> TbCompra { get; set; }
        public virtual DbSet<TbCompraManga> TbCompraManga { get; set; }
        public virtual DbSet<TbFuncionario> TbFuncionario { get; set; }
        public virtual DbSet<TbLogin> TbLogin { get; set; }
        public virtual DbSet<TbManga> TbManga { get; set; }
        public virtual DbSet<TbPermissao> TbPermissao { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=localhost;user id=root;password=12345;database=sitebd", x => x.ServerVersion("8.0.22-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TbAnime>(entity =>
            {
                entity.HasKey(e => e.IdAnime)
                    .HasName("PRIMARY");

                entity.Property(e => e.DsGenero)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.ImgCapa)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.NmAnime)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.NmAutor)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<TbCliente>(entity =>
            {
                entity.HasKey(e => e.IdCliente)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.IdLogin)
                    .HasName("id_login");

                entity.Property(e => e.NmCliente)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.HasOne(d => d.IdLoginNavigation)
                    .WithMany(p => p.TbCliente)
                    .HasForeignKey(d => d.IdLogin)
                    .HasConstraintName("tb_cliente_ibfk_1");
            });

            modelBuilder.Entity<TbCompra>(entity =>
            {
                entity.HasKey(e => e.IdCompra)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.IdCliente)
                    .HasName("id_cliente");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbCompra)
                    .HasForeignKey(d => d.IdCliente)
                    .HasConstraintName("tb_compra_ibfk_1");
            });

            modelBuilder.Entity<TbCompraManga>(entity =>
            {
                entity.HasKey(e => e.IdCompraManga)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.IdCompra)
                    .HasName("id_compra");

                entity.HasIndex(e => e.IdManga)
                    .HasName("id_manga");

                entity.HasOne(d => d.IdCompraNavigation)
                    .WithMany(p => p.TbCompraManga)
                    .HasForeignKey(d => d.IdCompra)
                    .HasConstraintName("tb_compra_manga_ibfk_1");

                entity.HasOne(d => d.IdMangaNavigation)
                    .WithMany(p => p.TbCompraManga)
                    .HasForeignKey(d => d.IdManga)
                    .HasConstraintName("tb_compra_manga_ibfk_2");
            });

            modelBuilder.Entity<TbFuncionario>(entity =>
            {
                entity.HasKey(e => e.IdFuncionario)
                    .HasName("PRIMARY");

                entity.Property(e => e.DsEmail)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.DsEndereco)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.NmFuncionario)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<TbLogin>(entity =>
            {
                entity.HasKey(e => e.IdLogin)
                    .HasName("PRIMARY");

                entity.Property(e => e.DsEmail)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.DsSenha)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<TbManga>(entity =>
            {
                entity.HasKey(e => e.IdManga)
                    .HasName("PRIMARY");

                entity.Property(e => e.DsGenero)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.ImgCapa)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.NmAutor)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.NmManga)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<TbPermissao>(entity =>
            {
                entity.HasKey(e => e.IdPermissao)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.IdAnime)
                    .HasName("id_anime");

                entity.HasIndex(e => e.IdFuncionario)
                    .HasName("id_funcionario");

                entity.HasIndex(e => e.IdManga)
                    .HasName("id_manga");

                entity.HasOne(d => d.IdAnimeNavigation)
                    .WithMany(p => p.TbPermissao)
                    .HasForeignKey(d => d.IdAnime)
                    .HasConstraintName("tb_permissao_ibfk_2");

                entity.HasOne(d => d.IdFuncionarioNavigation)
                    .WithMany(p => p.TbPermissao)
                    .HasForeignKey(d => d.IdFuncionario)
                    .HasConstraintName("tb_permissao_ibfk_1");

                entity.HasOne(d => d.IdMangaNavigation)
                    .WithMany(p => p.TbPermissao)
                    .HasForeignKey(d => d.IdManga)
                    .HasConstraintName("tb_permissao_ibfk_3");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
