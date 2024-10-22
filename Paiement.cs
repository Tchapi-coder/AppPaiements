using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPaiements
{
    internal class Paiement
    {
        // creation des proprietes 
        public double Montant { get; set; }
        public string Description { get; set; }

        // creation du constructeur
        public Paiement(int montant, string description)
        {
            Montant = montant;
            Description = description;

        }
        // methode afficher 
        public virtual void AfficherDetails()
        {
            Console.WriteLine($"montant: {Montant}, description:{Description}");
        }

    }
}
