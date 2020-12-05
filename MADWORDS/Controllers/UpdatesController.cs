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
    public class UpdatesController : Controller
    {
        IUpdateRepository repo;

        public UpdatesController(IUpdateRepository r)
        {
            repo = r;
        }

        public IActionResult Index()
        {
            //get all updates in the database
            List<Update> updates = repo.Updates.ToList(); // Use ToList to convert the IQueryable to a list
            return View(updates);
        }

        public IActionResult NewUpdate()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NewUpdate(Update model)
        {
            model.UpdateDate = DateTime.Now;
            // Store the model in the database
            repo.AddUpdate(model);

            return View(model);
        }
    }
}