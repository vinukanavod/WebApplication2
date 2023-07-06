using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace Webapplication2.Database
{
    public class TodoDbContext : DbContext
    {
        public DbSet<Todoo> Todos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectiongString = "Data Source=DESKTOP-0R2JABK;Initial Catalog=todoDB;Integrated Security=True;";
            optionsBuilder.UseSqlServer(connectiongString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Todoo>().HasData(new Todoo
            {
                Id = 1,
                Title = "Apatath Dawasaka Ira Payado",
                Description = "ME kathawen kiyawenne siriyawathi gana",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(7),
                Status = TodooStatus.High,
                Animal = apple.cat
            });
        }
    }
}
