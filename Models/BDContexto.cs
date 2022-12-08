using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ProjetoIntegradorFinal.Models
{
    public partial class BDContexto : DbContext
    {
        public BDContexto()
        {
        }

        public BDContexto(DbContextOptions<BDContexto> options)
            : base(options)
        {
        }

        public virtual DbSet<Aluno> Alunos { get; set; } = null!;
        public virtual DbSet<Avaliacao> Avaliacaos { get; set; } = null!;
        public virtual DbSet<Colaborador> Colaboradors { get; set; } = null!;
        public virtual DbSet<Disciplina> Disciplinas { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=localhost;port=3306;user=arnmysql;password=cursomysql;database=projeto_integrador", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.29-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb4_0900_ai_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<Aluno>(entity =>
            {
                entity.HasKey(e => e.NMatricula)
                    .HasName("PRIMARY");

                entity.ToTable("aluno");

                entity.Property(e => e.NMatricula)
                    .ValueGeneratedNever()
                    .HasColumnName("n_matricula");

                entity.Property(e => e.CCpfAluno)
                    .HasMaxLength(20)
                    .HasColumnName("c_cpfAluno");

                entity.Property(e => e.CFoneAluno)
                    .HasMaxLength(20)
                    .HasColumnName("c_foneAluno");

                entity.Property(e => e.CNomeAluno)
                    .HasMaxLength(100)
                    .HasColumnName("c_nomeAluno");

                entity.Property(e => e.DDataNasc).HasColumnName("d_dataNasc");
            });

            modelBuilder.Entity<Avaliacao>(entity =>
            {
                entity.HasKey(e => e.IdAvaliacao)
                    .HasName("PRIMARY");

                entity.ToTable("avaliacao");

                entity.HasIndex(e => e.NCodDisci, "n_codDisci");

                entity.Property(e => e.IdAvaliacao)
                    .ValueGeneratedNever()
                    .HasColumnName("idAvaliacao");

                entity.Property(e => e.CComentario)
                    .HasColumnType("text")
                    .HasColumnName("c_comentario");

                entity.Property(e => e.NCodDisci).HasColumnName("n_codDisci");

                entity.Property(e => e.NNotaAvalia).HasColumnName("n_notaAvalia");

                entity.HasOne(d => d.NCodDisciNavigation)
                    .WithMany(p => p.Avaliacaos)
                    .HasForeignKey(d => d.NCodDisci)
                    .HasConstraintName("avaliacao_ibfk_1");
            });

            modelBuilder.Entity<Colaborador>(entity =>
            {
                entity.HasKey(e => e.NIdColab)
                    .HasName("PRIMARY");

                entity.ToTable("colaborador");

                entity.Property(e => e.NIdColab).HasColumnName("n_idColab");

                entity.Property(e => e.CCargoProfessor).HasColumnName("c_cargoProfessor");

                entity.Property(e => e.CCargoTutor).HasColumnName("c_cargoTutor");

                entity.Property(e => e.CCpfColb)
                    .HasMaxLength(20)
                    .HasColumnName("c_cpfColb");

                entity.Property(e => e.CNomeColab)
                    .HasMaxLength(100)
                    .HasColumnName("c_nomeColab");
            });

            modelBuilder.Entity<Disciplina>(entity =>
            {
                entity.HasKey(e => e.NCodDisci)
                    .HasName("PRIMARY");

                entity.ToTable("disciplina");

                entity.Property(e => e.NCodDisci)
                    .ValueGeneratedNever()
                    .HasColumnName("n_codDisci");

                entity.Property(e => e.CHorasDisci)
                    .HasMaxLength(10)
                    .HasColumnName("c_horasDisci");

                entity.Property(e => e.CNomeDisci)
                    .HasMaxLength(100)
                    .HasColumnName("c_nomeDisci");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
