using Microsoft.EntityFrameworkCore;
using Photography.Models;
using System;


namespace Photography.Data
{
    public class SocialPhotographyNetworkContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("SERVER=localhost; DATABASE=photography-db;UID=root;PWD=password364824672483472463264873264782648;PORT=;");

        }

    }
}
