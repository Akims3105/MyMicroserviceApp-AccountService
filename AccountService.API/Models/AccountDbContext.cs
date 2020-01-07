using AccountService.API.Models.DbEnities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccountService.API.Models
{
    public class AccountDbContext : DbContext
    {
        public AccountDbContext() : base() { }
        public AccountDbContext(DbContextOptions options) : base(options) { }

        public DbSet<User> Users { get; set;}

    }
}
