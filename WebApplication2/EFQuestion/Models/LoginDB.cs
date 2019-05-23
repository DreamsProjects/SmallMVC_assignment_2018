using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFQuestion.Models
{
    public class LoginDB : DbContext
    {

        public LoginDB(DbContextOptions<LoginDB> options)
            : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=EFQuestions;Trusted_Connection=True;");
            }
        }


        public DbSet<UserLogin> Users { get; set; }

    }
}
