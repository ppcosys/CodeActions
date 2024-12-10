using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            if (context.Events.Any()) return;
            
            var events = new List<Event>
            {
                new Event
                {
                    Title = "DevDays Europe",
                    Date = DateTime.UtcNow.AddMonths(1),
                    Description = "Activity 1 month in future",
                    Category = "Dev",
                    City = "Vilnius",
                    Country = "Lithuania",
                    Venue = "LITEXPO Conference Center",
                },
                new Event
                {
                    Title = "Microsoft Conference",
                    Date = DateTime.UtcNow.AddMonths(-1),
                    Description = "Activity 1 month ago",
                    Category = "Dev",
                    City = "Warsaw",
                    Country = "Poland",
                    Venue = "PGE National Stadium",
                },          
                new Event
                {
                    Title = "DevOps Meeting",
                    Date = DateTime.UtcNow.AddMonths(2),
                    Description = "Activity 2 months in future",
                    Category = "DevOps",
                    City = "London",
                    Country = "UK",
                    Venue = "O2 Arena",
                },
                new Event
                {
                    Title = "AI Summit New York",
                    Date = DateTime.UtcNow.AddMonths(3),
                    Description = "Activity 3 months in future",
                    Category = "AI",
                    City = "New York",
                    Country = "USA",
                    Venue = " Javits Center",
                }
            };

            await context.Events.AddRangeAsync(events);
            await context.SaveChangesAsync();
        }
    }
}