using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Employee.DataModel.Models;

public partial class EtreportContext : DbContext
{
    public EtreportContext()
    {
    }

    public EtreportContext(DbContextOptions<EtreportContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Employees> Employees { get; set; }

    public virtual DbSet<EmployeeProject> EmployeeProjects { get; set; }

    public virtual DbSet<Interviews> Interviews { get; set; }

    public virtual DbSet<Learning> Learnings { get; set; }

    public virtual DbSet<LearningEvaluation> LearningEvaluations { get; set; }

    public virtual DbSet<LookUp> LookUps { get; set; }

    public virtual DbSet<LookUpType> LookUpTypes { get; set; }

    public virtual DbSet<Oppurtunity> Oppurtunities { get; set; }

    public virtual DbSet<Project> Projects { get; set; }

    public virtual DbSet<ProofOfConcept> ProofOfConcepts { get; set; }

    public virtual DbSet<Training> Trainings { get; set; }

    public virtual DbSet<UserDetail> UserDetails { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=MLI00737\\SQL_DEV;Database=ETReport;Integrated Security=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employees>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Employee__3214EC270CF6EE74");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Email)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.FullName)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.ManagerId).HasColumnName("ManagerID");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<EmployeeProject>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Employee__3214EC27072E172B");

            entity.ToTable("EmployeeProject");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Achievements)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ClientDesignation)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("CLientDesignation");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.EmpId).HasColumnName("EmpID");
            entity.Property(e => e.EmpProjectEndDate).HasColumnType("datetime");
            entity.Property(e => e.EmpProjectStartDate).HasColumnType("datetime");
            entity.Property(e => e.ManagerId).HasColumnName("ManagerID");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.NewSkillEarned)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ProjectId).HasColumnName("ProjectID");
            entity.Property(e => e.ReasonToLeave)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Interviews>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Intervie__3214EC27FF1B3A06");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Comments)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.EmpId).HasColumnName("EmpID");
            entity.Property(e => e.IsSelected)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.ProjectId).HasColumnName("ProjectID");
            entity.Property(e => e.SkillId).HasColumnName("SKillID");
        });

        modelBuilder.Entity<Learning>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Learning__3214EC27631C6108");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.EmpId).HasColumnName("EmpID");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.Skill)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<LearningEvaluation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Learning__3214EC27B0F38346");

            entity.ToTable("LearningEvaluation");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.EmpId).HasColumnName("EmpID");
            entity.Property(e => e.EvaluatorEmpId).HasColumnName("EvaluatorEmpID");
            entity.Property(e => e.LearningId).HasColumnName("LearningID");
        });

        modelBuilder.Entity<LookUp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LookUp__3214EC27731D3796");

            entity.ToTable("LookUp");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Value)
                .HasMaxLength(32)
                .IsUnicode(false);
        });

        modelBuilder.Entity<LookUpType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LookUpTy__3214EC27B218BA94");

            entity.ToTable("LookUpType");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Lookup)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Oppurtunity>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Oppurtun__3214EC27F8239DC4");

            entity.ToTable("Oppurtunity");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.EmpId).HasColumnName("EmpID");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Project>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Project__3214EC27A2F84A74");

            entity.ToTable("Project");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Description)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Name)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.ProjectEndDate).HasColumnType("datetime");
            entity.Property(e => e.ProjectStartDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ProofOfConcept>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ProofOfC__3214EC27B8CD8AA2");

            entity.ToTable("ProofOfConcept");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.EmpId).HasColumnName("EmpID");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.Pocname)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("POCName");
            entity.Property(e => e.SkillId).HasColumnName("SKillID");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Training>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Training__3214EC27C312F8F6");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.EmpId).HasColumnName("EmpID");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.TrainingGroup)
                .HasMaxLength(32)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UserDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__UserDeta__3214EC27CD2108DA");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.EmpId).HasColumnName("EmpID");
            entity.Property(e => e.Key)
                .HasMaxLength(32)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
