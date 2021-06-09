using APIDemo.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIDemo.Data
{
    public class DBInitializer
    {
        public static class DbInitializer
        {
            public static void Initialize(Context context)
            {
                context.Database.EnsureCreated();

                // Look for any users.
                if (context.Users.Any())
                {
                    return;   // DB has been seeded
                }

                var users = new User[]
                {
                    new User{FirstName="Timmy", LastName="Turner", Age=11, Address="360 Circle Lane", Interests="Baseball, Gardening" },
                    new User{FirstName="Jimmy", LastName="Neutron", Age=15, Address="180 Semi Street", Interests="Robotics, Running" },
                    new User{FirstName="Spongebob", LastName="Squarepants", Age=20, Address="123 ABC Drive", Interests="Cooking, Working" }
                };
                foreach (User u in users)
                {
                    context.Users.Add(u);
                }
                context.SaveChanges();
            }
        }
    }
}
