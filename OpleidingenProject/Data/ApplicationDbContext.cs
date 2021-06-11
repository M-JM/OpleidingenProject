using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OpleidingenProject.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpleidingenProject.Data
{
    public class ApplicationDbContext : IdentityDbContext<CustomUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Categorie> Categorieen { get; set; }

        public DbSet<Inschrijving> Inschrijvingen { get; set; }

        public DbSet<Opleiding> Opleidingen { get; set; }

        public DbSet<Sessie> Sessies { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /* Omdat één van de vereiste soft deletes zijn en ik standaard geen verwijderde entries will tonen 
             * maak ik gebruik van Built-in EF Query filters die ervoor zullen zorgen dat elke Linq query automatisch geen rekening hou met entries
             * waar isdeleted == false*/

            /* Indien ik toch de verwijderde gegevens wil ophalen zal ik gewoon de built-in method "IgnoreQueryFilters()" aan mijn query toevoegen*/


            modelBuilder.Entity<Categorie>()
            .HasQueryFilter(categorie => EF.Property<bool>(categorie, "IsDeleted") == false);

            modelBuilder.Entity<Inschrijving>()
            .HasQueryFilter(inschrijving => EF.Property<bool>(inschrijving, "IsDeleted") == false);

            modelBuilder.Entity<Opleiding>()
            .HasQueryFilter(opleiding => EF.Property<bool>(opleiding, "IsDeleted") == false);

            modelBuilder.Entity<Sessie>()
            .HasQueryFilter(sessie => EF.Property<bool>(sessie, "IsDeleted") == false);


            base.OnModelCreating(modelBuilder);

            modelBuilder.Seed();
        }



    }
}
