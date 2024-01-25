﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Labb3_Anropa_Databas___Simon_Ståhl_SUT23.Models
{
    public partial class DBSchoolDbContext : DbContext
    {
        public DBSchoolDbContext()
        {
        }

        public DBSchoolDbContext(DbContextOptions<DBSchoolDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblCourse> TblCourses { get; set; } = null!;
        public virtual DbSet<TblGrade> TblGrades { get; set; } = null!;
        public virtual DbSet<TblPersonal> TblPersonals { get; set; } = null!;
        public virtual DbSet<TblStudent> TblStudents { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data source = DESKTOP-QCSHMVR;Initial Catalog = DBSchool;Integrated Security=True;TrustServerCertificate=Yes;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblCourse>(entity =>
            {
                entity.HasKey(e => e.CourseId)
                    .HasName("PK__tblCours__C92D7187AD59E351");

                entity.ToTable("tblCourse");

                entity.Property(e => e.CourseId)
                    .ValueGeneratedNever()
                    .HasColumnName("CourseID");

                entity.Property(e => e.CourseName)
                    .HasMaxLength(50)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblGrade>(entity =>
            {
                entity.HasKey(e => e.GradeId)
                    .HasName("PK__tblGrade__54F87A37F8CBF01A");

                entity.ToTable("tblGrade");

                entity.Property(e => e.GradeId)
                    .ValueGeneratedNever()
                    .HasColumnName("GradeID");

                entity.Property(e => e.CourseId).HasColumnName("CourseID");

                entity.Property(e => e.Grade)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.GradeDate).HasColumnType("date");

                entity.Property(e => e.PersonalId).HasColumnName("PersonalID");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.TblGrades)
                    .HasForeignKey(d => d.CourseId)
                    .HasConstraintName("FK__tblGrade__Course__74AE54BC");

                entity.HasOne(d => d.Personal)
                    .WithMany(p => p.TblGrades)
                    .HasForeignKey(d => d.PersonalId)
                    .HasConstraintName("FK__tblGrade__Person__72C60C4A");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.TblGrades)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK__tblGrade__Studen__73BA3083");
            });

            modelBuilder.Entity<TblPersonal>(entity =>
            {
                entity.HasKey(e => e.PersonalId)
                    .HasName("PK__tblPerso__283437134F1394A0");

                entity.ToTable("tblPersonal");

                entity.Property(e => e.PersonalId)
                    .ValueGeneratedNever()
                    .HasColumnName("PersonalID");

                entity.Property(e => e.Fname)
                    .HasMaxLength(50)
                    .HasColumnName("FName")
                    .IsFixedLength();

                entity.Property(e => e.Lname)
                    .HasMaxLength(50)
                    .HasColumnName("LName")
                    .IsFixedLength();

                entity.Property(e => e.Occupation)
                    .HasMaxLength(50)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblStudent>(entity =>
            {
                entity.HasKey(e => e.StudentId)
                    .HasName("PK__tblStude__32C52A79D9EF817A");

                entity.ToTable("tblStudent");

                entity.Property(e => e.StudentId)
                    .ValueGeneratedNever()
                    .HasColumnName("StudentID");

                entity.Property(e => e.Class)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Fname)
                    .HasMaxLength(50)
                    .HasColumnName("FName")
                    .IsFixedLength();

                entity.Property(e => e.Lname)
                    .HasMaxLength(50)
                    .HasColumnName("LName")
                    .IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
