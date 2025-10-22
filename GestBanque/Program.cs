// See https://aka.ms/new-console-template for more information
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

Console.WriteLine($"Depot de -100");
courant.Depot(-100);
Console.WriteLine($"Nouveau solde : {courant.Solde}");
Console.WriteLine($"Depot de 100");
courant.Depot(100);
Console.WriteLine($"Nouveau solde : {courant.Solde}");
Console.WriteLine($"Retrait de -100");
courant.Retrait(-100);
Console.WriteLine($"Nouveau solde : {courant.Solde}");
Console.WriteLine($"Retrait de 300");
courant.Retrait(300);
Console.WriteLine($"Nouveau solde : {courant.Solde}");
Console.WriteLine($"Retrait de 500");
courant.Retrait(500);
Console.WriteLine($"Nouveau solde : {courant.Solde}");