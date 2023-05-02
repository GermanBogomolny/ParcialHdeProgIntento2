using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Stix.Models;

namespace Stix.Data
{
    public class RestaurantContext : DbContext
    {
        public RestaurantContext (DbContextOptions<RestaurantContext> options)
            : base(options)
        {
        }

        public DbSet<Stix.Models.Restaurant> Restaurant { get; set; } = default!;
        public DbSet<Stix.Models.Food> Food { get; set; } = default!;

    }
}
