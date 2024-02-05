using System.ComponentModel.DataAnnotations;

namespace Caisse_Enregistreuse.Models
{
    public class Produit
    {
        [Display(Name = "Id")]
        private int _id;

        [Display(Name = "Nom")]
        private string _nom;

        [Display(Name = "Descrition")]
        private string _description;

        [Display(Name = "Prix")]
        private float _prix;

        [Display(Name = "Quantité")]
        private int _quantite;

        [Display(Name = "Categorie")]
        private Categorie _categorie;

        private int _categorieId;

        private string? _imagePath;

        [Key]
        public int Id { get => _id; set => _id = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public string Description { get => _description; set => _description = value; }
        public float Prix { get => _prix; set => _prix = value; }
        public int Quantite { get => _quantite; set => _quantite = value; }
        public Categorie Categorie { get => _categorie; set => _categorie = value; }
        public string ImagePath { get => _imagePath; set => _imagePath = value; }
        public int CategorieId { get => _categorieId; set => _categorieId = value; }
    }
}
