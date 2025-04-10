namespace EventLite.Models
{
    public class EventCategory
    {
        public int EventId { get; set; }
        public Event Event { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
