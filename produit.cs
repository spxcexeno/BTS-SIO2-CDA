public class Produit
{
    public string réference { get; private set; }
    public string nomProduit { get; set; }
    public decimal prix { get; private set; }
    public int quantité { get; private set; }

    public Produit(string réference, string nomProduit, decimal prix, int quantité)
    {
        this.réference = réference;
        this.nomProduit = nomProduit;

        if (prix < 0)
        {
            Console.WriteLine("Le prix ne peut pas être négatif.");
            prix = 0;
        }

        this.prix = prix;
        this.quantité = quantité;
    }

    public void AjouterStock(int quantiteAjoutee)
    {
        if (quantiteAjoutee <= 0)
        {
            Console.WriteLine("La quantité à ajouter doit être positive.");
            return;
        }

        quantité += quantiteAjoutee;
    }

    public void RetirerStock(int quantiteRetiree)
    {
        if (quantiteRetiree <= 0)
        {
            Console.WriteLine("La quantité à retirer doit être positive.");
            return;
        }

        if (quantiteRetiree > quantité)
        {
            Console.WriteLine("Stock insuffisant.");
            return;
        }

        quantité -= quantiteRetiree;
    }
}
