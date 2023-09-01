using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TraineeProgram.Persistence.DBEntities
{
    public partial class TraineeProgramDBContext : DbContext
    {
        public TraineeProgramDBContext()
        {
        }

        public TraineeProgramDBContext(DbContextOptions<TraineeProgramDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DBCandidate> Candidates { get; set; } = null!;
        public virtual DbSet<DBCandidateJobOpening> CandidateJobOpenings { get; set; } = null!;
        public virtual DbSet<DBCandidateLink> CandidateLinks { get; set; } = null!;
        public virtual DbSet<DBCandidateSkill> CandidateSkills { get; set; } = null!;
        public virtual DbSet<DBInterview> Interviews { get; set; } = null!;
        public virtual DbSet<DBInterviewType> InterviewTypes { get; set; } = null!;
        public virtual DbSet<DBInterviewUser> InterviewUsers { get; set; } = null!;
        public virtual DbSet<DBJobOpening> JobOpenings { get; set; } = null!;
        public virtual DbSet<DBJobRole> JobRoles { get; set; } = null!;
        public virtual DbSet<DBProcess> Processes { get; set; } = null!;
        public virtual DbSet<DBReference> References { get; set; } = null!;
        public virtual DbSet<DBSeniority> Seniorities { get; set; } = null!;
        public virtual DbSet<DBSkill> Skills { get; set; } = null!;
        public virtual DbSet<DBTeam> Teams { get; set; } = null!;
        public virtual DbSet<DBTeamSkill> TeamSkills { get; set; } = null!;
        public virtual DbSet<DBUserInterviewType> UserInterviewTypes { get; set; } = null!;
        public virtual DbSet<DBUserR> UserRs { get; set; } = null!;
        public virtual DbSet<DBUserSkill> UserSkills { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=TraineeProgram");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DBCandidate>(entity =>
            {
                entity.ToTable("Candidate");

                entity.HasIndex(e => e.Email, "UQ__Candidat__A9D10534BE7DB6C6")
                    .IsUnique();

                entity.HasIndex(e => e.Dni, "UQ__Candidat__C03085757E82E80B")
                    .IsUnique();

                entity.Property(e => e.Address)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CoverLetter)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Dni)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MobilePhone)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Photo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UploadResume)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DBCandidateJobOpening>(entity =>
            {
                entity.ToTable("CandidateJobOpening");

                entity.Property(e => e.PostulationDate).HasColumnType("datetime");

                entity.HasOne(d => d.Candidate)
                    .WithMany(p => p.CandidateJobOpenings)
                    .HasForeignKey(d => d.CandidateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Candidate__Candi__571DF1D5");

                entity.HasOne(d => d.JobOpening)
                    .WithMany(p => p.CandidateJobOpenings)
                    .HasForeignKey(d => d.JobOpeningId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Candidate__JobOp__5812160E");
            });

            modelBuilder.Entity<DBCandidateLink>(entity =>
            {
                entity.ToTable("CandidateLink");

                entity.Property(e => e.Link)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LinkType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Candidate)
                    .WithMany(p => p.CandidateLinks)
                    .HasForeignKey(d => d.CandidateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Candidate__Candi__5AEE82B9");
            });

            modelBuilder.Entity<DBCandidateSkill>(entity =>
            {
                entity.ToTable("CandidateSkill");

                entity.HasIndex(e => new { e.SkillId, e.CandidateId }, "UQ__Candidat__0255A83F42E68228")
                    .IsUnique();

                entity.HasOne(d => d.Candidate)
                    .WithMany(p => p.CandidateSkills)
                    .HasForeignKey(d => d.CandidateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Candidate__Candi__4AB81AF0");

                entity.HasOne(d => d.Skill)
                    .WithMany(p => p.CandidateSkills)
                    .HasForeignKey(d => d.SkillId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Candidate__Skill__49C3F6B7");
            });

            modelBuilder.Entity<DBInterview>(entity =>
            {
                entity.ToTable("Interview");

                entity.Property(e => e.Feedback)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.InterviewDate).HasColumnType("datetime");

                entity.HasOne(d => d.InterviewType)
                    .WithMany(p => p.Interviews)
                    .HasForeignKey(d => d.InterviewTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Interview__Inter__5DCAEF64");

                entity.HasOne(d => d.JobOpening)
                    .WithMany(p => p.Interviews)
                    .HasForeignKey(d => d.JobOpeningId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Interview__JobOp__5FB337D6");

                entity.HasOne(d => d.Process)
                    .WithMany(p => p.Interviews)
                    .HasForeignKey(d => d.ProcessId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Interview__Proce__5EBF139D");
            });

            modelBuilder.Entity<DBInterviewType>(entity =>
            {
                entity.ToTable("InterviewType");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DBInterviewUser>(entity =>
            {
                entity.ToTable("InterviewUser");

                entity.HasIndex(e => new { e.UserId, e.InterviewId }, "UQ__Intervie__2B1F09C876A68674")
                    .IsUnique();

                entity.HasOne(d => d.Interview)
                    .WithMany(p => p.InterviewUsers)
                    .HasForeignKey(d => d.InterviewId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Interview__Inter__6477ECF3");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.InterviewUsers)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Interview__UserI__6383C8BA");
            });

            modelBuilder.Entity<DBJobOpening>(entity =>
            {
                entity.ToTable("JobOpening");

                entity.Property(e => e.JobSummary)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.JobTitle)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Link)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.JobRole)
                    .WithMany(p => p.JobOpenings)
                    .HasForeignKey(d => d.JobRoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__JobOpenin__JobRo__52593CB8");

                entity.HasOne(d => d.Seniority)
                    .WithMany(p => p.JobOpenings)
                    .HasForeignKey(d => d.SeniorityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__JobOpenin__Senio__534D60F1");

                entity.HasOne(d => d.Team)
                    .WithMany(p => p.JobOpenings)
                    .HasForeignKey(d => d.TeamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__JobOpenin__TeamI__5441852A");
            });

            modelBuilder.Entity<DBJobRole>(entity =>
            {
                entity.ToTable("JobRole");

                entity.Property(e => e.Name)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DBProcess>(entity =>
            {
                entity.ToTable("Process");

                entity.Property(e => e.ProcessDate).HasColumnType("date");

                entity.Property(e => e.ProcessStatus)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Candidate)
                    .WithMany(p => p.Processes)
                    .HasForeignKey(d => d.CandidateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Process__Candida__286302EC");
            });

            modelBuilder.Entity<DBReference>(entity =>
            {
                entity.ToTable("Reference");

                entity.Property(e => e.Comments)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceDate).HasColumnType("date");

                entity.Property(e => e.RelatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Candidate)
                    .WithMany(p => p.References)
                    .HasForeignKey(d => d.CandidateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Reference__Candi__3D5E1FD2");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.References)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Reference__UserI__3E52440B");
            });

            modelBuilder.Entity<DBSeniority>(entity =>
            {
                entity.ToTable("Seniority");

                entity.Property(e => e.Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DBSkill>(entity =>
            {
                entity.ToTable("Skill");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.JobRole)
                    .WithMany(p => p.Skills)
                    .HasForeignKey(d => d.JobRoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Skill__JobRoleId__412EB0B6");
            });

            modelBuilder.Entity<DBTeam>(entity =>
            {
                entity.ToTable("Team");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DBTeamSkill>(entity =>
            {
                entity.ToTable("TeamSkill");

                entity.HasIndex(e => new { e.TeamId, e.SkillId }, "UQ__TeamSkil__7FC0EE809F09808A")
                    .IsUnique();

                entity.HasOne(d => d.Skill)
                    .WithMany(p => p.TeamSkills)
                    .HasForeignKey(d => d.SkillId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TeamSkill__Skill__4F7CD00D");

                entity.HasOne(d => d.Team)
                    .WithMany(p => p.TeamSkills)
                    .HasForeignKey(d => d.TeamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TeamSkill__TeamI__4E88ABD4");
            });

            modelBuilder.Entity<DBUserInterviewType>(entity =>
            {
                entity.ToTable("UserInterviewType");

                entity.HasIndex(e => new { e.InterviewTypeId, e.UserId }, "UQ__UserInte__4AA8EEF0EDC4D70B")
                    .IsUnique();

                entity.HasOne(d => d.InterviewType)
                    .WithMany(p => p.UserInterviewTypes)
                    .HasForeignKey(d => d.InterviewTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__UserInter__Inter__398D8EEE");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserInterviewTypes)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__UserInter__UserI__3A81B327");
            });

            modelBuilder.Entity<DBUserR>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__UserR__1788CC4C4B365E31");

                entity.ToTable("UserR");

                entity.HasIndex(e => e.Email, "UQ__UserR__A9D105349B106EC2")
                    .IsUnique();

                entity.Property(e => e.Email)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.JobRole)
                    .WithMany(p => p.UserRs)
                    .HasForeignKey(d => d.JobRoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__UserR__JobRoleId__33D4B598");

                entity.HasOne(d => d.Seniority)
                    .WithMany(p => p.UserRs)
                    .HasForeignKey(d => d.SeniorityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__UserR__Seniority__34C8D9D1");

                entity.HasOne(d => d.Team)
                    .WithMany(p => p.UserRs)
                    .HasForeignKey(d => d.TeamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__UserR__TeamId__35BCFE0A");
            });

            modelBuilder.Entity<DBUserSkill>(entity =>
            {
                entity.ToTable("UserSkill");

                entity.HasIndex(e => new { e.UserId, e.SkillId }, "UQ__UserSkil__7A72C555B0D0B05E")
                    .IsUnique();

                entity.HasOne(d => d.Skill)
                    .WithMany(p => p.UserSkills)
                    .HasForeignKey(d => d.SkillId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__UserSkill__Skill__45F365D3");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserSkills)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__UserSkill__UserI__44FF419A");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
