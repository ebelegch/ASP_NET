using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Models
{
    public class EFProductRepository : IProductRepository
    {
        private ApplicationDbContext context;

        public IQueryable<Produit> Products => context.Produits;
        

        public EFProductRepository(ApplicationDbContext ctx)//Constructeur qui positionne le contexte
        {
            context = ctx;
        }

        public IQueryable<Produit> Produits()
        {
            return context.Produits;
        }
    }
}
