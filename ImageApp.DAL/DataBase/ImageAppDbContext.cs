﻿using ImageApp.DAL.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ImageApp.DAL.DataBase
{
    public class ImageAppDbContext : IdentityDbContext<User, IdentityRole, string>
    {
        public ImageAppDbContext(DbContextOptions<ImageAppDbContext> options)
          : base(options)
        {

        }
        public DbSet<Picture> Pictures { get; set; }

    }
}
