using System.ComponentModel.DataAnnotations;

namespace Caisse_Enregistreuse.Models
{
    public class Categorie
    {
        [Display(Name = "Id")]
        private int _id;

        [Display(Name = "Nom")]
        private string _nom;
        private List<Produit> _produitList;

        [Key]
        public int Id { get => _id; set => _id = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public List<Produit> ProduitList { get => _produitList; set => _produitList = value; }
    }
}
