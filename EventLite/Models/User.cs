using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace EventLite.Models
{
    public class User
    {
        public int UserId { get; set; }

        [Required, MaxLength(50)]
        public string Username { get; set; }

        [Required, MaxLength(100)]
        public string Email { get; set; }

        [Required]
        public string PasswordHash { get; set; }

        public int RoleId { get; set; }
        public Role Role { get; set; }
        public DateTime CreatedAt { get; set; }

        public ICollection<RSVP> RSVPs { get; set; }
        public ICollection<Event> CreatedEvents { get; set; }
    }
}
