using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ScheduleAppWepAPI.Model;

public partial class AdventureContext : DbContext
{
    public AdventureContext()
    {
    }

    public AdventureContext(DbContextOptions<AdventureContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Schedule> Schedules { get; set; }

    public virtual DbSet<Scheduling> Schedulings { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<Subject> Subjects { get; set; }

    public virtual DbSet<TimeFrame> TimeFrames { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(LocalDb)\\PhongLe LocalDB;Database=ScheduleWebAPI;Trusted_Connection=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Schedule>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Schedule__3214EC07720D55F4");

            entity.ToTable("Schedule");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Scheduling>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Scheduli__3214EC071DAAFF22");

            entity.ToTable("Scheduling");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Schedule).WithMany(p => p.Schedulings)
                .HasForeignKey(d => d.ScheduleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Schedulin__Sched__35BCFE0A");

            entity.HasOne(d => d.Subject).WithMany(p => p.Schedulings)
                .HasForeignKey(d => d.SubjectId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Schedulin__Subje__36B12243");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Student__3214EC075F2A1534");

            entity.ToTable("Student");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Address).HasMaxLength(100);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);

            entity.HasOne(d => d.Schedule).WithMany(p => p.Students)
                .HasForeignKey(d => d.ScheduleId)
                .HasConstraintName("FK__Student__Schedul__2D27B809");
        });

        modelBuilder.Entity<Subject>(entity =>
        {
            entity.ToTable("Subject");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.DayOfWeek).HasMaxLength(30);
            entity.Property(e => e.Name).HasMaxLength(50);

            entity.HasOne(d => d.TimeBegin).WithMany(p => p.SubjectTimeBegins)
                .HasForeignKey(d => d.TimeBeginId)
                .HasConstraintName("FK__Subject__TimeBeg__398D8EEE");

            entity.HasOne(d => d.TimeEnd).WithMany(p => p.SubjectTimeEnds)
                .HasForeignKey(d => d.TimeEndId)
                .HasConstraintName("FK__Subject__TimeEnd__3A81B327");
        });

        modelBuilder.Entity<TimeFrame>(entity =>
        {
            entity.ToTable("TimeFrame");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
