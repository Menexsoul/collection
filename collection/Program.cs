using collection;

class Program
{
    static void Main()
    {
        Article article1 = new Article(1, "Ordinateur", "PC Gamer Haut de Gamme", 1500.00m);
        Article article2 = new Article(2, "Souris", "Souris ergonomique sans fil", 50.00m);
        Article article3 = new Article(3, "Clavier", "Clavier mécanique rétroéclairé", 100.00m);

        Commande commande = new Commande(101);

        commande.AjouterLigne(new LigneDeCommande(article1, 1));
        commande.AjouterLigne(new LigneDeCommande(article2, 2));
        commande.AjouterLigne(new LigneDeCommande(article3, 1));

        Console.WriteLine(commande);
    }
}