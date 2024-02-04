using Caisse_Enregistreuse.Data;
using Caisse_Enregistreuse.Models;

namespace Caisse_Enregistreuse.Repositories
{
    public class CategorieRepository : IRepository<Categorie>
    {
        private ApplicationDbContext _db;

        public CategorieRepository(ApplicationDbContext dbContext)
        {
            _db = dbContext;
        }
        public bool Create(Categorie entity)
        {
            _db.Categories.Add(entity);
            _db.SaveChanges();
            return _db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            GetById(id);
            _db.Remove(id);
            return _db.SaveChanges() > 0;
        }

        public List<Categorie> GetAll()
        {
            return _db.Categories.ToList();
        }

        public Categorie? GetById(int id)
        {
            return _db.Categories.FirstOrDefault(c => c.Id == id);

        }

        public bool Update(Categorie entity)
        {
            _db.Categories.Update(entity);

            return _db.SaveChanges() > 0;
        }
    }
}
