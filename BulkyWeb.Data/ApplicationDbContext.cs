using BulkyWeb.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyWeb.Data
{
    public  class ApplicationDbContext : DbContext
    {
        //esta configuracion se nesesita para entity framework
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        //aqui se ponen para crear las tablas 
        public DbSet<Category> Categories { get; set; }

        //sembraremos datos 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //sembrado de datos 
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Acción",
                    DisplayOrder = 1

                  
                },
                new Category
                {
                    Id=2,Name="Ciencia",DisplayOrder = 2
                },
                new Category
                {
                    Id=3,Name="Tecnologia",DisplayOrder=3
                }
                );
                
            
                
        }

    }
}
