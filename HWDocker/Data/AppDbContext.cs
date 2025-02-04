using Microsoft.EntityFrameworkCore;
using HWDocker.Models;
using System.Collections.Generic;

namespace HWDocker.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<MenuItem> MenuItems => Set<MenuItem>();
}
