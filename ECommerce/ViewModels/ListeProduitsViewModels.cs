using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerce.Models;

namespace ECommerce.ViewModels
{
    public class ListeProduitsViewModels
    {
        public PaginationInfo informations;
        public IQueryable<Produit> liste;

        
    }
}
