using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata;
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
        public DbSet<Todoomommy> Todoomommies { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectiongString = "Data Source=DESKTOP-0R2JABK;Initial Catalog=todoDB;Integrated Security=True;";
            optionsBuilder.UseSqlServer(connectiongString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Todoo>().HasData(new Todoo
            {
                Id = 2,
                Title = "Apatath Dawasaka Ira Payado hichchi putheeee.... ",
                Description = " siriyawathi gana",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = TodooStatus.High
            }

                );
            modelBuilder.Entity<Todoomommy>().HasData(new Todoomommy
            {
                 Id=3,
                 Description="Hello Machan KOhomada IThin.....",
                 Name="Vinuka Nvod",
                 number=0714703776
            }


                );
        }


    }
}
