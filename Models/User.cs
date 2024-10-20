using SQLite;

namespace AuditappNew.Models
{
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string? Username { get; set; }
        public string? Email { get; set; }
        public string? PasswordHash { get; set; }
        public DateTime CreatedAt { get; set; }
        public string? Company { get; set; }
        public UserRole Role { get; set; }
        public AccessLevel AccessLevel { get; set; }
    }

    public enum UserRole
    {
        Customer,
        Consultant,
        Administrator
    }

    public enum AccessLevel
    {
        Basic,
        Extended,
        Full
    }
}