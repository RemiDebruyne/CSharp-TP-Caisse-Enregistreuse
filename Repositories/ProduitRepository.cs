using Caisse_Enregistreuse.Data;
using Caisse_Enregistreuse.Models;

namespace Caisse_Enregistreuse.Repositories
{
    public class ProduitRepository : IRepository<Produit>

    {
        private ApplicationDbContext _db;

        public ProduitRepository(ApplicationDbContext dbContext)
        {
            _db = dbContext;
        }
        public bool Create(Produit entity)
        {
            _db.Produits.Add(entity);
            _db.SaveChanges();
            return _db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            GetById(id);
            _db.Remove(id);
            return _db.SaveChanges() > 0;
        }

        public List<Produit> GetAll()
        {
            return _db.Produits.ToList();
        }

        public Produit? GetById(int id)
        {
            return _db.Produits.FirstOrDefault(c => c.Id == id);

        }

        public bool Update(Produit entity)
        {
            _db.Produits.Update(entity);

            return _db.SaveChanges() > 0;
        }
    }

}

