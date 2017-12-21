using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Models
{
    public class Produit
    {
        [Key]
        public int IDProduit { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public float Prix { get; set; }

        public string  Categorie  { get; set; }


        public Produit( string name, string description, float prix, string catégorie)
        {
            Name = name;
            Description = description;
            Prix = prix;
            Categorie = catégorie;
        }
        public Produit()
        {

        }

    }
}
