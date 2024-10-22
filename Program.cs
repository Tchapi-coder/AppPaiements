using AppPaiements;
using System.Reflection.Metadata;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        CarteCredit carte1 = new CarteCredit(numeroCarte:1231,  montant: 12000,  description: "besoins urgents");
        CarteCredit carte2 = new CarteCredit(numeroCarte:1232,  montant: 13000,  description: "besoins de sante");
        CarteCredit carte3 = new CarteCredit(numeroCarte:1233,  montant: 14000, description: "besoins de formation");
        carte1.AfficherDetails();
        carte2.AfficherDetails();
        carte3.AfficherDetails();




    }
}