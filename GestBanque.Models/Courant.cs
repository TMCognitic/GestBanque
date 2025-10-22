﻿namespace GestBanque.Models
{
    public class Courant : Compte
    {
        private double _ligneDeCredit;
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

        public override void Retrait(double montant)
        {
            Retrait(montant, LigneDeCredit);
        }

        protected override double CalculInteret()
        {
            return Solde * ((Solde < 0) ? 0.0975 : 0.03);
        }
    }
}
