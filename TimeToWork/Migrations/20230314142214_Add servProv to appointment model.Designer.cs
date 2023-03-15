﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TimeToWork.Data;

#nullable disable

namespace TimeToWork.Migrations
{
    [DbContext(typeof(TimeToWorkContext))]
    [Migration("20230314142214_Add servProv to appointment model")]
    partial class AddservProvtoappointmentmodel
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TimeToWork.Models.Appointment", b =>
                {
                    b.Property<int>("AppointmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AppointmentId"));

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("ServiceId")
                        .HasColumnType("int");

                    b.Property<int>("ServiceProviderId")
                        .HasColumnType("int");

                    b.HasKey("AppointmentId");

                    b.HasIndex("ClientId");

                    b.HasIndex("ServiceId");

                    b.HasIndex("ServiceProviderId");

                    b.ToTable("Appointment", (string)null);
                });

            modelBuilder.Entity("TimeToWork.Models.Client", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Client", (string)null);
                });

            modelBuilder.Entity("TimeToWork.Models.Service", b =>
                {
                    b.Property<int>("ServiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ServiceId"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ServiceName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ServiceId");

                    b.ToTable("Service", (string)null);
                });

            modelBuilder.Entity("TimeToWork.Models.ServiceAssignment", b =>
                {
                    b.Property<int>("ServiceID")
                        .HasColumnType("int");

                    b.Property<int>("ServiceProviderID")
                        .HasColumnType("int");

                    b.HasKey("ServiceID", "ServiceProviderID");

                    b.HasIndex("ServiceProviderID");

                    b.ToTable("ServiceAssignment", (string)null);
                });

            modelBuilder.Entity("TimeToWork.Models.ServiceProvider", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("HireDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("ServiceProvider", (string)null);
                });

            modelBuilder.Entity("TimeToWork.Models.Appointment", b =>
                {
                    b.HasOne("TimeToWork.Models.Client", "Client")
                        .WithMany("Appointments")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TimeToWork.Models.Service", "Service")
                        .WithMany("Appointments")
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TimeToWork.Models.ServiceProvider", "ServiceProvider")
                        .WithMany()
                        .HasForeignKey("ServiceProviderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("Service");

                    b.Navigation("ServiceProvider");
                });

            modelBuilder.Entity("TimeToWork.Models.ServiceAssignment", b =>
                {
                    b.HasOne("TimeToWork.Models.Service", "Service")
                        .WithMany("ServiceAssignments")
                        .HasForeignKey("ServiceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TimeToWork.Models.ServiceProvider", "ServiceProvider")
                        .WithMany("ServiceAssignments")
                        .HasForeignKey("ServiceProviderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Service");

                    b.Navigation("ServiceProvider");
                });

            modelBuilder.Entity("TimeToWork.Models.Client", b =>
                {
                    b.Navigation("Appointments");
                });

            modelBuilder.Entity("TimeToWork.Models.Service", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("ServiceAssignments");
                });

            modelBuilder.Entity("TimeToWork.Models.ServiceProvider", b =>
                {
                    b.Navigation("ServiceAssignments");
                });
#pragma warning restore 612, 618
        }
    }
}
