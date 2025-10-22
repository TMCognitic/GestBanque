// See https://aka.ms/new-console-template for more information

Banque banque = new Banque() { Nom = "TechnofuturBanking" };

Personne johnDoe = new Personne() 
{ 
    Nom = "Doe", 
    Prenom = "John", 
    DateNaiss = new DateTime(1970, 1, 1) 
};

Courant courant = new Courant()
{
    Numero = "0001",
    LigneDeCredit = 300,
    Titulaire = johnDoe
};

banque.Ajouter(courant);

Console.WriteLine($"Depot de -100");
banque["0001"].Depot(-100);
Console.WriteLine($"Nouveau solde : {courant.Solde}");
Console.WriteLine($"Depot de 100");
banque["0001"].Depot(100);
Console.WriteLine($"Nouveau solde : {courant.Solde}");
Console.WriteLine($"Retrait de -100");
banque["0001"].Retrait(-100);
Console.WriteLine($"Nouveau solde : {courant.Solde}");
Console.WriteLine($"Retrait de 300");
banque["0001"].Retrait(300);
Console.WriteLine($"Nouveau solde : {courant.Solde}");
Console.WriteLine($"Retrait de 500");
banque["0001"].Retrait(500);
Console.WriteLine($"Nouveau solde : {courant.Solde}");