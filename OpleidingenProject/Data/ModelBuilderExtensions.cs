using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using OpleidingenProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpleidingenProject.Data
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Categorie>().HasData(
                new Categorie(1, "Retail banking", false),
                new Categorie(2, "Verzekeringen", false),
                new Categorie(3, "Kredieten", false),
                new Categorie(4, "Duurzaamheid", false),
                new Categorie(5, "Boekhouding", false),
                new Categorie(6, "Corporate Banking", false)
                );

            modelBuilder.Entity<Opleiding>().HasData(
                new Opleiding(1,"Verzekeringen voor beginners","Korte introductie tot de wereld van verzekeringen", NiveauOpleiding.Beginner, Talen.Engels,60,false,2),
                new Opleiding(2, "Kredieten voor beginners", "Korte introductie tot de wereld van kredieten", NiveauOpleiding.Beginner, Talen.Frans, 20, false, 3),
                new Opleiding(3, "Duurzaamheid, de wereld van morgen", "Duurzaam investeren is de toekomst.", NiveauOpleiding.Gevorderd, Talen.Nederlands, 50, false, 4),
                new Opleiding(4, "Kapitaal en markten", "Intensieve opleiding gaande van FX naar cash management", NiveauOpleiding.Intermediair, Talen.Engels, 100, false, 6),
                new Opleiding(5, "Fiscaliteit en boekhouding", "Opleiding voor professionelen ", NiveauOpleiding.Gevorderd, Talen.Frans, 60, false, 5)
                ); ;

            modelBuilder.Entity<Sessie>().HasData(
                new Sessie(1, 20, LeerVorm.Afstandsonderwijs, 250, DateTime.Now.AddDays(4), DateTime.Now.AddDays(10), false, 1),
                new Sessie(2, 40, LeerVorm.Online, 150, DateTime.Now.AddDays(2), DateTime.Now.AddDays(7), false, 1),
                new Sessie(3, 50, LeerVorm.Online, 150, DateTime.Now.AddDays(8), DateTime.Now.AddDays(14), false, 1),
                new Sessie(4, 15, LeerVorm.Afstandsonderwijs, 102, DateTime.Now.AddDays(6), DateTime.Now.AddDays(20), false, 1),
                new Sessie(5, 5, LeerVorm.BlendedLearning, 658, DateTime.Now.AddDays(10), DateTime.Now.AddDays(40), false, 2),
                new Sessie(6, 30, LeerVorm.Klassikaal, 850, DateTime.Now.AddDays(12), DateTime.Now.AddDays(25), false, 2),
                new Sessie(7, 18, LeerVorm.Afstandsonderwijs, 150, DateTime.Now.AddDays(8), DateTime.Now.AddDays(19), false, 2),
                new Sessie(8, 10, LeerVorm.Klassikaal, 480, DateTime.Now.AddDays(7), DateTime.Now.AddDays(18), false, 3),
                new Sessie(9, 18, LeerVorm.BlendedLearning, 455, DateTime.Now.AddDays(6), DateTime.Now.AddDays(20), false, 3),
                new Sessie(10, 30, LeerVorm.Afstandsonderwijs, 846, DateTime.Now.AddDays(9), DateTime.Now.AddDays(15), false, 4),
                new Sessie(11, 50, LeerVorm.Online, 975, DateTime.Now.AddDays(10), DateTime.Now.AddDays(19), false, 5),
                new Sessie(12, 40, LeerVorm.Afstandsonderwijs, 105, DateTime.Now.AddDays(15), DateTime.Now.AddDays(20), false, 5),
                new Sessie(13, 60, LeerVorm.Klassikaal, 804, DateTime.Now.AddDays(20), DateTime.Now.AddDays(25), false, 5),
                new Sessie(14, 80, LeerVorm.Online, 642, DateTime.Now.AddDays(40), DateTime.Now.AddDays(80), false, 5));
        }




    }
}
