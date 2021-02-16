using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SVR___Sajermann_Vehicle_Reservations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SVR___Sajermann_Vehicle_Reservations.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {

        svrContext _context = new svrContext();


        [HttpGet]
        async public Task<List<User>> User()
        {
            return await _context.Users.ToListAsync();

        }
    }
}
