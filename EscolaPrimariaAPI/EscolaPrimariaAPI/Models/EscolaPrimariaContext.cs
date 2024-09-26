using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EscolaPrimariaAPI.Models
{
    public partial class EscolaPrimariaContext : DbContext
    {
        public EscolaPrimariaContext()
        {
        }

        public EscolaPrimariaContext(DbContextOptions<EscolaPrimariaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Aluno> Alunos { get; set; } = null!;
        public virtual DbSet<Curso> Cursos { get; set; } = null!;
        public virtual DbSet<Professor> Professors { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-DNE8J0V; database=EscolaPrimaria;Trusted_Connection=true;Trustservercertificate=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aluno>(entity =>
            {
                entity.HasKey(e => e.IdAluno)
                    .HasName("PK__ALUNO__5896AB6F28A6527C");

                entity.ToTable("ALUNO");

                entity.Property(e => e.IdAluno)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_ALUNO");

                entity.Property(e => e.Cidade)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("CIDADE");

                entity.Property(e => e.Complemento)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("COMPLEMENTO");

                entity.Property(e => e.Cpf).HasColumnName("CPF");

                entity.Property(e => e.Email)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Endereco)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("ENDERECO");

                entity.Property(e => e.Estado)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("ESTADO");

                entity.Property(e => e.Nome)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("NOME");

                entity.Property(e => e.Numero).HasColumnName("NUMERO");
            });

            modelBuilder.Entity<Curso>(entity =>
            {
                entity.HasKey(e => e.IdCurso)
                    .HasName("PK__CURSO__9B4AE7985A6397CD");

                entity.ToTable("CURSO");

                entity.Property(e => e.IdCurso)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_CURSO");

                entity.Property(e => e.IdProfessor).HasColumnName("ID_PROFESSOR");

                entity.Property(e => e.Nome)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("NOME");

                entity.HasOne(d => d.IdProfessorNavigation)
                    .WithMany(p => p.Cursos)
                    .HasForeignKey(d => d.IdProfessor)
                    .HasConstraintName("FK_CURSO_PROFESSOR");

                entity.HasMany(d => d.IdAlunos)
                    .WithMany(p => p.IdCursos)
                    .UsingEntity<Dictionary<string, object>>(
                        "Cursoaluno",
                        l => l.HasOne<Aluno>().WithMany().HasForeignKey("IdAluno").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_CURSOALUNO_ALUNO"),
                        r => r.HasOne<Curso>().WithMany().HasForeignKey("IdCurso").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_CURSOALUNO_CURSO"),
                        j =>
                        {
                            j.HasKey("IdCurso", "IdAluno").HasName("PK__CURSOALU__7EC38D2E94BC71A9");

                            j.ToTable("CURSOALUNO");

                            j.IndexerProperty<int>("IdCurso").HasColumnName("ID_CURSO");

                            j.IndexerProperty<int>("IdAluno").HasColumnName("ID_ALUNO");
                        });
            });

            modelBuilder.Entity<Professor>(entity =>
            {
                entity.HasKey(e => e.IdProfessor)
                    .HasName("PK__PROFESSO__605937A1434AC1C5");

                entity.ToTable("PROFESSOR");

                entity.Property(e => e.IdProfessor)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_PROFESSOR");

                entity.Property(e => e.Cidade)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("CIDADE");

                entity.Property(e => e.Complemento)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("COMPLEMENTO");

                entity.Property(e => e.Cpf).HasColumnName("CPF");

                entity.Property(e => e.Email)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Endereco)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("ENDERECO");

                entity.Property(e => e.Estado)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("ESTADO");

                entity.Property(e => e.Nome)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("NOME");

                entity.Property(e => e.Numero).HasColumnName("NUMERO");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
