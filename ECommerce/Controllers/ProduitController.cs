using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ECommerce.Models;
using ECommerce.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ECommerce.Controllers
{
    public class ProduitController : Controller
    {
        private IProductRepository myObj;
        public ListeProduitsViewModels listeProduitViewModels;

        public ProduitController(IProductRepository produit)
        {
            myObj = produit;

        }

        public ViewResult list ( int? id, int? page)
        {
            //IQueryable<Produit> laliste = myObj.Produits();
            IQueryable<Produit> laliste = listeProduitViewModels.liste;

            if (!(id == null))
            {
                return View(myObj.Produits().Where(t => t.IDProduit == id));
               
            }
            else if (!(page==null))
            {
                laliste=laliste.Skip((page.Value-1)*3).Take(3);
                return View(laliste);
            }
            else
            {
                return View(laliste);

            }

        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
    }
}
