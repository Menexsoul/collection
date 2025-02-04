using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collection
{
    class Commande
    {
        public int IdCommande;
        public DateTime DateCommande;
        public List<LigneDeCommande> Lignes = new List<LigneDeCommande>();

        public Commande(int unIdCommande)
        {
            IdCommande = unIdCommande;
            DateCommande = DateTime.Now;
            Lignes = new List<LigneDeCommande>();
        }

        public void AjouterLigne(LigneDeCommande ligne)
        {
            Lignes.Add(ligne);
        }

        public decimal CalculerTotalCommande()
        {
            decimal total = 0;
            foreach (var ligne in Lignes)
            {
                total += ligne.CalculerTotal();
            }
            return total;
        }

        public override string ToString()
        {
            string recap = $"Commande ID: {IdCommande}, Date: {DateCommande}\n";
            foreach (var ligne in Lignes)
            {
                recap += ligne.ToString() + "\n";
            }
            recap += $"Total de la commande: {CalculerTotalCommande():C}";
            return recap;
        }
    }




}
