namespace GestBanque.Models
{
    public class Epargne : Compte
    {
        public DateTime DernierRetrait { get; set; }

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
