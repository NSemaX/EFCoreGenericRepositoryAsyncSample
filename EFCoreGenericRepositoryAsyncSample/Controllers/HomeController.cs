using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EFCoreGenericRepositoryAsyncSample.Models;
using EFCoreGenericRepositoryAsyncSample.Repositories;
using EFCoreGenericRepositoryAsyncSample.Data.Entities;

namespace EFCoreGenericRepositoryAsyncSample.Controllers
{
    public class HomeController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        private readonly IPersonRepository _repository;

        public HomeController(IPersonRepository repository)
        {
            _repository = repository;
        }

        public async Task<IActionResult> Index()
        {
            var category = new Person
            {
                Name = "Sema",
                LastName = "KUDU"
            };
            await _repository.Create(category);

            var coolestCategory = await _repository.GetCoolestPerson();

            ViewBag.CoolestName = coolestCategory.Name;
            ViewBag.CoolestLastName = coolestCategory.LastName;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
