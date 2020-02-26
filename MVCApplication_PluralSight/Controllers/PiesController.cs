using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCApplication_PluralSight.Models;

namespace MVCApplication_PluralSight.Controllers
{
    public class PiesController : Controller
    {
        private readonly IPieRepository _pieRepo;
        private readonly ICategoryRepository _categoryRepo;

        public PiesController(
            IPieRepository pieRepo,
            ICategoryRepository categoryRepo)
        {
            _pieRepo = pieRepo;
            _categoryRepo = categoryRepo;
        }

        public ViewResult List()
        {
            return View(_pieRepo.AllPies);
        }
    }
}