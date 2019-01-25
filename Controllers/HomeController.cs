using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Edura.WebUI.Repository.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Edura.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private IProductRepository repository;
        public HomeController(IProductRepository _repository)
        {
            repository = _repository;
        }
        public IActionResult Index()
        {
            return View(repository.GetAll());
        }
        public IActionResult Details(int id)
        {
            return View(repository.Get(id));
        }
    }
}