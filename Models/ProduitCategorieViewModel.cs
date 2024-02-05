namespace Caisse_Enregistreuse.Models
{
    public class ProduitCategorieViewModel
    {
        public ProduitCategorieViewModel(Produit produit, List<Categorie> categories)
        {
            Produit = produit;
            Categories = categories;
        }

        public Produit Produit { get; set; }
        public List<Categorie> Categories { get; set; }


    }
}
