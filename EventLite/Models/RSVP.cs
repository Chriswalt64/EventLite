namespace EventLite.Models
{
    public class RSVP
    {
        public int RSVPId { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public int EventId { get; set; }
        public Event Event { get; set; }

        public DateTime RSVPDate { get; set; }
    }
}
