var compte1 = new Compte(1000m, "FR001", "Alice");
var compte2 = compte1;

compte2.Crediter(500m);

Console.WriteLine(compte1.Solde);
