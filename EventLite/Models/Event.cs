using System.ComponentModel.DataAnnotations;

namespace EventLite.Models
{
    public class Event
    {
        public int EventId { get; set; }

        [Required, MaxLength(100)]
        public string Title { get; set; }

        public string Description { get; set; }

        [MaxLength(200)]
        public string Location { get; set; }

        public DateTime StartDateTime { get; set; }
        public DateTime? EndDateTime { get; set; }

        public int? MaxAttendees { get; set; }

        public int CreatedBy { get; set; }
        public User Creator { get; set; }

        public DateTime CreatedAt { get; set; }

        public ICollection<RSVP> RSVPs { get; set; }
        public ICollection<EventCategory> EventCategories { get; set; }
    }
}
