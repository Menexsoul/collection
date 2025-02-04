using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collection
{
    class Article
    {
        public int Id;
        public string nom;
        public string description;
        public decimal prixUnitaire;


        public Article(int unId, string unNom, string uneDescription, decimal unPrixUnitaire)
        {
            Id = unId;
            nom = unNom;
            description = uneDescription;
            prixUnitaire = unPrixUnitaire;
        }

        public string ToString()
        {
            return $" Article : {Id} {nom} {description} {prixUnitaire}";
        }


    }
}
