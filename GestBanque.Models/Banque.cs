namespace GestBanque.Models
{
    public class Banque
    {
        private Dictionary<string, Compte> _comptes = new Dictionary<string, Compte>();

        public string Nom { get; set; }

        public Compte this[string key]
        {
            get { return _comptes[key]; }
        }

        public void Ajouter(Compte courant)
        {
            _comptes.Add(courant.Numero, courant);
        }

        public void Supprimer(string numero)
        {
            _comptes.Remove(numero);
        }

        public double AvoirDesComptes(Personne titulaire)
        {
            double total = 0;

            foreach(Compte compte in _comptes.Values)
            {
                if(compte.Titulaire == titulaire)
                {
                    total += compte;                    
                }
            }
            return total;
        }
    }
}
