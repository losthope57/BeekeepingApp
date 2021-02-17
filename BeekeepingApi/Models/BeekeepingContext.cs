﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeekeepingApi.Models
{
    public class BeekeepingContext : DbContext
    {
        public BeekeepingContext(DbContextOptions<BeekeepingContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}