using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Models
{
    public class FauxDepotProduit : IProductRepository

    {
        private List<Produit> produits = new List<Produit>();

        public FauxDepotProduit()
        {
            Produit parfum = new Produit( "sauvage", "un bon parfum", 50, "parfum");
            Produit console = new Produit( "PS4", "une bonne console", 400, "console");
        

            produits.Add(parfum);
            produits.Add(console);
           
        }
        public IQueryable<Produit> Produits()
        {
            return  produits.AsQueryable();
        }
    }
}
