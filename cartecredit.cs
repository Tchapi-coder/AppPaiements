using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AppPaiements
{
    internal class CarteCredit : Paiement
    {
        public int NumeroCarte { get; set; }


        public CarteCredit(int numeroCarte, double montant, String description) : base(montant, description)
        {
            NumeroCarte = numeroCarte;

        }
        public override void AfficherDetails()
        {
            Console.WriteLine($"numeroCarte: {NumeroCarte} ,montant: {Montant}, description:{Description}");

        }
    }
    

}

 