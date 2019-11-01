using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using OpenProjectIntegrationClassLibrary.Configurations;

namespace OpenProjectDataContext
{
    public class OpenProjectContext:DbContext
    {
        public OpenProjectContext(DbContextOptions<OpenProjectContext> options) : base(options)
        {
        }

        public DbSet<Configuration> Configurations { get; set; }
        public DbSet<UserSystem> UserSystems { get; set; }
    }
}
