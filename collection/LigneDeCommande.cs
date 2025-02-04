using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collection
{
    class LigneDeCommande
    {
        public Article ArticleCommande;
        public int Quantite;

        public LigneDeCommande(Article unArticle, int uneQuantite)
        {
            ArticleCommande = unArticle;
            Quantite = uneQuantite;
        }


        public decimal CalculerTotal()
        {
            return Quantite * ArticleCommande.prixUnitaire;
        }

        public override string ToString()
        {
            return $"Article: {ArticleCommande.nom}, Quantité: {Quantite}, Total: {CalculerTotal():C}";
        }
    }
}
