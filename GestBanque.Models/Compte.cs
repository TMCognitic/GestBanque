namespace GestBanque.Models
{
    public abstract class Compte
    {
        public static double operator +(double solde, Compte courant)
        {
            return (solde < 0 ? 0 : solde) + (courant.Solde < 0 ? 0 : courant.Solde);
        }

        public string Numero { get; set; }
        public double Solde { get; private set; }
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

        public virtual void Retrait(double montant)
        {
            Retrait(montant, 0);
        }

        protected void Retrait(double montant, double ligneDeCredit)
        {
            if (montant <= 0)
            {
                Console.WriteLine("Montant invalide");
                return;
            }
            if (Solde - montant < -ligneDeCredit)
            {
                Console.WriteLine("Solde insuffisant");
                return;
            }

            Solde -= montant;
        }

        protected abstract double CalculInteret();

        public void AppliquerInteret()
        {
            Solde += CalculInteret();
        }
    }
}