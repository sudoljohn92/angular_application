using api.Entities;
using Microsoft.EntityFrameworkCore;

namespace api.Data
{
    public class datacontext : DbContext
    {
        public datacontext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<AppUser> Users { get; set; }
    }
}