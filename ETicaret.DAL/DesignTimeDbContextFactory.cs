using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace ETicaret.DAL
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ETicaretContext>
    {
        public ETicaretContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ETicaretContext>();
            var connectionString = ".;Database=ETicaretDB;Trusted_Connection=True;MultipleActiveResultSets=true";
            builder.UseSqlServer(connectionString);
            return new ETicaretContext(builder.Options);
        }
    }
}
