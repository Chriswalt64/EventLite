using System.ComponentModel.DataAnnotations;

namespace EventLite.Models
{
    public class Role
    {
        public int RoleId { get; set; }

        [Required, MaxLength(50)]
        public string RoleName { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
