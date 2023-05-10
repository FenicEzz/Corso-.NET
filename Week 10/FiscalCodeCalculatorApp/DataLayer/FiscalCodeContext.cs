using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DataLayer;

public class FiscalCodeContext : DbContext
{
    public FiscalCodeContext() : base() { }
    public FiscalCodeContext(DbContextOptions<FiscalCodeContext> options)
        : base(options)
    {
    }

    public virtual DbSet<User> Users { get; set; }
    public virtual DbSet<City> Cities { get; set; }

}
