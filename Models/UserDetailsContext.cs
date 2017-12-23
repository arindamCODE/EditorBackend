using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Models
{
    public class UserDetailsContext : DbContext
    {
        public UserDetailsContext(DbContextOptions<UserDetailsContext> options)
            : base(options)
        {

        }

        /* public DbSet<ContentTable> ContentTable { get; set;}  */
        public DbSet<UserDetails> UserDetails { get; set; }

    }
}