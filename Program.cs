decimal solde = 1000m;
decimal montant = -520.3m;

if (montant > 0)
{
    solde = Crediter(solde, montant);
}
else if (montant < 0)
{
    decimal debit = -montant;
    if (debit <= solde)
    {
        solde = Debiter(solde, debit);
    }
    else
    {
        Console.WriteLine("Solde insuffisant.");
    }
}

Console.WriteLine($"Votre solde est de {solde}.");

static decimal Crediter(decimal solde, decimal montant)
{
    if (montant <= 0)
    {
        Console.WriteLine("Le montant du crédit doit être positif.");
        return solde;
    }

    return solde + montant;
}

static decimal Debiter(decimal solde, decimal montant)
{
    if (montant <= 0)
    {
        Console.WriteLine("Le montant du débit doit être positif.");
        return solde;
    }

    if (montant > solde)
    {
        Console.WriteLine("Solde insuffisant.");
        return solde;
    }

    return solde - montant;
}



var compte = new Compte(12345, "John Doe");
Console.WriteLine($"Compte n°{compte.NumeroCompte}, titulaire : {compte.NomTitulaire}, solde : {compte.Solde}");
compte.Crediter(500m);
compte.Debiter(200m);
compte.AfficherSolde();


public class Compte
{
    public decimal Solde { get; private set; }
    public decimal NumeroCompte { get; private set; }
    public string NomTitulaire { get; private set; }

    public Compte(int numeroCompte, string nomTitulaire)
    {
        Solde = 0m;
        NumeroCompte = numeroCompte;
        NomTitulaire = nomTitulaire;
    }

    public void Crediter(decimal montant)
    {
        if (montant <= 0)
        {
            Console.WriteLine("Le montant du crédit doit être positif.");
            return;
        }

        Solde += montant;
    }
    public void Debiter(decimal montant)
    {
        if (montant <= 0)
        {
            Console.WriteLine("Le montant du débit doit être positif.");
            return;
        }

        if (montant > Solde)
        {
            Console.WriteLine("Solde insuffisant.");
            return;
        }

        Solde -= montant;
    }

    public void AfficherSolde()
    {
        Console.WriteLine($"Votre solde est de {Solde}.");
    }

}

