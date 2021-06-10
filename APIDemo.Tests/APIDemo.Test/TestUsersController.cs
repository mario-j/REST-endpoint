using APIDemo.Controllers;
using APIDemo.Data;
using APIDemo.Data.Models;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using static APIDemo.Data.DBInitializer;

namespace APIDemo.Test
{
    [TestClass]
    public class TestUsersController
    { 

        [TestMethod]
        public void TestUserController()
        {
            var host = CreateWebHostBuilder(null).Build();

            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var context = services.GetRequiredService<Context>();
                    DbInitializer.Initialize(context);
                    var usersController = new UsersController(context);

                    // Search endpoint
                    var searchResult = usersController.SearchUsers("immy");
                    Assert.IsNotNull(searchResult.Value);
                    Assert.AreEqual(searchResult.Value.Count(), 2); //Initial seeded DB has 2 Users containing 'immy'

                    // Add endpoint
                    var newUser = new User { UserId = 4, FirstName = "Donald", LastName = "Duck", Address = "720 Isometric Plaza", Age = 33, Interests = "Whistling, Waddling" };
                    var originalCount = context.Users.Count();
                    var searchNewUserResult = usersController.SearchUsers("Duck");
                    var newUserCount = context.Users.Count();
                    Assert.IsTrue(originalCount + 1 == newUserCount);
                    Assert.IsNotNull(searchNewUserResult);
                    Assert.AreEqual(searchNewUserResult.Value.Count(), 1);
                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occurred creating the DB.");
                }
            }
        }


        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();

    }


}
