using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Models
{
    public class NewsContext : DbContext
    {
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<NewsKategori> Kategori { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=News;Trusted_Connection=True;");
            }
        }
        public NewsContext()
        {

        }

        public NewsContext(DbContextOptions<NewsContext> options) : base(options)
        {
        }

        public DbSet<WebApplication2.Models.Question> Question { get; set; }
    }
}
