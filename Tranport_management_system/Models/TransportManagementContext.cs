using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Tranport_management_system.Models;

public partial class TransportManagementContext : DbContext
{
    public TransportManagementContext()
    {
    }

    public TransportManagementContext(DbContextOptions<TransportManagementContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Booking> Bookings { get; set; }

    public virtual DbSet<Driver> Drivers { get; set; }

    public virtual DbSet<Register> Registers { get; set; }

    public virtual DbSet<Tour> Tours { get; set; }

    public virtual DbSet<Vehicle> Vehicles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=Transport_management;Trusted_Connection=True;Encrypt=false;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Booking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Booking__3214EC0720857FC1");

            entity.ToTable("Booking");

            entity.Property(e => e.CustAge).HasColumnName("cust_Age");
            entity.Property(e => e.CustArrivingTo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cust_arriving_to");
            entity.Property(e => e.CustContactNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cust_contact_number");
            entity.Property(e => e.CustDepature)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cust_depature");
            entity.Property(e => e.CustGender)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cust_gender");
            entity.Property(e => e.CustName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cust_name");
            entity.Property(e => e.CustSeatNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cust_seat_number");
        });

        modelBuilder.Entity<Driver>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Driver__3214EC07AA2D7BF5");

            entity.ToTable("Driver");

            entity.Property(e => e.DriverAge).HasColumnName("Driver_age");
            entity.Property(e => e.DriverContactNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Driver_contact_number");
            entity.Property(e => e.DriverLic)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Driver_lic");
            entity.Property(e => e.DriverName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Driver_name");
        });

        modelBuilder.Entity<Register>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Register__3214EC07C3D2D1F0");

            entity.ToTable("Register");

            entity.Property(e => e.AdminAgencyName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Admin_agency_name");
            entity.Property(e => e.AdminContactNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Admin_contact_number");
            entity.Property(e => e.AdminEmail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Admin_email");
            entity.Property(e => e.AdminName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Admin_name");
            entity.Property(e => e.AdminPassword)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Admin_password");
            entity.Property(e => e.AdminUsername)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Admin_Username");
        });

        modelBuilder.Entity<Tour>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Tours__3214EC07282C6401");

            entity.Property(e => e.ArrivalName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Arrival_name");
            entity.Property(e => e.DeptName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Dept_name");
        });

        modelBuilder.Entity<Vehicle>(entity =>
        {
            entity.HasKey(e => e.VehNumber).HasName("PK__Vehicle__ECDCF698F573C33B");

            entity.ToTable("Vehicle");

            entity.Property(e => e.VehNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("veh_number");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.VehColor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("veh_color");
            entity.Property(e => e.VehModel)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("veh_model");
            entity.Property(e => e.VehName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("veh_name");
            entity.Property(e => e.VehStatus)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("veh_status");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
