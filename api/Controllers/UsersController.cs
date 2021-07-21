using Microsoft.AspNetCore.Mvc;
using api.Data;
using System.Collections.Generic;
using api.Entities;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace api.Controllers
{
    public class UsersController : BaseApiController
    {
        private readonly datacontext _context;
        public UsersController(datacontext context)
        {
            _context = context;
        }


        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
            return await _context.Users.ToListAsync();
        }

        [Authorize]
        [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> GetUser(int id)
        {
            return await _context.Users.FindAsync(id);
        }
    }
}