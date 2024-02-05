using Caisse_Enregistreuse.Data;
using Caisse_Enregistreuse.Models;
using Caisse_Enregistreuse.Repositories;
using Caisse_Enregistreuse.Services;
using Microsoft.AspNetCore.Mvc;

namespace Caisse_Enregistreuse.Controllers
{
    public class CategoriesController : Controller
    {
        private IRepository<Categorie> _repository;
        public CategoriesController(IRepository<Categorie> repository)
        {
            _repository = repository;
        }
        public IActionResult Index()
        {
            return View(_repository.GetAll());
        }

        public IActionResult Details(int id)
        {
            var categorie = _repository.GetById(id);
            return View(categorie);
        }

        public IActionResult Form(int id)
        {
            if (id == 0)
            {
                return View();
            }

            var categorie = _repository.GetById(id);

            return View(categorie);
        }

        public IActionResult SubmitCategorie(Categorie categorie)
        {

            if (categorie.Id == 0)
                _repository.Create(categorie);

            else
                _repository.Update(categorie);

            return RedirectToAction(nameof(Index));

        }
    }
}
