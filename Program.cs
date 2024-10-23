using AppPaiements;
using System.Reflection.Metadata;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        //creation des instances cartes de credit et affichage a l ecran
        CarteCredit carte1 = new CarteCredit(numeroCarte:1231,  montant: 12000,  description: "besoins urgents");
        CarteCredit carte2 = new CarteCredit(numeroCarte:1232,  montant: 13000,  description: "besoins de sante");
        CarteCredit carte3 = new CarteCredit(numeroCarte:1233,  montant: 14000, description: "besoins de formation");
        carte1.AfficherDetails();
        carte2.AfficherDetails();
        carte3.AfficherDetails();

    // creation des instances pour les comptes paypal et affichage a  l ecran
        Paypal compte1 = new Paypal(email: "tchapi1@gmail.com", montant: 12500, description: "achat en ligne");
        Paypal compte2 = new Paypal(email: "tchapi2@gmail.com", montant: 13500, description: "facture en ligne");
        compte1.AfficherDetails();
        compte2.AfficherDetails();

        // creation d une instance utilisateur 
        Utilisateur utilisateur1 = new Utilisateur(Nom: "Ingrid");
        utilisateur1.AjouterPaiements(carte1);
        utilisateur1.AjouterPaiements(carte2);
        utilisateur1.AjouterPaiements(carte3);
        utilisateur1.AjouterPaiements(compte1);
        utilisateur1.AjouterPaiements(compte2);
        utilisateur1.AfficherInfos();








    }
}