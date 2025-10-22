// See https://aka.ms/new-console-template for more information

using GestBanque.Models.Divers;

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

Courant courant2 = new Courant()
{
    Numero = "0002",
    LigneDeCredit = 300,
    Titulaire = johnDoe
};

banque.Ajouter(courant);
banque.Ajouter(courant2);

Console.WriteLine($"Depot de -100");
banque["0001"].Depot(-100);
Console.WriteLine($"Nouveau solde : {banque["0001"].Solde}");
Console.WriteLine($"Depot de 100");
banque["0001"].Depot(100);
Console.WriteLine($"Nouveau solde : {banque["0001"].Solde}");
Console.WriteLine($"Retrait de -100");
banque["0001"].Retrait(-100);
Console.WriteLine($"Nouveau solde : {banque["0001"].Solde}");
Console.WriteLine($"Retrait de 300");
banque["0001"].Retrait(300);
Console.WriteLine($"Nouveau solde : {banque["0001"].Solde}");
Console.WriteLine($"Retrait de 500");
banque["0001"].Retrait(500);
Console.WriteLine($"Nouveau solde : {banque["0001"].Solde}");

Console.WriteLine($"Depot de 1000");
banque["0002"].Depot(1000);
Console.WriteLine($"Nouveau solde : {banque["0002"].Solde}");

Console.WriteLine($"Avoir des compte de {johnDoe.Prenom} {johnDoe.Nom} : {banque.AvoirDesComptes(johnDoe)}");






//Autres Opérateur de cast
Celsius celsius = new Celsius() { Temperature = 30 };
Fahrenheit fahrenheit = celsius;
celsius = (Celsius)fahrenheit;

Console.WriteLine($"{celsius.Temperature}°c => {fahrenheit.Temperature}°f");