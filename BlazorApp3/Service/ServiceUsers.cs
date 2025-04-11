using BlazorApp3.Modalss;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp3.Service
{
    public class ServiceUsers
    {
        private readonly FailDbContext _context;

        public ServiceUsers (FailDbContext context)
        {
            _context = context;
        }

        public async Task<List<Users>> GetUsersAsync()
        {
            var users = await _context.Users.ToListAsync();
            return users;
        }
    }
}
