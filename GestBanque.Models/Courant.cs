using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestBanque.Models
{
    public class Courant
    {
        //double <= double, Courant
        public static double operator+(double solde, Courant courant)
        {
            return (solde < 0 ? 0 : solde) + (courant.Solde < 0 ? 0 : courant.Solde);
        }


        private double _ligneDeCredit;
        public string Numero { get; set; }
        public double Solde { get; private set; }
        public double LigneDeCredit
        {
            get
            {
                return _ligneDeCredit;
            }

            set
            {
                if (value < 0)
                    return;

                _ligneDeCredit = value;
            }
        }
        public Personne Titulaire { get; set; }

        public void Depot(double montant)
        {
            if (montant <= 0)
            {
                Console.WriteLine("Montant invalide");
                return;
            }

            Solde += montant;
        }

        public void Retrait(double montant)
        {
            if (montant <= 0) 
            {
                Console.WriteLine("Montant invalide");
                return; 
            }
            if(Solde - montant < -LigneDeCredit) 
            {
                Console.WriteLine("Solde insuffisant");
                return; 
            }

            Solde -= montant;
        }
    }
}
