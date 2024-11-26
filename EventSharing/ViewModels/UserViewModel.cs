using System.ComponentModel.DataAnnotations;

namespace EventSharing.ViewModels
{
    public class UserViewModel
    {
        public string? Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public bool EmailConfirmed { get; set; }
    }
}
