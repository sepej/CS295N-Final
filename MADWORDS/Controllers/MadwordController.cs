using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MADWORDS.Models;
using MADWORDS.Repos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MADWORDS.Controllers
{
    public class MadwordController : Controller
    {
        IMadwordRepository repo;

        public MadwordController(IMadwordRepository r)
        {
            repo = r;
        }

        public IActionResult Index()
        {
            //get all madwords in the database
            //List<Madword> madwords = repo.Madwords.ToList<Madword>(); // Use ToList to convert the IQueryable to a list
            var madwords = (from r in repo.Madwords orderby r.MadwordDate descending select r).ToList();

            return View(madwords);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Madword model)
        {
            model.MadwordDate = DateTime.Now;
            model.MadwordRating = 1;
            // Store the model in the database
            repo.AddMadword(model);
            return View(model);
        }

        public IActionResult Madwords()
        {
            //get all madwords in the database
            List<Madword> madwords = repo.Madwords.ToList<Madword>(); // Use ToList to convert the IQueryable to a list

            return View(madwords);
        }

        [HttpPost]
        public IActionResult Index(string madwordSearch)
        {
            var madwordsList = (from r in repo.Madwords where r.MadwordText.Contains(madwordSearch) || r.MadwordTitle.Contains(madwordSearch) || r.Author.Name.Contains(madwordSearch) orderby r.MadwordDate descending select r).ToList();

            return View(madwordsList);
        }
    }
}
