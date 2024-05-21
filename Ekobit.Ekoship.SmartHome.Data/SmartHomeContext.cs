﻿using Ekobit.Ekoship.SmartHome.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Ekobit.Ekoship.SmartHome.Data
{
    public class SmartHomeContext : DbContext
    {
        public SmartHomeContext(DbContextOptions<SmartHomeContext> options) : base(options)
        { }

        public DbSet<Home> Homes { get; set; } = null!;

        public DbSet<Address> Addresses { get; set; } = null!;
    }
}
