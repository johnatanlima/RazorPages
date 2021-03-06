﻿using Microsoft.EntityFrameworkCore;
using MyPages.Models;

namespace MyPages.Data
{
    public class MyPagesContext : DbContext
    {
        public MyPagesContext (DbContextOptions<MyPagesContext> options)
            : base(options)
        {
        }

        public DbSet<MoviesModel> Movies { get; set; }
    }
}
