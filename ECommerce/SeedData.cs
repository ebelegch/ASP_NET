using ECommerce.Models;
using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace ECommerce
{
    public class SeedData
    {
        public static void ImplementDatabase(IApplicationBuilder appBuilder)
        {
            // Récupération du contexte bdd
            ApplicationDbContext context = appBuilder.ApplicationServices.GetRequiredService<ApplicationDbContext>();

            // Migration afin de pouvoir ajouter des données
            context.Database.Migrate();

            // Vérification si il n'y a pas un context existant avec des produits initialisé
           
                // Construction de l'ensemble des produits
                context.Produits.AddRange(
                                   new Produit("sauvage", "un bon parfum", 50, "parfum"),
                                   new Produit("PS4", "une bonne console", 400, "console"),
                                   new Produit("Samsunsg A5", "un bon téléphone", 150, "téléphone"),
                                   new Produit("Audi 8", "une bonne voiture", 100000, "Voiture"),
                                   new Produit("un autre sauvage", "un bon parfum", 50, "parfum")
                                 
                    );

                context.SaveChanges();
            
        }
    }
}