using Microsoft.AspNetCore.Identity;

namespace ParsiBin.Persistence.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public byte[]? ProfilePicture { get; set; }
        public bool IsActive { get; set; } = false;
        public DateTime PasswordChangeDate { get; set; }
        public bool IsPanelUser { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
