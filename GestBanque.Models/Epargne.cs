namespace GestBanque.Models
{
    public class Epargne : Compte
    {
        public DateTime DernierRetrait { get; private set; }

        public Epargne(string numero, Personne titulaire)
            : base (numero, titulaire)
        {
        }

        public Epargne(string numero, Personne titulaire, double solde, DateTime dernierRetrait)
            : base(numero, titulaire, solde)
        {
            DernierRetrait = dernierRetrait;
        }

        public override void Retrait(double montant)
        {
            double ancienSolde = Solde;
            base.Retrait(montant);

            if(ancienSolde != Solde)
            {
                DernierRetrait = DateTime.Now;
            }
        }

        protected override double CalculInteret()
        {
            return Solde * 0.045;
        }
    }
}
