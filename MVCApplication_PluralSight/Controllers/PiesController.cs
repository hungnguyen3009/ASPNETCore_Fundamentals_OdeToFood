using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCApplication_PluralSight.Models;
using MVCApplication_PluralSight.ViewModels;

namespace MVCApplication_PluralSight.Controllers
{
    [Route("[controller]")]
    public class PiesController : Controller
    {
        private readonly IPieRepository _pieRepo;
        private readonly ICategoryRepository _categoryRepo;

        public PiesController(
            IPieRepository pieRepo,
            ICategoryRepository categoryRepo)
        {
            _pieRepo = pieRepo ?? throw new ArgumentNullException(nameof(pieRepo));
            _categoryRepo = categoryRepo ?? throw new ArgumentNullException(nameof(categoryRepo));
        }

        [HttpGet("[action]")]
        public ViewResult List()
        {
            var piesListViewModel = new PiesListViewModel
            {
                Pies = _pieRepo.AllPies,
                CurrentCategory = "Cheese Cakes"
            };

            return View(piesListViewModel);
        }
    }
}