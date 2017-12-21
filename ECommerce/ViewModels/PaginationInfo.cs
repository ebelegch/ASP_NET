using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.ViewModels
{
    public class PaginationInfo
    {
        public int? NombreProduits { get; set; }

        public int? ProduitsParPage { get; set; }

        public int? PageCourante { get; set; }

        public PaginationInfo(int? nombreProduits, int? produitsParPage, int? pageCourante)
        {
            NombreProduits = nombreProduits;
            ProduitsParPage = produitsParPage;
            PageCourante = pageCourante;
        }


    }
}