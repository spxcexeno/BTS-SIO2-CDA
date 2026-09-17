var compte1 = new Compte(500m, 12345, "John Doe");   // solde initial = 500
var compte2 = new Compte(67890, "Jane Doe");         // pas de solde -> 0
Console.WriteLine($"Compte n°{compte1.NumeroCompte}, titulaire : {compte1.NomTitulaire}, solde : {compte1.Solde}");
compte1.Crediter(500m);
compte1.Debiter(200m);
compte1.AfficherSolde();
Console.WriteLine($"Compte n°{compte2.NumeroCompte}, titulaire : {compte2.NomTitulaire}, solde : {compte2.Solde}");
compte2.AfficherSolde();