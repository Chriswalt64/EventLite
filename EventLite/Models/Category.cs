using System.ComponentModel.DataAnnotations;

namespace EventLite.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        [Required, MaxLength(50)]
        public string CategoryName { get; set; }

        public ICollection<EventCategory> EventCategories { get; set; }
    }
}
