﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Models
{
    public interface IProductRepository
    {
          IQueryable<Produit> Produits();
       
    }
}
