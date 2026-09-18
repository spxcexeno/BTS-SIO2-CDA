public class CompteEpargne : Compte
{
    public decimal TauxInteret { get; private set; }

    public CompteEpargne(decimal soldeInitial, string numeroCompte, string nomTitulaire, decimal tauxInteret)
        : base(soldeInitial, numeroCompte, nomTitulaire)
    {
        TauxInteret = tauxInteret;
    }


}