using Microsoft.EntityFrameworkCore;
using NutritionalValueAPI;
using System.Collections.Generic;

namespace NutritionalValueAPI.Controllers.Data
{
    public class DataContext : DbContext    
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<NutritionalValue> NutritionalValues => Set<NutritionalValue>();
    }
}
