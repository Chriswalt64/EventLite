﻿// <auto-generated />
using System;
using EventLite.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EventLite.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250410163154_SeedDataInit2")]
    partial class SeedDataInit2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EventLite.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Tech"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Music"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Health"
                        });
                });

            modelBuilder.Entity("EventLite.Models.Event", b =>
                {
                    b.Property<int>("EventId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EventId"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("EndDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int?>("MaxAttendees")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("EventId");

                    b.HasIndex("CreatedBy");

                    b.ToTable("Events");

                    b.HasData(
                        new
                        {
                            EventId = 1,
                            CreatedAt = new DateTime(2025, 4, 10, 15, 37, 57, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Description = "Annual tech conference with keynote speakers and workshops.",
                            EndDateTime = new DateTime(2025, 5, 2, 15, 0, 0, 0, DateTimeKind.Unspecified),
                            Location = "Silicon Valley Convention Center",
                            MaxAttendees = 300,
                            StartDateTime = new DateTime(2025, 4, 30, 8, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Tech Conference 2025"
                        },
                        new
                        {
                            EventId = 2,
                            CreatedAt = new DateTime(2025, 4, 10, 15, 37, 57, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Description = "Enjoy a night of live jazz performances.",
                            Location = "Downtown Jazz Club",
                            StartDateTime = new DateTime(2025, 4, 11, 19, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Live Jazz Night"
                        });
                });

            modelBuilder.Entity("EventLite.Models.EventCategory", b =>
                {
                    b.Property<int>("EventId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.HasKey("EventId", "CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("EventCategories");

                    b.HasData(
                        new
                        {
                            EventId = 1,
                            CategoryId = 1
                        },
                        new
                        {
                            EventId = 2,
                            CategoryId = 2
                        });
                });

            modelBuilder.Entity("EventLite.Models.RSVP", b =>
                {
                    b.Property<int>("RSVPId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RSVPId"));

                    b.Property<int>("EventId")
                        .HasColumnType("int");

                    b.Property<DateTime>("RSVPDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("RSVPId");

                    b.HasIndex("EventId");

                    b.HasIndex("UserId");

                    b.ToTable("RSVPs");

                    b.HasData(
                        new
                        {
                            RSVPId = 1,
                            EventId = 1,
                            RSVPDate = new DateTime(2025, 4, 10, 15, 37, 57, 0, DateTimeKind.Unspecified),
                            UserId = 2
                        });
                });

            modelBuilder.Entity("EventLite.Models.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleId"));

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("RoleId");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            RoleId = 1,
                            RoleName = "Admin"
                        },
                        new
                        {
                            RoleId = 2,
                            RoleName = "User"
                        });
                });

            modelBuilder.Entity("EventLite.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("UserId");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            CreatedAt = new DateTime(2025, 4, 10, 15, 37, 57, 0, DateTimeKind.Unspecified),
                            Email = "admin@example.com",
                            PasswordHash = "$2y$10$mljmtXnFCZgMISnz6IFI5eZZMk03APF2Yz/t7mLnLy/ocgf7AaVpq",
                            RoleId = 1,
                            Username = "admin"
                        },
                        new
                        {
                            UserId = 2,
                            CreatedAt = new DateTime(2025, 4, 10, 15, 37, 57, 0, DateTimeKind.Unspecified),
                            Email = "john@example.com",
                            PasswordHash = "$2y$10$mljmtXnFCZgMISnz6IFI5eZZMk03APF2Yz/t7mLnLy/ocgf7AaVpq",
                            RoleId = 2,
                            Username = "john_doe"
                        });
                });

            modelBuilder.Entity("EventLite.Models.Event", b =>
                {
                    b.HasOne("EventLite.Models.User", "Creator")
                        .WithMany("CreatedEvents")
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Creator");
                });

            modelBuilder.Entity("EventLite.Models.EventCategory", b =>
                {
                    b.HasOne("EventLite.Models.Category", "Category")
                        .WithMany("EventCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EventLite.Models.Event", "Event")
                        .WithMany("EventCategories")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Event");
                });

            modelBuilder.Entity("EventLite.Models.RSVP", b =>
                {
                    b.HasOne("EventLite.Models.Event", "Event")
                        .WithMany("RSVPs")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EventLite.Models.User", "User")
                        .WithMany("RSVPs")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Event");

                    b.Navigation("User");
                });

            modelBuilder.Entity("EventLite.Models.User", b =>
                {
                    b.HasOne("EventLite.Models.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("EventLite.Models.Category", b =>
                {
                    b.Navigation("EventCategories");
                });

            modelBuilder.Entity("EventLite.Models.Event", b =>
                {
                    b.Navigation("EventCategories");

                    b.Navigation("RSVPs");
                });

            modelBuilder.Entity("EventLite.Models.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("EventLite.Models.User", b =>
                {
                    b.Navigation("CreatedEvents");

                    b.Navigation("RSVPs");
                });
#pragma warning restore 612, 618
        }
    }
}
