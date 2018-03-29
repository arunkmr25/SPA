using System.Collections.Generic;
using System.Threading.Tasks;
using connections.Model;
using Microsoft.EntityFrameworkCore;

namespace connections.Data.connectionRep
{
    public class connection : IConnection
    {
         private readonly DataContext _context;
        public connection(DataContext context)
        {
            _context = context;

        }
        public void Add<T>(T entity) where T : class
        {
            throw new System.NotImplementedException();
        }

        public void Delete<T>(T entity) where T : class
        {
            throw new System.NotImplementedException();
        }

       public async Task<User> GetUser(int id)
        {
            var users = await _context.Users.Include(p => p.Photos).FirstOrDefaultAsync(u => u.Id == id);
            return users;
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            var users = await _context.Users.Include(p => p.Photos).ToListAsync();
            return users;
        }

        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}