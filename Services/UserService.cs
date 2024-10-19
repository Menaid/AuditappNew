using AuditappNew.Data;
using AuditappNew.Models;

namespace AuditappNew.Services
{
    public class UserService
    {
        private readonly AppDbContext _context;

        public UserService ( AppDbContext context )
        {
            _context = context;
        }

        public Task<List<User>> GetAllUsersAsync ( )
        {
            return _context.GetUsersAsync ( );
        }

        public Task<User> GetUserByIdAsync ( int id )
        {
            return _context.GetUserAsync ( id );
        }

        public Task<int> CreateUserAsync ( User user )
        {
            return _context.SaveUserAsync ( user );
        }

        public Task<int> UpdateUserAsync ( User user )
        {
            return _context.SaveUserAsync ( user );
        }

        public Task<int> DeleteUserAsync ( User user )
        {
            return _context.DeleteUserAsync ( user );
        }
    }
}