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

        public Courant(string numero, Personne titulaire) :
            base(numero, titulaire)
        {
        }

        public Courant(string numero, Personne titulaire, double solde)
            : base(numero, titulaire, solde)
        {
        }

        //Attention changement de l'ordre des paramètres pour avoir une surcharge de méthode valide
        public Courant(string numero, double ligneDeCredit, Personne titulaire)
            : base(numero, titulaire)
        {
            LigneDeCredit = ligneDeCredit;
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
