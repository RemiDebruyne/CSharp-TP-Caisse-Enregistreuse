using Caisse_Enregistreuse.Models;
using Caisse_Enregistreuse.Repositories;
using Caisse_Enregistreuse.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Caisse_Enregistreuse.Controllers
{
    public class ProduitController : Controller
    {
        private readonly IRepository<Produit> _repository;
        private readonly IUploadService _uploadService;

        public ProduitController(IRepository<Produit> repository, IUploadService uploadService)
        {
            _repository = repository;
            _uploadService = uploadService;
        }

        public IActionResult Index()
        {
            return View(_repository.GetAll());
        }

        public IActionResult Details(int id)
        {
            return View(_repository.GetById(id));
        }

        public IActionResult Form(int id)
        {
            if (id == 0)
            {
                return View();
            }

            var produit = _repository.GetById(id);

            return View(produit);
        }

        public IActionResult SubmitProduit(Produit produit, IFormFile picture)
        {

            produit.ImagePath = _uploadService.Upload(picture);

            if (produit.Id == 0)
                _repository.Create(produit);

            else
                _repository.Update(produit);

            return RedirectToAction(nameof(Index));

        }
    }
}
