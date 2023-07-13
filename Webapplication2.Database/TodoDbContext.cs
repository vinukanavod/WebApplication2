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

        public DbSet<Author> Authors { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectiongString = "Data Source=DESKTOP-0R2JABK;Initial Catalog=todoDB;Integrated Security=True;";
            optionsBuilder.UseSqlServer(connectiongString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Todoo>().HasData(new Todoo[]
            {
               new Todoo{ Id = 1,
                Title = "row 1 ",
                Description = " A",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = TodooStatus.High,
                AuthorId=1
               },
               new Todoo{ Id = 2,
                Title = "row 2",
                Description = " B",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(6),
                Status = TodooStatus.Middle,
                AuthorId=2
               },
               new Todoo{ Id = 3,
                Title = "row 3 ",
                Description = "C",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(7),
                Status = TodooStatus.High,
                AuthorId=3
               }
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
            modelBuilder.Entity<Author>().HasData(new Author[]
            {
                new Author {Id=1,FirstName="vinuka",LastName="navod"},
               new Author { Id= 2,FirstName="kavindu",LastName="hasintha"},
               new Author { Id=3,FirstName="pravindu",LastName="bhashitha"},
               new Author { Id=4,FirstName="Nethmi", LastName="anjani"},
               new Author { Id=5,FirstName="Nethmi" , LastName="Nishara"}
            }
                );
        }


    }
}
