using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace RestAPI.Model.Models;

public partial class SampleRestApiContext : DbContext
{
    DbSet<Product> Products { get; set; }
    DbSet<Brand> Brands { get; set; }


    public SampleRestApiContext()
    {
    }

    public SampleRestApiContext(DbContextOptions<SampleRestApiContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source=.\\TEST_INSTANCE;Initial Catalog=SampleRestAPI;Integrated Security=True;Pooling=False;Encrypt=True;Trust Server Certificate=True");

}
