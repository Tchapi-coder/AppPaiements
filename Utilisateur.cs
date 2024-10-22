using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPaiements
{
    internal class Utilisateur
    {
        public string Nom { get; set; }
        public List<Paiement> Paiements { get; set; }
        public Utilisateur(string Nom)
        {
            Nom = Nom;
            Paiements = new List<Paiement>();
        }
        public void AfficherInfos()
        {
            Console.WriteLine($"Nom:{Nom}");
            foreach (Paiement p in Paiements)
            {
                p.AfficherDetails();

            }

        }
        public void AjouterPaiements(Paiement paiement)
        {
            Paiements.Add(paiement);
        }
    }
}
        
