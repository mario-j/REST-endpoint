using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIDemo.Data;
using APIDemo.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APIDemo.Controllers
{
    public class UsersController : Controller
    {

        private readonly Context _context;

        public UsersController(Context context)
        {
            _context = context;
        }


        //Return users with first or last name's matching 'input' to endpoint
        [HttpGet("search/{input}")]
        public ActionResult<List<User>> SearchUsers(string input)
        {
            return _context.Users.Where(user => user.FirstName.Contains(input) || user.LastName.Contains(input)).ToList();
        }

        // Add a new user to the DB  
        [HttpPost("add")]
        public void AddUser([FromBody] User user)
        {
            try
            {
                using (var transaction = _context.Database.BeginTransaction())
                {
                    _context.Add(user);
                    _context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[User] ON;");
                    _context.SaveChanges();
                    _context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[User] OFF");
                    transaction.Commit();
                }
            }
            catch(Exception ex)
            {

            }
        }
    }
}
