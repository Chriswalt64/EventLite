using EventLite.Models;
using Microsoft.EntityFrameworkCore;

namespace EventLite.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<RSVP> RSVPs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<EventCategory> EventCategories { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed Roles
            modelBuilder.Entity<Role>().HasData(
                new Role { RoleId = 1, RoleName = "Admin" },
                new Role { RoleId = 2, RoleName = "User" }
            );

            // Seed Users
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    UserId = 1,
                    Username = "admin",
                    Email = "admin@example.com",
                    PasswordHash = "$2y$10$mljmtXnFCZgMISnz6IFI5eZZMk03APF2Yz/t7mLnLy/ocgf7AaVpq", // Replace with a real hash
                    RoleId = 1,
                    CreatedAt = DateTime.Parse("04/10/2025 15:37:57")
                },
                new User
                {
                    UserId = 2,
                    Username = "john_doe",
                    Email = "john@example.com",
                    PasswordHash = "$2y$10$mljmtXnFCZgMISnz6IFI5eZZMk03APF2Yz/t7mLnLy/ocgf7AaVpq", // Replace with a real hash
                    RoleId = 2,
                    CreatedAt = DateTime.Parse("04/10/2025 15:37:57")
                }
            );

            // Seed Categories
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Tech" },
                new Category { CategoryId = 2, CategoryName = "Music" },
                new Category { CategoryId = 3, CategoryName = "Health" }
            );

            // Seed Events
            modelBuilder.Entity<Event>().HasData(
                new Event
                {
                    EventId = 1,
                    Title = "Tech Conference 2025",
                    Description = "Annual tech conference with keynote speakers and workshops.",
                    Location = "Silicon Valley Convention Center",
                    StartDateTime = DateTime.Parse("04/30/2025 08:00:00"),
                    EndDateTime = DateTime.Parse("05/02/2025 15:00:00"),
                    MaxAttendees = 300,
                    CreatedBy = 1,
                    CreatedAt = DateTime.Parse("04/10/2025 15:37:57")
                },
                new Event
                {
                    EventId = 2,
                    Title = "Live Jazz Night",
                    Description = "Enjoy a night of live jazz performances.",
                    Location = "Downtown Jazz Club",
                    StartDateTime = DateTime.Parse("04/11/2025 19:00:00"),
                    CreatedBy = 1,
                    CreatedAt = DateTime.Parse("04/10/2025 15:37:57")
                }
            );

            // Seed RSVP
            modelBuilder.Entity<RSVP>().HasData(
                new RSVP
                {
                    RSVPId = 1,
                    UserId = 2,
                    EventId = 1,
                    RSVPDate = DateTime.Parse("04/10/2025 15:37:57")
                }
            );

            // Seed EventCategory
            modelBuilder.Entity<EventCategory>().HasData(
                new EventCategory { EventId = 1, CategoryId = 1 }, // Tech Conference → Tech
                new EventCategory { EventId = 2, CategoryId = 2 }  // Jazz Night → Music
            );

            // Define composite key for EventCategory
            modelBuilder.Entity<EventCategory>()
                .HasKey(ec => new { ec.EventId, ec.CategoryId });

            // Many-to-Many: Event ↔ Category
            modelBuilder.Entity<EventCategory>()
                .HasKey(ec => new { ec.EventId, ec.CategoryId });

            modelBuilder.Entity<EventCategory>()
                .HasOne(ec => ec.Event)
                .WithMany(e => e.EventCategories)
                .HasForeignKey(ec => ec.EventId);

            modelBuilder.Entity<EventCategory>()
                .HasOne(ec => ec.Category)
                .WithMany(c => c.EventCategories)
                .HasForeignKey(ec => ec.CategoryId);

            // User ↔ Role
            modelBuilder.Entity<User>()
                .HasOne(u => u.Role)
                .WithMany(r => r.Users)
                .HasForeignKey(u => u.RoleId);

            // Event ↔ Creator
            modelBuilder.Entity<Event>()
                .HasOne(e => e.Creator)
                .WithMany(u => u.CreatedEvents)
                .HasForeignKey(e => e.CreatedBy)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }

}
